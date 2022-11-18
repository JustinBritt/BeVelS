namespace BeVelS.Graphics.KTX.Factories
{
    using System;

    using log4net;

    using BeVelS.Graphics.KTX.Classes;
    using BeVelS.Graphics.KTX.Interfaces;
    using BeVelS.Graphics.KTX.InterfacesFactories;

    internal sealed class KTXMipmapLevelFactory : IKTXMipmapLevelFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public KTXMipmapLevelFactory()
        {
        }

        public IKTXMipmapLevel Create(
            uint width,
            uint height,
            uint depth,
            uint totalSize,
            uint arraySliceSize,
            IKTXArrayElement[] slices)
        {
            IKTXMipmapLevel KTXMipmapLevel = null;

            try
            {
                KTXMipmapLevel = new KTXMipmapLevel(
                    width: width,
                    height: height,
                    depth: depth,
                    totalSize: totalSize,
                    arraySliceSize: arraySliceSize,
                    slices: slices);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return KTXMipmapLevel;
        }
    }
}