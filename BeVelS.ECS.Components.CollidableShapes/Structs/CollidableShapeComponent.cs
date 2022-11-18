namespace BeVelS.ECS.Components.CollidableShapes.Structs
{
    using BepuPhysics;
    using BepuPhysics.Collidables;

    public struct CollidableShapeComponent
    {
        public CollidableShapeComponent(
            CollidableReference collidableReference,
            IShape shape,
            Simulation simulation)
        {
            this.CollidableReference = collidableReference;

            this.Shape = shape;

            this.Simulation = simulation;
        }

        public CollidableReference CollidableReference { get; set; }

        public IShape Shape { get; set; }

        public Simulation Simulation { get; set; }
    }
}