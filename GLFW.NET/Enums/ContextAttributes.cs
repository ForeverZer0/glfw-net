namespace GLFW
{
    /// <summary>
    ///     Used internally to consolidate strongly-typed values for getting/setting window attributes.
    /// </summary>
    internal enum ContextAttributes
    {
        ClientApi = 0x00022001,
        ContextCreationApi = 0x0002200B,
        ContextVersionMajor = 0x00022002,
        ContextVersionMinor = 0x00022003,
        ContextVersionRevision = 0x00022004,
        OpenglForwardCompat = 0x00022006,
        OpenglDebugContext = 0x00022007,
        OpenglProfile = 0x00022008,
        ContextRobustness = 0x00022005
    }
}