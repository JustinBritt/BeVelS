namespace BeVelS.ECS.Components.CollidableShapes.InterfacesAbstractFactories
{
    using BeVelS.ECS.Components.CollidableShapes.InterfacesFactories;

    public interface ICollidableShapesAbstractFactory
    {
        ICollidableShapeComponentFactory CreateCollidableShapeComponentFactory();
    }
}