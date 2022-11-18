namespace BeVelS.Common.Comparers.Factories
{
    using System;

    using log4net;

    using BeVelS.Common.Comparers.Classes;
    using BeVelS.Common.Comparers.Interfaces;
    using BeVelS.Common.Comparers.InterfacesFactories;

    internal sealed class GuidEqualityComparerRefFactory : IGuidEqualityComparerRefFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public GuidEqualityComparerRefFactory()
        {
        }

        public IGuidEqualityComparerRef Create()
        {
            IGuidEqualityComparerRef comparer = null;

            try
            {
                comparer = new GuidEqualityComparerRef();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return comparer;
        }
    }
}