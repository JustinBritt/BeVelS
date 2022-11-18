namespace BeVelS.Graphics.VertexLayouts.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.VertexLayouts.Factories.Descriptions;
    using BeVelS.Graphics.VertexLayouts.InterfacesAbstractFactories;
    using BeVelS.Graphics.VertexLayouts.InterfacesFactories.Descriptions;

    public sealed class VertexLayoutsAbstractFactory : IVertexLayoutsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VertexLayoutsAbstractFactory()
        {
        }

        public IVertexElementDescriptionFactory CreateVertexElementDescriptionFactory()
        {
            IVertexElementDescriptionFactory factory = null;

            try
            {
                factory = new VertexElementDescriptionFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IVertexLayoutDescriptionFactory CreateVertexLayoutDescriptionFactory()
        {
            IVertexLayoutDescriptionFactory factory = null;

            try
            {
                factory = new VertexLayoutDescriptionFactory();
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