namespace BeVelS.Common.Vectors.Factories
{
    using System.Numerics;

    using log4net;

    using BeVelS.Common.Vectors.InterfacesFactories;
    using System;

    internal sealed class Vector3Factory : IVector3Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Vector3Factory()
        {
        }

        public Vector3 Create()
        {
            Vector3 vector3 = default;

            try
            {
                vector3 = new Vector3();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return vector3;
        }

        public Vector3 Create(
            float x,
            float y,
            float z)
        {
            Vector3 vector3 = default;

            try
            {
                vector3 = new Vector3(
                    x: x,
                    y: y,
                    z: z);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return vector3;
        }

        public Vector3 Create(
            Vector2 xy,
            float z)
        {
            Vector3 vector3 = default;

            try
            {
                vector3 = new Vector3(
                    value: xy,
                    z: z);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return vector3;
        }
    }
}