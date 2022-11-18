namespace BeVelS.Graphics.CommandLists.InterfacesAbstractFactories
{
    using BeVelS.Graphics.CommandLists.InterfacesFactories;

    public interface ICommandListsAbstractFactory
    {
        ICommandListFactory CreateCommandListFactory();
    }
}