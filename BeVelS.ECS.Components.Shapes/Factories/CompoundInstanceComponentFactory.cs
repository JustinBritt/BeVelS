namespace BeVelS.ECS.Components.Shapes.Factories
{
    using System;

    using log4net;

    using BeVelS.ECS.Components.Shapes.InterfacesFactories;
    using BeVelS.ECS.Components.Shapes.Structs;

    using BeVelS.Graphics.Shapes.Structs;

    internal sealed class CompoundInstanceComponentFactory : ICompoundInstanceComponentFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CompoundInstanceComponentFactory()
        {
        }

        public CompoundInstanceComponent Create(
            CompoundInstance value)
        {
            CompoundInstanceComponent component = default;

            try
            {
                component = new CompoundInstanceComponent(
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