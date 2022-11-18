namespace BeVelS.ECS.Systems.Recorders.Factories
{
    using System;

    using log4net;

    using DefaultEcs;

    using BeVelS.ECS.Messages.CommandLists.InterfacesFactories;
    using BeVelS.ECS.Messages.Recorders.InterfacesFactories;
    using BeVelS.ECS.Systems.Recorders.Classes;
    using BeVelS.ECS.Systems.Recorders.Interfaces;
    using BeVelS.ECS.Systems.Recorders.InterfacesFactories;

    using BeVelS.Graphics.CommandLists.InterfacesFactories;
    using BeVelS.Graphics.Recorders.Interfaces.Configurations;
    using BeVelS.Graphics.Recorders.InterfacesFactories;

    internal sealed class FrameRecordingSystemFactory : IFrameRecordingSystemFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FrameRecordingSystemFactory()
        {
        }

        public IFrameRecordingSystem Create(
            ICommandListSubmitCommandsMessageFactory commandListSubmitCommandsMessageFactory,
            IRecordedFrameAddImageToAnimatedGifMessageFactory recordedFrameAddImageToAnimatedGifMessageFactory,
            ICommandListFactory commandListFactory,
            IFrameRecorderFactory frameRecorderFactory,
            IFrameRecorderConfiguration frameRecorderConfiguration,
            World world)
        {
            IFrameRecordingSystem system = null;

            try
            {
                system = new FrameRecordingSystem(
                    commandListSubmitCommandsMessageFactory,
                    recordedFrameAddImageToAnimatedGifMessageFactory,
                    commandListFactory,
                    frameRecorderFactory,
                    frameRecorderConfiguration,
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