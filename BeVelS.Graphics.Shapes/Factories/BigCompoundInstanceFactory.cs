namespace BeVelS.Graphics.Shapes.Factories
{
    using System.Numerics;

    using log4net;

    using BepuPhysics;
    using BepuPhysics.Collidables;

    using BeVelS.Graphics.Shapes.InterfacesFactories;
    using BeVelS.Graphics.Shapes.Structs;

    internal sealed class BigCompoundInstanceFactory : IBigCompoundInstanceFactory
    {
        public BigCompoundInstanceFactory()
        {
        }

        public BigCompoundInstance Create()
        {
            BigCompoundInstance instance = default;

            return instance;
        }

        public BigCompoundInstance Create(
            BigCompound bigCompound,
            RigidPose rigidPose)
        {
            return this.Create();
        }
    }
}