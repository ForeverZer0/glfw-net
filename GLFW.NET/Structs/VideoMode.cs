#region MIT License

// VideoMode.cs is distributed under the MIT License (MIT)
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
// VideoMode.cs created on 06/09/2018

#endregion

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