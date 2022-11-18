namespace BeVelS.Graphics.DepthStencilStates.Factories.Descriptions
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.DepthStencilStates.InterfacesFactories.Descriptions;

    internal sealed class DepthStencilStateDescriptionFactory : IDepthStencilStateDescriptionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DepthStencilStateDescriptionFactory()
        {
        }

        public DepthStencilStateDescription Create(
            bool depthTestEnabled,
            bool depthWriteEnabled,
            ComparisonKind comparisonKind)
        {
            DepthStencilStateDescription depthStencilStateDescription = default;

            try
            {
                depthStencilStateDescription = new DepthStencilStateDescription(
                    depthTestEnabled: depthTestEnabled,
                    depthWriteEnabled: depthWriteEnabled,
                    comparisonKind: comparisonKind);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return depthStencilStateDescription;
        }

        public DepthStencilStateDescription Create(
            bool depthTestEnabled,
            bool depthWriteEnabled,
            ComparisonKind comparisonKind,
            bool stencilTestEnabled,
            StencilBehaviorDescription stencilFront,
            StencilBehaviorDescription stencilBack,
            byte stencilReadMask,
            byte stencilWriteMask,
            uint stencilReference)
        {
            DepthStencilStateDescription depthStencilStateDescription = default;

            try
            {
                depthStencilStateDescription = new DepthStencilStateDescription(
                    depthTestEnabled,
                    depthWriteEnabled,
                    comparisonKind,
                    stencilTestEnabled,
                    stencilFront,
                    stencilBack,
                    stencilReadMask,
                    stencilWriteMask,
                    stencilReference);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return depthStencilStateDescription;
        }

        // https://docs.microsoft.com/en-us/windows/win32/api/d3d11/ns-d3d11-d3d11_depth_stencil_desc
        public DepthStencilStateDescription CreateD3D11Default()
        {
            DepthStencilStateDescription depthStencilStateDescription = default;

            try
            {
                depthStencilStateDescription = new DepthStencilStateDescription(
                    depthTestEnabled: true,
                    depthWriteEnabled: true,
                    comparisonKind: ComparisonKind.Less,
                    stencilTestEnabled: false,
                    stencilFront: new StencilBehaviorDescription(
                        fail: StencilOperation.Keep,
                        pass: StencilOperation.Keep,
                        depthFail: StencilOperation.Keep,
                        comparison: ComparisonKind.Always),
                    stencilBack: new StencilBehaviorDescription(
                        fail: StencilOperation.Keep,
                        pass: StencilOperation.Keep,
                        depthFail: StencilOperation.Keep,
                        comparison: ComparisonKind.Always),
                    stencilReadMask: 0,
                    stencilWriteMask: 0,
                    stencilReference: 0);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return depthStencilStateDescription;
        }
    }
}