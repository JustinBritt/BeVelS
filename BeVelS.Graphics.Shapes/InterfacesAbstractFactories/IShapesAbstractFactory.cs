namespace BeVelS.Graphics.Shapes.InterfacesAbstractFactories
{
    using BeVelS.Graphics.Shapes.InterfacesFactories;

    public interface IShapesAbstractFactory
    {
        IBigCompoundInstanceFactory CreateBigCompoundInstanceFactory();

        IBoxInstanceFactory CreateBoxInstanceFactory();

        ICapsuleInstanceFactory CreateCapsuleInstanceFactory();

        ICompoundInstanceFactory CreateCompoundInstanceFactory();

        IConvexHullInstanceFactory CreateConvexHullInstanceFactory();

        ICylinderInstanceFactory CreateCylinderInstanceFactory();

        IMeshInstanceFactory CreateMeshInstanceFactory();

        IShapeInstanceFactory CreateShapeInstanceFactory();

        ISphereInstanceFactory CreateSphereInstanceFactory();

        ITriangleInstanceFactory CreateTriangleInstanceFactory();
    }
}