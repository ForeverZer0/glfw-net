#region MIT License

// Profile.cs is distributed under the MIT License (MIT)
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
// Profile.cs created on 06/11/2018

#endregion

namespace GLFW
{
	/// <summary>
	///     Strongly-typed values used for getting/setting window hints.
	///     <para>If OpenGL ES is requested, this hint is ignored.</para>
	/// </summary>
	public enum Profile
	{
		/// <summary>
		///     Indicates no preference on profile.
		///     <para>If requesting an OpenGL version below 3.2, this profile must be used.</para>
		/// </summary>
		Any = 0x00000000,

		/// <summary>
		///     Indicates OpenGL Core profile.
		///     <para>Only if requested OpenGL is greater than 3.2.</para>
		/// </summary>
		Core = 0x00032001,

		/// <summary>
		///     Indicates OpenGL Compatibility profile.
		///     <para>Only if requested OpenGL is greater than 3.2.</para>
		/// </summary>
		Compatibility = 0x00032002
	}
}