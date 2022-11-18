namespace BeVelS.Integration.Windows.InterfacesFactories.Controls
{
    using System.Windows.Input;

    using BeVelS.Integration.Enums.Controls;
    using BeVelS.Integration.Windows.Interfaces.Controls;

    public interface IInstantBindFactory
    {
        IInstantBind Create(
            Key key);

        IInstantBind Create(
            Key key,
            Key alternativeKey);

        IInstantBind Create(
            Key key,
            MouseButton mouseButton);

        IInstantBind Create(
            Key key,
            MouseWheelAction mouseWheelAction);

        IInstantBind Create(
            MouseButton mouseButton);

        IInstantBind Create(
            MouseButton mouseButton,
            Key alternativeKey);

        IInstantBind Create(
            MouseButton mouseButton,
            MouseButton alternativeMouseButton);

        IInstantBind Create(
            MouseButton mouseButton,
            MouseWheelAction alternativeMouseWheelAction);

        IInstantBind Create(
            MouseWheelAction mouseWheelAction);

        IInstantBind Create(
            MouseWheelAction mouseWheelAction,
            Key alternativeKey);

        IInstantBind Create(
            MouseWheelAction mouseWheelAction,
            MouseButton alternativeMouseButton);

        IInstantBind Create(
            MouseWheelAction mouseWheelAction,
            MouseWheelAction alternativeMouseWheelAction);
    }
}