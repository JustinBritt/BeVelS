namespace BeVelS.Graphics.DepthStencilStates.Extensions.Descriptions
{
    using Veldrid;

    public static class DepthStencilStateDescriptionExtensions
    {
        public static DepthStencilStateDescription WithoutDepthTest(
            this DepthStencilStateDescription depthStencilStateDescription)
        {
            depthStencilStateDescription.DepthTestEnabled = false;

            return depthStencilStateDescription;
        }

        public static DepthStencilStateDescription WithoutDepthWrite(
            this DepthStencilStateDescription depthStencilStateDescription)
        {
            depthStencilStateDescription.DepthWriteEnabled = false;

            return depthStencilStateDescription;
        }

        public static DepthStencilStateDescription WithoutStencilTest(
            this DepthStencilStateDescription depthStencilStateDescription)
        {
            depthStencilStateDescription.StencilTestEnabled = false;

            return depthStencilStateDescription;
        }
    }
}