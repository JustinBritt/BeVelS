namespace BeVelS.ECS.Systems.RenderTargets.Factories
{
    using System;

    using log4net;

    using DefaultEcs;

    using BeVelS.ECS.Systems.RenderTargets.Classes;
    using BeVelS.ECS.Systems.RenderTargets.Interfaces;
    using BeVelS.ECS.Systems.RenderTargets.InterfacesFactories;

    using BeVelS.Graphics.Textures.InterfacesFactories;

    internal sealed class ResolvedColorBufferSystemFactory : IResolvedColorBufferSystemFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResolvedColorBufferSystemFactory()
        {
        }

        public IResolvedColorBufferSystem Create(
            ITextureFactory textureFactory,
            World world)
        {
            IResolvedColorBufferSystem system = null;

            try
            {
                system = new ResolvedColorBufferSystem(
                    textureFactory,
                    world);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return system;
        }
    }
}