using System;
using System.Drawing;

namespace GLFW
{
    /// <summary>
    ///     Arguments supplied with size changing events.
    /// </summary>
    /// <seealso cref="EventArgs" />
    public class SizeChangeEventArgs : EventArgs
    {
        #region Properties

        /// <summary>
        ///     Gets the new size.
        /// </summary>
        /// <value>
        ///     The size.
        /// </value>
        public Size Size { get; }

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="SizeChangeEventArgs" /> class.
        /// </summary>
        /// <param name="width">The new width.</param>
        /// <param name="height">The new height.</param>
        public SizeChangeEventArgs(int width, int height) : this(new Size(width, height)) { }

        /// <summary>
        ///     Initializes a new instance of the <see cref="SizeChangeEventArgs" /> class.
        /// </summary>
        /// <param name="size">The new size.</param>
        public SizeChangeEventArgs(Size size) { Size = size; }

        #endregion
    }
}