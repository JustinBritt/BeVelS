namespace BeVelS.Graphics.RasterizerStates.Factories.Descriptions
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.RasterizerStates.InterfacesFactories.Descriptions;

    internal sealed class RasterizerStateDescriptionFactory : IRasterizerStateDescriptionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RasterizerStateDescriptionFactory()
        {
        }

        public RasterizerStateDescription Create(
            FaceCullMode cullMode,
            PolygonFillMode fillMode,
            FrontFace frontFace,
            bool depthClipEnabled,
            bool scissorTestEnabled)
        {
            RasterizerStateDescription rasterizerStateDescription = default;

            try
            {
                rasterizerStateDescription = new RasterizerStateDescription(
                    cullMode,
                    fillMode,
                    frontFace,
                    depthClipEnabled,
                    scissorTestEnabled);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return rasterizerStateDescription;
        }

        // https://docs.microsoft.com/en-us/windows/win32/api/d3d11/ns-d3d11-d3d11_rasterizer_desc
        public RasterizerStateDescription CreateD3D11Default()
        {
            RasterizerStateDescription rasterizerStateDescription = default;

            try
            {
                rasterizerStateDescription = new RasterizerStateDescription(
                    cullMode: FaceCullMode.Back,
                    fillMode: PolygonFillMode.Solid,
                    frontFace: FrontFace.Clockwise,
                    depthClipEnabled: true,
                    scissorTestEnabled: false);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return rasterizerStateDescription;
        }
    }
}