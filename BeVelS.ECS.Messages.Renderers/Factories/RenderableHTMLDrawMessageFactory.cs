namespace BeVelS.ECS.Messages.Renderers.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.ECS.Messages.Renderers.InterfacesFactories;
    using BeVelS.ECS.Messages.Renderers.Structs;

    using BeVelS.Graphics.HTML.Interfaces;
    using BeVelS.Graphics.HTML.InterfacesFactories;

    internal sealed class RenderableHTMLDrawMessageFactory : IRenderableHTMLDrawMessageFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RenderableHTMLDrawMessageFactory()
        {
        }

        public RenderableHTMLDrawMessage Create(
            IVector2Factory vector2Factory,
            IHTMLInstanceFactory HTMLInstanceFactory,
            Vector4 color,
            IRenderableHTML renderableHTML,
            Vector2 size,
            Vector2 targetPosition)
        {
            RenderableHTMLDrawMessage message = default;

            try
            {
                message = new RenderableHTMLDrawMessage(
                    vector2Factory: vector2Factory,
                    HTMLInstanceFactory: HTMLInstanceFactory,
                    color: color,
                    renderableHTML: renderableHTML,
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