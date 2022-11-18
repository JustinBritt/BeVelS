namespace BeVelS.Windows.InterfacesAbstractFactories
{
    public interface IBeVelSWindowsAbstractFactory
    {
        BeVelS.ECS.Components.Hosts.Windows.InterfacesAbstractFactories.IHostsWindowsAbstractFactory CreateECSComponentsHostsWindowsAbstractFactory();

        BeVelS.ECS.Components.Inputs.Windows.InterfacesAbstractFactories.IInputsWindowsAbstractFactory CreateECSComponentsInputsWindowsAbstractFactory();

        BeVelS.ECS.Messages.Hosts.Windows.InterfacesAbstractFactories.IHostsWindowsAbstractFactory CreateECSMessagesHostsWindowsAbstractFactory();

        BeVelS.ECS.Messages.Inputs.Windows.InterfacesAbstractFactories.IInputsWindowsAbstractFactory CreateECSMessagesInputsWindowsAbstractFactory();

        BeVelS.ECS.Systems.Controls.Windows.InterfacesAbstractFactories.IControlsWindowsAbstractFactory CreateECSSystemsControlsWindowsAbstractFactory();

        BeVelS.ECS.Systems.Hosts.Windows.InterfacesAbstractFactories.IHostsWindowsAbstractFactory CreateECSSystemsHostsWindowsAbstractFactory();

        BeVelS.ECS.Systems.Inputs.Windows.InterfacesAbstractFactories.IInputsWindowsAbstractFactory CreateECSSystemsInputsWindowsAbstractFactory();
    }
}