using System;

namespace GLFW
{
    /// <summary>
    ///     Specifies a minimum version of the GLFW that the target is valid on.
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public class GlfwVersionAttribute : Attribute
    {
        /// <summary>
        ///     The minimum major version.
        /// </summary>
        public readonly int Major;
        
        /// <summary>
        ///     The minimum minor version.
        /// </summary>
        public readonly int Minor;

        /// <summary>
        ///     
        /// </summary>
        /// <param name="major">The minimum major version.</param>
        /// <param name="minor">The minimum minor version.</param>
        public GlfwVersionAttribute(int major, int minor)
        {
            Major = major;
            Minor = minor;
        }
    }
}