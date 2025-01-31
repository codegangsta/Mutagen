﻿using System.ComponentModel;

namespace Mutagen.Bethesda;

/// <summary>
/// Game categories that generally have similar or the same formats
/// </summary>
public enum GameCategory
{
    [Description("Oblivion")]
    Oblivion,
    [Description("Skyrim")]
    Skyrim, 
    [Description("Fallout4")]
    Fallout4,
    [Description("Starfield")]
    Starfield,
}

public static class GameReleaseKernelExt
{
    public static GameCategory ToCategory(this GameRelease release)
    {
        return release switch
        {
            GameRelease.Oblivion => GameCategory.Oblivion,
            GameRelease.SkyrimLE => GameCategory.Skyrim,
            GameRelease.SkyrimSE => GameCategory.Skyrim,
            GameRelease.SkyrimSEGog => GameCategory.Skyrim,
            GameRelease.SkyrimVR => GameCategory.Skyrim,
            GameRelease.EnderalLE => GameCategory.Skyrim,
            GameRelease.EnderalSE => GameCategory.Skyrim,
            GameRelease.Fallout4 => GameCategory.Fallout4,
            GameRelease.Starfield => GameCategory.Starfield,
            _ => throw new NotImplementedException(),
        };
    }
    
    public static int GetMasterFlagIndex(this GameCategory release)
    {
        return 0x0000_0001;
    }
    
    public static int? GetLocalizedFlagIndex(this GameCategory release)
    {
        return 0x0000_0080;
    }
    
    public static int? GetLightFlagIndex(this GameCategory release)
    {
        switch (release)
        {
            case GameCategory.Starfield:
                return 0x0000_0100;
            case GameCategory.Oblivion:
                return null;
            default:
                return 0x0000_0200;
        }
    }
}
