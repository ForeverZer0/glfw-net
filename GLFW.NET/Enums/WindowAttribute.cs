#region MIT License

// WindowAttribute.cs is distributed under the MIT License (MIT)
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
// WindowAttribute.cs created on 06/11/2018

#endregion

namespace GLFW
{
	/// <summary>
	///     Strongly-typed values used for getting/setting window hints.
	/// </summary>
	public enum WindowAttribute
	{
		/// <summary>
		///     Indicates whether the windowed mode window will be given input focus when created.
		///     <para>This hint is ignored for full screen and initially hidden windows.</para>
		/// </summary>
		Focused = 0x00020001,

		/// <summary>
		///     Indicates whether the full screen window will automatically iconify and restore the previous video mode on input
		///     focus loss.
		///     <para>This hint is ignored for windowed mode windows.</para>
		/// </summary>
		AutoIconify = 0x00020002,

		/// <summary>
		///     Indicates whether the windowed mode window will be maximized when created.
		///     <para>This hint is ignored for full screen windows.</para>
		/// </summary>
		Maximized = 0x00020008,

		/// <summary>
		///     Indicates whether the windowed mode window will be initially visible.
		///     <para>This hint is ignored for full screen windows.</para>
		/// </summary>
		Visible = 0x00020004,

		/// <summary>
		///     Indicates whether the windowed mode window will be resizable by the <i>user</i>.
		///     <para>The window will still be resizable using the <see cref="Glfw.SetWindowSize" /> function.</para>
		///     <para>This hint is ignored for full screen windows.</para>
		/// </summary>
		Resizable = 0x00020003,

		/// <summary>
		///     Indicates whether the windowed mode window will have window decorations such as a border, a close widget, etc.
		///     <para>An undecorated window may still allow the user to generate close events on some platforms.</para>
		///     <para>This hint is ignored for full screen windows.</para>
		/// </summary>
		Decorated = 0x00020005,

		/// <summary>
		///     Indicates whether the windowed mode window will be floating above other regular windows, also called topmost or
		///     always-on-top.
		///     <para>This is intended primarily for debugging purposes and cannot be used to implement proper full screen windows.</para>
		///     <para>This hint is ignored for full screen windows.</para>
		/// </summary>
		Floating = 0x00020007,
		
		/// <summary>
		/// 	 Indicates whether the cursor is currently directly over the content area of the window, with no other
		/// 	 windows between.
		/// </summary>
		[GlfwVersion(3, 3)]
		MouseHover = 0x0002000B
	}
}