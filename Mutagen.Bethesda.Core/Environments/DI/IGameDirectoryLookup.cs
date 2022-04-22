﻿using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Noggog;

namespace Mutagen.Bethesda.Environments.DI;

public interface IGameDirectoryLookup
{
    /// <summary>
    /// Given a release, will return all the located game directories it could find
    /// </summary>
    /// <param name="release">Release to query</param>
    /// <returns>The located game directories it could find</returns>
    IEnumerable<DirectoryPath> GetAll(GameRelease release);

    /// <summary>
    /// Given a release, tries to retrieve the preferred game directory (not the data directory within)
    /// </summary>
    /// <param name="release">Release to query</param>
    /// <param name="path">The game directory, if located</param>
    /// <returns>True if located</returns>
    bool TryGet(GameRelease release, [MaybeNullWhen(false)] out DirectoryPath path);
        
    /// <summary>
    /// Given a release, tries to retrieve the preferred game directory (not the data directory within)
    /// </summary>
    /// <param name="release">Release to query</param>
    /// <exception cref="System.IO.DirectoryNotFoundException">Thrown if the game directory could not be located</exception>
    /// <returns>The game directory</returns>
    DirectoryPath Get(GameRelease release);
}