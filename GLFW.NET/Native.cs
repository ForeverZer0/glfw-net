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
        /// 	Returns the GLXContext of the specified window.
        /// </summary>
        /// <param name="window">A window instance.</param>
        /// <returns>The GLXContext of the specified window, or <see cref="GLXContext.None"/> if an error occurred.</returns>
        [DllImport(Glfw.LIBRARY, EntryPoint = "glfwGetGLXContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern GLXContext GetGLXContext(Window window);
        
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
        ///     Returns the WGL context of the specified window.
        /// </summary>
        /// <param name="window">A window instance.</param>
        /// <returns>The WGL context of the specified window, or <see cref="EGLContext.None" /> if an error occurred.</returns>
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
        public static string GetWin32Adapter(Monitor monitor)
        {
            return Util.PtrToStringUTF8(GetWin32AdapterInternal(monitor));
        }

        /// <summary>
        ///     Returns the display device name of the specified monitor
        /// </summary>
        /// <param name="monitor">A monitor instance.</param>
        /// <returns>
        ///     The display device name (for example \\.\DISPLAY1\Monitor0) of the specified monitor, or <c>null</c> if an
        ///     error occurred.
        /// </returns>
        public static string GetWin32Monitor(Monitor monitor)
        {
            return Util.PtrToStringUTF8(GetWin32MonitorInternal(monitor));
        }

        #endregion
    }
}