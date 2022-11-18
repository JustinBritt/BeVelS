namespace BeVelS.Physics.Collidables.Factories
{
    using System;

    using log4net;

    using BepuPhysics.Collidables;

    using BeVelS.Physics.Collidables.InterfacesFactories;

    internal sealed class BoxFactory : IBoxFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BoxFactory()
        {
        }

        public Box Create(
            float width,
            float height,
            float length)
        {
            Box box = default;

            try
            {
                box = new Box(
                    width: width,
                    height: height,
                    length: length);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return box;
        }
    }
}