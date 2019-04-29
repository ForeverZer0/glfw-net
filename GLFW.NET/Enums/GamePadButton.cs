#pragma warning disable 1591

namespace GLFW
{
    /// <summary>
    ///     Represents gamepad buttons.
    ///     <para>
    ///         Duplicate values convenience for providing naming conventions for common gamepads (PlayStation,
    ///         X-Box, etc).
    ///     </para>
    /// </summary>
    public enum GamePadButton : byte
    {
        A = 0,
        B = 1,
        X = 2,
        Y = 3,
        LeftBumper = 4,
        RightBumper = 5,
        Back = 6,
        Start = 7,
        Guide = 8,
        LeftThumb = 9,
        RightThumb = 10,
        DpadUp = 11,
        DpadRight = 12,
        DpadDown = 13,
        DpadLeft = 14,
        Cross = A,
        Circle = B,
        Square = X,
        Triangle = Y
    }
}