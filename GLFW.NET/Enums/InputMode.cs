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
	    ///     When this input mode is enabled, any callback that receives modifier bits will have the
	    ///     <see cref="ModifierKeys.CapsLock" /> bit set if caps lock was on when the event occurred and the
	    ///     <see cref="ModifierKeys.NumLock" /> bit set if num lock was on.
	    /// </summary>
	    LockKeyMods = 0x00033004,

	    /// <summary>
	    ///     When the cursor is disabled, raw (unscaled and unaccelerated) mouse motion can be enabled if available.
	    ///     <seealso cref="Glfw.RawMouseMotionSupported" />
	    /// </summary>
	    RawMouseMotion = 0x00033005
    }
}