namespace BeVelS.Common.Vectors.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BeVelS.Common.Vectors.InterfacesFactories;

    internal sealed class Vector4Factory : IVector4Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Vector4Factory()
        {
        }

        public Vector4 Create(
            float x,
            float y,
            float z,
            float w)
        {
            Vector4 vector4 = default;

            try
            {
                vector4 = new Vector4(
                    x: x,
                    y: y,
                    z: z,
                    w: w);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return vector4;
        }

        public Vector4 Create(
            Vector3 xyz,
            float w)
        {
            Vector4 vector4 = default;

            try
            {
                vector4 = new Vector4(
                    value: xyz,
                    w: w);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return vector4;
        }
    }
}