namespace BeVelS.Physics.InterfacesFactories
{
    using BepuPhysics;

    public interface IBodyActivityDescriptionFactory
    {
        BodyActivityDescription Create(
            float sleepThreshold);
    }
}