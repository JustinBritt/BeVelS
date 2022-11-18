namespace BeVelS.ECS.Components.Fonts.InterfacesFactories
{
    using BeVelS.ECS.Components.Fonts.Structs;

    using BeVelS.Graphics.Fonts.Interfaces;

    public interface IFontComponentFactory
    {
        FontComponent Create(
            IFont value);
    }
}