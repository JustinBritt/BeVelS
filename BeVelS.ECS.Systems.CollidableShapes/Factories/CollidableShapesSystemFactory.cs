namespace BeVelS.ECS.Systems.CollidableShapes.Factories
{
    using System;

    using log4net;

    using DefaultEcs;
    using DefaultEcs.Threading;

    using BeVelS.ECS.Systems.CollidableShapes.Classes;
    using BeVelS.ECS.Systems.CollidableShapes.Interfaces;
    using BeVelS.ECS.Systems.CollidableShapes.InterfacesFactories;

    using BeVelS.Graphics.Shapes.InterfacesFactories;

    internal sealed class CollidableShapesSystemFactory : ICollidableShapesSystemFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CollidableShapesSystemFactory()
        {
        }

        public ICollidableShapesSystem Create(
            IShapeInstanceFactory shapeInstanceFactory,
            IParallelRunner parallelRunner,
            World world)
        {
            ICollidableShapesSystem system = null;

            try
            {
                system = new CollidableShapesSystem(
                    shapeInstanceFactory,
                    parallelRunner,
                    world);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return system;
        }
    }
}