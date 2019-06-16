# GLFW.NET
Complete, cross-platform, managed wrapper around the GLFW library for creating native windows with an OpenGL context.

## Features
* Wraps 100% of the GLFW library (3.3), including Vulkan
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
The recommended way to use this library is to download the source and include directly within your application, as this offers the highest amount of control over dependency loading. It was build upon [.NET Standard 2.0](https://docs.microsoft.com/en-us/dotnet/standard/net-standard) to target the largest number of platforms and frameworks, and thus you will need to fine-tune the dependency loading to your specific needs (see below).

### .NET Core
In all platforms utilizing .NET Core, the `AssemblyLoadContext` can be used to resolve native dependencies at runtime, based on platform, architecture, etc.

### Microsoft Windows
Windows users need only grab the pre-built binaries from the the [GLFW](https://www.glfw.org/download.html). There are x86 and x64 versions available, and you will need the appropriate one for your target architecture. These need placed in a place where they can be loaded by your application (i.e. side-by-side) or edit the `Glfw.LIBRARY` constant.

### Unix
Unix users need only have GLFW built and installed on the system globally, and need not distribute any binaries along with the application.

## IMPORTANT!
The Windows and Unix library name differ. On Windows, the library name is `glfw3` (always exclude file extensions), and on Unix systems, it is only `glfw` without the major version suffix. By default, the `Glfw.LIBRARY` constant is hard-coded in the Unix format. On Windows, you will need to account for name change while resolving dependencies, or rename the binary. 

## Native Window Creation
Once you have your dependencies taken care of, creating a window is simple. 
```csharp
using (var window = new NativeWindow(800, 600, "MyWindowTitle"))
{
    // Main application loop
    while (!window.IsClosing)
    {
        // OpenGL rendering
        // Implement any timing for flow control, etc (see Glfw.GetTime())
        
        // Swap the front/back buffers
        window.SwapBuffers();
        
        // Poll native operating system events (must be called or OS will think application is hanging)
        Glfw.PollEvents();
    }
}
```

## Source Code
Source code can be found at GitHub: https://github.com/ForeverZer0/glfw-net