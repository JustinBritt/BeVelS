namespace BeVelS.ECS.Messages.Renderers.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.ECS.Messages.Renderers.InterfacesFactories;
    using BeVelS.ECS.Messages.Renderers.Structs;

    using BeVelS.Graphics.Fonts.Interfaces;
    using BeVelS.Graphics.Text.Interfaces;

    internal sealed class TextBuilderWriteMessageFactory : ITextBuilderWriteMessageFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TextBuilderWriteMessageFactory()
        {
        }

        public TextBuilderWriteMessage Create(
            IVector2Factory vector2Factory,
            IVector4Factory vector4Factory,
            Vector3 color,
            IFont font,
            float height,
            Vector2 horizontalAxis,
            Vector2 targetPosition,
            ITextBuilder textBuilder)
        {
            TextBuilderWriteMessage message = default;

            try
            {
                message = new TextBuilderWriteMessage(
                    vector2Factory: vector2Factory,
                    vector4Factory: vector4Factory,
                    color: color,
                    font: font,
                    height: height,
                    horizontalAxis: horizontalAxis,
                    targetPosition: targetPosition,
                    textBuilder: textBuilder);
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