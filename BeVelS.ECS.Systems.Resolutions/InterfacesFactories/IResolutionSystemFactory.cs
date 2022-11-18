namespace BeVelS.ECS.Systems.Resolutions.InterfacesFactories
{
    using System.Numerics;

    using DefaultEcs;

    using BeVelS.ECS.Systems.Resolutions.Interfaces;

    public interface IResolutionSystemFactory
    {
        IResolutionSystem Create(
            Vector2 resolution,
            World world);
    }
}