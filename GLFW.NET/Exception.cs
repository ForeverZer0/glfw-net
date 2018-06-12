#region MIT License

// Exception.cs is distributed under the MIT License (MIT)
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
// Exception.cs created on 06/08/2018

#endregion

namespace GLFW
{
	public class Exception : System.Exception
	{
		#region Constructors

		/// <summary>
		///     Initializes a new instance of the <see cref="Exception" /> class.
		/// </summary>
		/// <param name="error">The error code to create a generic message from.</param>
		public Exception(ErrorCode error) : base(GetErrorMessage(error)) { }

		/// <summary>
		///     Initializes a new instance of the <see cref="Exception" /> class.
		/// </summary>
		/// <param name="message">The error message.</param>
		public Exception(string message) : base(message) { }

		#endregion

		#region Methods

		/// <summary>
		///     Generic error messages if only an error code is supplied as an argument to the constructor.
		/// </summary>
		/// <param name="code">The error code.</param>
		/// <returns>Error message.</returns>
		public static string GetErrorMessage(ErrorCode code)
		{
			switch (code)
			{
				case ErrorCode.NotInitialized: return Strings.NotInitialized;
				case ErrorCode.NoCurrentContext: return Strings.NoCurrentContext;
				case ErrorCode.InvalidEnum: return Strings.InvalidEnum;
				case ErrorCode.InvalidValue: return Strings.InvalidValue;
				case ErrorCode.OutOfMemory: return Strings.OutOfMemory;
				case ErrorCode.ApiUnavailable: return Strings.ApiUnavailable;
				case ErrorCode.VersionUnavailable: return Strings.VersionUnavailable;
				case ErrorCode.PlatformError: return Strings.PlatformError;
				case ErrorCode.FormatUnavailable: return Strings.FormatUnavailable;
				case ErrorCode.NoWindowContext: return Strings.NoWindowContext;
				default: return Strings.UnknownError;
			}
		}

		#endregion
	}
}