namespace BeVelS.Graphics.Shapes.InterfacesFactories
{
    using System;

    using BepuPhysics;
    using BepuPhysics.Collidables;

    using BeVelS.Graphics.Shapes.Interfaces;

    public interface IShapeInstanceFactory
    {
        IShapeInstance Create(
            CollidableReference collidableReference,
            Type shapeType,
            Simulation simulation);
    }
}