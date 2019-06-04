namespace Glfw.Skia
{
    using System;
    using System.Drawing;
    using GLFW;
    using SkiaSharp;

    class Program
    {
        private static SKCanvas canvas;

        private static Keys? lastKeyPressed;
        private static Point? lastMousePosition;

        //----------------------------------
        //NOTE: On Windows you must copy SharedLib manually (https://github.com/ForeverZer0/glfw-net#microsoft-windows)
        //----------------------------------
        
        static void Main(string[] args)
        {
            // Create GLFW Window
            using (var window = new NativeWindow(800, 600, "Skia Example"))
            {
                // Subscribe to window events
                window.SizeChanged += Program.OnWindowsSizeChanged;
                window.Refreshed += Program.OnWindowRefreshed;
                window.KeyPress += Program.OnWindowKeyPress;
                window.MouseMoved += Program.OnWindowMouseMoved;

                // Generate Skia Context
                var context = Program.GenerateSkiaContext(window);
                

                // Generate Skia surface
                var skiaSurface = Program.GenerateSkiaSurface(context, window.ClientSize);
                
                // Assign surface canvas to private member
                Program.canvas = skiaSurface.Canvas;
                
                //Loop waiting for window close
                while (!window.IsClosing)
                {
                    Program.Render(window);
                    Glfw.WaitEvents();
                }
            }
        }

        private static GRContext GenerateSkiaContext(NativeWindow nativeWindow)
        {
            var glInterface = GRGlInterface.AssembleGlInterface(Native.GetWglContext(nativeWindow), (contextHandle, name) => Glfw.GetProcAddress(name));
            return GRContext.Create(GRBackend.OpenGL, glInterface);
        }
        
        private static SKSurface GenerateSkiaSurface(GRContext skiaContext, Size surfaceSize)
        {
            var frameBufferInfo = new GRGlFramebufferInfo((uint)new UIntPtr(0), GRPixelConfig.Rgba8888.ToGlSizedFormat());
            var backendRenderTarget = new GRBackendRenderTarget(surfaceSize.Width,
                                                                surfaceSize.Height,
                                                                0, 
                                                                8,
                                                                frameBufferInfo);
            return SKSurface.Create(skiaContext, backendRenderTarget, GRSurfaceOrigin.BottomLeft, SKImageInfo.PlatformColorType);
        }
        
        private static void Render(NativeWindow window)
        {
            if (Program.canvas == null)
            {
                return;
            }

            Program.canvas.Clear(SKColor.Parse("#F0F0F0"));
            var headerPaint = new SKPaint {Color = SKColor.Parse("#333333"), TextSize = 50, IsAntialias = true};
            Program.canvas.DrawText("Hello from GLFW.NET + SkiaSharp!", 10, 60, headerPaint);
            
            var inputInfoPaint = new SKPaint {Color = SKColor.Parse("#F34336"), TextSize = 18, IsAntialias = true};
            Program.canvas.DrawText($"Last key pressed: {Program.lastKeyPressed}", 10, 90, inputInfoPaint);
            Program.canvas.DrawText($"Last mouse position: {Program.lastMousePosition}", 10, 120, inputInfoPaint);
            
            var exitInfoPaint = new SKPaint {Color = SKColor.Parse("#3F51B5"), TextSize = 18, IsAntialias = true};
            Program.canvas.DrawText("Press Enter to Exit.", 10, 160, exitInfoPaint);
            
            Program.canvas.Flush();
            window.SwapBuffers();
        }

        #region Window Events Handlers

        private static void OnWindowsSizeChanged(object sender, SizeChangeEventArgs e)
        {
            Program.Render((NativeWindow)sender);
        }
        
        private static void OnWindowKeyPress(object sender, KeyEventArgs e)
        {
            Program.lastKeyPressed = e.Key;
            if (e.Key == Keys.Enter || e.Key == Keys.NumpadEnter)
            {
                ((NativeWindow)sender).Close();
            }
        }

        private static void OnWindowMouseMoved(object sender, MouseMoveEventArgs e)
        {
            Program.lastMousePosition = e.Position;
        }
        
        private static void OnWindowRefreshed(object sender, EventArgs e)
        {
            Program.Render((NativeWindow)sender);
        }

        #endregion
    }
}