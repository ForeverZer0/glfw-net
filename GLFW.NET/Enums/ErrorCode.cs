#region MIT License

// ErrorCode.cs is distributed under the MIT License (MIT)
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
// ErrorCode.cs created on 06/10/2018

#endregion

namespace GLFW
{
	/// <summary>
	///     Strongly-typed error codes for error handling.
	/// </summary>
	public enum ErrorCode
	{
		/// <summary>
		///     An unknown or undefined error.
		/// </summary>
		Unknown = 0x00000000,

		/// <summary>
		///     This occurs if a GLFW function was called that must not be called unless the library is initialized.
		/// </summary>
		NotInitialized = 0x00010001,

		/// <summary>
		///     This occurs if a GLFW function was called that needs and operates on the current OpenGL or OpenGL ES context but no
		///     context is current on the calling thread.
		/// </summary>
		NoCurrentContext = 0x00010002,

		/// <summary>
		///     One of the arguments to the function was an invalid enum value.
		/// </summary>
		InvalidEnum = 0x00010003,

		/// <summary>
		///     One of the arguments to the function was an invalid value, for example requesting a non-existent OpenGL or OpenGL
		///     ES version like 2.7.
		/// </summary>
		InvalidValue = 0x00010004,

		/// <summary>
		///     A memory allocation failed.
		/// </summary>
		OutOfMemory = 0x00010005,

		/// <summary>
		///     GLFW could not find support for the requested API on the system.
		/// </summary>
		ApiUnavailable = 0x00010006,

		/// <summary>
		///     The requested OpenGL or OpenGL ES version (including any requested context or framebuffer hints) is not available
		///     on this machine.
		/// </summary>
		VersionUnavailable = 0x00010007,

		/// <summary>
		///     A platform-specific error occurred that does not match any of the more specific categories.
		/// </summary>
		PlatformError = 0x00010008,

		/// <summary>
		///     If emitted during window creation, the requested pixel format is not supported, else if emitted when querying the
		///     clipboard, the contents of the clipboard could not be converted to the requested format.
		/// </summary>
		FormatUnavailable = 0x00010009,

		/// <summary>
		///     A window that does not have an OpenGL or OpenGL ES context was passed to a function that requires it to have one.
		/// </summary>
		NoWindowContext = 0x0001000A
	}
}