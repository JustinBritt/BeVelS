namespace BeVelS.ECS.Components.Shapes.Factories
{
    using System;

    using log4net;

    using BeVelS.ECS.Components.Shapes.InterfacesFactories;
    using BeVelS.ECS.Components.Shapes.Structs;

    internal sealed class TShapeInstanceComponentFactory : ITShapeInstanceComponentFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TShapeInstanceComponentFactory()
        {
        }

        public TShapeInstanceComponent Create(
            Type value)
        {
            TShapeInstanceComponent component = default;

            try
            {
                component = new TShapeInstanceComponent(
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