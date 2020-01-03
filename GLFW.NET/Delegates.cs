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
    public delegate void SizeCallback(Window window, int width, int height);

    /// <summary>
    ///     This is the function signature for cursor position callback functions.
    /// </summary>
    /// <param name="window">The window handle.</param>
    /// <param name="x">The new cursor x-coordinate, relative to the left edge of the client area.</param>
    /// <param name="y">The new cursor y-coordinate, relative to the left edge of the client area.</param>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PositionCallback(Window window, double x, double y);

    /// <summary>
    ///     This is the function signature for window focus callback functions.
    /// </summary>
    /// <param name="window">The window handle.</param>
    /// <param name="focusing"><c>true</c> if window is gaining focus; otherise <c>false</c>.</param>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void FocusCallback(Window window, bool focusing);

    /// <summary>
    ///     Generic signature for window callbacks.
    /// </summary>
    /// <param name="window">The window handle.</param>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void WindowCallback(Window window);

    /// <summary>
    ///     This is the function signature for file drop callbacks.
    /// </summary>
    /// <param name="window">The window that received the event.</param>
    /// <param name="count">The number of dropped files.</param>
    /// <param name="arrayPtr">Pointer to an array UTF-8 encoded file and/or directory path name pointers.</param>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void FileDropCallback(Window window, int count, IntPtr arrayPtr);

    /// <summary>
    ///     This is the function signature for cursor position callback functions.
    /// </summary>
    /// <param name="window">The window handle recieving the event.</param>
    /// <param name="x">The new cursor x-coordinate, relative to the left edge of the client area.</param>
    /// <param name="y">The new cursor y-coordinate, relative to the left edge of the client area.</param>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void MouseCallback(Window window, double x, double y);

    /// <summary>
    ///     This is the function signature for cursor enter/leave callback functions.
    /// </summary>
    /// <param name="window">The window handle.</param>
    /// <param name="entering"><c>true</c> if cursor is entering the window client area; otherwise <c>false</c>.</param>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void MouseEnterCallback(Window window, bool entering);

    /// <summary>
    ///     This is the function signature for mouse button callback functions.
    /// </summary>
    /// <param name="window">The window handle.</param>
    /// <param name="button">TThe mouse button that was pressed or released.</param>
    /// <param name="state">The state.</param>
    /// <param name="modifiers">Flags describing which modifier keys were held down.</param>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void MouseButtonCallback(Window window, MouseButton button, InputState state,
        ModifierKeys modifiers);

    /// <summary>
    ///     This is the function signature for Unicode character callback functions.
    /// </summary>
    /// <param name="window">The window handle.</param>
    /// <param name="codePoint">The Unicode code point of the character.</param>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void CharCallback(Window window, uint codePoint);

    /// <summary>
    ///     This is the function signature for Unicode character callback functions.
    /// </summary>
    /// <param name="window">The window handle.</param>
    /// <param name="codePoint">The Unicode code point of the character.</param>
    /// <param name="mods">Bit field describing which modifier keys were held down.</param>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void CharModsCallback(Window window, uint codePoint, ModifierKeys mods);

    /// <summary>
    ///     This is the function signature for keyboard key callback functions.
    /// </summary>
    /// <param name="window">The window handle.</param>
    /// <param name="key">The keyboard key that was pressed or released.</param>
    /// <param name="scanCode">The system-specific scancode of the key.</param>
    /// <param name="state">The state of the key.</param>
    /// <param name="mods">	Bit field describing which modifier keys were held down.</param>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void KeyCallback(Window window, Keys key, int scanCode, InputState state, ModifierKeys mods);

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
    ///     This is the function signature for window content scale callback functions.
    /// </summary>
    /// <param name="window">The window whose content scale changed.</param>
    /// <param name="xScale">The new x-axis content scale of the window.</param>
    /// <param name="yScale">The new y-axis content scale of the window.</param>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void WindowContentsScaleCallback(Window window, float xScale, float yScale);

    /// <summary>
    ///     This is the function signature for window maximize/restore callback functions.
    /// </summary>
    /// <param name="window">The window that was maximized or restored.</param>
    /// <param name="maximized"><c>true</c> if the window was maximized, or <c>false</c> if it was restored.</param>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void WindowMaximizedCallback(Window window, bool maximized);
}