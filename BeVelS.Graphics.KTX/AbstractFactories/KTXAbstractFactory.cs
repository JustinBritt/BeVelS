namespace BeVelS.Graphics.KTX.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.KTX.Factories;
    using BeVelS.Graphics.KTX.InterfacesAbstractFactories;
    using BeVelS.Graphics.KTX.InterfacesFactories;

    public sealed class KTXAbstractFactory : IKTXAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public KTXAbstractFactory()
        {
        }

        public IKTXArrayElementFactory CreateKTXArrayElementFactory()
        {
            IKTXArrayElementFactory factory = null;

            try
            {
                factory = new KTXArrayElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IKTXFaceFactory CreateKTXFaceFactory()
        {
            IKTXFaceFactory factory = null;

            try
            {
                factory = new KTXFaceFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IKTXFileFactory CreateKTXFileFactory()
        {
            IKTXFileFactory factory = null;

            try
            {
                factory = new KTXFileFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IKTXKeyValuePairFactory CreateKTXKeyValuePairFactory()
        {
            IKTXKeyValuePairFactory factory = null;

            try
            {
                factory = new KTXKeyValuePairFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IKTXMipmapLevelFactory CreateKTXMipmapLevelFactory()
        {
            IKTXMipmapLevelFactory factory = null;

            try
            {
                factory = new KTXMipmapLevelFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}