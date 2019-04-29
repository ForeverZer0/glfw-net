using System;
using System.Runtime.InteropServices;

namespace GLFW
{
    /// <summary>
    ///     Describes the gamma ramp for a monitor.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct GammaRamp
    {
        /// <summary>
        ///     An array of value describing the response of the red channel.
        /// </summary>
        [MarshalAs(UnmanagedType.LPArray)]
        public ushort[] Red;

        /// <summary>
        ///     An array of value describing the response of the green channel.
        /// </summary>
        [MarshalAs(UnmanagedType.LPArray)]
        public readonly ushort[] Green;

        /// <summary>
        ///     An array of value describing the response of the blue channel.
        /// </summary>
        [MarshalAs(UnmanagedType.LPArray)]
        public readonly ushort[] Blue;

        /// <summary>
        ///     The number of elements in each array.
        /// </summary>
        public readonly uint Size;

        /// <summary>
        ///     Creates a new instance of a <see cref="GammaRamp" /> using the specified values.
        ///     <para>WARNING: On some platforms (Windows), each value MUST be 256 in length.</para>
        /// </summary>
        /// <param name="red">An array of value describing the response of the red channel.</param>
        /// <param name="green">An array of value describing the response of the green channel.</param>
        /// <param name="blue">An array of value describing the response of the blue channel.</param>
        public GammaRamp(ushort[] red, ushort[] green, ushort[] blue)
        {
            if (red.Length == green.Length && green.Length == blue.Length)
            {
                Red = red;
                Green = green;
                Blue = blue;
                Size = (uint) red.Length;
            }
            else
            {
                throw new ArgumentException(
                    $"{nameof(red)}, {nameof(green)}, and {nameof(blue)} must all be equal length.");
            }
        }
    }
}