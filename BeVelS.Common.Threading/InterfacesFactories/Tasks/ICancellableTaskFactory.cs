namespace BeVelS.Common.Threading.InterfacesFactories.Tasks
{
    using System;

    using BeVelS.Common.Threading.Interfaces.Tasks;

    public interface ICancellableTaskFactory
    {
        ICancellableTask Create(
            Action action);
    }
}