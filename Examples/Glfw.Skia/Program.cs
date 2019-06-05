namespace Glfw.Skia
{
    using System;
    using System.Drawing;
    using System.Runtime.InteropServices;
    using GLFW;
    using SkiaSharp;

    class Program
    {
        private static NativeWindow window;
        private static SKCanvas canvas;

        private static Keys? lastKeyPressed;
        private static Point? lastMousePosition;

        //----------------------------------
        //NOTE: On Windows you must copy SharedLib manually (https://github.com/ForeverZer0/glfw-net#microsoft-windows)
        //----------------------------------
        
        static void Main(string[] args)
        {
            using (Program.window = new NativeWindow(800, 600, "Skia Example"))
            {
                Program.SubscribeToWindowEvents();
                
                using (var context = Program.GenerateSkiaContext(Program.window))
                {
                    using (var skiaSurface = Program.GenerateSkiaSurface(context, Program.window.ClientSize))
                    {
                        Program.canvas = skiaSurface.Canvas;
                        
                        while (!Program.window.IsClosing)
                        {
                            Program.Render();
                            Glfw.WaitEvents();
                        }
                    }
                }
            }
        }

        private static void SubscribeToWindowEvents()
        {
            Program.window.SizeChanged += Program.OnWindowsSizeChanged;
            Program.window.Refreshed += Program.OnWindowRefreshed;
            Program.window.KeyPress += Program.OnWindowKeyPress;
            Program.window.MouseMoved += Program.OnWindowMouseMoved;
        }

        private static GRContext GenerateSkiaContext(NativeWindow nativeWindow)
        {
            var nativeContext = Program.GetNativeContext(nativeWindow);
            var glInterface = GRGlInterface.AssembleGlInterface(nativeContext, (contextHandle, name) => Glfw.GetProcAddress(name));
            return GRContext.Create(GRBackend.OpenGL, glInterface);
        }

        private static object GetNativeContext(NativeWindow nativeWindow)
        {
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return Native.GetWglContext(nativeWindow);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                // XServer
                //return Native.GetGlxContext(nativeWindow);
                // Wayland
                //return Native.GetEglContext(nativeWindow);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                //return Native.GetNSGLContext(nativeWindow);
            }
            
            throw new PlatformNotSupportedException();
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
        
        private static void Render()
        {
            Program.canvas.Clear(SKColor.Parse("#F0F0F0"));
            var headerPaint = new SKPaint {Color = SKColor.Parse("#333333"), TextSize = 50, IsAntialias = true};
            Program.canvas.DrawText("Hello from GLFW.NET + SkiaSharp!", 10, 60, headerPaint);
            
            var inputInfoPaint = new SKPaint {Color = SKColor.Parse("#F34336"), TextSize = 18, IsAntialias = true};
            Program.canvas.DrawText($"Last key pressed: {Program.lastKeyPressed}", 10, 90, inputInfoPaint);
            Program.canvas.DrawText($"Last mouse position: {Program.lastMousePosition}", 10, 120, inputInfoPaint);
            
            var exitInfoPaint = new SKPaint {Color = SKColor.Parse("#3F51B5"), TextSize = 18, IsAntialias = true};
            Program.canvas.DrawText("Press Enter to Exit.", 10, 160, exitInfoPaint);
            
            Program.canvas.Flush();
            Program.window.SwapBuffers();
        }

        #region Window Events Handlers

        private static void OnWindowsSizeChanged(object sender, SizeChangeEventArgs e)
        {
            Program.Render();
        }
        
        private static void OnWindowKeyPress(object sender, KeyEventArgs e)
        {
            Program.lastKeyPressed = e.Key;
            if (e.Key == Keys.Enter || e.Key == Keys.NumpadEnter)
            {
                Program.window.Close();
            }
        }

        private static void OnWindowMouseMoved(object sender, MouseMoveEventArgs e)
        {
            Program.lastMousePosition = e.Position;
        }
        
        private static void OnWindowRefreshed(object sender, EventArgs e)
        {
            Program.Render();
        }

        #endregion
    }
}