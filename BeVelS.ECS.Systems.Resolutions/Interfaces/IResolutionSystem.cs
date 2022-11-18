namespace BeVelS.ECS.Systems.Resolutions.Interfaces
{
    using System.Numerics;

    using DefaultEcs.System;

    public interface IResolutionSystem : ISystem<float>
    {
        Vector2 Resolution { get; }
    }
}