using System;

namespace GLFW
{
    /// <summary>
    ///     Arguments supplied with mouse button events.
    /// </summary>
    /// <seealso cref="EventArgs" />
    public class MouseButtonEventArgs : EventArgs
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="MouseButtonEventArgs" /> class.
        /// </summary>
        /// <param name="button">The mouse button.</param>
        /// <param name="state">The state of the <paramref name="button" />.</param>
        /// <param name="modifiers">The modifier keys.</param>
        public MouseButtonEventArgs(MouseButton button, InputState state, ModifierKeys modifiers)
        {
            Button = button;
            Action = state;
            Modifiers = modifiers;
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets the state of the mouse button when the event was raised.
        /// </summary>
        /// <value>
        ///     The action.
        /// </value>
        public InputState Action { get; }

        /// <summary>
        ///     Gets the mouse button that raised the event.
        /// </summary>
        /// <value>
        ///     The button.
        /// </value>
        public MouseButton Button { get; }

        /// <summary>
        ///     Gets the key modifiers present when mouse button was pressed.
        /// </summary>
        /// <value>
        ///     The modifiers.
        /// </value>
        public ModifierKeys Modifiers { get; }

        #endregion
    }
}