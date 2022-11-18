namespace BeVelS.Graphics.HTML.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BeVelS.Graphics.HTML.InterfacesFactories;
    using BeVelS.Graphics.HTML.Structs;

    internal sealed class HTMLInstanceFactory : IHTMLInstanceFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HTMLInstanceFactory()
        {
        }

        public HTMLInstance Create(
            Vector2 start,
            Vector2 horizontalAxis,
            Vector2 size,
            Vector4 color,
            Vector2 screenToPackedScale)
        {
            HTMLInstance instance = default;

            try
            {
                instance = new HTMLInstance(
                    start: start,
                    horizontalAxis: horizontalAxis,
                    size: size,
                    color: color,
                    screenToPackedScale: screenToPackedScale);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }
    }
}