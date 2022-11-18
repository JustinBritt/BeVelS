namespace BeVelS.ECS.Systems.Recorders.Factories
{
    using System;

    using log4net;

    using DefaultEcs;

    using BeVelS.ECS.Systems.Recorders.Classes;
    using BeVelS.ECS.Systems.Recorders.Interfaces;
    using BeVelS.ECS.Systems.Recorders.InterfacesFactories;

    using BeVelS.Graphics.Recorders.Interfaces.Configurations;
    using BeVelS.Graphics.Recorders.InterfacesFactories;

    internal sealed class AnimatedGifRecordingSystemFactory : IAnimatedGifRecordingSystemFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AnimatedGifRecordingSystemFactory()
        {
        }

        public IAnimatedGifRecordingSystem Create(
            IAnimatedGifRecorderFactory animatedGifRecorderFactory,
            IAnimatedGifRecorderConfiguration animatedGifRecorderConfiguration,
            World world)
        {
            IAnimatedGifRecordingSystem system = null;

            try
            {
                system = new AnimatedGifRecordingSystem(
                    animatedGifRecorderFactory,
                    animatedGifRecorderConfiguration,
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