using System;

namespace GLFW.Game
{
    /// <summary>
    /// Arguments used when a window content scaling is changed.
    /// </summary>
    public class ContentScaleEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the new scale on the x-axis.
        /// </summary>
        public float XScale { get; }
        
        /// <summary>
        /// Gets the new scale on the y-axis.
        /// </summary>
        public float YScale { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xScale">The new scale on the x-axis.</param>
        /// <param name="yScale">The new scale on the y-axis.</param>
        public ContentScaleEventArgs(float xScale, float yScale)
        {
            XScale = xScale;
            YScale = yScale;
        }
    }
}