namespace BeVelS.ECS.Systems.Fonts.Classes
{
    using DefaultEcs;

    using Veldrid;
    using Veldrid.ECS.Components.Extensions;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.ECS.Components.Fonts.Extensions;
    using BeVelS.ECS.Components.Fonts.Structs;
    using BeVelS.ECS.Systems.Fonts.Interfaces;

    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Fonts.Interfaces;
    using BeVelS.Graphics.Fonts.InterfacesFactories;
    using BeVelS.Graphics.Textures.InterfacesFactories;

    internal sealed class FontSystem : IFontSystem
    {
        public FontSystem(
            IVector2Factory vector2Factory,
            IBufferDescriptionFactory bufferDescriptionFactory,
            IFontContentFactory fontContentFactory,
            IFontFactory fontFactory,
            IFontPackerFactory fontPackerFactory,
            ITextureContentFactory textureContentFactory,
            string path,
            World world)
        {
            this.World = world;

            this.World.Subscribe(
                this);

            GraphicsDevice graphicsDevice = this.World.GetGraphicsDeviceLast();

            IFontContent fontContent = fontContentFactory.Create(
                vector2Factory,
                fontPackerFactory,
                textureContentFactory,
                path);

            this.Font = fontFactory.Create(
                vector2Factory,
                bufferDescriptionFactory,
                fontContent,
                graphicsDevice);

            Entity fontEntity = this.World.CreateEntity();

            FontComponent fontComponent = default;

            fontComponent.Value = this.Font;

            fontEntity.Set<FontComponent>(
                fontComponent);
        }

        public IFont Font { get; private set; }

        public bool IsEnabled { get; set; }

        private World World { get; }

        public void Update(
            float state)
        {
            ref FontComponent fontComponent = ref this.World.GetFontComponentLastRef();

            fontComponent.Value = this.Font;
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                this.Font.Dispose();
            }
        }
    }
}