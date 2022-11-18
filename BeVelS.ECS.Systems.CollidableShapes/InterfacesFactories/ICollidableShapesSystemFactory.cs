namespace BeVelS.ECS.Systems.CollidableShapes.InterfacesFactories
{
    using DefaultEcs;
    using DefaultEcs.Threading;

    using BeVelS.ECS.Systems.CollidableShapes.Interfaces;

    using BeVelS.Graphics.Shapes.InterfacesFactories;

    public interface ICollidableShapesSystemFactory
    {
        ICollidableShapesSystem Create(
            IShapeInstanceFactory shapeInstanceFactory,
            IParallelRunner parallelRunner,
            World world);
    }
}