namespace BeVelS.ECS.Systems.Fonts.InterfacesFactories
{
    using DefaultEcs;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.ECS.Systems.Fonts.Interfaces;

    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Fonts.InterfacesFactories;
    using BeVelS.Graphics.Textures.InterfacesFactories;

    public interface IFontSystemFactory
    {
        IFontSystem Create(
            IVector2Factory vector2Factory,
            IBufferDescriptionFactory bufferDescriptionFactory,
            IFontContentFactory fontContentFactory,
            IFontFactory fontFactory,
            IFontPackerFactory fontPackerFactory,
            ITextureContentFactory textureContentFactory,
            string path,
            World world);
    }
}