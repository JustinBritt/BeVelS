namespace BeVelS.ECS.Components.Shapes.Factories
{
    using System;

    using log4net;

    using BeVelS.ECS.Components.Shapes.InterfacesFactories;
    using BeVelS.ECS.Components.Shapes.Structs;

    using BeVelS.Graphics.Shapes.Structs;

    internal sealed class BigCompoundInstanceComponentFactory : IBigCompoundInstanceComponentFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BigCompoundInstanceComponentFactory()
        {
        }

        public BigCompoundInstanceComponent Create(
            BigCompoundInstance value)
        {
            BigCompoundInstanceComponent component = default;

            try
            {
                component = new BigCompoundInstanceComponent(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return component;
        }
    }
}