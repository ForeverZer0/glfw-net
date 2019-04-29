using System;

// TODO: Create Hint component

namespace GLFW
{
    /// <summary>
    ///     Strongly-typed values for setting window hints.
    /// </summary>
    public enum Hint
    {
	    /// <summary>
	    ///     Specifies whether the windowed mode window will be given input focus when created. This hint is ignored for full
	    ///     screen and initially hidden windows.
	    ///     <para>Default Value: <see cref="Constants.True" /></para>
	    ///     <para>Possible Values: <see cref="Constants.True" /> or <see cref="Constants.False" />.</para>
	    /// </summary>
	    Focused = 0x00020001,

	    /// <summary>
	    ///     Specifies whether the windowed mode window will be resizable by the user. The window will still be resizable
	    ///     programmatically. This hint is ignored for full screen windows.
	    ///     <para>Default Value: <see cref="Constants.True" /></para>
	    ///     <para>Possible Values: <see cref="Constants.True" /> or <see cref="Constants.False" />.</para>
	    /// </summary>
	    Resizable = 0x00020003,

	    /// <summary>
	    ///     Specifies whether the windowed mode window will be initially visible.This hint is ignored for full screen windows.
	    ///     <para>Default Value: <see cref="Constants.True" /></para>
	    ///     <para>Possible Values: <see cref="Constants.True" /> or <see cref="Constants.False" />.</para>
	    /// </summary>
	    Visible = 0x00020004,

	    /// <summary>
	    ///     Specifies whether the windowed mode window will have window decorations such as a border, a close widget, etc.An
	    ///     undecorated window may still allow the user to generate close events on some platforms.This hint is ignored for
	    ///     full screen windows.
	    ///     <para>Default Value: <see cref="Constants.True" /></para>
	    ///     <para>Possible Values: <see cref="Constants.True" /> or <see cref="Constants.False" />.</para>
	    /// </summary>
	    Decorated = 0x00020005,

	    /// <summary>
	    ///     Specifies whether the full screen window will automatically iconify and restore the previous video mode on input
	    ///     focus loss. This hint is ignored for windowed mode windows.
	    ///     <para>Default Value: <see cref="Constants.True" /></para>
	    ///     <para>Possible Values: <see cref="Constants.True" /> or <see cref="Constants.False" />.</para>
	    /// </summary>
	    AutoIconify = 0x00020006,

	    /// <summary>
	    ///     Specifies whether the windowed mode window will be floating above other regular windows, also called topmost or
	    ///     always-on-top.This is intended primarily for debugging purposes and cannot be used to implement proper full screen
	    ///     windows. This hint is ignored for full screen windows.
	    ///     <para>Default Value: <see cref="Constants.False" /></para>
	    ///     <para>Possible Values: <see cref="Constants.True" /> or <see cref="Constants.False" />.</para>
	    /// </summary>
	    Floating = 0x00020007,

	    /// <summary>
	    ///     Specifies whether the windowed mode window will be maximized when created. This hint is ignored for full screen
	    ///     windows.
	    ///     <para>Default Value: <see cref="Constants.False" /></para>
	    ///     <para>Possible Values: <see cref="Constants.True" /> or <see cref="Constants.False" />.</para>
	    /// </summary>
	    Maximized = 0x00020008,

	    /// <summary>
	    ///     Specifies the desired bit depth of the red component for default framebuffer. <see cref="Constants.Default" />
	    ///     means
	    ///     the application has no preference.
	    ///     <para>Default Value: <c>8</c></para>
	    ///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
	    /// </summary>
	    RedBits = 0x00021001,

	    /// <summary>
	    ///     Specifies the desired bit depth of the green component for default framebuffer. <see cref="Constants.Default" />
	    ///     means
	    ///     the application has no preference.
	    ///     <para>Default Value: <c>8</c></para>
	    ///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
	    /// </summary>
	    GreenBits = 0x00021002,

	    /// <summary>
	    ///     Specifies the desired bit depth of the blue component for default framebuffer. <see cref="Constants.Default" />
	    ///     means
	    ///     the application has no preference.
	    ///     <para>Default Value: <c>8</c></para>
	    ///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
	    /// </summary>
	    BlueBits = 0x00021003,

	    /// <summary>
	    ///     Specifies the desired bit depth of the alpha component for default framebuffer. <see cref="Constants.Default" />
	    ///     means
	    ///     the application has no preference.
	    ///     <para>Default Value: <c>8</c></para>
	    ///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
	    /// </summary>
	    AlphaBits = 0x00021004,

