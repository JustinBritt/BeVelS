namespace BeVelS.ECS.Systems.InterfacesFactories
{
    using DefaultEcs.System;

    public interface ISequentialSystemFactory
    {
        ISystem<T> Create<T>(
            params ISystem<T>[] systems);
    }
}