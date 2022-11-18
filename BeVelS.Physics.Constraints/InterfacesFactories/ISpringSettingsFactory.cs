namespace BeVelS.Physics.Constraints.InterfacesFactories
{
    using BepuPhysics.Constraints;

    public interface ISpringSettingsFactory
    {
        SpringSettings Create(
            float frequency,
            float dampingRatio);
    }
}