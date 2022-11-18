namespace BeVelS.Physics.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Physics.Factories;
    using BeVelS.Physics.InterfacesAbstractFactories;
    using BeVelS.Physics.InterfacesFactories;

    public sealed class PhysicsAbstractFactory : IPhysicsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PhysicsAbstractFactory()
        {
        }

        public IBodyActivityDescriptionFactory CreateBodyActivityDescriptionFactory()
        {
            IBodyActivityDescriptionFactory factory = null;

            try
            {
                factory = new BodyActivityDescriptionFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IBodyDescriptionFactory CreateBodyDescriptionFactory()
        {
            IBodyDescriptionFactory factory = null;

            try
            {
                factory = new BodyDescriptionFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IBodyInertiaFactory CreateBodyInertiaFactory()
        {
            IBodyInertiaFactory factory = null;

            try
            {
                factory = new BodyInertiaFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IBodyVelocityFactory CreateBodyVelocityFactory()
        {
            IBodyVelocityFactory factory = null;

            try
            {
                factory = new BodyVelocityFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraintHandleFactory CreateConstraintHandleFactory()
        {
            IConstraintHandleFactory factory = null;

            try
            {
                factory = new ConstraintHandleFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IDefaultTimestepperFactory CreateDefaultTimestepperFactory()
        {
            IDefaultTimestepperFactory factory = null;

            try
            {
                factory = new DefaultTimestepperFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IRigidPoseFactory CreateRigidPoseFactory()
        {
            IRigidPoseFactory factory = null;

            try
            {
                factory = new RigidPoseFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISolveDescriptionFactory CreateSolveDescriptionFactory()
        {
            ISolveDescriptionFactory factory = null;

            try
            {
                factory = new SolveDescriptionFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IStaticDescriptionFactory CreateStaticDescriptionFactory()
        {
            IStaticDescriptionFactory factory = null;

            try
            {
                factory = new StaticDescriptionFactory();
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