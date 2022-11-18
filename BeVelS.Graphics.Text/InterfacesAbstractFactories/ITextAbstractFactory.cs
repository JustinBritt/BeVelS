namespace BeVelS.Graphics.Text.InterfacesAbstractFactories
{
    using BeVelS.Graphics.Text.InterfacesFactories;

    public interface ITextAbstractFactory
    {
        ITextBuilderFactory CreateTextBuilderFactory();
    }
}