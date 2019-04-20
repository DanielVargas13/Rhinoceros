﻿using System.Drawing;

namespace Rhinoceros
{
    public static class Utility
    {
        public static uint ColorToUInt(Color color)
        {
            return (uint)((color.A << 24) | (color.R << 16) | (color.G << 8) | (color.B << 0));
        }

        public static Color UIntToColor(uint color)
        {
            return Color.FromArgb((byte)(color >> 24), (byte)(color >> 16), (byte)(color >> 8), (byte)(color >> 0));
        }
    }
}
