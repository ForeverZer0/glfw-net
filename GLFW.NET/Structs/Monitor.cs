#region MIT License

// Monitor.cs is distributed under the MIT License (MIT)
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
// Monitor.cs created on 06/08/2018

#endregion

using System;
using System.Runtime.InteropServices;

namespace GLFW
{
	/// <summary>
	///     Wrapper around a pointer to monitor.
	/// </summary>
	/// <seealso cref="Monitor" />
	[StructLayout(LayoutKind.Sequential)]
	public struct Monitor : IEquatable<Monitor>
	{
		/// <summary>
		///     Represents a <c>null</c> value for a <see cref="Monitor" /> object.
		/// </summary>
		public static readonly Monitor None;

		/// <summary>
		///     Internal pointer.
		/// </summary>
		private readonly IntPtr handle;

		/// <summary>
		///     Determines whether the specified <see cref="Monitor" />, is equal to this instance.
		/// </summary>
		/// <param name="other">The <see cref="Monitor" /> to compare with this instance.</param>
		/// <returns>
		///		<c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
		/// </returns>
		public bool Equals(Monitor other) => handle.Equals(other.handle);

		/// <summary>
		///     Determines whether the specified <see cref="object" />, is equal to this instance.
		/// </summary>
		/// <param name="obj">The <see cref="object" /> to compare with this instance.</param>
		/// <returns>
		///     <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (obj is Monitor monitor)
				return Equals(monitor);
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
		public static bool operator ==(Monitor left, Monitor right) => left.Equals(right);

		/// <summary>
		///     Implements the operator !=.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>
		///     The result of the operator.
		/// </returns>
		public static bool operator !=(Monitor left, Monitor right) => !left.Equals(right);

		/// <summary>
		///     Returns a <see cref="string" /> that represents this instance.
		/// </summary>
		/// <returns>
		///     A <see cref="string" /> that represents this instance.
		/// </returns>
		public override string ToString() => handle.ToString();
	}
}