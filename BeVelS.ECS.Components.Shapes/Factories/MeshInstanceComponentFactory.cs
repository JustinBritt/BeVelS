namespace BeVelS.ECS.Components.Shapes.Factories
{
    using System;

    using log4net;

    using BeVelS.ECS.Components.Shapes.InterfacesFactories;
    using BeVelS.ECS.Components.Shapes.Structs;

    using BeVelS.Graphics.Shapes.Structs;

    internal sealed class MeshInstanceComponentFactory : IMeshInstanceComponentFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MeshInstanceComponentFactory()
        {
        }

        public MeshInstanceComponent Create(
            MeshInstance value)
        {
            MeshInstanceComponent component = default;

            try
            {
                component = new MeshInstanceComponent(
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