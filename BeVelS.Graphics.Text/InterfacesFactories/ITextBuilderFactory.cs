namespace BeVelS.Graphics.Text.InterfacesFactories
{
    using BeVelS.Graphics.Text.Interfaces;

    public interface ITextBuilderFactory
    {
        ITextBuilder Create(
            int initialCapacity = 32);
    }
}