#region MIT License

// Hint.cs is distributed under the MIT License (MIT)
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
// Hint.cs created on 06/10/2018

#endregion

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
		///     Specifies the desired bit depth of the red component for default framebuffer. <see cref="Constants.Default" /> means
		///     the application has no preference.
		///     <para>Default Value: <c>8</c></para>
		///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
		/// </summary>
		RedBits = 0x00021001,

		/// <summary>
		///     Specifies the desired bit depth of the green component for default framebuffer. <see cref="Constants.Default" /> means
		///     the application has no preference.
		///     <para>Default Value: <c>8</c></para>
		///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
		/// </summary>
		GreenBits = 0x00021002,

		/// <summary>
		///     Specifies the desired bit depth of the blue component for default framebuffer. <see cref="Constants.Default" /> means
		///     the application has no preference.
		///     <para>Default Value: <c>8</c></para>
		///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
		/// </summary>
		BlueBits = 0x00021003,

		/// <summary>
		///     Specifies the desired bit depth of the alpha component for default framebuffer. <see cref="Constants.Default" /> means
		///     the application has no preference.
		///     <para>Default Value: <c>8</c></para>
		///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
		/// </summary>
		AlphaBits = 0x00021004,

		/// <summary>
		///     Specifies the desired bit depth of for default framebuffer. <see cref="Constants.Default" />"/> means the application
		///     has no preference.
		///     <para>Default Value: <c>24</c></para>
		///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
		/// </summary>
		DepthBits = 0x00021005,

		/// <summary>
		///     Specifies the desired stencil bits for default framebuffer. <see cref="Constants.Default" /> means the application has
		///     no preference.
		///     <para>Default Value: <c>0</c></para>
		///     <para>Possible Values: <c>0</c> to <see cref="int.MaxValue" /> or <see cref="Constants.Default" />.</para>
		/// </summary>
		StencilBits = 0x00021006,

		/// <summary>
		///     Specify the desired bit depths of the red component of the accumulation buffer. <see cref="Constants.Default" /> means
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
		ContextNoError = 0x0002200a
	}
}