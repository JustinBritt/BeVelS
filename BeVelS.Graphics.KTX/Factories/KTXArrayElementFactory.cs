namespace BeVelS.Graphics.KTX.Factories
{
    using System;

    using log4net;

    using BeVelS.Graphics.KTX.Classes;
    using BeVelS.Graphics.KTX.Interfaces;
    using BeVelS.Graphics.KTX.InterfacesFactories;

    internal sealed class KTXArrayElementFactory : IKTXArrayElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public KTXArrayElementFactory()
        {
        }

        public IKTXArrayElement Create(
            IKTXFace[] faces)
        {
            IKTXArrayElement KTXArrayElement = null;

            try
            {
                KTXArrayElement = new KTXArrayElement(
                    faces);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return KTXArrayElement;
        }
    }
}