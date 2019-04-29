using System;
using System.Runtime.InteropServices;

namespace GLFW
{
	/// <summary>
	///     Wrapper around a EGL surface pointer.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct EGLSurface : IEquatable<EGLSurface>
    {
	    /// <summary>
	    ///     Describes a default/null instance.
	    /// </summary>
	    public static readonly EGLSurface None;

	    /// <summary>
	    ///     Internal pointer.
	    /// </summary>
	    private readonly IntPtr handle;

	    /// <summary>
	    ///     Performs an implicit conversion from <see cref="EGLSurface" /> to <see cref="IntPtr" />.
	    /// </summary>
	    /// <param name="surface">The surface.</param>
	    /// <returns>
	    ///     The result of the conversion.
	    /// </returns>
	    public static implicit operator IntPtr(EGLSurface surface) { return surface.handle; }

	    /// <summary>
	    ///     Returns a <see cref="System.String" /> that represents this instance.
	    /// </summary>
	    /// <returns>
	    ///     A <see cref="System.String" /> that represents this instance.
	    /// </returns>
	    public override string ToString() { return handle.ToString(); }

	    /// <summary>
	    ///     Determines whether the specified <see cref="EGLSurface" />, is equal to this instance.
	    /// </summary>
	    /// <param name="other">The <see cref="EGLSurface" /> to compare with this instance.</param>
	    /// <returns>
	    ///     <c>true</c> if the specified <see cref="EGLSurface" /> is equal to this instance; otherwise, <c>false</c>.
	    /// </returns>
	    public bool Equals(EGLSurface other) { return handle.Equals(other.handle); }

	    /// <summary>
	    ///     Determines whether the specified <see cref="System.Object" />, is equal to this instance.
	    /// </summary>
	    /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
	    /// <returns>
	    ///     <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
	    /// </returns>
	    public override bool Equals(object obj)
        {
            if (obj is EGLSurface surface)
                return Equals(surface);
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
	    public static bool operator ==(EGLSurface left, EGLSurface right) { return left.Equals(right); }

	    /// <summary>
	    ///     Implements the operator !=.
	    /// </summary>
	    /// <param name="left">The left.</param>
	    /// <param name="right">The right.</param>
	    /// <returns>
	    ///     The result of the operator.
	    /// </returns>
	    public static bool operator !=(EGLSurface left, EGLSurface right) { return !left.Equals(right); }
    }
}