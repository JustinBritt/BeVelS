namespace BeVelS.ECS.Systems.CommandLists.Interfaces
{
    using DefaultEcs.System;

    public interface ICommandListsSystem : ISystem<float>
    {
        void PostUpdate(
            float state);
    }
}