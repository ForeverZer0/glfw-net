# GLFW.NET
Complete, cross-platform, managed wrapper around the GLFW library for creating native windows with an OpenGL context.

## Features
* Wraps 100% of the latest GLFW library (3.2.1), including Vulkan
* Cross-platform
* Built upon the .NET Standard 2.0, for full compatibility with .NET Framework, .NET Core, and Mono
* Detailed XML documentation for full IntelliSense in Visual Studio, etc. 
* Included "GameWindow" class, to simplify window management by emulating a WinForm with similar properties, events, etc.

## Dependencies
* A .NET Standard 2.0 compatible framework such as: 
    * .NET Framework 4.6.1
    * .NET Core 2.0
    * Mono 5.4
* The GLFW library, which can be found here: http://www.glfw.org/download.html 
    * Windows 32 and 64 bit binaries available
    
## Getting Started
Creating a window is simple. 
```csharp
using (var window = new GameWindow(640, 480, "MyWindowTitle"))
{
    while (!window.IsClosing)
    {
        // OpenGL rendering

        window.SwapBuffers();
        Glfw.PollEvents();
    }
}
```

## Source Code
Source code can be found at GitHub: https://github.com/ForeverZer0/glfw-net