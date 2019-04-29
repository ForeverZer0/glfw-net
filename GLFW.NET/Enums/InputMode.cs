#region MIT License

// InputMode.cs is distributed under the MIT License (MIT)
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
// InputMode.cs created on 06/11/2018

#endregion

namespace GLFW
{
	/// <summary>
	///     Strongly-typed values for getting/setting the input mode hints.
	/// </summary>
	public enum InputMode
	{
		/// <summary>
		///     If specified, enables setting the mouse behavior.
		///     <para>See <see cref="CursorMode" /> for possible values.</para>
		/// </summary>
		Cursor = 0x00033001,

		/// <summary>
		///     If specified, enables setting sticky keys, where <see cref="Glfw.GetKey" /> will return
		///     <see cref="InputState.Press" /> the first time you call it for a key that was pressed, even if that key has already
		///     been released.
		/// </summary>
		StickyKeys = 0x00033002,

		/// <summary>
		///     If specified, enables setting sticky mouse buttons, where <see cref="Glfw.GetMouseButton" /> will return
		///     <see cref="InputState.Press" /> the first time you call it for a mouse button that was pressed, even if that mouse
		///     button has already been released.
		/// </summary>
		StickyMouseButton = 0x00033003,
		
		/// <summary>
		/// 	When this input mode is enabled, any callback that receives modifier bits will have the
		/// 	<see cref="ModiferKeys.CapsLock"/> bit set if caps lock was on when the event occurred and the
		///		<see cref="ModiferKeys.NumLock"/> bit set if num lock was on.
		/// </summary>
		
		LockKeyMods = 0x00033004,
		
		/// <summary>
		/// 	When the cursor is disabled, raw (unscaled and unaccelerated) mouse motion can be enabled if available.
		/// 	<seealso cref="Glfw.RawMouseMotionSupported"/>
		/// </summary>
		
		RawMouseMotion = 0x00033005
	}
}