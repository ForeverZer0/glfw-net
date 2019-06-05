using System;

// ReSharper disable once CheckNamespace
namespace GLFW.Game
{
    /// <inheritdoc cref="NativeWindow"/>
    [Obsolete("Use NativeWindow, GameWindow will be removed in future release.")]
    public class GameWindow : NativeWindow
    {
        /// <inheritdoc cref="NativeWindow()"/>
        [Obsolete("Use NativeWindow, GameWindow will be removed in future release.")]
        public GameWindow()
        {
        }

        /// <inheritdoc cref="NativeWindow(int, int, string)"/>
        [Obsolete("Use NativeWindow, GameWindow will be removed in future release.")]
        public GameWindow(int width, int height, string title) : base(width, height, title)
        {
        }

        /// <inheritdoc cref="NativeWindow(int, int, string, Monitor, Window)"/>
        [Obsolete("Use NativeWindow, GameWindow will be removed in future release.")]
        public GameWindow(int width, int height, string title, Monitor monitor, Window share) : base(width, height,
            title, monitor, share)
        {
        }
    }
}