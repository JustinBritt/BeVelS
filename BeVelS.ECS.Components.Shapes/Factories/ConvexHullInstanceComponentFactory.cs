namespace BeVelS.ECS.Components.Shapes.Factories
{
    using System;

    using log4net;

    using BeVelS.ECS.Components.Shapes.InterfacesFactories;
    using BeVelS.ECS.Components.Shapes.Structs;

    using BeVelS.Graphics.Shapes.Structs;

    internal sealed class ConvexHullInstanceComponentFactory : IConvexHullInstanceComponentFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConvexHullInstanceComponentFactory()
        {
        }

        public ConvexHullInstanceComponent Create(
            ConvexHullInstance value)
        {
            ConvexHullInstanceComponent component = default;

            try
            {
                component = new ConvexHullInstanceComponent(
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