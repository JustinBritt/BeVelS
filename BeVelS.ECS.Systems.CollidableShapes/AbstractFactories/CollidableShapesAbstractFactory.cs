namespace BeVelS.ECS.Systems.CollidableShapes.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Systems.CollidableShapes.Factories;
    using BeVelS.ECS.Systems.CollidableShapes.InterfacesAbstractFactories;
    using BeVelS.ECS.Systems.CollidableShapes.InterfacesFactories;

    public sealed class CollidableShapesAbstractFactory : ICollidableShapesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CollidableShapesAbstractFactory()
        {
        }

        public ICollidableShapesSystemFactory CreateCollidableShapesSystemFactory()
        {
            ICollidableShapesSystemFactory factory = null;

            try
            {
                factory = new CollidableShapesSystemFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}