	    /// <summary>
	    ///     Specifies the desired bit depth of for default framebuffer. <see cref="Constants.Default" />"/> means the
	    ///     application
	    ///     has no preference.
	    ///     <para>Default Value: <c>24</c></para>
	    ///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
	    /// </summary>
	    DepthBits = 0x00021005,

	    /// <summary>
	    ///     Specifies the desired stencil bits for default framebuffer. <see cref="Constants.Default" /> means the application
	    ///     has
	    ///     no preference.
	    ///     <para>Default Value: <c>0</c></para>
	    ///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
	    /// </summary>
	    StencilBits = 0x00021006,

	    /// <summary>
	    ///     Specify the desired bit depths of the red component of the accumulation buffer. <see cref="Constants.Default" />
	    ///     means
	    ///     the application has no preference.
	    ///     <para>Accumulation buffers are a legacy OpenGL feature and should not be used in new code.</para>
	    ///     <para>Default Value: <c>0</c></para>
	    ///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
	    /// </summary>
	    [Obsolete]
        AccumRedBits = 0x00021007,

	    /// <summary>
	    ///     Specify the desired bit depths of the green component of the accumulation buffer. <see cref="Constants.Default" />
	    ///     means the application has no preference.
	    ///     <para>Accumulation buffers are a legacy OpenGL feature and should not be used in new code.</para>
	    ///     <para>Default Value: <c>0</c></para>
	    ///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
	    /// </summary>
	    [Obsolete]
        AccumGreenBits = 0x00021008,

	    /// <summary>
	    ///     Specify the desired bit depths of the blue component of the accumulation buffer. <see cref="Constants.Default" />
	    ///     means the application has no preference.
	    ///     <para>Accumulation buffers are a legacy OpenGL feature and should not be used in new code.</para>
	    ///     <para>Default Value: <c>0</c></para>
	    ///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
	    /// </summary>
	    [Obsolete]
        AccumBlueBits = 0x00021009,

	    /// <summary>
	    ///     Specify the desired bit depths of the alpha component of the accumulation buffer.
	    ///     <para><see cref="Constants.Default" /> means the application has no preference.</para>
	    ///     <para>Accumulation buffers are a legacy OpenGL feature and should not be used in new code.</para>
	    ///     <para>Default Value: <c>0</c></para>
	    ///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
	    /// </summary>
	    [Obsolete]
        AccumAlphaBits = 0x0002100a,

	    /// <summary>
	    ///     Specifies the desired number of auxiliary buffers.<see cref="Constants.Default" /> means the application has no
	    ///     preference.
	    ///     <para>Auxiliary buffers are a legacy OpenGL feature and should not be used in new code.</para>
	    ///     <para>Default Value: <c>0</c></para>
	    ///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
	    /// </summary>
	    [Obsolete]
        AuxBuffers = 0x0002100b,

	    /// <summary>
	    ///     Specifies whether to use stereoscopic rendering.
	    ///     <para>This is a hard constraint.</para>
	    ///     <para>Default Value: <see cref="Constants.False" /></para>
	    ///     <para>Possible Values: <see cref="Constants.True" /> or <see cref="Constants.False" />.</para>
	    /// </summary>
	    Stereo = 0x0002100c,

	    /// <summary>
	    ///     Specifies the desired number of samples to use for multisampling.Zero disables multisampling.
	    ///     <para><see cref="Constants.Default" /> means the application has no preference.</para>
	    ///     <para>Default Value: <c>0</c></para>
	    ///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
	    /// </summary>
	    Samples = 0x0002100d,

	    /// <summary>
	    ///     Specifies whether the framebuffer should be sRGB capable. If supported, a created OpenGL context will support the
	    ///     GL_FRAMEBUFFER_SRGB enable, also called GL_FRAMEBUFFER_SRGB_EXT) for controlling sRGB rendering and a created
	    ///     OpenGL ES context will always have sRGB rendering enabled.
	    ///     <para>Default Value: <see cref="Constants.False" /></para>
	    ///     <para>Possible Values: <see cref="Constants.True" /> or <see cref="Constants.False" />.</para>
	    /// </summary>
	    SrgbCapable = 0x0002100e,

	    /// <summary>
	    ///     Specifies whether the framebuffer should be double buffered.You nearly always want to use double buffering.
	    ///     <para>This is a hard constraint.</para>
	    ///     <para>Default Value: <see cref="Constants.True" /></para>
	    ///     <para>Possible Values: <see cref="Constants.True" /> or <see cref="Constants.False" />.</para>
	    /// </summary>
	    Doublebuffer = 0x00021010,

