using System;
using System.Drawing;

namespace GLFW
{
    /// <summary>
    ///     Arguments supplied with mouse movement events.
    /// </summary>
    /// <seealso cref="EventArgs" />
    public class MouseMoveEventArgs : EventArgs
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="MouseMoveEventArgs" /> class.
        /// </summary>
        /// <param name="x">
        ///     The cursor x-coordinate, relative to the left edge of the client area, or the amount of movement on
        ///     x-axis if this is scroll event.
        /// </param>
        /// <param name="y">
        ///     The cursor y-coordinate, relative to the left edge of the client area, or the amount of movement on
        ///     y-axis if this is scroll event.
        /// </param>
        public MouseMoveEventArgs(double x, double y)
        {
            X = x;
            Y = y;
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets the position of the mouse, relative to the screen.
        /// </summary>
        /// <value>
        ///     The position.
        /// </value>
        public Point Position => new Point(Convert.ToInt32(X), Convert.ToInt32(Y));

        /// <summary>
        ///     Gets the cursor x-coordinate, relative to the left edge of the client area, or the amount of movement on
        ///     x-axis if this is scroll event.
        /// </summary>
        /// <value>
        ///     The location on the x-axis.
        /// </value>
        public double X { get; }

        /// <summary>
        ///     Gets the cursor y-coordinate, relative to the left edge of the client area, or the amount of movement on
        ///     y-axis if this is scroll event.
        /// </summary>
        /// <value>
        ///     The location on the y-axis.
        /// </value>
        public double Y { get; }

        #endregion
    }
}