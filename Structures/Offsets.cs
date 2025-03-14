﻿namespace SVTradePartnerViewer.Structures
{
    internal class Offsets
    {
        public const string ScarletID = "0100A3D008C5C000";
        public const string VioletID = "01008F6008C5E000";

        public static IReadOnlyList<long> MyStatusPointer { get; } = new long[] { 0x4384B18, 0x148, 0x40 };
        public static IReadOnlyList<long> Trader1MyStatusPointer { get; } = new long[] { 0x437ECE0, 0x48, 0xB0, 0x0 };
        public static IReadOnlyList<long> Trader2MyStatusPointer { get; } = new long[] { 0x437ECE0, 0x48, 0xE0, 0x0 };

        public static IReadOnlyList<long> LinkTradePartnerNIDPointer { get; } = new long[] { 0x43A28F0, 0xF8, 0x8 };
    }
}
