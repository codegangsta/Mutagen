﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutagen.Bethesda
{
    public struct RawFormID : IEquatable<RawFormID>
    {
        public static readonly RawFormID NULL = new RawFormID();
        public readonly ModID ModID;
        public readonly uint ID;

        public RawFormID(ModID modID, uint id)
        {
            this.ModID = modID;
            this.ID = id;
        }

        public static bool TryFactory(string hexString, out RawFormID id)
        {
            if (TryFactory(hexString, out RawFormID? idNull))
            {
                id = idNull ?? default(RawFormID);
                return true;
            }

            id = default(RawFormID);
            return false;
        }

        public static bool TryFactory(string hexString, out RawFormID? id)
        {
            if (hexString.Length != 12)
            {
                id = null;
                return false;
            }

            try
            {
                id = new RawFormID(
                    new ModID(Convert.ToByte(hexString.Substring(0, 2), 16)),
                    Convert.ToUInt32(hexString.Substring(2, 8), 16));
                return true;
            }
            catch (Exception)
            {
                id = null;
                return false;
            }
        }

        public static RawFormID Factory(byte[] bytes)
        {
            byte[] arr = new byte[4];
            Array.Copy(bytes, 0, arr, 0, 3);
            var i = BitConverter.ToUInt32(arr, 0);
            return new RawFormID(
                new ModID(bytes[3]),
                i);
        }

        public byte[] ToBytes()
        {
            byte[] arr = new byte[4];
            var bytes = BitConverter.GetBytes(this.ID);
            Array.Copy(bytes, 0, arr, 0, 3);
            bytes[3] = this.ModID.ID;
            return bytes;
        }

        public string ToHex()
        {
            return $"{ModID}{IDString()}";
        }

        public override string ToString()
        {
            return $"({ModID}){IDString()}";
        }

        public string IDString()
        {
            return ID.ToString("X8");
        }

        public override bool Equals(object obj)
        {
            if (!(obj is RawFormID formID)) return false;
            return Equals(formID);
        }

        public bool Equals(RawFormID other)
        {
            return this.ModID.Equals(other.ModID)
                && this.ID == other.ID;
        }

        public override int GetHashCode()
        {
            return this.ModID.GetHashCode()
                .CombineHashCode(this.ID.GetHashCode());
        }

        public static bool operator ==(RawFormID a, RawFormID b)
        {
            return a.ModID == b.ModID
                && a.ID == b.ID;
        }

        public static bool operator !=(RawFormID a, RawFormID b)
        {
            return !(a == b);
        }
    }
}
