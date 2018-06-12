#region MIT License

// MouseButtonEventArgs.cs is distributed under the MIT License (MIT)
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
// MouseButtonEventArgs.cs created on 06/10/2018

#endregion

using System;

namespace GLFW.Game
{
	/// <summary>
	///     Arguments supplied with mouse button events.
	/// </summary>
	/// <seealso cref="EventArgs" />
	public class MouseButtonEventArgs : EventArgs
	{
		#region Properties

		/// <summary>
		///     Gets the state of the mouse button when the event was raised.
		/// </summary>
		/// <value>
		///     The action.
		/// </value>
		public InputState Action { get; }

		/// <summary>
		///     Gets the mouse button that raised the event.
		/// </summary>
		/// <value>
		///     The button.
		/// </value>
		public MouseButton Button { get; }

		/// <summary>
		///     Gets the key modifiers present when mouse button was pressed.
		/// </summary>
		/// <value>
		///     The modifiers.
		/// </value>
		public ModiferKeys Modifiers { get; }

		#endregion

		#region Constructors

		/// <summary>
		///     Initializes a new instance of the <see cref="MouseButtonEventArgs" /> class.
		/// </summary>
		/// <param name="button">The mouse button.</param>
		/// <param name="state">The state of the <paramref name="button" />.</param>
		/// <param name="modifiers">The modifier keys.</param>
		public MouseButtonEventArgs(MouseButton button, InputState state, ModiferKeys modifiers)
		{
			Button = button;
			Action = state;
			Modifiers = modifiers;
		}

		#endregion
	}
}