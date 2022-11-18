namespace BeVelS.Physics.InterfacesFactories
{
    using System.Numerics;

    using BepuPhysics;

    public interface IBodyVelocityFactory
    {
        BodyVelocity Create(
            Vector3 angularVelocity,
            Vector3 linearVelocity);
    }
}