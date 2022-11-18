namespace BeVelS.Physics.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BepuPhysics;
    using BepuPhysics.Collidables;

    using BeVelS.Physics.InterfacesFactories;

    internal sealed class StaticDescriptionFactory : IStaticDescriptionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public StaticDescriptionFactory()
        {
        }

        public StaticDescription Create(
            RigidPose rigidPose,
            TypedIndex shape)
        {
            StaticDescription staticDescription = default;

            try
            {
                staticDescription = new StaticDescription(
                    pose: rigidPose,
                    shape: shape);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return staticDescription;
        }
    }
}