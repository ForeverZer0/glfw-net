namespace GLFW
{
    /// <summary>
    ///     Describes the robustness strategy to be used by the context.
    /// </summary>
    public enum Robustness
    {
        /// <summary>
        ///     Disabled/no strategy (default)
        /// </summary>
        None = 0,

        /// <summary>
        ///     No notification.
        /// </summary>
        NoResetNotification = 0x00031001,

        /// <summary>
        ///     The context is lost on reset, use glGetGraphicsResetStatus for more information.
        /// </summary>
        LoseContextOnReset = 0x00031002
    }
}