namespace BeVelS.Physics.Collidables.Extensions
{
    using System;

    using BepuPhysics;
    using BepuPhysics.Collidables;

    public static class ShapeExtensions
    {
        public static TypedIndex AddToSimulation(
            this IShape shape,
            Simulation simulation)
        {
            return shape switch
            {
                Box box => simulation.Shapes.Add(
                    box),

                Capsule capsule => simulation.Shapes.Add(
                    capsule),

                ConvexHull convexHull => simulation.Shapes.Add(
                    convexHull),

                Cylinder cylinder => simulation.Shapes.Add(
                    cylinder),

                Mesh mesh => simulation.Shapes.Add(
                    mesh),

                Sphere sphere => simulation.Shapes.Add(
                    sphere),

                Triangle triangle => simulation.Shapes.Add(
                    triangle),

                { } => throw new ArgumentNullException(nameof(shape)),

                _ => throw new NotImplementedException()
            };
        }
    }
}