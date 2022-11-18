namespace BeVelS.ECS.Components.Shapes.Factories
{
    using System;

    using log4net;

    using BeVelS.ECS.Components.Shapes.InterfacesFactories;
    using BeVelS.ECS.Components.Shapes.Structs;

    using BeVelS.Graphics.Shapes.Interfaces;

    internal sealed class ShapeInstanceComponentFactory : IShapeInstanceComponentFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ShapeInstanceComponentFactory()
        {
        }

        public ShapeInstanceComponent Create(
            IShapeInstance value)
        {
            ShapeInstanceComponent component = default;

            try
            {
                component = new ShapeInstanceComponent(
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