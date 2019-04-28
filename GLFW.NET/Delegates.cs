#region MIT License

// Delegates.cs is distributed under the MIT License (MIT)
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
// Delegates.cs created on 06/08/2018

#endregion

using System;
using System.Runtime.InteropServices;

namespace GLFW
{
	/// <summary>
	///     Function signature for receiving error callbacks.
	/// </summary>
	/// <param name="code">The error code.</param>
	/// <param name="message">A pointer to the UTF-8 encoded (null-terminated) error message.</param>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ErrorCallback(ErrorCode code, IntPtr message);

	/// <summary>
	///     This is the function signature for window size callback functions.
	/// </summary>
	/// <param name="window">The window handle.</param>
	/// <param name="width">The new width, in screen coordinates, of the window.</param>
	/// <param name="height">The new height, in screen coordinates, of the window.</param>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void SizeCallback(IntPtr window, int width, int height);

	/// <summary>
	///     This is the function signature for cursor position callback functions.
	/// </summary>
	/// <param name="window">The window handle.</param>
	/// <param name="x">The new cursor x-coordinate, relative to the left edge of the client area.</param>
	/// <param name="y">The new cursor y-coordinate, relative to the left edge of the client area.</param>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void PositionCallback(IntPtr window, double x, double y);

	/// <summary>
	///     This is the function signature for window focus callback functions.
	/// </summary>
	/// <param name="window">The window handle.</param>
	/// <param name="focusing"><c>true</c> if window is gaining focus; otherise <c>false</c>.</param>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void FocusCallback(IntPtr window, bool focusing);

	/// <summary>
	///     Generic signature for window callbacks.
	/// </summary>
	/// <param name="window">The window handle.</param>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void WindowCallback(IntPtr window);

	/// <summary>
	///     This is the function signature for file drop callbacks.
	/// </summary>
	/// <param name="window">The window that received the event.</param>
	/// <param name="count">The number of dropped files.</param>
	/// <param name="arrayPtr">Pointer to an array UTF-8 encoded file and/or directory path name pointers.</param>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void FileDropCallback(IntPtr window, int count, IntPtr arrayPtr);

	/// <summary>
	///     This is the function signature for cursor position callback functions.
	/// </summary>
	/// <param name="window">The window handle recieving the event.</param>
	/// <param name="x">The new cursor x-coordinate, relative to the left edge of the client area.</param>
	/// <param name="y">The new cursor y-coordinate, relative to the left edge of the client area.</param>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void MouseCallback(IntPtr window, double x, double y);

	/// <summary>
	///     This is the function signature for cursor enter/leave callback functions.
	/// </summary>
	/// <param name="window">The window handle.</param>
	/// <param name="entering"><c>true</c> if cursor is entering the window client area; otherwise <c>false</c>.</param>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void MouseEnterCallback(IntPtr window, bool entering);

	/// <summary>
	///     This is the function signature for mouse button callback functions.
	/// </summary>
	/// <param name="window">The window handle.</param>
	/// <param name="button">TThe mouse button that was pressed or released.</param>
	/// <param name="state">The state.</param>
	/// <param name="modifiers">Flags describing which modifier keys were held down.</param>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void MouseButtonCallback(IntPtr window, MouseButton button, InputState state, ModiferKeys modifiers);

	/// <summary>
	///     This is the function signature for Unicode character callback functions.
	/// </summary>
	/// <param name="window">The window handle.</param>
	/// <param name="codePoint">The Unicode code point of the character.</param>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void CharCallback(IntPtr window, uint codePoint);

	/// <summary>
	///     This is the function signature for Unicode character callback functions.
	/// </summary>
	/// <param name="window">The window handle.</param>
	/// <param name="codePoint">The Unicode code point of the character.</param>
	/// <param name="mods">Bit field describing which modifier keys were held down.</param>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void CharModsCallback(IntPtr window, uint codePoint, ModiferKeys mods);

	/// <summary>
	///     This is the function signature for keyboard key callback functions.
	/// </summary>
	/// <param name="window">The window handle.</param>
	/// <param name="key">The keyboard key that was pressed or released.</param>
	/// <param name="scanCode">The system-specific scancode of the key.</param>
	/// <param name="state">The state of the key.</param>
	/// <param name="mods">	Bit field describing which modifier keys were held down.</param>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void KeyCallback(IntPtr window, Keys key, int scanCode, InputState state, ModiferKeys mods);

	/// <summary>
	///     This is the function signature for joystick configuration callback functions.
	/// </summary>
	/// <param name="joystick">The joystick that was connected or disconnected.</param>
	/// <param name="status">The connection status.</param>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void JoystickCallback(Joystick joystick, ConnectionStatus status);

	/// <summary>
	///     This is the function signature for monitor configuration callback functions.
	/// </summary>
	/// <param name="monitor">The monitor that was connected or disconnected.</param>
	/// <param name="status">The connection status.</param>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void MonitorCallback(Monitor monitor, ConnectionStatus status);

	/// <summary>
	///     This is the function signature for window iconify/restore callback functions.
	/// </summary>
	/// <param name="window">The window handle.</param>
	/// <param name="focusing"><c>true</c> if window is iconified; otherwise <c>false</c> if restoring.</param>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void IconifyCallback(IntPtr window, bool focusing);

	/// <summary>
	/// 	This is the function signature for window content scale callback functions.
	/// </summary>
	/// <param name="window">The window whose content scale changed.</param>
	/// <param name="xScale">The new x-axis content scale of the window.</param>
	/// <param name="yScale">The new y-axis content scale of the window.</param>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[GlfwVersion(3, 3)]
	public delegate void WindowContentsScaleCallback(IntPtr window, float xScale, float yScale);

	/// <summary>
	/// 	This is the function signature for window maximize/restore callback functions.
	/// </summary>
	/// <param name="window">The window that was maximized or restored.</param>
	/// <param name="maximized"><c>true</c> if the window was maximized, or <c>false</c> if it was restored.</param>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[GlfwVersion(3, 3)]
	public delegate void WindowMaximizedCallback(IntPtr window, bool maximized);
}