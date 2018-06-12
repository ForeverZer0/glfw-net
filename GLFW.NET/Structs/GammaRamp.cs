#region MIT License

// GammaRamp.cs is distributed under the MIT License (MIT)
// 
// Copyright (c) 2018, Eric Freed
//   
// The MIT License (MIT)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
// 
// GammaRamp.cs created on 06/10/2018

#endregion

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