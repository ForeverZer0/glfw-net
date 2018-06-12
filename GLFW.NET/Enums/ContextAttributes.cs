#region MIT License

// ContextAttributes.cs is distributed under the MIT License (MIT)
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
// ContextAttributes.cs created on 06/11/2018

#endregion

namespace GLFW
{
	/// <summary>
	///     Used internally to consolidate strongly-typed values for getting/setting window attributes.
	/// </summary>
	internal enum ContextAttributes
	{
		ClientApi = 0x00022001,
		ContextCreationApi = 0x0002200B,
		ContextVersionMajor = 0x00022002,
		ContextVersionMinor = 0x00022003,
		ContextVersionRevision = 0x00022004,
		OpenglForwardCompat = 0x00022006,
		OpenglDebugContext = 0x00022007,
		OpenglProfile = 0x00022008,
		ContextRobustness = 0x00022005
	}
}