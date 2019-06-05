# History

## GLFW.NET Version 3.3.0.1 Changes

* Changed default library name from `glfw3` to `glfw` (See [Issue#8](https://github.com/ForeverZer0/glfw-net/issues/8))
* Merged [Pull Request#7](https://github.com/ForeverZer0/glfw-net/pull/7) to implement storing managed references to delegates used for native callbacks, as this caused errors with .NET Framework when the reference got lost.
* Merged [Pull Request#11](https://github.com/ForeverZer0/glfw-net/pull/11) to fix critical error when using static `Glfw.Monitors` property
* Default `NativeWindow` resolution is now `800x600` from `640x480` if not specified

## GLFW.NET Version 3.3 Changes

* Added support for GLFW 3.3 (Released April 15, 2019)
* Implemented new versioning system to keep with the supported native GLFW version
    * Major and minor parts will match the supported native library
    * Revision major and revision minor parts will indicate changes to the bindings

### Types/Classes/Structs
* Added `GamePadState` struct
* Added `WindowContentsScaleCallback` delegate
* Added `WindowMaximizedCallback` delegate
* Added `MaximizeEventArgs` class
* Added `ContentScaleEventArgs` class

### Enums/Constants
* Added `ErrorCode.None`
* Deprecated `ErrorCode.Unknown`
* Added `Hint.JoystickHatButtons`
* Added `Hint.CocoaChDirResources`
* Added `Hint.CocoaMenuBar`
* Added `Hint.CenterCursor`
* Added `Hint.TransparentFramebuffer`
* Added `Hint.FocusOnShow`
* Added `Hint.ScaleToMonitor`
* Added `Hint.CocoaRetinaFrameBuffer`
* Added `Hint.CocoaFrameName`
* Added `Hint.CocoaGraphicsSwitching`
* Added `Hint.X11InstanceName`
* Added `Hint.X11ClassName`
* Added `ContextApi.Mesa`
* Added `Hat` enum
    * `Centered`
    * `Up`
    * `Right`
    * `Down`
    * `Left`
    * `RightUp`
    * `RightDown`
    * `LeftUp`
    * `LeftDown`
* Added `ModiferKeys.CapsLock`
* Added `ModiferKeys.NumLock`
* Added `GamePadButtons` enum
    * `A`
    * `B`
    * `X`
    * `Y`
    * `LeftBumper`
    * `RightBumper`
    * `Back`
    * `Start`
    * `Guide`
    * `LeftThumb`
    * `RightThumb`
    * `DpadUp`
    * `DpadRight`
    * `DpadDown`
    * `DpadLeft`
    * `Cross`
    * `Circle`
    * `Square`
    * `Triangle`
* Added `GamePadAxis` enum
    * `LeftX`       
    * `LeftY`       
    * `RightX`      
    * `RightY`
    * `LeftTrigger`
    * `RightTrigger`
* Added `WindowAttribute.MouseHover`
* Added `InputMode.LockKeyMods`
* Added `InputMode.RawMouseMotion`

### Functions/Properties

#### Static Glfw Class
* Added `Glfw.InitHint`
* Added `Glfw.GetError`
* Added `Glfw.GetMonitorWorkArea`
* Added `Glfw.GetMonitorContentScale`
* Added `Glfw.GetMonitorUserPointer`
* Added `Glfw.SetMonitorUserPointer`
* Added `Glfw.GetWindowOpacity`
* Added `Glfw.SetWindowOpacity`
* Added `Glfw.WindowHintString`
* Added `Glfw.GetWindowContentScale`
* Added `Glfw.RequestWindowAttention`
* Added `Glfw.RawMouseMotionSupported`
* Added `Glfw.SetWindowMaximizeCallback`
* Added `Glfw.SetWindowContentScaleCallback`
* Added `Glfw.GetKeyScanCode`
* Added `Glfw.SetWindowAttribute`
* Added `Glfw.GetJoyStickHats`
* Added `Glfw.GetJoystickGuid`
* Added `Glfw.GetJoystickUserPointer`
* Added `Glfw.SetJoystickUserPointer`
* Added `Glfw.JoystickIsGamepad`
* Added `Glfw.UpdateGamepadMappings`
* Added `Glfw.GetGamepadName`
* Added `Glfw.wGetGamepadState`

#### Objects
* Added `Monitor.WorkArea`
* Added `Monitor.ContentScale`
* Added `Monitor.UserPointer`
* Added `GameWindow.Opacity`
* Added `GameWindow.ContentScale`
* Added `GameWindow.RequestAttention`
* Added `GameWindow.MaximizeChanged`
* Added `GameWindow.OnMaximize`
* Added `GameWindow.ContentScaleChanged`
* Added `GameWindow.OnContentScaleChanged

### Misc.
* Fixed some typos and grammatical errors in XML comments
* Added this version history`






