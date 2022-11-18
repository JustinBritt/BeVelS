namespace BeVelS.Common.Threading.InterfacesFactories
{
    using System.Threading;

    public interface ICancellationTokenSourceFactory
    {
        CancellationTokenSource Create();
    }
}