namespace BeVelS.ECS.Components.RenderTargets.Factories
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.ECS.Components.RenderTargets.InterfacesFactories;
    using BeVelS.ECS.Components.RenderTargets.Structs;

    internal sealed class DepthBufferComponentFactory : IDepthBufferComponentFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DepthBufferComponentFactory()
        {
        }

        public DepthBufferComponent Create(
            Texture value)
        {
            DepthBufferComponent component = default;

            try
            {
                component = new DepthBufferComponent(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return component;
        }
    }
}