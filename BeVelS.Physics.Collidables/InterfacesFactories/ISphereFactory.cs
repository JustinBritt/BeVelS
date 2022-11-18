﻿namespace BeVelS.Physics.Collidables.InterfacesFactories
{
    using BepuPhysics.Collidables;

    public interface ISphereFactory
    {
        Sphere Create(
            float radius);
    }
}