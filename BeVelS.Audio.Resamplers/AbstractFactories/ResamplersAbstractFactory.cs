namespace BeVelS.Audio.Resamplers.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Audio.Resamplers.Factories;
    using BeVelS.Audio.Resamplers.InterfacesAbstractFactories;
    using BeVelS.Audio.Resamplers.InterfacesFactories;

    public sealed class ResamplersAbstractFactory : IResamplersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResamplersAbstractFactory()
        {
        }

        public IWdlResamplingSampleProviderFactory CreateWdlResamplingSampleProviderFactory()
        {
            IWdlResamplingSampleProviderFactory factory = null;

            try
            {
                factory = new WdlResamplingSampleProviderFactory();
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