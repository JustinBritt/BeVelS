namespace BeVelS.Graphics.PostProcessors.AbstractFactories
{
    using System;

    using log4net;
    
    using BeVelS.Graphics.PostProcessors.Factories;
    using BeVelS.Graphics.PostProcessors.InterfacesAbstractFactories;
    using BeVelS.Graphics.PostProcessors.InterfacesFactories;

    public sealed class PostProcessorsAbstractFactory : IPostProcessorsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PostProcessorsAbstractFactory()
        {
        }

        public ICompressToSwapFactory CreateCompressToSwapFactory()
        {
            ICompressToSwapFactory factory = null;

            try
            {
                factory = new CompressToSwapFactory();
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