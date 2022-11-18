namespace BeVelS.Common.Comparers.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Common.Comparers.Factories;
    using BeVelS.Common.Comparers.InterfacesAbstractFactories;
    using BeVelS.Common.Comparers.InterfacesFactories;

    public sealed class ComparersAbstractFactory : IComparersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ComparersAbstractFactory()
        {
        }

        public IGuidEqualityComparerRefFactory CreateGuidEqualityComparerRefFactory()
        {
            IGuidEqualityComparerRefFactory factory = null;

            try
            {
                factory = new GuidEqualityComparerRefFactory();
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