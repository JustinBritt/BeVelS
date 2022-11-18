namespace BeVelS.ECS.Systems.Recorders.Factories
{
    using System;

    using log4net;

    using DefaultEcs;

    using BeVelS.ECS.Messages.CommandLists.InterfacesFactories;
    using BeVelS.ECS.Messages.Recorders.InterfacesFactories;
    using BeVelS.ECS.Systems.InterfacesFactories;
    using BeVelS.ECS.Systems.Recorders.Classes;
    using BeVelS.ECS.Systems.Recorders.Interfaces;
    using BeVelS.ECS.Systems.Recorders.InterfacesFactories;

    using BeVelS.Graphics.CommandLists.InterfacesFactories;
    using BeVelS.Graphics.Recorders.Interfaces.Configurations;
    using BeVelS.Graphics.Recorders.InterfacesFactories;
    
    internal sealed class RecordingSystemFactory : IRecordingSystemFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RecordingSystemFactory()
        {
        }

        public IRecordingSystem Create(
            ICommandListSubmitCommandsMessageFactory commandListSubmitCommandsMessageFactory,
            IRecordedFrameAddImageToAnimatedGifMessageFactory recordedFrameAddImageToAnimatedGifMessageFactory,
            ISequentialSystemFactory sequentialSystemFactory,
            IAnimatedGifRecordingSystemFactory animatedGifRecordingSystemFactory,
            IFrameRecordingSystemFactory frameRecordingSystemFactory,
            ICommandListFactory commandListFactory,
            IAnimatedGifRecorderFactory animatedGifRecorderFactory,
            IFrameRecorderFactory frameRecorderFactory,
            IAnimatedGifRecorderConfiguration animatedGifRecorderConfiguration,
            IFrameRecorderConfiguration frameRecorderConfiguration,
            World world)
        {
            IRecordingSystem system = null;

            try
            {
                system = new RecordingSystem(
                    commandListSubmitCommandsMessageFactory,
                    recordedFrameAddImageToAnimatedGifMessageFactory,
                    sequentialSystemFactory,
                    animatedGifRecordingSystemFactory,
                    frameRecordingSystemFactory,
                    commandListFactory,
                    animatedGifRecorderFactory,
                    frameRecorderFactory,
                    animatedGifRecorderConfiguration,
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