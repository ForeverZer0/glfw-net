using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using Microsoft.Win32.SafeHandles;

namespace GLFW
{
    /// <summary>
    ///     Provides a simplified interface for creating and using a GLFW window with properties, events, etc.
    /// </summary>
    /// <seealso cref="Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid" />
    public class NativeWindow : SafeHandleZeroOrMinusOneIsInvalid, IEquatable<NativeWindow>
    {
        /// <summary>
        ///     Determines whether the specified <paramref name="window" /> is equal to this instance.
        /// </summary>
        /// <param name="window">A <see cref="NativeWindow" /> instance to compare for equality.</param>
        /// <returns><c>true</c> if objects represent the same window, otherwise <c>false</c>.</returns>
        public bool Equals(NativeWindow window)
        {
            if (ReferenceEquals(null, window)) return false;
            return ReferenceEquals(this, window) || Window.Equals(window.Window);
        }

        /// <summary>
        ///     Raises the <see cref="Maximized" /> event.
        /// </summary>
        /// <param name="maximized">Flag indicating if window is being maximized or restored.</param>
        protected virtual void OnMaximizeChanged(bool maximized)
        {
            MaximizeChanged?.Invoke(this, new MaximizeEventArgs(maximized));
        }

        /// <summary>
        ///     Occurs when the content scale has been changed.
        /// </summary>
        public event EventHandler<ContentScaleEventArgs> ContentScaleChanged;

        /// <summary>
        ///     Raises the <see cref="ContentScaleChanged" /> event.
        /// </summary>
        /// <param name="xScale">The new scale on the x-axis.</param>
        /// <param name="yScale">The new scale on the y-axis.</param>
        protected virtual void OnContentScaleChanged(float xScale, float yScale)
        {
            ContentScaleChanged?.Invoke(this, new ContentScaleEventArgs(xScale, yScale));
        }

