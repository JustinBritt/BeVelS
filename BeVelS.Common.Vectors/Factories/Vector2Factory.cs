namespace BeVelS.Common.Vectors.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BeVelS.Common.Vectors.InterfacesFactories;

    internal sealed class Vector2Factory : IVector2Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Vector2Factory()
        {
        }

        public Vector2 Create(
            float value)
        {
            Vector2 vector2 = default;

            try
            {
                vector2 = new Vector2(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return vector2;
        }

        public Vector2 Create(
            float x,
            float y)
        {
            Vector2 vector2 = default;

            try
            {
                vector2 = new Vector2(
                    x: x,
                    y: y);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return vector2;
        }
    }
}