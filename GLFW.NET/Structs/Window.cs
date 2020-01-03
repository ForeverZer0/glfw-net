using System;
using System.Runtime.InteropServices;

namespace GLFW
{
    /// <summary>
    ///     Wrapper around a GLFW window pointer.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Window : IEquatable<Window>
    {
        /// <summary>
        ///     Describes a default/null instance.
        /// </summary>
        public static readonly Window None;

        /// <summary>
        ///     Internal pointer.
        /// </summary>
        private readonly IntPtr handle;

        /// <summary>
        ///     Performs an implicit conversion from <see cref="Window" /> to <see cref="IntPtr" />.
        /// </summary>
        /// <param name="window">The window.</param>
        /// <returns>
        ///     The result of the conversion.
        /// </returns>
        public static implicit operator IntPtr(Window window) { return window.handle; }
        
        /// <summary>
        ///     Performs an explicit conversion from <see cref="IntPtr"/> to <see cref="Window"/>.
        /// </summary>
        /// <param name="handle">A pointer representing the window handle.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Window(IntPtr handle) => new Window(handle);

        /// <summary>
        /// Creates a new instance of the <see cref="Window"/> struct.
        /// </summary>
        /// <param name="handle">A pointer representing the window handle.</param>
        public Window(IntPtr handle)
        {
            this.handle = handle;
        }

        /// <summary>
        ///     Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        ///     A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString() { return handle.ToString(); }

        /// <summary>
        ///     Determines whether the specified <see cref="Window" />, is equal to this instance.
        /// </summary>
        /// <param name="other">The <see cref="Window" /> to compare with this instance.</param>
        /// <returns>
        ///     <c>true</c> if the specified <see cref="Window" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public bool Equals(Window other) { return handle.Equals(other.handle); }

        /// <summary>
        ///     Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///     <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj is Window window)
                return Equals(window);
            return false;
        }

        /// <summary>
        ///     Gets or sets the opacity of the window in the range of <c>0.0</c> and <c>1.0</c> inclusive.
        /// </summary>
        public float Opacity
        {
            get => Glfw.GetWindowOpacity(handle);
            set => Glfw.SetWindowOpacity(handle, Math.Min(1.0f, Math.Max(0.0f, value)));
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
        public static bool operator ==(Window left, Window right) { return left.Equals(right); }

        /// <summary>
        ///     Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        ///     The result of the operator.
        /// </returns>
        public static bool operator !=(Window left, Window right) { return !left.Equals(right); }
    }
}