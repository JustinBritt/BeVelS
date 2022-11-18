namespace BeVelS.Common.Meshes.Factories
{
    using System;

    using log4net;

    using BeVelS.Common.Meshes.Classes;
    using BeVelS.Common.Meshes.Interfaces;
    using BeVelS.Common.Meshes.InterfacesFactories;
    using BeVelS.Common.Triangles.Structs;

    internal sealed class MeshContentFactory : IMeshContentFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MeshContentFactory()
        {
        }

        public IMeshContent Create(
            TriangleContent[] triangles)
        {
            IMeshContent meshContent = null;

            try
            {
                meshContent = new MeshContent(
                    triangles);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return meshContent;
        }
    }
}