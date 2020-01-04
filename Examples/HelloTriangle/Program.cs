using System;
using System.IO;
using GLFW;
using static OpenGL.Gl;

namespace HelloTriangle
{
    /// <summary>
    /// Basic GLFW example to create a window with an OpenGL 3.3 Core profile context and draw a triangle. 
    /// </summary>
    class Program
    {
        
        /// <summary>
        /// Obligatory name for your first OpenGL example program.
        /// </summary>
        private const string TITLE = "Hello Triangle!";

        static void Main(string[] args)
        {
            // Set context creation hints
            PrepareContext();
            // Create a window and shader program
            var window = CreateWindow(1024, 800);
            var program = CreateProgram();
            
            // Define a simple triangle
            CreateVertices(out var vao, out var vbo);
            rand = new Random();

            var location = glGetUniformLocation(program, "color");
            SetRandomColor(location);
            long n = 0;

            while (!Glfw.WindowShouldClose(window))
            {
                // Swap fore/back framebuffers, and poll for operating system events.
                Glfw.SwapBuffers(window);
                Glfw.PollEvents();
                
                // Clear the framebuffer to defined background color
                glClear(GL_COLOR_BUFFER_BIT);
                
                if (n++ % 60 == 0)
                    SetRandomColor(location);
                
                // Draw the triangle.
                glDrawArrays(GL_TRIANGLES, 0, 3);
            }

            Glfw.Terminate();
        }

        private static void SetRandomColor(int location)
        {
            var r = (float) rand.NextDouble();
            var g = (float) rand.NextDouble();
            var b = (float) rand.NextDouble();
            glUniform3f(location, r, g, b);
        }
        
        private static void PrepareContext()
        {
            // Set some common hints for the OpenGL profile creation
            Glfw.WindowHint(Hint.ClientApi, ClientApi.OpenGL);
            Glfw.WindowHint(Hint.ContextVersionMajor, 3);
            Glfw.WindowHint(Hint.ContextVersionMinor, 3);
            Glfw.WindowHint(Hint.OpenglProfile, Profile.Core);
            Glfw.WindowHint(Hint.Doublebuffer, true);
            Glfw.WindowHint(Hint.Decorated, true);
        }

        /// <summary>
        /// Creates and returns a handle to a GLFW window with a current OpenGL context.
        /// </summary>
        /// <param name="width">The width of the client area, in pixels.</param>
        /// <param name="height">The height of the client area, in pixels.</param>
        /// <returns>A handle to the created window.</returns>
        private static Window CreateWindow(int width, int height)
        {
            // Create window, make the OpenGL context current on the thread, and import graphics functions
            var window = Glfw.CreateWindow(width, height, TITLE, Monitor.None, Window.None);
            Glfw.MakeContextCurrent(window);
            Import(Glfw.GetProcAddress);
            
            // Center window
            var screen = Glfw.PrimaryMonitor.WorkArea;
            var x = (screen.Width - width) / 2;
            var y = (screen.Height - height) / 2;
            Glfw.SetWindowPosition(window, x, y);
            
            return window;
        }
        
        /// <summary>
        /// Creates an extremely basic shader program that is capable of displaying a triangle on screen.
        /// </summary>
        /// <returns>The created shader program. No error checking is performed for this basic example.</returns>
        private static uint CreateProgram()
        {
            var vertex = CreateShader(GL_VERTEX_SHADER, File.ReadAllText("./triangle.vert"));
            var fragment = CreateShader(GL_FRAGMENT_SHADER, File.ReadAllText("./triangle.frag"));
            
            var program = glCreateProgram();
            glAttachShader(program, vertex);
            glAttachShader(program, fragment);

            glLinkProgram(program);
            
            glDeleteShader(vertex);
            glDeleteShader(fragment);

            glUseProgram(program);
            return program;
        }

        /// <summary>
        /// Creates a shader of the specified type from the given source string.
        /// </summary>
        /// <param name="type">An OpenGL enum for the shader type.</param>
        /// <param name="source">The source code of the shader.</param>
        /// <returns>The created shader. No error checking is performed for this basic example.</returns>
        private static uint CreateShader(int type, string source)
        {
            var shader = glCreateShader(type);
            glShaderSource(shader, source);
            glCompileShader(shader);
            return shader;
        }

        /// <summary>
        /// Creates a VBO and VAO to store the vertices for a triangle.
        /// </summary>
        /// <param name="vao">The created vertex array object for the triangle.</param>
        /// <param name="vbo">The created vertex buffer object for the triangle.</param>
        private static unsafe void CreateVertices(out uint vao, out uint vbo)
        {

            var vertices = new[] {
                -0.5f, -0.5f, 0.0f,
                0.5f, -0.5f, 0.0f,
                0.0f,  0.5f, 0.0f
            };

            vao = glGenVertexArray();
            vbo = glGenBuffer();
            
            glBindVertexArray(vao);
            
            glBindBuffer(GL_ARRAY_BUFFER, vbo);
            fixed (float* v = &vertices[0])
            {
                glBufferData(GL_ARRAY_BUFFER, sizeof(float) * vertices.Length, v, GL_STATIC_DRAW);
            }
            
            glVertexAttribPointer(0, 3, GL_FLOAT, false, 3 * sizeof(float), NULL);
            glEnableVertexAttribArray(0);
        }

        private static Random rand;
    }
}