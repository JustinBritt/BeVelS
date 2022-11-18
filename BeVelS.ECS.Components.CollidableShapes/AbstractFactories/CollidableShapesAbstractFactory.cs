namespace BeVelS.ECS.Components.CollidableShapes.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Components.CollidableShapes.Factories;
    using BeVelS.ECS.Components.CollidableShapes.InterfacesAbstractFactories;
    using BeVelS.ECS.Components.CollidableShapes.InterfacesFactories;

    public sealed class CollidableShapesAbstractFactory : ICollidableShapesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CollidableShapesAbstractFactory()
        {
        }

        public ICollidableShapeComponentFactory CreateCollidableShapeComponentFactory()
        {
            ICollidableShapeComponentFactory factory = null;

            try
            {
                factory = new CollidableShapeComponentFactory();
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