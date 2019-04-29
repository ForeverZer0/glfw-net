namespace GLFW
{
    /// <summary>
    ///     Describes the state of a button/key.
    /// </summary>
    public enum InputState : byte
    {
        /// <summary>
        ///     The key or mouse button was released.
        /// </summary>
        Release = 0,

        /// <summary>
        ///     The key or mouse button was pressed.
        /// </summary>
        Press = 1,

        /// <summary>
        ///     The key was held down until it repeated.
        /// </summary>
        Repeat = 2
    }
}