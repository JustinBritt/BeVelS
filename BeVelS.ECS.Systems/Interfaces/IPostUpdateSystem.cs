namespace BeVelS.ECS.Systems.Interfaces
{
    using DefaultEcs.System;

    public interface IPostUpdateSystem<T> : ISystem<T>
    {
        void PostUpdate(
            T state);
    }
}