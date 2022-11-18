namespace BeVelS.Graphics.UILines.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BeVelS.Graphics.UILines.InterfacesFactories;
    using BeVelS.Graphics.UILines.Structs;

    internal sealed class UILineInstanceFactory : IUILineInstanceFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public UILineInstanceFactory()
        {
        }

        public UILineInstance Create(
            Vector3 color,
            Vector2 end,
            float radius,
            Vector2 screenToPackedScale,
            Vector2 start)
        {
            UILineInstance UILineInstance = default;

            try
            {
                UILineInstance = new UILineInstance(
                    start,
                    end,
                    radius,
                    color,
                    screenToPackedScale);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return UILineInstance;
        }
    }
}