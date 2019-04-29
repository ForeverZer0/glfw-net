namespace GLFW
{
    /// <summary>
    ///     Strongly-typed description for possible client APIs to be used.
    /// </summary>
    public enum ClientApi
    {
	    /// <summary>
	    ///     No context
	    /// </summary>
	    None = 0x00000000,

        /// <summary>
        ///     OpenGL
        /// </summary>
        OpenGL = 0x00030001,

        /// <summary>
        ///     OpenGL ES
        /// </summary>
        OpenGLES = 0x00030002
    }
}