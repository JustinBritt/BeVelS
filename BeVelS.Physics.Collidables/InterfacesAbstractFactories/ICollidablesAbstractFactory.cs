namespace BeVelS.Physics.Collidables.InterfacesAbstractFactories
{
    using BeVelS.Physics.Collidables.InterfacesFactories;

    public interface ICollidablesAbstractFactory
    {
        IBoxFactory CreateBoxFactory();

        ICapsuleFactory CreateCapsuleFactory();

        ICollidableDescriptionFactory CreateCollidableDescriptionFactory();

        ICollidableReferenceFactory CreateCollidableReferenceFactory();

        IConvexHullFactory CreateConvexHullFactory();

        ICylinderFactory CreateCylinderFactory();

        IMeshFactory CreateMeshFactory();

        IShapeFactory CreateShapeFactory();

        ISphereFactory CreateSphereFactory();

        ITriangleFactory CreateTriangleFactory();
    }
}