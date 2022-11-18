namespace BeVelS.Graphics.Meshes.Factories
{
    using System;

    using log4net;

    using Veldrid;

    using BepuUtilities.Memory;

    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Meshes.Classes;
    using BeVelS.Graphics.Meshes.Interfaces;
    using BeVelS.Graphics.Meshes.InterfacesFactories;

    internal sealed class MeshCacheFactory : IMeshCacheFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MeshCacheFactory()
        {
        }

        public IMeshCache Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            BufferPool pool,
            int initialSizeInVertices = 1 << 22)
        {
            IMeshCache meshCache = null;

            try
            {
                meshCache = new MeshCache(
                    bufferDescriptionFactory,
                    graphicsDevice,
                    pool,
                    initialSizeInVertices);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return meshCache;
        }
    }
}