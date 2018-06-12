#region MIT License

// Image.cs is distributed under the MIT License (MIT)
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
// Image.cs created on 06/10/2018

#endregion

using System;
using System.Runtime.InteropServices;

namespace GLFW
{
	/// <summary>
	///     Desribes a basic image structure.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct Image
	{
		/// <summary>
		///     The height, in pixels, of this image.
		/// </summary>
		public readonly int Width;

		/// <summary>
		///     The width, in pixels, of this image.
		/// </summary>
		public readonly int Height;

		/// <summary>
		///     Pointer to the RGBA pixel data of this image, arranged left-to-right, top-to-bottom.
		/// </summary>
		public readonly IntPtr Pixels;

		/// <summary>
		///     Initializes a new instance of the <see cref="Image" /> struct.
		/// </summary>
		/// <param name="width">The height, in pixels, of this image.</param>
		/// <param name="height">The width, in pixels, of this image..</param>
		/// <param name="pixels">Pointer to the RGBA pixel data of this image, arranged left-to-right, top-to-bottom.</param>
		public Image(int width, int height, IntPtr pixels)
		{
			Width = width;
			Height = height;
			Pixels = pixels;
		}

		// TODO: Implement manual load of bmp
	}
}