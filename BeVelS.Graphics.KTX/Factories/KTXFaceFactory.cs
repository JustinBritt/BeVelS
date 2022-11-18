namespace BeVelS.Graphics.KTX.Factories
{
    using System;

    using log4net;

    using BeVelS.Graphics.KTX.Classes;
    using BeVelS.Graphics.KTX.Interfaces;
    using BeVelS.Graphics.KTX.InterfacesFactories;

    internal sealed class KTXFaceFactory : IKTXFaceFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public KTXFaceFactory()
        {
        }

        public IKTXFace Create(
            byte[] data)
        {
            IKTXFace KTXFace = null;

            try
            {
                KTXFace = new KTXFace(
                    data);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return KTXFace;
        }
    }
}