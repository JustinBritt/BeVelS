namespace BeVelS.ECS.Systems.CollidableShapes.InterfacesAbstractFactories
{
    using BeVelS.ECS.Systems.CollidableShapes.InterfacesFactories;

    public interface ICollidableShapesAbstractFactory
    {
        ICollidableShapesSystemFactory CreateCollidableShapesSystemFactory();
    }
}