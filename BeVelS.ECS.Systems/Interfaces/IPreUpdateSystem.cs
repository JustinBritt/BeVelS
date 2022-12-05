namespace BeVelS.ECS.Systems.Interfaces
{
    using DefaultEcs.System;

    public interface IPreUpdateSystem<T> : ISystem<T>
    {
        void PreUpdate(
            T state);
    }
}