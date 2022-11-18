namespace BeVelS.ECS.Messages.Recorders.Factories
{
    using System;

    using log4net;

    using BeVelS.ECS.Messages.Recorders.InterfacesFactories;
    using BeVelS.ECS.Messages.Recorders.Structs;

    internal sealed class AnimatedGifSaveMessageFactory : IAnimatedGifSaveMessageFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AnimatedGifSaveMessageFactory()
        {
        }

        public AnimatedGifSaveMessage Create()
        {
            AnimatedGifSaveMessage message = default;

            try
            {
                message = new AnimatedGifSaveMessage();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return message;
        }
    }
}