        /// <inheritdoc cref="Object.Equals(object)" />
        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj) || obj is NativeWindow other && Equals(other);
        }

        /// <inheritdoc cref="Object.GetHashCode" />
        public override int GetHashCode()
        {
            return Window.GetHashCode();
        }

        /// <summary>
        ///     Determines whether the specified window is equal to this instance.
        /// </summary>
        /// <param name="left">This instance.</param>
        /// <param name="right">A <see cref="NativeWindow" /> instance to compare for equality.</param>
        /// <returns><c>true</c> if objects represent the same window, otherwise <c>false</c>.</returns>
        public static bool operator ==(NativeWindow left, NativeWindow right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Determines whether the specified window is not equal to this instance.
        /// </summary>
        /// <param name="left">This instance.</param>
        /// <param name="right">A <see cref="NativeWindow" /> instance to compare for equality.</param>
        /// <returns><c>true</c> if objects do not represent the same window, otherwise <c>false</c>.</returns>
        public static bool operator !=(NativeWindow left, NativeWindow right)
        {
            return !Equals(left, right);
        }

        #region Fields and Constants

        /// <summary>
        ///     The window instance this object wraps.
        /// </summary>
        protected readonly Window Window;

        private string title;

        private PositionCallback windowPositionCallback;
        private SizeCallback windowSizeCallback, framebufferSizeCallback;
        private FocusCallback windowFocusCallback;
        private WindowCallback closeCallback, windowRefreshCallback;
        private FileDropCallback dropCallback;
        private MouseCallback cursorPositionCallback, scrollCallback;
        private MouseEnterCallback cursorEnterCallback;
        private MouseButtonCallback mouseButtonCallback;
        private CharModsCallback charModsCallback;
        private KeyCallback keyCallback;
        private WindowMaximizedCallback windowMaximizeCallback;
        private WindowContentsScaleCallback windowContentScaleCallback;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the size and location of the window including its non-client elements (borders, title bar, etc.), in
        ///     screen coordinates.
        /// </summary>
        /// <value>
        ///     A <see cref="Rectangle" /> in screen coordinates relative to the parent control that represents the size and
        ///     location of the control including its non-client elements.
        /// </value>
        public Rectangle Bounds
        {
            get => new Rectangle(Position, Size);
            set
            {
                Size = value.Size;
                Position = value.Location;
            }
        }

        /// <summary>
        ///     Gets the ratio between the current DPI and the platform's default DPI.
        /// </summary>
        /// <seealso cref="Glfw.GetWindowContentScale" />
        public PointF ContentScale
        {
            get
            {
                Glfw.GetWindowContentScale(handle, out var x, out var y);
                return new PointF(x, y);
            }
        }

        /// <summary>
        ///     Gets the size and location of the client area of the window, in screen coordinates.
        /// </summary>
        /// <value>
        ///     A <see cref="Rectangle" /> in screen coordinates that represents the size and location of the window's client area.
        /// </value>
        public Rectangle ClientBounds
        {
            get => new Rectangle(Position, ClientSize);
            set
            {
                Glfw.SetWindowPosition(Window, value.X, value.Y);
                Glfw.SetWindowSize(Window, value.Width, value.Height);
            }
        }

        /// <summary>
        ///     Gets or sets the width of the client area of the window, in screen coordinates.
        /// </summary>
        /// <exception cref="Exception">Thrown when specified value is less than 1.</exception>
        public int ClientWidth
        {
            get
            {
                Glfw.GetWindowSize(Window, out var width, out var dummy);
                return width;
            }
            set
            {
                if (value < 1) 
                    throw new Exception("Window width muts be greater than 0.");
                Glfw.GetWindowSize(Window, out var dummy, out var height);
                Glfw.SetWindowSize(Window, value, height);
            }
        }
        
        /// <summary>
        ///     Gets or sets the height of the client area of the window, in screen coordinates.
        /// </summary>
        /// <exception cref="Exception">Thrown when specified value is less than 1.</exception>
        public int ClientHeight
        {
            get
            {
                Glfw.GetWindowSize(Window, out var dummy, out var height);
                return height;
            }
            set
            {
                if (value < 1) 
                    throw new Exception("Window height muts be greater than 0.");
                Glfw.GetWindowSize(Window, out var width, out var dummy);
                Glfw.SetWindowSize(Window, width, value);
            }
        }

        /// <summary>
        ///     Gets or sets the size of the client area of the window, in screen coordinates.
        /// </summary>
        /// <value>
        ///     A <see cref="System.Drawing.Size" /> in screen coordinates that represents the size of the window's client area.
        /// </value>
        public Size ClientSize
        {
            get
            {
                Glfw.GetWindowSize(Window, out var width, out var height);
                return new Size(width, height);
            }
            set => Glfw.SetWindowSize(Window, value.Width, value.Height);
        }

        /// <summary>
        ///     Requests user-attention to this window on platforms that support it,
        ///     <para>
        ///         Once the user has given attention, usually by focusing the window or application, the system will end the
        ///         request automatically.
        ///     </para>
        /// </summary>
        public void RequestAttention()
        {
            Glfw.RequestWindowAttention(handle);
        }

        /// <summary>
        ///     Gets or sets a string to the system clipboard.
        /// </summary>
        /// <value>
        ///     The clipboard string.
        /// </value>
        [JetBrains.Annotations.NotNull]
        public string Clipboard
        {
            get => Glfw.GetClipboardString(Window);
            set => Glfw.SetClipboardString(Window, value);
        }

        /// <summary>
        ///     Gets or sets the behavior of the mouse cursor.
        /// </summary>
        /// <value>
        ///     The cursor mode.
        /// </value>
        public CursorMode CursorMode
        {
            get => (CursorMode) Glfw.GetInputMode(Window, InputMode.Cursor);
            set => Glfw.SetInputMode(Window, InputMode.Cursor, (int) value);
        }

        /// <summary>
        ///     Gets the underlying pointer used by GLFW for this window instance.
        /// </summary>
        /// <value>
        ///     The GLFW window handle.
        /// </value>
        public IntPtr Handle => handle;

        /// <summary>
        ///     Gets the Window's HWND for this window.
        ///     <para>WARNING: Windows only.</para>
        /// </summary>
        /// <value>
        ///     The HWND pointer.
        /// </value>
        // ReSharper disable once IdentifierTypo
        public IntPtr Hwnd
        {
            get
            {
                try
                {
                    return Native.GetWin32Window(Window);
                }
                catch (Exception)
                {
                    return IntPtr.Zero;
                }
            }
        }

        /// <summary>
        ///     Gets a value indicating whether this instance is closing.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is closing; otherwise, <c>false</c>.
        /// </value>
        public bool IsClosing => Glfw.WindowShouldClose(Window);

        /// <summary>
        ///     Gets a value indicating whether this instance is decorated.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is decorated; otherwise, <c>false</c>.
        /// </value>
        public bool IsDecorated => Glfw.GetWindowAttribute(Window, WindowAttribute.Decorated);

        /// <summary>
        ///     Gets a value indicating whether this instance is floating (top-most, always-on-top).
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is floating; otherwise, <c>false</c>.
        /// </value>
        public bool IsFloating => Glfw.GetWindowAttribute(Window, WindowAttribute.Floating);

        /// <summary>
        ///     Gets a value indicating whether this instance is focused.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is focused; otherwise, <c>false</c>.
        /// </value>
        public bool IsFocused => Glfw.GetWindowAttribute(Window, WindowAttribute.Focused);

        /// <summary>
        ///     Gets a value indicating whether this instance is resizable.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is resizable; otherwise, <c>false</c>.
        /// </value>
        public bool IsResizable => Glfw.GetWindowAttribute(Window, WindowAttribute.Resizable);

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="NativeWindow" /> is maximized.
        ///     <para>Has no effect on fullscreen windows.</para>
        /// </summary>
        /// <value>
        ///     <c>true</c> if maximized; otherwise, <c>false</c>.
        /// </value>
        public bool Maximized
        {
            get => Glfw.GetWindowAttribute(Window, WindowAttribute.Maximized);
            set
            {
                if (value)
                    Glfw.MaximizeWindow(Window);
                else
                    Glfw.RestoreWindow(Window);
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="NativeWindow" /> is minimized.
        ///     <para>If window is already minimized, does nothing.</para>
        /// </summary>
        /// <value>
        ///     <c>true</c> if minimized; otherwise, <c>false</c>.
        /// </value>
        public bool Minimized
        {
            get => Glfw.GetWindowAttribute(Window, WindowAttribute.AutoIconify);
            set
            {
                if (value)
                    Glfw.IconifyWindow(Window);
                else
                    Glfw.RestoreWindow(Window);
            }
        }

        /// <summary>
        ///     Gets the monitor this window is fullscreen on.
        ///     <para>Returns <see cref="GLFW.Monitor.None" /> if window is not fullscreen.</para>
        /// </summary>
        /// <value>
        ///     The monitor.
        /// </value>
        public Monitor Monitor => Glfw.GetWindowMonitor(Window);

        /// <summary>
        ///     Gets or sets the mouse position in screen-coordinates relative to the client area of the window.
        /// </summary>
        /// <value>
        ///     The mouse position.
        /// </value>
        public Point MousePosition
        {
            get
            {
                Glfw.GetCursorPosition(Window, out var x, out var y);
                return new Point(Convert.ToInt32(x), Convert.ToInt32(y));
            }
            set => Glfw.SetCursorPosition(Window, value.X, value.Y);
        }

        /// <summary>
        ///     Gets or sets the position of the window in screen coordinates, including border, titlebar, etc..
        /// </summary>
        /// <value>
        ///     The position.
        /// </value>
        public Point Position
        {
            get
            {
                Glfw.GetWindowPosition(Window, out var x, out var y);
                Glfw.GetWindowFrameSize(Window, out var l, out var t, out var dummy1, out var dummy2);
                return new Point(x - l, y - t);
            }
            set
            {
                Glfw.GetWindowFrameSize(Window, out var l, out var t, out var dummy1, out var dummy2);
                Glfw.SetWindowPosition(Window, value.X + l, value.Y + t);
            }
        }

        /// <summary>
        ///     Gets or sets the size of the window, in screen coordinates, including border, titlebar, etc.
        /// </summary>
        /// <value>
        ///     A <see cref="System.Drawing.Size" /> in screen coordinates that represents the size of the window.
        /// </value>
        public Size Size
        {
            get
            {
                Glfw.GetWindowSize(Window, out var width, out var height);
                Glfw.GetWindowFrameSize(Window, out var l, out var t, out var r, out var b);
                return new Size(width + l + r, height + t + b);
            }
            set
            {
                Glfw.GetWindowFrameSize(Window, out var l, out var t, out var r, out var b);
                Glfw.SetWindowSize(Window, value.Width - l - r, value.Height - t - b);
            }
        }

        /// <summary>
        ///     Sets the sticky keys input mode.
        ///     <para>
        ///         Set to <c>true</c> to enable sticky keys, or <c>false</c> to disable it. If sticky keys are enabled, a key
        ///         press will ensure that <see cref="Glfw.GetKey" /> returns <see cref="InputState.Press" /> the next time it is
        ///         called even if the key had been released before the call. This is useful when you are only interested in
        ///         whether keys have been pressed but not when or in which order.
        ///     </para>
        /// </summary>
        public bool StickyKeys
        {
            get => Glfw.GetInputMode(Window, InputMode.StickyKeys) == (int) Constants.True;
            set =>
                Glfw.SetInputMode(Window, InputMode.StickyKeys, value ? (int) Constants.True : (int) Constants.False);
        }

        /// <summary>
        ///     Gets or sets the sticky mouse button input mode.
        ///     <para>
        ///         Set to <c>true</c> to enable sticky mouse buttons, or <c>false</c> to disable it. If sticky mouse buttons are
        ///         enabled, a mouse button press will ensure that <see cref="Glfw.GetMouseButton" /> returns
        ///         <see cref="InputState.Press" /> the next time it is called even if the mouse button had been released before
        ///         the call. This is useful when you are only interested in whether mouse buttons have been pressed but not when
        ///         or in which order.
        ///     </para>
        /// </summary>
        public bool StickyMouseButtons
        {
            get => Glfw.GetInputMode(Window, InputMode.StickyMouseButton) == (int) Constants.True;
            set =>
                Glfw.SetInputMode(Window, InputMode.StickyMouseButton,
                    value ? (int) Constants.True : (int) Constants.False);
        }

        /// <summary>
        ///     Gets or sets the window title or caption.
        /// </summary>
        /// <value>
        ///     The title.
        /// </value>
        [CanBeNull]
        public string Title
        {
            get => title;
            set
            {
                title = value;
                Glfw.SetWindowTitle(Window, value ?? string.Empty);
            }
        }

        /// <summary>
        ///     Gets or sets a user-defined pointer for GLFW to retain for this instance.
        /// </summary>
        /// <value>
        ///     The user-defined pointer.
        /// </value>
        public IntPtr UserPointer
        {
            get => Glfw.GetWindowUserPointer(Window);
            set => Glfw.SetWindowUserPointer(Window, value);
        }

        /// <summary>
        ///     Gets the video mode for the monitor this window is fullscreen on.
        ///     <para>If window is not fullscreen, returns the <see cref="GLFW.VideoMode" /> for the primary monitor.</para>
        /// </summary>
        /// <value>
        ///     The video mode.
        /// </value>
        public VideoMode VideoMode
        {
            get
            {
                var monitor = Monitor;
                return Glfw.GetVideoMode(monitor == Monitor.None ? Glfw.PrimaryMonitor : monitor);
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="NativeWindow" /> is visible.
        /// </summary>
        /// <value>
        ///     <c>true</c> if visible; otherwise, <c>false</c>.
        /// </value>
        public bool Visible
        {
            get => Glfw.GetWindowAttribute(Window, WindowAttribute.Visible);
            set
            {
                if (value)
                    Glfw.ShowWindow(Window);
                else
                    Glfw.HideWindow(Window);
            }
        }

        #region Operators

        /// <summary>
        ///     Performs an implicit conversion from <see cref="NativeWindow" /> to <see cref="GLFW.Window" />.
        /// </summary>
        /// <param name="nativeWindow">The game window.</param>
        /// <returns>
        ///     The result of the conversion.
        /// </returns>
        public static implicit operator Window(NativeWindow nativeWindow)
        {
            return nativeWindow.Window;
        }

        /// <summary>
        ///     Performs an implicit conversion from <see cref="NativeWindow" /> to <see cref="IntPtr" />.
        /// </summary>
        /// <param name="nativeWindow">The game window.</param>
        /// <returns>
        ///     The result of the conversion.
        /// </returns>
        public static implicit operator IntPtr(NativeWindow nativeWindow)
        {
            return nativeWindow.Window;
        }

        #endregion

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="NativeWindow" /> class.
        /// </summary>
        public NativeWindow() : this(800, 600, string.Empty, Monitor.None, Window.None)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="NativeWindow" /> class.
        /// </summary>
        /// <param name="width">The desired width, in screen coordinates, of the window. This must be greater than zero.</param>
        /// <param name="height">The desired height, in screen coordinates, of the window. This must be greater than zero.</param>
        /// <param name="title">The initial window title.</param>
        public NativeWindow(int width, int height, [CanBeNull] string title) : this(width, height, title, Monitor.None,
            Window.None)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="NativeWindow" /> class.
        /// </summary>
        /// <param name="width">The desired width, in screen coordinates, of the window. This must be greater than zero.</param>
        /// <param name="height">The desired height, in screen coordinates, of the window. This must be greater than zero.</param>
        /// <param name="title">The initial window title.</param>
        /// <param name="monitor">The monitor to use for full screen mode, or <see cref="GLFW.Monitor.None" /> for windowed mode.</param>
        /// <param name="share">
        ///     A window instance whose context to share resources with, or <see cref="GLFW.Window.None" /> to not share
        ///     resources..
        /// </param>
        public NativeWindow(int width, int height, [CanBeNull] string title, Monitor monitor, Window share) : base(true)
        {
            this.title = title ?? string.Empty;
            Window = Glfw.CreateWindow(width, height, title ?? string.Empty, monitor, share);
            SetHandle(Window);
            if (Glfw.GetClientApi(this) != ClientApi.None)
                MakeCurrent();
            BindCallbacks();
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Centers the on window on the screen.
        ///     <para>Has no effect on fullscreen or maximized windows.</para>
        /// </summary>
        public void CenterOnScreen()
        {
            if (Maximized)
                return;
            var monitor = Monitor == Monitor.None ? Glfw.PrimaryMonitor : Monitor;
            var videoMode = Glfw.GetVideoMode(monitor);
            var size = Size;
            Position = new Point((videoMode.Width - size.Width) / 2, (videoMode.Height - size.Height) / 2);
        }

        /// <summary>
        ///     Closes this instance.
        ///     <para>This invalidates the window, but does not free its resources.</para>
        /// </summary>
        public new void Close()
        {
            Glfw.SetWindowShouldClose(Window, true);
            OnClosing();
            base.Close();
        }

        /// <summary>
        ///     Focuses this form to receive input and events.
        /// </summary>
        public void Focus()
        {
            Glfw.FocusWindow(Window);
        }

        /// <summary>
        ///     Sets the window fullscreen on the primary monitor.
        /// </summary>
        public void Fullscreen()
        {
            Fullscreen(Glfw.PrimaryMonitor);
        }

        /// <summary>
        ///     Sets the window fullscreen on the specified monitor.
        /// </summary>
        /// <param name="monitor">The monitor to display the window fullscreen.</param>
        public void Fullscreen(Monitor monitor)
        {
            Glfw.SetWindowMonitor(Window, monitor, 0, 0, 0, 0, -1);
        }

        /// <summary>
        ///     Makes window and its context the current.
        /// </summary>
        public void MakeCurrent()
        {
            Glfw.MakeContextCurrent(Window);
        }

        /// <summary>
        ///     Maximizes this window to fill the screen.
        ///     <para>Has no effect if window is already maximized.</para>
        /// </summary>
        public void Maximize()
        {
            Glfw.MaximizeWindow(Window);
        }

        /// <summary>
        ///     Minimizes this window.
        ///     <para>Has no effect if window is already minimized.</para>
        /// </summary>
        public void Minimize()
        {
            Glfw.IconifyWindow(Window);
        }

        /// <summary>
        ///     Restores a minimized window to its previous state.
        ///     <para>Has no effect if window was already restored.</para>
        /// </summary>
        public void Restore()
        {
            Glfw.RestoreWindow(Window);
        }

        /// <summary>
        ///     Sets the aspect ratio to maintain for the window.
        ///     <para>This function is ignored for fullscreen windows.</para>
        /// </summary>
        /// <param name="numerator">The numerator of the desired aspect ratio.</param>
        /// <param name="denominator">The denominator of the desired aspect ratio.</param>
        public void SetAspectRatio(int numerator, int denominator)
        {
            Glfw.SetWindowAspectRatio(Window, numerator, denominator);
        }

        /// <summary>
        ///     Sets the icon(s) used for the titlebar, taskbar, etc.
        ///     <para>Standard sizes are 16x16, 32x32, and 48x48.</para>
        /// </summary>
        /// <param name="images">One or more images to set as an icon.</param>
        public void SetIcons([JetBrains.Annotations.NotNull] params Image[] images)
        {
            Glfw.SetWindowIcon(Window, images.Length, images);
        }

        /// <summary>
        ///     Sets the window monitor.
        ///     <para>
        ///         If <paramref name="monitor" /> is not <see cref="GLFW.Monitor.None" />, the window will be full-screened and
        ///         dimensions ignored.
        ///     </para>
        /// </summary>
        /// <param name="monitor">The desired monitor, or <see cref="GLFW.Monitor.None" /> to set windowed mode.</param>
        /// <param name="x">The desired x-coordinate of the upper-left corner of the client area.</param>
        /// <param name="y">The desired y-coordinate of the upper-left corner of the client area.</param>
        /// <param name="width">The desired width, in screen coordinates, of the client area or video mode.</param>
        /// <param name="height">The desired height, in screen coordinates, of the client area or video mode.</param>
        /// <param name="refreshRate">The desired refresh rate, in Hz, of the video mode, or <see cref="Constants.Default" />.</param>
        public void SetMonitor(Monitor monitor, int x, int y, int width, int height,
            int refreshRate = (int) Constants.Default)
        {
            Glfw.SetWindowMonitor(Window, monitor, x, y, width, height, refreshRate);
        }

        /// <summary>
        ///     Sets the limits of the client size  area of the window.
        /// </summary>
        /// <param name="minSize">The minimum size of the client area.</param>
        /// <param name="maxSize">The maximum size of the client area.</param>
        public void SetSizeLimits(Size minSize, Size maxSize)
        {
            SetSizeLimits(minSize.Width, minSize.Height, maxSize.Width, maxSize.Height);
        }

        /// <summary>
        ///     Sets the limits of the client size  area of the window.
        /// </summary>
        /// <param name="minWidth">The minimum width of the client area.</param>
        /// <param name="minHeight">The minimum height of the client area.</param>
        /// <param name="maxWidth">The maximum width of the client area.</param>
        /// <param name="maxHeight">The maximum height of the client area.</param>
        public void SetSizeLimits(int minWidth, int minHeight, int maxWidth, int maxHeight)
        {
            Glfw.SetWindowSizeLimits(Window, minWidth, minHeight, maxWidth, maxHeight);
        }

        /// <summary>
        ///     Swaps the front and back buffers when rendering with OpenGL or OpenGL ES.
        ///     <para>
        ///         This should not be called on a window that is not using an OpenGL or OpenGL ES context (.i.e. Vulkan).
        ///     </para>
        /// </summary>
        public void SwapBuffers()
        {
            Glfw.SwapBuffers(Window);
        }

        /// <summary>
        ///     Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing">
        ///     <c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only
        ///     unmanaged resources.
        /// </param>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            Disposed?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        ///     Releases the internal GLFW handle.
        /// </summary>
        /// <returns><c>true</c> if handle was released successfully, otherwise <c>false</c>.</returns>
        protected override bool ReleaseHandle()
        {
            try
            {
                Glfw.DestroyWindow(Window);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void BindCallbacks()
        {
            windowPositionCallback = (_, x, y) => OnPositionChanged(x, y);
            windowSizeCallback = (_, w, h) => OnSizeChanged(w, h);
            windowFocusCallback = (_, focusing) => OnFocusChanged(focusing);
            closeCallback = _ => OnClosing();
            dropCallback = (_, count, arrayPtr) => OnFileDrop(count, arrayPtr);
            cursorPositionCallback = (_, x, y) => OnMouseMove(x, y);
            cursorEnterCallback = (_, entering) => OnMouseEnter(entering);
            mouseButtonCallback = (_, button, state, mod) => OnMouseButton(button, state, mod);
            scrollCallback = (_, x, y) => OnMouseScroll(x, y);
            charModsCallback = (_, cp, mods) => OnCharacterInput(cp, mods);
            framebufferSizeCallback = (_, w, h) => OnFramebufferSizeChanged(w, h);
            windowRefreshCallback = _ => Refreshed?.Invoke(this, EventArgs.Empty);
            keyCallback = (_, key, code, state, mods) => OnKey(key, code, state, mods);
            windowMaximizeCallback = (_, maximized) => OnMaximizeChanged(maximized);
            windowContentScaleCallback = (_, x, y) => OnContentScaleChanged(x, y);

            Glfw.SetWindowPositionCallback(Window, windowPositionCallback);
            Glfw.SetWindowSizeCallback(Window, windowSizeCallback);
            Glfw.SetWindowFocusCallback(Window, windowFocusCallback);
            Glfw.SetCloseCallback(Window, closeCallback);
            Glfw.SetDropCallback(Window, dropCallback);
            Glfw.SetCursorPositionCallback(Window, cursorPositionCallback);
            Glfw.SetCursorEnterCallback(Window, cursorEnterCallback);
            Glfw.SetMouseButtonCallback(Window, mouseButtonCallback);
            Glfw.SetScrollCallback(Window, scrollCallback);
            Glfw.SetCharModsCallback(Window, charModsCallback);
            Glfw.SetFramebufferSizeCallback(Window, framebufferSizeCallback);
            Glfw.SetWindowRefreshCallback(Window, windowRefreshCallback);
            Glfw.SetKeyCallback(Window, keyCallback);
            Glfw.SetWindowMaximizeCallback(Window, windowMaximizeCallback);
            Glfw.SetWindowContentScaleCallback(Window, windowContentScaleCallback);
        }

        private void OnFileDrop(int count, IntPtr pointer)
        {
            var paths = new string[count];
            var offset = 0;
            for (var i = 0; i < count; i++, offset += IntPtr.Size)
            {
                var ptr = Marshal.ReadIntPtr(pointer + offset);
                paths[i] = Util.PtrToStringUTF8(ptr);
            }

            OnFileDrop(paths);
        }

        #endregion

        #region Delegates and Events

        /// <summary>
        ///     Occurs when the window is maximized or restored.
        /// </summary>
        public event EventHandler<MaximizeEventArgs> MaximizeChanged;

        /// <summary>
        ///     Occurs when the window receives character input.
        /// </summary>
        public event EventHandler<CharEventArgs> CharacterInput;

        /// <summary>
        ///     Occurs when the window is closed.
        /// </summary>
        public event EventHandler Closed;

        /// <summary>
        ///     Occurs when the form is closing, and provides subscribers means of canceling the action..
        /// </summary>
        public event CancelEventHandler Closing;

        /// <summary>
        ///     Occurs when the window is disposed.
        /// </summary>
        public event EventHandler Disposed;

        /// <summary>
        ///     Occurs when files are dropped onto the window client area with a drag-drop event.
        /// </summary>
        public event EventHandler<FileDropEventArgs> FileDrop;

        /// <summary>
        ///     Occurs when the window gains or loses focus.
        /// </summary>
        public event EventHandler FocusChanged;

        /// <summary>
        ///     Occurs when the size of the internal framebuffer is changed.
        /// </summary>
        public event EventHandler<SizeChangeEventArgs> FramebufferSizeChanged;

        /// <summary>
        ///     Occurs when a key is pressed, released, or repeated.
        /// </summary>
        public event EventHandler<KeyEventArgs> KeyAction;

        /// <summary>
        ///     Occurs when a key is pressed.
        /// </summary>
        public event EventHandler<KeyEventArgs> KeyPress;

        /// <summary>
        ///     Occurs when a key is released.
        /// </summary>
        public event EventHandler<KeyEventArgs> KeyRelease;

        /// <summary>
        ///     Occurs when a key is held long enough to raise a repeat event.
        /// </summary>
        public event EventHandler<KeyEventArgs> KeyRepeat;

        /// <summary>
        ///     Occurs when a mouse button is pressed or released.
        /// </summary>
        public event EventHandler<MouseButtonEventArgs> MouseButton;

        /// <summary>
        ///     Occurs when the mouse cursor enters the client area of the window.
        /// </summary>
        public event EventHandler MouseEnter;

        /// <summary>
        ///     Occurs when the mouse cursor leaves the client area of the window.
        /// </summary>
        public event EventHandler MouseLeave;

        /// <summary>
        ///     Occurs when mouse cursor is moved.
        /// </summary>
        public event EventHandler<MouseMoveEventArgs> MouseMoved;

        /// <summary>
        ///     Occurs when mouse is scrolled.
        /// </summary>
        public event EventHandler<MouseMoveEventArgs> MouseScroll;

        /// <summary>
        ///     Occurs when position of the <see cref="NativeWindow" /> is changed.
        /// </summary>
        public event EventHandler PositionChanged;

        /// <summary>
        ///     Occurs when window is refreshed.
        /// </summary>
        public event EventHandler Refreshed;

        /// <summary>
        ///     Occurs when size of the <see cref="NativeWindow" /> is changed.
        /// </summary>
        public event EventHandler<SizeChangeEventArgs> SizeChanged;

        /// <summary>
        ///     Raises the <see cref="CharacterInput" /> event.
        /// </summary>
        /// <param name="codePoint">The Unicode code point.</param>
        /// <param name="mods">The modifier keys present.</param>
        protected virtual void OnCharacterInput(uint codePoint, ModifierKeys mods)
        {
            CharacterInput?.Invoke(this, new CharEventArgs(codePoint, mods));
        }

        /// <summary>
        ///     Raises the <see cref="Closed" /> event.
        /// </summary>
        protected virtual void OnClosed()
        {
            Closed?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        ///     Raises the <see cref="Closing" /> event.
        /// </summary>
        protected virtual void OnClosing()
        {
            var args = new CancelEventArgs();
            Closing?.Invoke(this, args);
            if (args.Cancel)
            {
                Glfw.SetWindowShouldClose(Window, false);
            }
            else
            {
                base.Close();
                OnClosed();
            }
        }

        /// <summary>
        ///     Raises the <see cref="FileDrop" /> event.
        /// </summary>
        /// <param name="paths">The filenames of the dropped files.</param>
        protected virtual void OnFileDrop([JetBrains.Annotations.NotNull] string[] paths)
        {
            FileDrop?.Invoke(this, new FileDropEventArgs(paths));
        }

        /// <summary>
        ///     Raises the <see cref="FocusChanged" /> event.
        /// </summary>
        /// <param name="focusing"><c>true</c> if window is gaining focus, otherwise <c>false</c>.</param>
        // ReSharper disable once UnusedParameter.Global
        protected virtual void OnFocusChanged(bool focusing)
        {
            FocusChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        ///     Raises the <see cref="FramebufferSizeChanged" /> event.
        /// </summary>
        /// <param name="width">The new width.</param>
        /// <param name="height">The new height.</param>
        protected virtual void OnFramebufferSizeChanged(int width, int height)
        {
            FramebufferSizeChanged?.Invoke(this, new SizeChangeEventArgs(new Size(width, height)));
        }

        /// <summary>
        ///     Raises the appropriate key events.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="scanCode">The scan code.</param>
        /// <param name="state">The state of the key.</param>
        /// <param name="mods">The modifier keys.</param>
        /// <seealso cref="KeyPress" />
        /// <seealso cref="KeyRelease" />
        /// <seealso cref="KeyRepeat" />
        /// <seealso cref="KeyAction" />
        protected virtual void OnKey(Keys key, int scanCode, InputState state, ModifierKeys mods)
        {
            var args = new KeyEventArgs(key, scanCode, state, mods);
            if (state.HasFlag(InputState.Press))
                KeyPress?.Invoke(this, args);
            else if (state.HasFlag(InputState.Release))
                KeyRelease?.Invoke(this, args);
            else
                KeyRepeat?.Invoke(this, args);
            KeyAction?.Invoke(this, args);
        }

        /// <summary>
        ///     Raises the <see cref="MouseButton" /> event.
        /// </summary>
        /// <param name="button">The mouse button.</param>
        /// <param name="state">The state of the mouse button.</param>
        /// <param name="modifiers">The modifier keys.</param>
        protected virtual void OnMouseButton(MouseButton button, InputState state, ModifierKeys modifiers)
        {
            MouseButton?.Invoke(this, new MouseButtonEventArgs(button, state, modifiers));
        }

        /// <summary>
        ///     Raises the <see cref="MouseEnter" /> and <see cref="MouseLeave" /> events.
        /// </summary>
        /// <param name="entering"><c>true</c> if mouse is entering window, otherwise <c>false</c> if it is leaving.</param>
        protected virtual void OnMouseEnter(bool entering)
        {
            if (entering)
                MouseEnter?.Invoke(this, EventArgs.Empty);
            else
                MouseLeave?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        ///     Raises the <see cref="MouseMoved" /> event.
        /// </summary>
        /// <param name="x">The new x-coordinate of the mouse.</param>
        /// <param name="y">The new y-coordinate of the mouse.</param>
        protected virtual void OnMouseMove(double x, double y)
        {
            MouseMoved?.Invoke(this, new MouseMoveEventArgs(x, y));
        }

        /// <summary>
        ///     Raises the <see cref="MouseScroll" /> event.
        /// </summary>
        /// <param name="x">The amount of the scroll on the x-axis.</param>
        /// <param name="y">The amount of the scroll on the y-axis.</param>
        protected virtual void OnMouseScroll(double x, double y)
        {
            MouseScroll?.Invoke(this, new MouseMoveEventArgs(x, y));
        }

        /// <summary>
        ///     Raises the <see cref="PositionChanged" /> event.
        /// </summary>
        /// <param name="x">The new position on the x-axis.</param>
        /// <param name="y">The new position on the y-axis.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "UnusedParameter.Global")]
        protected virtual void OnPositionChanged(double x, double y)
        {
            PositionChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        ///     Raises the <see cref="SizeChanged" /> event.
        /// </summary>
        /// <param name="width">The new width.</param>
        /// <param name="height">The new height.</param>
        protected virtual void OnSizeChanged(int width, int height)
        {
            SizeChanged?.Invoke(this, new SizeChangeEventArgs(new Size(width, height)));
        }

        #endregion
    }
}
