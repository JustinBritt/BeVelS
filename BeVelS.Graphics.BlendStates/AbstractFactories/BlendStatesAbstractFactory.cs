namespace BeVelS.Graphics.BlendStates.AbstractFactories
{
    using System;
    
    using log4net;

    using BeVelS.Graphics.BlendStates.Factories.Descriptions;
    using BeVelS.Graphics.BlendStates.InterfacesAbstractFactories;
    using BeVelS.Graphics.BlendStates.InterfacesFactories.Descriptions;

    public sealed class BlendStatesAbstractFactory : IBlendStatesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BlendStatesAbstractFactory()
        {
        }

        public IBlendAttachmentDescriptionFactory CreateBlendAttachmentDescriptionFactory()
        {
            IBlendAttachmentDescriptionFactory factory = null;

            try
            {
                factory = new BlendAttachmentDescriptionFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IBlendStateDescriptionFactory CreateBlendStateDescriptionFactory()
        {
            IBlendStateDescriptionFactory factory = null;

            try
            {
                factory = new BlendStateDescriptionFactory();
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