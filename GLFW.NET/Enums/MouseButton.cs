#region MIT License

// MouseButton.cs is distributed under the MIT License (MIT)
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
// MouseButton.cs created on 06/11/2018

#endregion

namespace GLFW
{
	/// <summary>
	///     Strongly-typed enumeration describing mouse buttons.
	/// </summary>
	public enum MouseButton
	{
		/// <summary>
		///     Mouse button 1.
		///     <para>Same as <see cref="Left" />.</para>
		/// </summary>
		Button1 = 0,

		/// <summary>
		///     Mouse button 2.
		///     <para>Same as <see cref="Right" />.</para>
		/// </summary>
		Button2 = 1,

		/// <summary>
		///     Mouse button 3.
		///     <para>Same as <see cref="Middle" />.</para>
		/// </summary>
		Button3 = 2,

		/// <summary>
		///     Mouse button 4.
		/// </summary>
		Button4 = 3,

		/// <summary>
		///     Mouse button 4.
		/// </summary>
		Button5 = 4,

		/// <summary>
		///     Mouse button 5.
		/// </summary>
		Button6 = 5,

		/// <summary>
		///     Mouse button 6.
		/// </summary>
		Button7 = 6,

		/// <summary>
		///     Mouse button 7.
		/// </summary>
		Button8 = 7,

		/// <summary>
		///     The left mouse button.
		///     <para>Same as <see cref="Button1" />.</para>
		/// </summary>
		Left = Button1,

		/// <summary>
		///     The right mouse button.
		///     <para>Same as <see cref="Button2" />.</para>
		/// </summary>
		Right = Button2,

		/// <summary>
		///     The middle mouse button.
		///     <para>Same as <see cref="Button3" />.</para>
		/// </summary>
		Middle = Button3
	}
}