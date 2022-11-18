namespace BeVelS.Graphics.GraphDataSeries.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.GraphDataSeries.Factories;
    using BeVelS.Graphics.GraphDataSeries.InterfacesAbstractFactories;
    using BeVelS.Graphics.GraphDataSeries.InterfacesFactories;

    public sealed class GraphDataSeriesAbstractFactory : IGraphDataSeriesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public GraphDataSeriesAbstractFactory()
        {
        }

        public ISeriesFactory CreateSeriesFactory()
        {
            ISeriesFactory factory = null;

            try
            {
                factory = new SeriesFactory();
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