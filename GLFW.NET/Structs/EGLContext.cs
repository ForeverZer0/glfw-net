using System;
using System.Runtime.InteropServices;

namespace GLFW
{
    /// <summary>
    ///     Wrapper around a EGL context pointer.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct EGLContext : IEquatable<EGLContext>
    {
        /// <summary>
        ///     Describes a default/null instance.
        /// </summary>
        public static readonly EGLContext None;

        /// <summary>
        ///     Internal pointer.
        /// </summary>
        private readonly IntPtr handle;

        /// <summary>
        ///     Performs an implicit conversion from <see cref="EGLContext" /> to <see cref="IntPtr" />.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns>
        ///     The result of the conversion.
        /// </returns>
        public static implicit operator IntPtr(EGLContext context) { return context.handle; }

        /// <summary>
        ///     Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <returns>
        ///     A <see cref="string" /> that represents this instance.
        /// </returns>
        public override string ToString() { return handle.ToString(); }

        /// <summary>
        ///     Determines whether the specified <see cref="EGLContext" />, is equal to this instance.
        /// </summary>
        /// <param name="other">The <see cref="EGLContext" /> to compare with this instance.</param>
        /// <returns>
        ///     <c>true</c> if the specified <see cref="EGLContext" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public bool Equals(EGLContext other) { return handle.Equals(other.handle); }

        /// <summary>
        ///     Determines whether the specified <see cref="object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="object" /> to compare with this instance.</param>
        /// <returns>
        ///     <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj is EGLContext context)
                return Equals(context);
            return false;
        }

        /// <summary>
        ///     Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        ///     A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode() { return handle.GetHashCode(); }

        /// <summary>
        ///     Implements the operator ==.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        ///     The result of the operator.
        /// </returns>
        public static bool operator ==(EGLContext left, EGLContext right) { return left.Equals(right); }

        /// <summary>
        ///     Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        ///     The result of the operator.
        /// </returns>
        public static bool operator !=(EGLContext left, EGLContext right) { return !left.Equals(right); }
    }
}