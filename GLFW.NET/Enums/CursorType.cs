#region MIT License

// CursorType.cs is distributed under the MIT License (MIT)
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
// CursorType.cs created on 06/11/2018

#endregion

namespace GLFW
{
	/// <summary>
	///     Strongly-typed values describing possible cursor shapes.
	/// </summary>
	public enum CursorType
	{
		/// <summary>
		///     The regular arrow cursor.
		/// </summary>
		Arrow = 0x00036001,

		/// <summary>
		///     The text input I-beam cursor shape.
		/// </summary>
		Beam = 0x00036002,

		/// <summary>
		///     The crosshair shape.
		/// </summary>
		Crosshair = 0x00036003,

		/// <summary>
		///     The hand shape.
		/// </summary>
		Hand = 0x00036004,

		/// <summary>
		///     The horizontal resize arrow shape.
		/// </summary>
		ResizeHorizontal = 0x00036005,

		/// <summary>
		///     The vertical resize arrow shape.
		/// </summary>
		ResizeVertical = 0x00036006
	}
}