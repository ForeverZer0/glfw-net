#region MIT License

// HGLRC.cs is distributed under the MIT License (MIT)
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
// HGLRC.cs created on 06/10/2018

#endregion

using System;
using System.Runtime.InteropServices;

namespace GLFW
{
	/// <summary>
	///     Wrapper around a Window's HGLRC pointer.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct HGLRC : IEquatable<HGLRC>
	{
		/// <summary>
		///     Describes a default/null instance.
		/// </summary>
		public static readonly HGLRC None;

		/// <summary>
		///     Internal pointer.
		/// </summary>
		private readonly IntPtr handle;

		/// <summary>
		///     Performs an implicit conversion from <see cref="HGLRC" /> to <see cref="IntPtr" />.
		/// </summary>
		/// <param name="hglrc">The hglrc.</param>
		/// <returns>
		///     The result of the conversion.
		/// </returns>
		public static implicit operator IntPtr(HGLRC hglrc) => hglrc.handle;

		/// <summary>
		///     Returns a <see cref="System.String" /> that represents this instance.
		/// </summary>
		/// <returns>
		///     A <see cref="System.String" /> that represents this instance.
		/// </returns>
		public override string ToString() => handle.ToString();

		/// <summary>
		///     Determines whether the specified <see cref="HGLRC" />, is equal to this instance.
		/// </summary>
		/// <param name="other">The <see cref="HGLRC" /> to compare with this instance.</param>
		/// <returns>
		///     <c>true</c> if the specified <see cref="HGLRC" /> is equal to this instance; otherwise, <c>false</c>.
		/// </returns>
		public bool Equals(HGLRC other) => handle.Equals(other.handle);

		/// <summary>
		///     Determines whether the specified <see cref="System.Object" />, is equal to this instance.
		/// </summary>
		/// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
		/// <returns>
		///     <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (obj is HGLRC hglrc)
				return Equals(hglrc);
			return false;
		}

		/// <summary>
		///     Returns a hash code for this instance.
		/// </summary>
		/// <returns>
		///     A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
		/// </returns>
		public override int GetHashCode() => handle.GetHashCode();

		/// <summary>
		///     Implements the operator ==.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>
		///     The result of the operator.
		/// </returns>
		public static bool operator ==(HGLRC left, HGLRC right) => left.Equals(right);

		/// <summary>
		///     Implements the operator !=.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>
		///     The result of the operator.
		/// </returns>
		public static bool operator !=(HGLRC left, HGLRC right) => !left.Equals(right);
	}
}