	    /// <summary>
	    ///     Specifies the desired refresh rate for full screen windows.
	    ///     <para>If set to <see cref="Constants.Default" />, the highest available refresh rate will be used.</para>
	    ///     <para>This hint is ignored for windowed mode windows.</para>
	    ///     <para>Default Value: <see cref="Constants.Default" /></para>
	    ///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
	    /// </summary>
	    RefreshRate = 0x0002100f,

	    /// <summary>
	    ///     Specifies which client API to create the context for.
	    ///     <para>This is a hard constraint.</para>
	    ///     <para>Default Value: <see cref="GLFW.ClientApi.OpenGL" /></para>
	    ///     <para>Possible Values: Any of <see cref="GLFW.ClientApi" /> values.</para>
	    /// </summary>
	    ClientApi = 0x00022001,

	    /// <summary>
	    ///     Specifies which context creation API to use to create the context.
	    ///     <para>If no client API is requested, this hint is ignored.</para>
	    ///     <para>This is a hard constraint. </para>
	    ///     <para>Default Value: <see cref="ContextApi.Native" /></para>
	    ///     <para>Possible Values: Any of <see cref="ContextApi" /> values.</para>
	    /// </summary>
	    ContextCreationApi = 0x0002200b,

	    /// <summary>
	    ///     Specify the client API major version that the created context must be compatible with.
	    ///     <para>The exact behavior of this hint depends on the requested client API, see remarks for details.</para>
	    ///     <para>Default Value: <c>1</c></para>
	    ///     <para>Possible Values: Any valid major version of the chosen client API</para>
	    /// </summary>
	    ContextVersionMajor = 0x00022002,

	    /// <summary>
	    ///     Specify the client API minor version that the created context must be compatible with.
	    ///     <para>The exact behavior of this hint depends on the requested client API, see remarks for details.</para>
	    ///     <para>Default Value: <c>0</c></para>
	    ///     <para>Possible Values: Any valid minor version of the chosen client API</para>
	    /// </summary>
	    ContextVersionMinor = 0x00022003,

	    /// <summary>
	    ///     Specifies the robustness strategy to be used by the context.
	    ///     <para>Default Value: <see cref="Robustness.None" /></para>
	    ///     <para>Possible Values: Any of <see cref="Robustness" /> values</para>
	    /// </summary>
	    ContextRobustness = 0x00022005,

	    /// <summary>
	    ///     Specifies whether the OpenGL context should be forward-compatible, i.e. one where all functionality deprecated in
	    ///     the requested version of OpenGL is removed.
	    ///     <para>This must only be used if the requested OpenGL version is 3.0 or above.</para>
	    ///     <para>If OpenGL ES is requested, this hint is ignored</para>
	    ///     <para>Forward-compatibility is described in detail in the OpenGL Reference Manual.</para>
	    ///     <para>Default Value: <see cref="Constants.False" /></para>
	    ///     <para>Possible Values: <see cref="Constants.True" /> or <see cref="Constants.False" />.</para>
	    /// </summary>
	    OpenglForwardCompatible = 0x00022006,

	    /// <summary>
	    ///     Specifies whether to create a debug OpenGL context, which may have additional error and performance issue reporting
	    ///     functionality.
	    ///     <para>If OpenGL ES is requested, this hint is ignored.</para>
	    ///     <para>Default Value: <see cref="Constants.False" /></para>
	    ///     <para>Possible Values: <see cref="Constants.True" /> or <see cref="Constants.False" />.</para>
	    /// </summary>
	    OpenglDebugContext = 0x00022007,

	    /// <summary>
	    ///     Specifies which OpenGL profile to create the context for.
	    ///     <para>If requesting an OpenGL version below <c>3.2</c>, <see cref="Profile.Any" />  must be used.</para>
	    ///     <para>If OpenGL ES is requested, this hint is ignored.</para>
	    ///     <para>OpenGL profiles are described in detail in the OpenGL Reference Manual.</para>
	    ///     <para>Default Value: <see cref="Profile.Any" /></para>
	    ///     <para>Possible Values: Any of <see cref="Profile" /> values</para>
	    /// </summary>
	    OpenglProfile = 0x00022008,

	    /// <summary>
	    ///     Specifies the release behavior to be used by the context.
	    ///     <para>Default Value: <see cref="ReleaseBehavior.Any" /></para>
	    ///     <para>Possible Values: Any of <see cref="ReleaseBehavior" /> values</para>
	    /// </summary>
	    ContextReleaseBehavior = 0x00022009,

