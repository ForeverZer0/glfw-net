#region MIT License

// CursorMode.cs is distributed under the MIT License (MIT)
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
// CursorMode.cs created on 06/10/2018

#endregion

namespace GLFW
{
	/// <summary>
	///     Indicates the behavior of the mouse cursor.
	/// </summary>
	public enum CursorMode
	{
		/// <summary>
		///     The cursor is visible and behaves normally.
		/// </summary>
		Normal = 0x00034001,

		/// <summary>
		///     The cursor is invisible when it is over the client area of the window but does not restrict the cursor from
		///     leaving.
		/// </summary>
		Hidden = 0x00034002,

		/// <summary>
		///     Hides and grabs the cursor, providing virtual and unlimited cursor movement. This is useful for implementing for
		///     example 3D camera controls.
		/// </summary>
		Disabled = 0x00034003
	}
}