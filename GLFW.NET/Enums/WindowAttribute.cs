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
	    ///     Indicates whether the cursor is currently directly over the content area of the window, with no other
	    ///     windows between.
	    /// </summary>
	    MouseHover = 0x0002000B
    }
}