	    /// <summary>
	    ///     Specifies whether errors should be generated by the context. If enabled, situations that would have generated
	    ///     errors instead cause undefined behavior.
	    ///     <para>Default Value: <see cref="Constants.False" /></para>
	    ///     <para>Possible Values: <see cref="Constants.True" /> or <see cref="Constants.False" />.</para>
	    /// </summary>
	    ContextNoError = 0x0002200a,

	    /// <summary>
	    ///     Specifies whether to also expose joystick hats as buttons, for compatibility with earlier versions of
	    ///     GLFW (less than 3.3) that did not have <see cref="Glfw.GetJoystickHats(int)" />.
	    /// </summary>
	    JoystickHatButtons = 0x00050001,

	    /// <summary>
	    ///     Specifies whether to set the current directory to the application to the Contents/Resources
	    ///     subdirectory of the application's bundle, if present.
	    ///     <para>macOS ONLY!</para>
	    /// </summary>
	    CocoaChDirResources = 0x00051001,

	    /// <summary>
	    ///     Specifies whether to create a basic menu bar, either from a nib or manually, when the first window is
	    ///     created, which is when AppKit is initialized.
	    ///     <para>macOS ONLY!</para>
	    /// </summary>
	    CocoaMenuBar = 0x00051002,

	    /// <summary>
	    ///     Specifies whether the cursor should be centered over newly created full screen windows.
	    ///     <para>Possible values are <c>true</c> and <c>false</c>.</para>
	    ///     <para>This hint is ignored for windowed mode windows.</para>
	    /// </summary>
	    CenterCursor = 0x00020009,

	    /// <summary>
	    ///     Specifies whether the window framebuffer will be transparent.
	    ///     <para>
	    ///         If enabled and supported by the system, the window framebuffer alpha channel will be used to combine
	    ///         the framebuffer with the background. This does not affect window decorations.
	    ///     </para>
	    ///     <para>Possible values are <c>true</c> and <c>false</c>.</para>
	    /// </summary>
	    TransparentFramebuffer = 0x0002000A,

	    /// <summary>
	    ///     Specifies whether the window will be given input focus when <see cref="Glfw.ShowWindow" /> is called.
	    ///     <para>Possible values are <c>true</c> and <c>false</c>.</para>
	    /// </summary>
	    FocusOnShow = 0x0002000C,

	    /// <summary>
	    ///     Specifies whether the window content area should be resized based on the monitor content scale of any
	    ///     monitor it is placed on. This includes the initial placement when the window is created.
	    ///     <para>Possible values are <c>true</c> and <c>false</c>.</para>
	    ///     <para>
	    ///         This hint only has an effect on platforms where screen coordinates and pixels always map 1:1 such as
	    ///         Windows and X11. On platforms like macOS the resolution of the framebuffer is changed independently
	    ///         of the window size.
	    ///     </para>
	    /// </summary>
	    ScaleToMonitor = 0x0002200C,

	    /// <summary>
	    ///     Specifies whether to use full resolution framebuffers on Retina displays.
	    ///     <para>Possible values are <c>true</c> and <c>false</c>.</para>
	    ///     <para>This is ignored on other platforms.</para>
	    /// </summary>
	    CocoaRetinaFrameBuffer = 0x00023001,

	    /// <summary>
	    ///     Specifies the UTF-8 encoded name to use for auto-saving the window frame, or if empty disables frame
	    ///     auto-saving for the window.
	    ///     <para>macOs only, this is ignored on other platforms.</para>
	    ///     <para>This is set with <see cref="Glfw.WindowHintString" />.</para>
	    /// </summary>
	    CocoaFrameName = 0x00023002,

	    /// <summary>
	    ///     Specifies whether to in Automatic Graphics Switching, i.e. to allow the system to choose the integrated
	    ///     GPU for the OpenGL context and move it between GPUs if necessary or whether to force it to always run on
	    ///     the discrete GPU.
	    ///     <para>This only affects systems with both integrated and discrete GPUs, ignored on other platforms.</para>
	    ///     <para>Possible values are <c>true</c> and <c>false</c>.</para>
	    /// </summary>
	    CocoaGraphicsSwitching = 0x00023003,

	    /// <summary>
	    ///     Specifies the desired ASCII encoded class parts of the ICCCM <c>WM_CLASS</c> window property.
	    ///     <para>Set with <see cref="Glfw.WindowHintString" />.</para>
	    /// </summary>
	    X11ClassName = 0x00024001,

	    /// <summary>
	    ///     Specifies the desired ASCII encoded instance parts of the ICCCM <c>WM_CLASS</c> window property.
	    ///     <para>Set with <see cref="Glfw.WindowHintString" />.</para>
	    /// </summary>
	    X11InstanceName = 0x00024002
    }
}