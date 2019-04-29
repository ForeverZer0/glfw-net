using System;
using System.Runtime.InteropServices;

namespace GLFW
{
    /// <summary>
    ///     Wrapper around a handle for a window cursor object.
    /// </summary>
    /// <seealso cref="Cursor" />
    [StructLayout(LayoutKind.Sequential)]
    public struct Cursor : IEquatable<Cursor>
    {
        /// <summary>
        ///     Represents a <c>null</c> value for a <see cref="Cursor" /> object.
        /// </summary>
        public static readonly Cursor None;

        /// <summary>
        ///     Internal pointer.
        /// </summary>
        private readonly IntPtr cursor;

        /// <summary>
        ///     Determines whether the specified <see cref="Cursor" />, is equal to this instance.
        /// </summary>
        /// <param name="other">The <see cref="Cursor" /> to compare with this instance.</param>
        /// <returns>
        ///     <c>true</c> if the specified <see cref="Cursor" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public bool Equals(Cursor other) { return cursor.Equals(other.cursor); }

        /// <summary>
        ///     Determines whether the specified <see cref="object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="object" /> to compare with this instance.</param>
        /// <returns>
        ///     <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj is Cursor cur)
                return Equals(cur);
            return false;
        }

        /// <summary>
        ///     Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        ///     A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode() { return cursor.GetHashCode(); }

        /// <summary>
        ///     Implements the operator ==.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        ///     The result of the operator.
        /// </returns>
        public static bool operator ==(Cursor left, Cursor right) { return left.Equals(right); }

        /// <summary>
        ///     Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        ///     The result of the operator.
        /// </returns>
        public static bool operator !=(Cursor left, Cursor right) { return !left.Equals(right); }
    }
}