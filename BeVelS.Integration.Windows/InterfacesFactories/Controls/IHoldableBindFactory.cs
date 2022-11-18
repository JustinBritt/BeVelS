namespace BeVelS.Integration.Windows.InterfacesFactories.Controls
{
    using System.Windows.Input;

    using BeVelS.Integration.Windows.Interfaces.Controls;

    public interface IHoldableBindFactory
    {
        IHoldableBind Create(
            Key key);

        IHoldableBind Create(
            Key key,
            Key alternativeKey);

        IHoldableBind Create(
            Key key,
            MouseButton alternativeMouseButton);

        IHoldableBind Create(
            MouseButton mouseButton);

        IHoldableBind Create(
            MouseButton mouseButton,
            Key alternativeKey);

        IHoldableBind Create(
            MouseButton mouseButton,
            MouseButton alternativeMouseButton);
    }
}