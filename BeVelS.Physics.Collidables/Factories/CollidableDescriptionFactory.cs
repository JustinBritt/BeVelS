namespace BeVelS.Physics.Collidables.Factories
{
    using System;

    using log4net;

    using BepuPhysics.Collidables;

    using BeVelS.Physics.Collidables.InterfacesFactories;

    internal sealed class CollidableDescriptionFactory : ICollidableDescriptionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CollidableDescriptionFactory()
        {
        }

        public CollidableDescription Create(
            ContinuousDetection continuousDetection,
            TypedIndex shape,
            float maximumSpeculativeMargin,
            float minimumSpeculativeMargin)
        {
            CollidableDescription collidableDescription = default;

            try
            {
                collidableDescription = new CollidableDescription(
                    shape: shape,
                    minimumSpeculativeMargin: minimumSpeculativeMargin,
                    maximumSpeculativeMargin: maximumSpeculativeMargin,
                    continuity: continuousDetection);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return collidableDescription;
        }
    }
}