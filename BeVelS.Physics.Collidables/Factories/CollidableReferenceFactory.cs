namespace BeVelS.Physics.Collidables.Factories
{
    using System;

    using log4net;

    using BepuPhysics;
    using BepuPhysics.Collidables;

    using BeVelS.Physics.Collidables.InterfacesFactories;
    
    internal sealed class CollidableReferenceFactory : ICollidableReferenceFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CollidableReferenceFactory()
        {
        }

        public CollidableReference Create(
            StaticHandle staticHandle)
        {
            CollidableReference collidableReference = default;

            try
            {
                collidableReference = new CollidableReference(
                    staticHandle);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return collidableReference;
        }

        public CollidableReference Create(
            CollidableMobility collidableMobility,
            BodyHandle bodyHandle)
        {
            CollidableReference collidableReference = default;

            try
            {
                collidableReference = new CollidableReference(
                    mobility: collidableMobility,
                    handle: bodyHandle);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return collidableReference;
        }
    }
}