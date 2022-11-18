namespace BeVelS.Graphics.KTX.Factories
{
    using System;

    using log4net;

    using BeVelS.Graphics.KTX.Classes;
    using BeVelS.Graphics.KTX.Interfaces;
    using BeVelS.Graphics.KTX.InterfacesFactories;
    using BeVelS.Graphics.KTX.Structs;

    internal sealed class KTXFileFactory : IKTXFileFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public KTXFileFactory()
        {
        }

        public IKTXFile Create(
            KTXHeader header,
            IKTXKeyValuePair[] keyValuePairs,
            IKTXMipmapLevel[] mipmaps)
        {
            IKTXFile KTXFile = null;

            try
            {
                KTXFile = new KTXFile(
                    header,
                    keyValuePairs,
                    mipmaps);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return KTXFile;
        }
    }
}