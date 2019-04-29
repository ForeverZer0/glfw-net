using System;

namespace GLFW
{
    /// <summary>
    ///     Arguments supplied with file drag-drop events.
    /// </summary>
    /// <seealso cref="EventArgs" />
    public class FileDropEventArgs : EventArgs
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="FileDropEventArgs" /> class.
        /// </summary>
        /// <param name="filenames">The dropped filenames.</param>
        public FileDropEventArgs(string[] filenames) { Filenames = filenames; }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets the filenames of the dropped files.
        /// </summary>
        /// <value>
        ///     The filenames.
        /// </value>
        public string[] Filenames { get; }

        #endregion
    }
}