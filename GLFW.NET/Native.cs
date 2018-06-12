#region MIT License

// Native.cs is distributed under the MIT License (MIT)
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
// Native.cs created on 06/10/2018

#endregion

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace GLFW
{
	/// <summary>
	///     Provides access to relevant native functions of the current operating system.
	///     <para>
	///         By using the native access functions you assert that you know what you're doing and how to fix problems
	///         caused by using them.
	///     </para>
	///     <para>If you don't, you shouldn't be using them.</para>
	/// </summary>
	[SuppressUnmanagedCodeSecurity]
	public static class Native
	{
		#region External

		/// <summary>
		///     Returns the EGLContext of the specified window.
		/// </summary>
		/// <param name="window">A window instance.</param>
		/// <returns>The EGLContext of the specified window, or <see cref="EGLContext.None" /> if an error occurred.</returns>
		[DllImport(Glfw.LIBRARY, EntryPoint = "glfwGetEGLContext", CallingConvention = CallingConvention.Cdecl)]
		public static extern EGLContext GetEglContext(Window window);

		/// <summary>
		///     Returns the EGLDisplay used by GLFW.
		/// </summary>
		/// <returns>The EGLDisplay used by GLFW, or <see cref="EGLDisplay.None" /> if an error occurred.</returns>
		[DllImport(Glfw.LIBRARY, EntryPoint = "glfwGetEGLDisplay", CallingConvention = CallingConvention.Cdecl)]
		public static extern EGLDisplay GetEglDisplay();

		/// <summary>
		///     Returns the <see cref="EGLSurface" /> of the specified window
		/// </summary>
		/// <param name="window">A window instance.</param>
		/// <returns>The EGLSurface of the specified window, or <see cref="EGLSurface.None" /> if an error occurred.</returns>
		[DllImport(Glfw.LIBRARY, EntryPoint = "glfwGetEGLSurface", CallingConvention = CallingConvention.Cdecl)]
		public static extern EGLSurface GetEglSurface(Window window);

		/// <summary>
		///     Returns the HGLRC of the specified window.
		/// </summary>
		/// <param name="window">A window instance.</param>
		/// <returns>The HGLRC of the specified window, or <see cref="HGLRC.Null" /> if an error occurred.</returns>
		[DllImport(Glfw.LIBRARY, EntryPoint = "glfwGetWGLContext", CallingConvention = CallingConvention.Cdecl)]
		public static extern HGLRC GetWglContext(Window window);

		/// <summary>
		///     Returns the HWND of the specified window.
		/// </summary>
		/// <param name="window">A window instance.</param>
		/// <returns>The HWND of the specified window, or <see cref="IntPtr.Zero" /> if an error occurred.</returns>
		[DllImport(Glfw.LIBRARY, EntryPoint = "glfwGetWin32Window", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GetWin32Window(Window window);

		[DllImport(Glfw.LIBRARY, EntryPoint = "glfwGetWin32Adapter", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr GetWin32AdapterInternal(Monitor monitor);

		[DllImport(Glfw.LIBRARY, EntryPoint = "glfwGetWin32Monitor", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr GetWin32MonitorInternal(Monitor monitor);

		#endregion

		#region Methods

		/// <summary>
		///     Gets the win32 adapter.
		/// </summary>
		/// <param name="monitor">A monitor instance.</param>
		/// <returns>dapter device name (for example \\.\DISPLAY1) of the specified monitor, or <c>null</c> if an error occurred.</returns>
		public static string GetWin32Adapter(Monitor monitor) => Util.PtrToStringUTF8(GetWin32AdapterInternal(monitor));

		/// <summary>
		///     Returns the display device name of the specified monitor
		/// </summary>
		/// <param name="monitor">A monitor instance.</param>
		/// <returns>
		///     The display device name (for example \\.\DISPLAY1\Monitor0) of the specified monitor, or <c>null</c> if an
		///     error occurred.
		/// </returns>
		public static string GetWin32Monitor(Monitor monitor) => Util.PtrToStringUTF8(GetWin32MonitorInternal(monitor));

		#endregion
	}
}