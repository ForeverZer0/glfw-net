namespace GLFW
{
    /// <summary>
    ///     Describes the API used for creating the OpenGL context.
    /// </summary>
    public enum ContextApi
    {
        /// <summary>
        ///     The native platform default.
        /// </summary>
        Native = 0x00036001,

        /// <summary>
        ///     EGL
        /// </summary>
        Egl = 0x00036002,

        /// <summary>
        ///     OS Mesa
        /// </summary>
        Mesa = 0x00036003
    }
}