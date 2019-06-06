namespace GLFW
{
    /// <summary>
    /// Base exception class for GLFW related errors.
    /// </summary>
    public class Exception : System.Exception
    {
        #region Methods

        /// <summary>
        ///     Generic error messages if only an error code is supplied as an argument to the constructor.
        /// </summary>
        /// <param name="code">The error code.</param>
        /// <returns>Error message.</returns>
        public static string GetErrorMessage(ErrorCode code)
        {
            switch (code)
            {
                case ErrorCode.NotInitialized:     return Strings.NotInitialized;
                case ErrorCode.NoCurrentContext:   return Strings.NoCurrentContext;
                case ErrorCode.InvalidEnum:        return Strings.InvalidEnum;
                case ErrorCode.InvalidValue:       return Strings.InvalidValue;
                case ErrorCode.OutOfMemory:        return Strings.OutOfMemory;
                case ErrorCode.ApiUnavailable:     return Strings.ApiUnavailable;
                case ErrorCode.VersionUnavailable: return Strings.VersionUnavailable;
                case ErrorCode.PlatformError:      return Strings.PlatformError;
                case ErrorCode.FormatUnavailable:  return Strings.FormatUnavailable;
                case ErrorCode.NoWindowContext:    return Strings.NoWindowContext;
                default:                           return Strings.UnknownError;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Exception" /> class.
        /// </summary>
        /// <param name="error">The error code to create a generic message from.</param>
        public Exception(ErrorCode error) : base(GetErrorMessage(error)) { }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Exception" /> class.
        /// </summary>
        /// <param name="message">The error message.</param>
        public Exception(string message) : base(message) { }

        #endregion
    }
}