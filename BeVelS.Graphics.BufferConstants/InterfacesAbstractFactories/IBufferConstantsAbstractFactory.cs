namespace BeVelS.Graphics.BufferConstants.InterfacesAbstractFactories
{
    using BeVelS.Graphics.BufferConstants.InterfacesFactories.FragmentConstants;
    using BeVelS.Graphics.BufferConstants.InterfacesFactories.VertexConstants;

    public interface IBufferConstantsAbstractFactory
    {
        IBoxVertexConstantsFactory CreateBoxVertexConstantsFactory();

        ICapsuleFragmentConstantsFactory CreateCapsuleFragmentConstantsFactory();

        ICapsuleVertexConstantsFactory CreateCapsuleVertexConstantsFactory();

        ICylinderFragmentConstantsFactory CreateCylinderFragmentConstantsFactory();

        ICylinderVertexConstantsFactory CreateCylinderVertexConstantsFactory();

        IGlyphVertexConstantsFactory CreateGlyphVertexConstantsFactory();

        IHTMLVertexConstantsFactory CreateHTMLVertexConstantsFactory();

        IImageVertexConstantsFactory CreateImageVertexConstantsFactory();

        ILineVertexConstantsFactory CreateLineVertexConstantsFactory();

        IMeshVertexConstantsFactory CreateMeshVertexConstantsFactory();

        ISphereFragmentConstantsFactory CreateSphereFragmentConstantsFactory();

        ISphereVertexConstantsFactory CreateSphereVertexConstantsFactory();

        ITriangleVertexConstantsFactory CreateTriangleVertexConstantsFactory();

        IUILineVertexConstantsFactory CreateUILineVertexConstantsFactory();
    }
}