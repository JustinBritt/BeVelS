namespace BeVelS.Graphics.GraphDataSeries.InterfacesAbstractFactories
{
    using BeVelS.Graphics.GraphDataSeries.InterfacesFactories;

    public interface IGraphDataSeriesAbstractFactory
    {
        ISeriesFactory CreateSeriesFactory();
    }
}