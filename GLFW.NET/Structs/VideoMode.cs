using System.Runtime.InteropServices;

namespace GLFW
{
    /// <summary>
    ///     Structure that describes a single video mode.
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24, Pack = 4)]
    public struct VideoMode
    {
        /// <summary>
        ///     The width, in screen coordinates, of the video mode.
        /// </summary>
        [FieldOffset(0)]
        public readonly int Width;

        /// <summary>
        ///     The height, in screen coordinates, of the video mode.
        /// </summary>
        [FieldOffset(4)]
        public readonly int Height;

        /// <summary>
        ///     The bit depth of the red channel of the video mode.
        /// </summary>
        [FieldOffset(8)]
        public readonly int RedBits;

        /// <summary>
        ///     The bit depth of the green channel of the video mode.
        /// </summary>
        [FieldOffset(12)]
        public readonly int GreenBits;

        /// <summary>
        ///     The bit depth of the blue channel of the video mode.
        /// </summary>
        [FieldOffset(16)]
        public readonly int BlueBits;

        /// <summary>
        ///     The refresh rate, in Hz, of the video mode.
        /// </summary>
        [FieldOffset(20)]
        public readonly int RefreshRate;
    }
}