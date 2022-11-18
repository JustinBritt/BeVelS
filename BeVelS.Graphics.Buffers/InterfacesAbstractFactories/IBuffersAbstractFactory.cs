namespace BeVelS.Graphics.Buffers.InterfacesAbstractFactories
{
    using BeVelS.Graphics.Buffers.InterfacesFactories;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Buffers.InterfacesFactories.FragmentConstants;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Instances;
    using BeVelS.Graphics.Buffers.InterfacesFactories.ShapeInstances;
    using BeVelS.Graphics.Buffers.InterfacesFactories.VertexConstants;

    public interface IBuffersAbstractFactory
    {
        IBackgroundVertexConstantsBufferFactory CreateBackgroundVertexConstantsBufferFactory();

        IBoxInstancesBufferFactory CreateBoxInstancesBufferFactory();

        IBoxVertexConstantsBufferFactory CreateBoxVertexConstantsBufferFactory();

        IBufferDescriptionFactory CreateBufferDescriptionFactory();

        ICapsuleFragmentConstantsBufferFactory CreateCapsuleFragmentConstantsBufferFactory();

        ICapsuleInstancesBufferFactory CreateCapsuleInstancesBufferFactory();

        ICapsuleVertexConstantsBufferFactory CreateCapsuleVertexConstantsBufferFactory();

        IConstantsBufferFactory CreateConstantsBufferFactory();

        ICylinderFragmentConstantsBufferFactory CreateCylinderFragmentConstantsBufferFactory();

        ICylinderInstancesBufferFactory CreateCylinderInstancesBufferFactory();

        ICylinderVertexConstantsBufferFactory CreateCylinderVertexConstantsBufferFactory();

        IGlyphInstancesBufferFactory CreateGlyphInstancesBufferFactory();

        IGlyphVertexConstantsBufferFactory CreateGlyphVertexConstantsBufferFactory();

        IHTMLInstancesBufferFactory CreateHTMLInstancesBufferFactory();

        IHTMLVertexConstantsBufferFactory CreateHTMLVertexConstantsBufferFactory();

        IImageInstancesBufferFactory CreateImageInstancesBufferFactory();

        IImageVertexConstantsBufferFactory CreateImageVertexConstantsBufferFactory();

        IIndexBufferFactory CreateIndexBufferFactory();

        IInstancesBufferFactory CreateInstancesBufferFactory();

        ILineInstancesBufferFactory CreateLineInstancesBufferFactory();

        ILineVertexConstantsBufferFactory CreateLineVertexConstantsBufferFactory();

        IMeshInstancesBufferFactory CreateMeshInstancesBufferFactory();

        IMeshVertexConstantsBufferFactory CreateMeshVertexConstantsBufferFactory();

        IShapeInstancesBufferFactory CreateShapeInstancesBufferFactory();

        ISphereFragmentConstantsBufferFactory CreateSphereFragmentConstantsBufferFactory();

        ISphereInstancesBufferFactory CreateSphereInstancesBufferFactory();

        ISphereVertexConstantsBufferFactory CreateSphereVertexConstantsBufferFactory();

        ITriangleInstancesBufferFactory CreateTriangleInstancesBufferFactory();

        ITriangleVertexConstantsBufferFactory CreateTriangleVertexConstantsBufferFactory();

        IUILineInstancesBufferFactory CreateUILineInstancesBufferFactory();

        IUILineVertexConstantsBufferFactory CreateUILineVertexConstantsBufferFactory();
    }
}