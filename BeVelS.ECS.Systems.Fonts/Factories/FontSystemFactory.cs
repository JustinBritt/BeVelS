namespace BeVelS.ECS.Systems.Fonts.Factories
{
    using System;

    using log4net;

    using DefaultEcs;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.ECS.Systems.Fonts.Classes;
    using BeVelS.ECS.Systems.Fonts.Interfaces;
    using BeVelS.ECS.Systems.Fonts.InterfacesFactories;
    
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Fonts.InterfacesFactories;
    using BeVelS.Graphics.Textures.InterfacesFactories;

    internal sealed class FontSystemFactory : IFontSystemFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FontSystemFactory()
        {
        }

        public IFontSystem Create(
            IVector2Factory vector2Factory,
            IBufferDescriptionFactory bufferDescriptionFactory,
            IFontContentFactory fontContentFactory,
            IFontFactory fontFactory,
            IFontPackerFactory fontPackerFactory,
            ITextureContentFactory textureContentFactory,
            string path,
            World world)
        {
            IFontSystem system = null;

            try
            {
                system = new FontSystem(
                    vector2Factory,
                    bufferDescriptionFactory,
                    fontContentFactory,
                    fontFactory,
                    fontPackerFactory,
                    textureContentFactory,
                    path,
                    world);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return system;
        }
    }
}