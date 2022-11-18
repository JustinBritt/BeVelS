namespace BeVelS.ECS.Systems.Factories
{
    using System;

    using log4net;

    using DefaultEcs.System;

    using BeVelS.ECS.Systems.InterfacesFactories;

    internal sealed class SequentialSystemFactory : ISequentialSystemFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SequentialSystemFactory()
        {
        }

        public ISystem<T> Create<T>(
            params ISystem<T>[] systems)
        {
            ISystem<T> system = null;

            try
            {
                system = new SequentialSystem<T>(
                    systems);
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