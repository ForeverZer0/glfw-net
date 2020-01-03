using System;
using System.Runtime.InteropServices;
using GLFW;

namespace BasicExample
{
    class Program
    {
        private const string TITLE = "Simple Window";
        private const int WIDTH = 1024;
        private const int HEIGHT = 800;
        
        private const int GL_COLOR_BUFFER_BIT = 0x00004000;


        private delegate void glClearColorHandler(float r, float g, float b, float a);
        private delegate void glClearHandler(int mask);

        private static glClearColorHandler glClearColor;
        private static glClearHandler glClear;

        private static Random rand;

        static void Main(string[] args)
        {
            // Set some common hints for the OpenGL profile creation
            Glfw.WindowHint(Hint.ClientApi, ClientApi.OpenGL);
            Glfw.WindowHint(Hint.ContextVersionMajor, 3);
            Glfw.WindowHint(Hint.ContextVersionMinor, 3);
            Glfw.WindowHint(Hint.OpenglProfile, Profile.Core);
            Glfw.WindowHint(Hint.Doublebuffer, true);
            Glfw.WindowHint(Hint.Decorated, true);
            
            rand = new Random();

            #if OBJECTORIENTED
            // // The object oriented approach
            // using (var window = new NativeWindow(WIDTH, HEIGHT, title))
            // {
            //     window.CenterOnScreen();
            //     window.KeyPress += WindowOnKeyPress;
            //     while (!window.IsClosing)
            //     {
            //         Glfw.PollEvents();
            //         window.SwapBuffers();
            //     }
            // }

            #else

            // Create window
            var window = Glfw.CreateWindow(WIDTH, HEIGHT, TITLE, Monitor.None, Window.None);
            Glfw.MakeContextCurrent(window);
            
            // Effectively enables VSYNC by setting to 1.
            Glfw.SwapInterval(1); 
            
            // Find center position based on window and monitor sizes
            var screenSize = Glfw.PrimaryMonitor.WorkArea;
            var x = (screenSize.Width - WIDTH) / 2;
            var y = (screenSize.Height - HEIGHT) / 2;
            Glfw.SetWindowPosition(window, x, y);
            
            // Set a key callback
            Glfw.SetKeyCallback(window, KeyCallback);
            

            glClearColor = Marshal.GetDelegateForFunctionPointer<glClearColorHandler>(Glfw.GetProcAddress("glClearColor"));
            glClear = Marshal.GetDelegateForFunctionPointer<glClearHandler>(Glfw.GetProcAddress("glClear"));
            
            
            var tick = 0L;
            ChangeRandomColor();

            while (!Glfw.WindowShouldClose(window))
            {
                // Poll for OS events and swap front/back buffers
                Glfw.PollEvents();
                Glfw.SwapBuffers(window);

                // Change background color to something random every 60 draws
                if (tick++ % 60 == 0)
                    ChangeRandomColor();
                
                // Clear the buffer to the set color
                glClear(GL_COLOR_BUFFER_BIT);
            }
            #endif
        }

        private static void ChangeRandomColor()
        {
            var r = (float) rand.NextDouble();
            var g = (float) rand.NextDouble();
            var b = (float) rand.NextDouble();
            glClearColor(r, g, b, 1.0f);
        }

#if OBJECTORIENTED

        private static void WindowOnKeyPress(object? sender, KeyEventArgs e)
        {
            var window = (NativeWindow) sender;
            switch (e.Key)
            {
                case Keys.Escape:
                    window.Close();
                    break;
                // ...and so on....
            }
        }
#else
      
        private static void KeyCallback(Window window, Keys key, int scancode, InputState state, ModifierKeys mods)
        {
            switch (key)
            {
                case Keys.Escape:
                    Glfw.SetWindowShouldClose(window, true);
                    break;
            }
        }
#endif
    }
}