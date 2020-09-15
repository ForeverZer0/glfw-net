using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using JetBrains.Annotations;

namespace GLFW
{
	/// <summary>
	///     Implements the Vulkan specific functions of GLFW.
	///     <para>See http://www.glfw.org/docs/latest/vulkan_guide.html for detailed documentation.</para>
	/// </summary>
	[SuppressUnmanagedCodeSecurity]
    public static class Vulkan
    {
        #region Properties

        /// <summary>
        ///     Gets whether the Vulkan loader has been found. This check is performed by <see cref="Glfw.Init" />.
        /// </summary>
        /// <value>
        ///     <c>true</c> if Vulkan is supported; otherwise <c>false</c>.
        /// </value>
        public static bool IsSupported => VulkanSupported();

        #endregion

        #region External

        /// <summary>
        ///     This function creates a Vulkan surface for the specified window.
        /// </summary>
        /// <param name="vulkan">A pointer to the Vulkan instance.</param>
        /// <param name="window">The window handle.</param>
        /// <param name="allocator">A pointer to the allocator to use, or <see cref="IntPtr.Zero" /> to use default allocator.</param>
        /// <param name="surface">The handle to the created Vulkan surface.</param>
        /// <returns>VK_SUCCESS if successful, or a Vulkan error code if an error occurred.</returns>
        [DllImport(Glfw.LIBRARY, EntryPoint = "glfwCreateWindowSurface", CallingConvention = CallingConvention.Cdecl)]
        public static extern int
            CreateWindowSurface(IntPtr vulkan, IntPtr window, IntPtr allocator, out ulong surface);

        /// <summary>
        ///     This function returns whether the specified queue family of the specified physical device supports presentation to
        ///     the platform GLFW was built for.
        /// </summary>
        /// <param name="instance">The instance that the physical device belongs to.</param>
        /// <param name="device">The physical device that the queue family belongs to.</param>
        /// <param name="family">The index of the queue family to query.</param>
        /// <returns><c>true</c> if the queue family supports presentation, or <c>false</c> otherwise.</returns>
        [DllImport(Glfw.LIBRARY, EntryPoint = "glfwGetPhysicalDevicePresentationSupport",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern bool GetPhysicalDevicePresentationSupport(IntPtr instance, IntPtr device, uint family);

        [DllImport(Glfw.LIBRARY, EntryPoint = "glfwGetInstanceProcAddress",
            CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr GetInstanceProcAddress(IntPtr vulkan, byte[] procName);

        [DllImport(Glfw.LIBRARY, EntryPoint = "glfwGetRequiredInstanceExtensions",
            CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr GetRequiredInstanceExtensions(out uint count);

        [DllImport(Glfw.LIBRARY, EntryPoint = "glfwVulkanSupported", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool VulkanSupported();

        #endregion

        #region Methods

        /// <summary>
        ///     This function returns the address of the specified Vulkan core or extension function for the specified instance. If
        ///     instance is set to <see cref="IntPtr.Zero" /> it can return any function exported from the Vulkan loader.
        ///     <para>
        ///         If Vulkan is not available on the machine, this function returns <see cref="IntPtr.Zero" /> and generates an
        ///         error. Use <see cref="IsSupported" /> to check whether Vulkan is available.
        ///     </para>
        /// </summary>
        /// <param name="vulkan">The vulkan instance.</param>
        /// <param name="procName">Name of the function.</param>
        /// <returns>The address of the function, or <see cref="IntPtr.Zero" /> if an error occurred.</returns>
        public static IntPtr GetInstanceProcAddress(IntPtr vulkan, [NotNull] string procName)
        {
            return GetInstanceProcAddress(vulkan, Encoding.ASCII.GetBytes(procName));
        }

        /// <summary>
        ///     This function returns an array of names of Vulkan instance extensions required by GLFW for creating Vulkan surfaces
        ///     for GLFW windows. If successful, the list will always contains VK_KHR_surface, so if you don't require any
        ///     additional extensions you can pass this list directly to the VkInstanceCreateInfo struct.
        ///     <para>
        ///         If Vulkan is not available on the machine, this function returns generates an error, use
        ///         <see cref="IsSupported" /> to first check if supported.
        ///     </para>
        ///     <para>
        ///         If Vulkan is available but no set of extensions allowing window surface creation was found, this function
        ///         returns an empty array. You may still use Vulkan for off-screen rendering and compute work.
        ///     </para>
        /// </summary>
        /// <returns>An array of extension names.</returns>
        [NotNull]
        public static string[] GetRequiredInstanceExtensions()
        {
            var ptr = GetRequiredInstanceExtensions(out var count);
            var extensions = new string[count];
            if (count > 0 && ptr != IntPtr.Zero)
            {
                var offset = 0;
                for (var i = 0; i < count; i++, offset += IntPtr.Size)
                {
                    var p = Marshal.ReadIntPtr(ptr, offset);
                    extensions[i] = Marshal.PtrToStringAnsi(p);
                }
            }

            return extensions.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();
        }

        #endregion
    }
}