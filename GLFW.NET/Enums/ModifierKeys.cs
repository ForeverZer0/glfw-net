using System;

namespace GLFW
{
    /// <summary>
    ///     Describes bitwise combination of modifier keys.
    /// </summary>
    [Flags]
    public enum ModifierKeys
    {
        /// <summary>
        ///     Either of the Shift keys.
        /// </summary>
        Shift = 0x0001,

        /// <summary>
        ///     Either of the Ctrl keys.
        /// </summary>
        Control = 0x0002,

        /// <summary>
        ///     Either of the Alt keys
        /// </summary>
        Alt = 0x0004,

        /// <summary>
        ///     The super key ("Windows" key on Windows)
        /// </summary>
        Super = 0x0008,

        /// <summary>
        ///     The caps-lock is enabled.
        /// </summary>
        CapsLock = 0x0010,

        /// <summary>
        ///     The num-lock is enabled.
        /// </summary>
        NumLock = 0x0020
    }
}