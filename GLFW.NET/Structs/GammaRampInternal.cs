using System;
using System.Runtime.InteropServices;

namespace GLFW
{
    // TODO:  Make custom marshaller instead of this

    /// <summary>
    ///     Used internally for marshalling
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct GammaRampInternal
    {
        public readonly IntPtr Red;
        public readonly IntPtr Green;
        public readonly IntPtr Blue;
        public readonly int Size;

        public static explicit operator GammaRamp(GammaRampInternal ramp)
        {
            var offset = 0;
            var red = new ushort[ramp.Size];
            var green = new ushort[ramp.Size];
            var blue = new ushort[ramp.Size];
            for (var i = 0; i < ramp.Size; i++, offset += sizeof(ushort))
            {
                red[i] = unchecked((ushort) Marshal.ReadInt16(ramp.Red, offset));
                green[i] = unchecked((ushort) Marshal.ReadInt16(ramp.Green, offset));
                blue[i] = unchecked((ushort) Marshal.ReadInt16(ramp.Blue, offset));
            }

            return new GammaRamp(red, green, blue);
        }
    }
}