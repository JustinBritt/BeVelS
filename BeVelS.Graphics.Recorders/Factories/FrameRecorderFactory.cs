namespace BeVelS.Graphics.Recorders.Factories
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.Recorders.Classes;
    using BeVelS.Graphics.Recorders.Interfaces;
    using BeVelS.Graphics.Recorders.InterfacesFactories;

    internal sealed class FrameRecorderFactory : IFrameRecorderFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FrameRecorderFactory()
        {
        }

        public IFrameRecorder Create(
            GraphicsDevice graphicsDevice,
            Texture sourceTexture)
        {
            IFrameRecorder recorder = null;

            try
            {
                recorder = new FrameRecorder(
                    graphicsDevice,
                    sourceTexture);
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