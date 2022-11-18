namespace BeVelS.Graphics.Recorders.Factories
{
    using System;

    using log4net;

    using BeVelS.Graphics.Recorders.Classes;
    using BeVelS.Graphics.Recorders.Interfaces;
    using BeVelS.Graphics.Recorders.InterfacesFactories;

    internal sealed class AnimatedGifRecorderFactory : IAnimatedGifRecorderFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AnimatedGifRecorderFactory()
        {
        }

        public IAnimatedGifRecorder Create(
            int height,
            int width)
        {
            IAnimatedGifRecorder recorder = null;

            try
            {
                recorder = new AnimatedGifRecorder(
                    height: height,
                    width: width);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return recorder;
        }
    }
}