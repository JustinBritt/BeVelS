namespace BeVelS.Graphics.GraphicsDevices.Extensions.Options
{
    using Veldrid;

    public static class GraphicsDeviceOptionsExtensions
    {
        public static GraphicsDeviceOptions WithPreferStandardClipSpaceYDirection(
            this GraphicsDeviceOptions graphicsDeviceOptions)
        {
            graphicsDeviceOptions.PreferStandardClipSpaceYDirection = true;

            return graphicsDeviceOptions;
        }
    }
}