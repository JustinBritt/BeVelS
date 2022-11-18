namespace BeVelS.Graphics.GraphDataSeries.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BeVelS.Graphics.GraphDataSeries.Interfaces;
    using BeVelS.Graphics.GraphDataSeries.InterfacesFactories;
    using BeVelS.Graphics.GraphDataSeries.Structs;
   
    internal sealed class SeriesFactory : ISeriesFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SeriesFactory()
        {
        }

        public Series Create(
            IDataSeries data,
            Vector3 lineColor,
            float lineRadius,
            string name)
        {
            Series series = default;

            try
            {
                series = new Series();

                series.Name = name;

                series.LineColor = lineColor;

                series.LineRadius = lineRadius;

                series.Data = data;
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return series;
        }
    }
}