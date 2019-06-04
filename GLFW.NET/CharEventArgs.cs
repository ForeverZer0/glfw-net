using System;

namespace GLFW
{
    /// <summary>
    ///     Arguments supplied with char input events.
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public class CharEventArgs : EventArgs
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="CharEventArgs" /> class.
        /// </summary>
        /// <param name="codePoint">A UTF-32 code point.</param>
        /// <param name="mods">The modifier keys present.</param>
        public CharEventArgs(uint codePoint, ModifierKeys mods)
        {
            CodePoint = codePoint;
            ModifierKeys = mods;
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets the Unicode character for the code point.
        /// </summary>
        /// <value>
        ///     The character.
        /// </value>
        public string Char => char.ConvertFromUtf32(unchecked((int) CodePoint));

        /// <summary>
        ///     Gets the platform independent code point.
        ///     <para>This value can be treated as a UTF-32 code point.</para>
        /// </summary>
        /// <value>
        ///     The code point.
        /// </value>
        public uint CodePoint { get; }

        /// <summary>
        ///     Gets the modifier keys.
        /// </summary>
        /// <value>
        ///     The modifier keys.
        /// </value>
        public ModifierKeys ModifierKeys { get; }

        #endregion
    }
}