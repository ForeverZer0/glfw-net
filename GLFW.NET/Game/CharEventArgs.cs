#region MIT License

// CharEventArgs.cs is distributed under the MIT License (MIT)
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
// CharEventArgs.cs created on 06/10/2018

#endregion

using System;

namespace GLFW.Game
{
	/// <summary>
	///     Arguments supplied with char input events.
	/// </summary>
	/// <seealso cref="System.EventArgs" />
	public class CharEventArgs : EventArgs
	{
		#region Properties

		/// <summary>
		///     Gets the Unicode character for the code point.
		/// </summary>
		/// <value>
		///     The character.
		/// </value>
		public string Char => char.ConvertFromUtf32(unchecked((int) CodePoint));

		/// <summary>
		///     Gets the platform independent code point.
		///     <para>This value can be treated as a UTF-32 code point.</para>
		/// </summary>
		/// <value>
		///     The code point.
		/// </value>
		public uint CodePoint { get; }

		/// <summary>
		///     Gets the modifier keys.
		/// </summary>
		/// <value>
		///     The modifier keys.
		/// </value>
		public ModiferKeys ModifierKeys { get; }

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="CharEventArgs"/> class.
		/// </summary>
		/// <param name="codePoint">A UTF-32 code point.</param>
		/// <param name="mods">The modifier keys present.</param>
		public CharEventArgs(uint codePoint, ModiferKeys mods)
		{
			CodePoint = codePoint;
			ModifierKeys = mods;
		}

		#endregion
	}
}