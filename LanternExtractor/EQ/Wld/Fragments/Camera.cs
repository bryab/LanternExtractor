﻿using System.Collections.Generic;
using System.IO;
using LanternExtractor.Infrastructure.Logger;

namespace LanternExtractor.EQ.Wld.Fragments
{
    /// <summary>
    /// 0x08 - Camera
    /// A fragment that is not understood. Contains 26 parameters. It's here in case someone wants to take a look.
    /// </summary>
    class Camera : WldFragment
    {
        public override void Initialize(int index, int id, int size, byte[] data,
            Dictionary<int, WldFragment> fragments,
            Dictionary<int, string> stringHash, ILogger logger)
        {
            base.Initialize(index, id, size, data, fragments, stringHash, logger);

            var reader = new BinaryReader(new MemoryStream(data));

            Name = stringHash[-reader.ReadInt32()];

            // 26 fields - unknown what they reference
            int params0 = reader.ReadInt32();
            int params1 = reader.ReadInt32();
            int params2 = reader.ReadInt32();
            int params3 = reader.ReadInt32();
            int params4 = reader.ReadInt32();
            float params5 = reader.ReadSingle();
            float params6 = reader.ReadSingle();
            int params7 = reader.ReadInt32();
            float params8 = reader.ReadSingle();
            float params9 = reader.ReadSingle();
            int params10 = reader.ReadInt32();
            float params11 = reader.ReadSingle();
            float params12 = reader.ReadSingle();
            int params13 = reader.ReadInt32();
            float params14 = reader.ReadSingle();
            float params15 = reader.ReadSingle();
            int params16 = reader.ReadInt32();
            int params17 = reader.ReadInt32();
            int params18 = reader.ReadInt32();
            int params19 = reader.ReadInt32();
            int params20 = reader.ReadInt32();
            int params21 = reader.ReadInt32();
            int params22 = reader.ReadInt32();
            int params23 = reader.ReadInt32();
            int params24 = reader.ReadInt32();
            int params25 = reader.ReadInt32();
        }

        public override void OutputInfo(ILogger logger)
        {
            base.OutputInfo(logger);
        }
    }
}