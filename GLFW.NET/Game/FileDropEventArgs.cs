#region MIT License

// FileDropEventArgs.cs is distributed under the MIT License (MIT)
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
// FileDropEventArgs.cs created on 06/10/2018

#endregion

using System;

namespace GLFW.Game
{
	/// <summary>
	///     Arguments supplied with file drag-drop events.
	/// </summary>
	/// <seealso cref="EventArgs" />
	public class FileDropEventArgs : EventArgs
	{
		#region Properties

		/// <summary>
		///     Gets the filenames of the dropped files.
		/// </summary>
		/// <value>
		///     The filenames.
		/// </value>
		public string[] Filenames { get; }

		#endregion

		#region Constructors

		/// <summary>
		///     Initializes a new instance of the <see cref="FileDropEventArgs" /> class.
		/// </summary>
		/// <param name="filenames">The dropped filenames.</param>
		public FileDropEventArgs(string[] filenames) => Filenames = filenames;

		#endregion
	}
}