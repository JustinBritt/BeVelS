namespace BeVelS.Physics.InterfacesFactories
{
    using System;

    using BepuPhysics;
    using BepuPhysics.Collidables;
   
    public interface IBodyInertiaFactory
    {
        BodyInertia Create();

        BodyInertia Create(
            float mass,
            IShape shape,
            bool isClosed = true,
            Span<float> childMasses = default,
            Shapes shapes = null);
    }
}