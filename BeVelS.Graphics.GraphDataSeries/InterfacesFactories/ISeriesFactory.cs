namespace BeVelS.Graphics.GraphDataSeries.InterfacesFactories
{
    using System.Numerics;

    using BeVelS.Graphics.GraphDataSeries.Interfaces;
    using BeVelS.Graphics.GraphDataSeries.Structs;

    public interface ISeriesFactory
    {
        Series Create(
            IDataSeries data,
            Vector3 lineColor,
            float lineRadius,
            string name);
    }
}