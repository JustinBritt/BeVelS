namespace BeVelS.ECS.Components.Shapes.InterfacesFactories
{
    using BeVelS.ECS.Components.Shapes.Structs;

    using BeVelS.Graphics.Shapes.Structs;

    public interface ICompoundInstanceComponentFactory
    {
        CompoundInstanceComponent Create(
            CompoundInstance value);
    }
}