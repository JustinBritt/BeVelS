namespace BeVelS.ECS.Components.Fonts.InterfacesAbstractFactories
{
    using BeVelS.ECS.Components.Fonts.InterfacesFactories;

    public interface IFontsAbstractFactory
    {
        IFontComponentFactory CreateFontComponentFactory();
    }
}