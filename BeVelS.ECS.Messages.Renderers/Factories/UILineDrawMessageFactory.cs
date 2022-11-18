namespace BeVelS.ECS.Messages.Renderers.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BeVelS.ECS.Messages.Renderers.InterfacesFactories;
    using BeVelS.ECS.Messages.Renderers.Structs;

    internal sealed class UILineDrawMessageFactory : IUILineDrawMessageFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public UILineDrawMessageFactory()
        {
        }

        public UILineDrawMessage Create(
            Vector3 color,
            Vector2 end,
            float radius,
            Vector2 start)
        {
            UILineDrawMessage message = default;

            try
            {
                message = new UILineDrawMessage(
                    color: color,
                    end: end,
                    radius: radius,
                    start: start);
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