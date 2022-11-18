namespace BeVelS.Graphics.PostProcessors.InterfacesAbstractFactories
{
    using BeVelS.Graphics.PostProcessors.InterfacesFactories;

    public interface IPostProcessorsAbstractFactory
    {
        ICompressToSwapFactory CreateCompressToSwapFactory();
    }
}