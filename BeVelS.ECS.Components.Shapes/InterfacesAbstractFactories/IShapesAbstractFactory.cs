namespace BeVelS.ECS.Components.Shapes.InterfacesAbstractFactories
{
    using BeVelS.ECS.Components.Shapes.InterfacesFactories;

    public interface IShapesAbstractFactory
    {
        IBigCompoundInstanceComponentFactory CreateBigCompoundInstanceComponentFactory();

        IBoxInstanceComponentFactory CreateBoxInstanceComponentFactory();

        ICapsuleInstanceComponentFactory CreateCapsuleInstanceComponentFactory();

        ICompoundInstanceComponentFactory CreateCompoundInstanceComponentFactory();

        IConvexHullInstanceComponentFactory CreateConvexHullInstanceComponentFactory();

        ICylinderInstanceComponentFactory CreateCylinderInstanceComponentFactory();

        IMeshInstanceComponentFactory CreateMeshInstanceComponentFactory();

        IShapeInstanceComponentFactory CreateShapeInstanceComponentFactory();

        ISphereInstanceComponentFactory CreateSphereInstanceComponentFactory();

        ITriangleInstanceComponentFactory CreateTriangleInstanceComponentFactory();

        ITShapeInstanceComponentFactory CreateTShapeInstanceComponentFactory();
    }
}