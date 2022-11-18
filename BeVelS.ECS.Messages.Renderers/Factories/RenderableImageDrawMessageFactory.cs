namespace BeVelS.ECS.Messages.Renderers.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.ECS.Messages.Renderers.InterfacesFactories;
    using BeVelS.ECS.Messages.Renderers.Structs;
    
    using BeVelS.Graphics.Images.Interfaces;
    using BeVelS.Graphics.Images.InterfacesFactories;
   
    internal sealed class RenderableImageDrawMessageFactory : IRenderableImageDrawMessageFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RenderableImageDrawMessageFactory()
        {
        }

        public RenderableImageDrawMessage Create(
            IVector2Factory vector2Factory,
            IImageInstanceFactory imageInstanceFactory,
            IRenderableImage renderableImage,
            Vector2 size,
            Vector2 targetPosition)
        {
            RenderableImageDrawMessage message = default;

            try
            {
                message = new RenderableImageDrawMessage(
                    vector2Factory: vector2Factory,
                    imageInstanceFactory: imageInstanceFactory,
                    renderableImage: renderableImage,
                    size: size,
                    targetPosition: targetPosition);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return message;
        }
    }
}