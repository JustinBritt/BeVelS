namespace BeVelS.Physics.Constraints.InterfacesFactories
{
    using System.Numerics;

    using BepuPhysics.Constraints;

    public interface IBallSocketFactory
    {
        BallSocket Create(
            Vector3 localOffsetA,
            Vector3 localOffsetB,
            SpringSettings springSettings);
    }
}