using System;

namespace GLFW
{
    /// <summary>
    ///     Arguments supplied with maximize events.
    /// </summary>
    public class MaximizeEventArgs : EventArgs
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="MaximizeEventArgs" /> class.
        /// </summary>
        /// <param name="maximized"><c>true</c> it maximized, otherwise <c>false</c>.</param>
        public MaximizeEventArgs(bool maximized) { IsMaximized = maximized; }

        /// <summary>
        ///     Gets value indicating if window was maximized, or being restored.
        /// </summary>
        public bool IsMaximized { get; }
    }
}