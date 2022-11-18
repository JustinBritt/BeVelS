namespace BeVelS.ECS.Systems.Fonts.Interfaces
{
    using DefaultEcs.System;

    using BeVelS.Graphics.Fonts.Interfaces;

    public interface IFontSystem : ISystem<float>
    {
        IFont Font { get; }
    }
}