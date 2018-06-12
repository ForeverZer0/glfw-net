#region MIT License

// Util.cs is distributed under the MIT License (MIT)
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
// Util.cs created on 06/10/2018

#endregion

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace GLFW
{
	internal static class Util
	{
		#region Methods

		/// <summary>
		///     Reads memory from the pointer until the first null byte is encountered and decodes the bytes from UTF-8 into a
		///     managed <see cref="string" />.
		/// </summary>
		/// <param name="ptr">Pointer to the start of the string.</param>
		/// <returns>Managed string created from read UTF-8 bytes.</returns>
		public static string PtrToStringUTF8(IntPtr ptr)
		{
			var length = 0;
			while (Marshal.ReadByte(ptr, length) != 0)
				length++;
			var buffer = new byte[length];
			Marshal.Copy(ptr, buffer, 0, length);
			return Encoding.UTF8.GetString(buffer);
		}

		#endregion
	}
}