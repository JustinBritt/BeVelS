namespace BeVelS.ECS.Systems.Viewports.Interfaces
{
    using DefaultEcs.System;

    public interface IViewportSystem : ISystem<float>
    {
        void PostUpdate(
            float state);
    }
}