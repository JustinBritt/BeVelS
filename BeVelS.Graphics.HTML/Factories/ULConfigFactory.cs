namespace BeVelS.Graphics.HTML.Factories
{
    using System;

    using log4net;

    using UltralightNet;

    using BeVelS.Graphics.HTML.InterfacesFactories;
    
    internal sealed class ULConfigFactory : IULConfigFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ULConfigFactory()
        {
        }

        public ULConfig Create(
            uint bitmapAlignment,
            ULFaceWinding faceWinding,
            bool forceRepaint)
        {
            ULConfig ULConfig = default;

            try
            {
                ULConfig = new ULConfig();

                ULConfig.BitmapAlignment = bitmapAlignment;

                ULConfig.FaceWinding = faceWinding;

                ULConfig.ForceRepaint = forceRepaint;
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return ULConfig;
        }
    }
}