namespace BeVelS.ECS.Components.Resolutions.InterfacesFactories
{
    using BepuUtilities;

    using BeVelS.ECS.Components.Resolutions.Structs;

    public interface IResolutionComponentFactory
    {
        ResolutionComponent Create(
            Int2 value);
    }
}