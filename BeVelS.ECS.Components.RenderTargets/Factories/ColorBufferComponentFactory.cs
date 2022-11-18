namespace BeVelS.ECS.Components.RenderTargets.Factories
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.ECS.Components.RenderTargets.InterfacesFactories;
    using BeVelS.ECS.Components.RenderTargets.Structs;

    internal sealed class ColorBufferComponentFactory : IColorBufferComponentFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ColorBufferComponentFactory()
        {
        }

        public ColorBufferComponent Create(
            Texture value)
        {
            ColorBufferComponent component = default;

            try
            {
                component = new ColorBufferComponent(
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