namespace BeVelS.Common.Vectors.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Common.Vectors.Factories;
    using BeVelS.Common.Vectors.InterfacesAbstractFactories;
    using BeVelS.Common.Vectors.InterfacesFactories;

    public sealed class VectorsAbstractFactory : IVectorsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VectorsAbstractFactory()
        {
        }

        public IVector2Factory CreateVector2Factory()
        {
            IVector2Factory factory = null;

            try
            {
                factory = new Vector2Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IVector3Factory CreateVector3Factory()
        {
            IVector3Factory factory = null;

            try
            {
                factory = new Vector3Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IVector4Factory CreateVector4Factory()
        {
            IVector4Factory factory = null;

            try
            {
                factory = new Vector4Factory();
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