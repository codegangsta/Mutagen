﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mutagen.Bethesda.Skyrim;

public partial class CellGrid
{
    [Flags]
    public enum Flag
    {
        Quad1,
        Quad2,
        Quad3,
        Quad4,
    }
}