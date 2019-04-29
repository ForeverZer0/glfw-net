using System;

namespace GLFW
{
    /// <summary>
    ///     Describes joystick hat states.
    /// </summary>
    [Flags]
    public enum Hat
    {
        /// <summary>
        ///     Centered
        /// </summary>
        Centered = 0x00,

        /// <summary>
        ///     Up
        /// </summary>
        Up = 0x01,

        /// <summary>
        ///     Right
        /// </summary>
        Right = 0x02,

        /// <summary>
        ///     Down
        /// </summary>
        Down = 0x04,

        /// <summary>
        ///     Left
        /// </summary>
        Left = 0x08,

        /// <summary>
        ///     Right and up
        /// </summary>
        RightUp = Right | Up,

        /// <summary>
        ///     Right and down
        /// </summary>
        RightDown = Right | Down,

        /// <summary>
        ///     Left and up
        /// </summary>
        LeftUp = Left | Up,

        /// <summary>
        ///     Left and down
        /// </summary>
        LeftDown = Left | Down
    }
}