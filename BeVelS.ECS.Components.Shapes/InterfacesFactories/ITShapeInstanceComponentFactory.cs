namespace BeVelS.ECS.Components.Shapes.InterfacesFactories
{
    using System;

    using BeVelS.ECS.Components.Shapes.Structs;
    
    public interface ITShapeInstanceComponentFactory
    {
        TShapeInstanceComponent Create(
            Type value);
    }
}