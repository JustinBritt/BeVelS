namespace BeVelS.ECS.Systems.Fonts.InterfacesAbstractFactories
{
    using BeVelS.ECS.Systems.Fonts.InterfacesFactories;

    public interface IFontsAbstractFactory
    {
        IFontSystemFactory CreateFontSystemFactory();
    }
}