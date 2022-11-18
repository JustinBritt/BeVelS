namespace BeVelS.ECS.Systems.Cameras.InterfacesFactories
{
    using DefaultEcs;

    using BeVelS.ECS.Systems.Cameras.Interfaces;

    using BeVelS.Graphics.Cameras.Interfaces;

    public interface ICameraSystemFactory
    {
        ICameraSystem Create(
            ICamera camera,
            World world);
    }
}