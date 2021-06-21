using DynamicData;
using Noggog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reactive;

namespace Mutagen.Bethesda.Plugins.Order
{
    public static class PluginListings
    {
        private static readonly PluginPathProviderFactory PathProviderFactory = new(IFileSystemExt.DefaultFilesystem);
        private static readonly ModListingParserFactory ModListingParserFactory = new();
        private static readonly PluginListingsParserFactory ParserFactory = new(ModListingParserFactory);
        private static readonly PluginListingsProvider Retriever = new(
            IFileSystemExt.DefaultFilesystem,
            ParserFactory,
            PathProviderFactory,
            new TimestampAligner(IFileSystemExt.DefaultFilesystem));
        private static readonly PluginLiveLoadOrderProvider LiveLoadOrder = new(
            IFileSystemExt.DefaultFilesystem,
            Retriever,
            PathProviderFactory);
        
        /// <inheritdoc cref="IPluginListingsProvider"/>
        public static string GetListingsPath(GameRelease game)
        {
            return PathProviderFactory.Create(game).GetListingsPath();
        }

        /// <inheritdoc cref="IPluginListingsProvider"/>
        public static bool TryGetListingsFile(GameRelease game, out FilePath path)
        {
            return PathProviderFactory.Create(game).TryLocateListingsPath(out path);
        }

        /// <inheritdoc cref="IPluginListingsProvider"/>
        public static FilePath GetListingsFile(GameRelease game)
        {
            return PathProviderFactory.Create(game).LocateListingsPath();
        }

        /// <summary>
        /// Parses a stream to retrieve all ModKeys in expected plugin file format
        /// </summary>
        /// <param name="stream">Stream to read from</param>
        /// <param name="game">Game type</param>
        /// <returns>List of ModKeys representing a load order</returns>
        /// <exception cref="ArgumentException">Line in plugin stream is unexpected</exception>
        public static IEnumerable<IModListingGetter> ListingsFromStream(Stream stream, GameRelease game)
        {
            return ParserFactory.Create(game).Parse(stream);
        }

        /// <inheritdoc cref="IPluginListingsProvider"/>
        public static IEnumerable<IModListingGetter> ListingsFromPath(
            GameRelease game,
            DirectoryPath dataPath,
            bool throwOnMissingMods = true)
        {
            return Retriever.ListingsFromPath(game, dataPath, throwOnMissingMods: throwOnMissingMods);
        }

        /// <inheritdoc cref="IPluginListingsProvider"/>
        public static IEnumerable<IModListingGetter> ListingsFromPath(
            FilePath pluginTextPath,
            GameRelease game,
            DirectoryPath dataPath,
            bool throwOnMissingMods = true)
        {
            return Retriever.ListingsFromPath(pluginTextPath, game, dataPath, throwOnMissingMods: throwOnMissingMods);
        }

        /// <inheritdoc cref="IPluginListingsProvider"/>
        public static IEnumerable<IModListingGetter> RawListingsFromPath(
            FilePath pluginTextPath,
            GameRelease game)
        {
            return Retriever.RawListingsFromPath(pluginTextPath, game);
        }

        /// <inheritdoc cref="IPluginLiveLoadOrderProvider"/>
        public static IObservable<IChangeSet<IModListingGetter>> GetLiveLoadOrder(
            GameRelease game,
            FilePath loadOrderFilePath,
            DirectoryPath dataFolderPath,
            out IObservable<ErrorResponse> state,
            bool throwOnMissingMods = true,
            bool orderListings = true)
        {
            return LiveLoadOrder.GetLiveLoadOrder(
                game: game,
                loadOrderFilePath: loadOrderFilePath,
                dataFolderPath: dataFolderPath,
                state: out state,
                throwOnMissingMods: throwOnMissingMods,
                orderListings: orderListings);
        }

        /// <inheritdoc cref="IPluginLiveLoadOrderProvider"/>
        public static IObservable<Unit> GetLoadOrderChanged(FilePath loadOrderFilePath)
        {
            return LiveLoadOrder.GetLoadOrderChanged(loadOrderFilePath);
        }

        /// <inheritdoc cref="IPluginLiveLoadOrderProvider"/>
        public static IObservable<Unit> GetLoadOrderChanged(GameRelease game) =>
            LiveLoadOrder.GetLoadOrderChanged(game);

        public static bool HasEnabledMarkers(GameRelease game)
        {
            return game switch
            {
                GameRelease.Fallout4 => true,
                GameRelease.SkyrimSE => true,
                GameRelease.EnderalSE => true,
                GameRelease.SkyrimVR => true,
                GameRelease.SkyrimLE => false,
                GameRelease.EnderalLE => false,
                GameRelease.Oblivion => false,
                _ => throw new NotImplementedException(),
            };
        }
    }
}
