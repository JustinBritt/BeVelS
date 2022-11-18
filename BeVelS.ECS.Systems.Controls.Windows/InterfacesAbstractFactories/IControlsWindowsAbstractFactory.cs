namespace BeVelS.ECS.Systems.Controls.Windows.InterfacesAbstractFactories
{
    using BeVelS.ECS.Systems.Controls.Windows.InterfacesFactories;

    public interface IControlsWindowsAbstractFactory
    {
        IControlsSystemFactory CreateControlsSystemFactory();
    }
}