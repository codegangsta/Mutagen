﻿using System;
using System.IO;
using System.Linq;
using AutoFixture;
using AutoFixture.Kernel;
using Mutagen.Bethesda.Environments.DI;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Testing;

namespace Mutagen.Bethesda.Core.UnitTests.AutoData
{
    public class ModKeyBuilder : ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
        {
            if (request is MultipleRequest mult)
            {
                var req = mult.Request;
                if (req is SeededRequest seed)
                {
                    req = seed.Request;
                }
                if (req is Type t)
                {
                    if (t == typeof(ModKey))
                    {
                        return new object[]
                        {
                            TestConstants.MasterModKey,
                            TestConstants.PluginModKey,
                            TestConstants.PluginModKey2,
                        };
                    }
                    else if (t == typeof(ModPath))
                    {
                        var dataDir = context.Create<IDataDirectoryProvider>();
                        return new ModKey[]
                        {
                            TestConstants.MasterModKey,
                            TestConstants.PluginModKey,
                            TestConstants.PluginModKey2,
                        }.Select(mk =>
                        {
                            return new ModPath(mk, Path.Combine(dataDir.Path, mk.FileName));
                        });
                    }
                }
            }
            else if (request is Type t)
            {
                var modKey = TestConstants.PluginModKey;
                if (t == typeof(ModKey))
                {
                    return modKey;
                }
                else if (t == typeof(ModPath))
                {
                    var dataDir = context.Create<IDataDirectoryProvider>();
                    return new ModPath(modKey, Path.Combine(dataDir.Path, modKey.FileName));
                }
            }

            return new NoSpecimen();
        }
    }
}