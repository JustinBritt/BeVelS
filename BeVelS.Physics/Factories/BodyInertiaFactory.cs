namespace BeVelS.Physics.Factories
{
    using System;

    using BepuPhysics;
    using BepuPhysics.Collidables;

    using BeVelS.Physics.InterfacesFactories;

    internal sealed class BodyInertiaFactory : IBodyInertiaFactory
    {
        public BodyInertiaFactory()
        {
        }

        public BodyInertia Create()
        {
            return new BodyInertia();
        }

        public BodyInertia Create(
            float mass,
            IShape shape,
            bool isClosed = true,
            Span<float> childMasses = default,
            Shapes shapes = null)
        {
            return shape switch
            {
                BigCompound bigCompound => bigCompound.ComputeInertia(
                    childMasses: childMasses,
                    shapes: shapes),

                Compound compound => compound.ComputeInertia(
                    childMasses: childMasses,
                    shapes: shapes),

                IConvexShape convexShape => convexShape.ComputeInertia(
                    mass: mass),

                Mesh mesh => isClosed switch 
                {
                    true => mesh.ComputeClosedInertia(
                        mass: mass),

                    false => mesh.ComputeOpenInertia(
                        mass: mass)
                },

                { } => throw new ArgumentException(nameof(shape)),

                _ => default
            };
        }
    }
}