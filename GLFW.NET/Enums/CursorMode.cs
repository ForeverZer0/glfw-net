namespace GLFW
{
    /// <summary>
    ///     Indicates the behavior of the mouse cursor.
    /// </summary>
    public enum CursorMode
    {
        /// <summary>
        ///     The cursor is visible and behaves normally.
        /// </summary>
        Normal = 0x00034001,

        /// <summary>
        ///     The cursor is invisible when it is over the client area of the window but does not restrict the cursor from
        ///     leaving.
        /// </summary>
        Hidden = 0x00034002,

        /// <summary>
        ///     Hides and grabs the cursor, providing virtual and unlimited cursor movement. This is useful for implementing for
        ///     example 3D camera controls.
        /// </summary>
        Disabled = 0x00034003
    }
}