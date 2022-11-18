namespace BeVelS.Graphics.CommandLists.InterfacesFactories
{
    using Veldrid;

    public interface ICommandListFactory
    {
        CommandList Create(
            GraphicsDevice graphicsDevice);

        CommandList Create(
            GraphicsDevice graphicsDevice,
            string name);
    }
}