using System;

namespace GLFW.Game
{
    [Obsolete("Use NativeWindow, GameWindow will be removed in future release.")]
    public class GameWindow : NativeWindow
    {
        [Obsolete("Use NativeWindow, GameWindow will be removed in future release.")]
        public GameWindow()
        {
        }

        [Obsolete("Use NativeWindow, GameWindow will be removed in future release.")]
        public GameWindow(int width, int height, string title) : base(width, height, title)
        {
            
        }

        [Obsolete("Use NativeWindow, GameWindow will be removed in future release.")]
        public GameWindow(int width, int height, string title, Monitor monitor, Window share) : base(width, height,
            title, monitor, share)
        {
           
        }
    }
}