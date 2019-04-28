# History

## GLFW.NET Version 3.3 Changes

* Added supoort for GLFW 3.3 (Released April 15, 2019)
* Implemented new versioning system to keep with the supported native GLFW version
    * Major and minor parts will match the supported native library
    * Revision major and revision minor parts will indicate changes to the bindings
* Added `GlfwVersionAttribute` to mark features specific to a GLFW version, starting with 3.3. Any feature without an attribute is assumed to be 3.2 compatible, as that was the original release version for the bindings.

### Types/Classes/Structs
* Added `GamePadState` struct
* Added `WindowContentsScaleCallback` delegate

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

### Misc.
* Fixed some typos and grammatical errors in XML comments

### Functions

* Added `Glfw.InitHint`
* Added `Glfw.GetError`









glfwGetMonitorWorkarea
glfwGetMonitorContentScale
glfwGetMonitorUserPointer
glfwSetMonitorUserPointer
glfwWindowHintString
glfwGetWindowContentScale
glfwGetWindowOpacity
glfwSetWindowOpacity
glfwRequestWindowAttention
glfwSetWindowAttrib
glfwSetWindowMaximizeCallback
glfwSetWindowContentScaleCallback
glfwRawMouseMotionSupported
glfwGetKeyScancode
glfwGetJoystickHats
glfwGetJoystickGUID
glfwGetJoystickUserPointer
glfwSetJoystickUserPointer
glfwJoystickIsGamepad
glfwUpdateGamepadMappings
glfwGetGamepadName
glfwGetGamepadState

