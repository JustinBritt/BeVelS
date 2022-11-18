namespace BeVelS.Graphics.UILines.InterfacesAbstractFactories
{
    using BeVelS.Graphics.UILines.InterfacesFactories;

    public interface IUILinesAbstractFactory
    {
        IUILineInstanceFactory CreateUILineInstanceFactory();
    }
}