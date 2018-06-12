#region MIT License

// KeyEventArgs.cs is distributed under the MIT License (MIT)
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
// KeyEventArgs.cs created on 06/10/2018

#endregion

using System;

namespace GLFW.Game
{
	/// <summary>
	///     Arguments supplied with keyboard events.
	/// </summary>
	/// <seealso cref="EventArgs" />
	public class KeyEventArgs : EventArgs
	{
		#region Properties

		/// <summary>
		///     Gets the key whose state change raised the event.
		/// </summary>
		/// <value>
		///     The key.
		/// </value>
		public Keys Key { get; }

		/// <summary>
		///     Gets the modifier keys at the time of the event.
		/// </summary>
		/// <value>
		///     The modifiers.
		/// </value>
		public ModiferKeys Modifiers { get; }

		/// <summary>
		///     Gets the platform scan code for the key.
		/// </summary>
		/// <value>
		///     The scan code.
		/// </value>
		public int ScanCode { get; }

		/// <summary>
		///     Gets the state of the key.
		/// </summary>
		/// <value>
		///     The state.
		/// </value>
		public InputState State { get; }

		#endregion

		#region Constructors

		/// <summary>
		///     Initializes a new instance of the <see cref="KeyEventArgs" /> class.
		/// </summary>
		/// <param name="key">The key.</param>
		/// <param name="scanCode">The platform scan code of the key.</param>
		/// <param name="state">The state of the key.</param>
		/// <param name="mods">The modifier keys.</param>
		public KeyEventArgs(Keys key, int scanCode, InputState state, ModiferKeys mods)
		{
			Key = key;
			ScanCode = scanCode;
			State = state;
			Modifiers = mods;
		}

		#endregion
	}
}