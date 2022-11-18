namespace BeVelS.ECS.Components.RenderTargets.Factories
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.ECS.Components.RenderTargets.InterfacesFactories;
    using BeVelS.ECS.Components.RenderTargets.Structs;

    internal sealed class ResolvedColorBufferComponentFactory : IResolvedColorBufferComponentFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResolvedColorBufferComponentFactory()
        {
        }

        public ResolvedColorBufferComponent Create(
            Texture value)
        {
            ResolvedColorBufferComponent component = default;

            try
            {
                component = new ResolvedColorBufferComponent(
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