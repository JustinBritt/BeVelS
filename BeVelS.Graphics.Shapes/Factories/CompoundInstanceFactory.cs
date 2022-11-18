namespace BeVelS.Graphics.Shapes.Factories
{
    using System.Numerics;

    using BepuPhysics;
    using BepuPhysics.Collidables;

    using BeVelS.Graphics.Shapes.InterfacesFactories;
    using BeVelS.Graphics.Shapes.Structs;

    internal sealed class CompoundInstanceFactory : ICompoundInstanceFactory
    {
        public CompoundInstanceFactory()
        {
        }

        public CompoundInstance Create()
        {
            CompoundInstance instance = default;

            return instance;
        }

        public CompoundInstance Create(
            Compound compound,
            RigidPose rigidPose)
        {
            return this.Create();
        }
    }
}