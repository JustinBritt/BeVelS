namespace BeVelS.Graphics.Shapes.Factories
{
    using System;

    using BepuPhysics;
    using BepuPhysics.Collidables;

    using BeVelS.Graphics.Shapes.Interfaces;
    using BeVelS.Graphics.Shapes.InterfacesFactories;

    internal sealed class ShapeInstanceFactory : IShapeInstanceFactory
    {
        public ShapeInstanceFactory()
        {
        }

        public IShapeInstance Create(
            RigidPose rigidPose,
            IShape shape)
        {
            return shape switch
            {
                BigCompound bigCompound => new BeVelS.Graphics.Shapes.Factories.BigCompoundInstanceFactory().Create(
                    bigCompound,
                    rigidPose),

                Box box => new BeVelS.Graphics.Shapes.Factories.BoxInstanceFactory().Create(
                    box,
                    rigidPose),

                Capsule capsule => new BeVelS.Graphics.Shapes.Factories.CapsuleInstanceFactory().Create(
                    capsule,
                    rigidPose),

                Compound compound => new BeVelS.Graphics.Shapes.Factories.CompoundInstanceFactory().Create(
                    compound,
                    rigidPose),

                ConvexHull convexHull => new BeVelS.Graphics.Shapes.Factories.ConvexHullInstanceFactory().Create(
                    convexHull,
                    rigidPose),

                Cylinder cylinder => new BeVelS.Graphics.Shapes.Factories.CylinderInstanceFactory().Create(
                    cylinder,
                    rigidPose),

                Mesh mesh => new BeVelS.Graphics.Shapes.Factories.MeshInstanceFactory().Create(
                    mesh,
                    rigidPose),

                Sphere sphere => new BeVelS.Graphics.Shapes.Factories.SphereInstanceFactory().Create(
                    rigidPose,
                    sphere),

                Triangle triangle => new BeVelS.Graphics.Shapes.Factories.TriangleInstanceFactory().Create(
                    rigidPose,
                    triangle),

                { } => throw new ArgumentNullException(nameof(shape)),

                _ => null
            };
        }

        public IShapeInstance Create(
            BodyDescription bodyDescription,
            Type shapeType,
            Simulation simulation)
        {
            return this.Create(
                rigidPose: bodyDescription.Pose,
                shape: this.GetShape(
                    shapeIn: bodyDescription.Collidable.Shape,
                    shapeType: shapeType,
                    simulation: simulation));
        }

        public IShapeInstance Create(
            BodyHandle bodyHandle,
            Type shapeType,
            Simulation simulation)
        {
            BodyDescription bodyDescription = default;

            simulation.Bodies.GetDescription(
                bodyHandle,
                out bodyDescription);

            return this.Create(
                bodyDescription: bodyDescription,
                shapeType: shapeType,
                simulation: simulation);
        }

        public IShapeInstance Create(
            Type shapeType,
            Simulation simulation,
            StaticDescription staticDescription)
        {
            return this.Create(
                rigidPose: staticDescription.Pose,
                shape: this.GetShape(
                    staticDescription.Shape,
                    shapeType,
                    simulation));
        }

        public IShapeInstance Create(
            Type shapeType,
            Simulation simulation,
            StaticHandle staticHandle)
        {
            StaticDescription staticDescription = default;

            simulation.Statics.GetDescription(
                staticHandle,
                out staticDescription);

            return this.Create(
                shapeType: shapeType,
                simulation: simulation,
                staticDescription: staticDescription);
        }

        public IShapeInstance Create(
            CollidableReference collidableReference,
            Type shapeType,
            Simulation simulation)
        {
            return collidableReference.Mobility switch
            {
                CollidableMobility.Dynamic or CollidableMobility.Kinematic => this.Create(
                    collidableReference.BodyHandle,
                    shapeType,
                    simulation),

                CollidableMobility.Static => this.Create(
                    shapeType,
                    simulation,
                    collidableReference.StaticHandle),

                { } => throw new ArgumentNullException(nameof(collidableReference.Mobility)),
            };
        }

        private IShape GetShape(
            TypedIndex shapeIn,
            Type shapeType,
            Simulation simulation)
        {
            IShape shape = null;

            if (shapeType == typeof(BigCompound))
            {
                shape = simulation.Shapes.GetShape<BigCompound>(
                    shapeIn.Index);
            }
            else if (shapeType == typeof(Box))
            {
                shape = simulation.Shapes.GetShape<Box>(
                    shapeIn.Index);
            }
            else if (shapeType == typeof(Capsule))
            {
                shape = simulation.Shapes.GetShape<Capsule>(
                    shapeIn.Index);
            }
            else if (shapeType == typeof(Compound))
            {
                shape = simulation.Shapes.GetShape<Compound>(
                    shapeIn.Index);
            }
            else if (shapeType == typeof(ConvexHull))
            {
                shape = simulation.Shapes.GetShape<ConvexHull>(
                    shapeIn.Index);
            }
            else if (shapeType == typeof(Cylinder))
            {
                shape = simulation.Shapes.GetShape<Cylinder>(
                    shapeIn.Index);
            }
            else if (shapeType == typeof(Mesh))
            {
                shape = simulation.Shapes.GetShape<Mesh>(
                    shapeIn.Index);
            }
            else if (shapeType == typeof(Sphere))
            {
                shape = simulation.Shapes.GetShape<Sphere>(
                    shapeIn.Index);
            }
            else if (shapeType == typeof(Triangle))
            {
                shape = simulation.Shapes.GetShape<Triangle>(
                    shapeIn.Index);
            }
            else
            {
                throw new NotImplementedException();
            }

            return shape;
        }
    }
}