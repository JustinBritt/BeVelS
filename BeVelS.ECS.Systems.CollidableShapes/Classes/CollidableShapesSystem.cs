namespace BeVelS.ECS.Systems.CollidableShapes.Classes
{
    using BepuPhysics.Collidables;
    using BepuPhysics.ECS.Components.Structs.Collidables;

    using DefaultEcs;
    using DefaultEcs.System;
    using DefaultEcs.Threading;

    using BeVelS.ECS.Components.CollidableShapes.Structs;
    using BeVelS.ECS.Components.Shapes.Structs;
    using BeVelS.ECS.Systems.CollidableShapes.Interfaces;
    
    using BeVelS.Graphics.Shapes.InterfacesFactories;

    [With(
        typeof(CollidableMobilityComponent),
        typeof(CollidableShapeComponent),
        typeof(ShapeInstanceComponent),
        typeof(TShapeComponent))]
    internal sealed class CollidableShapesSystem : AEntitySetSystem<float>, ICollidableShapesSystem
    {
        public CollidableShapesSystem(
            IShapeInstanceFactory shapeInstanceFactory,
            IParallelRunner parallelRunner,
            World world)
            :
            base(
                world,
                parallelRunner)
        {
            this.ShapeInstanceFactory = shapeInstanceFactory;

            this.World.Subscribe(
                this);
        }

        private IShapeInstanceFactory ShapeInstanceFactory { get; }

        protected override void Update(
            float state,
            in Entity entity)
        {
            if (this.IsEnabled)
            {
                ref CollidableMobilityComponent collidableMobilityComponent = ref entity.Get<CollidableMobilityComponent>();

                if (collidableMobilityComponent.Value != CollidableMobility.Static)
                {
                    ref CollidableShapeComponent collidableShapeComponent = ref entity.Get<CollidableShapeComponent>();

                    ref ShapeInstanceComponent shapeInstanceComponent = ref entity.Get<ShapeInstanceComponent>();

                    ref TShapeComponent TShapeComponent = ref entity.Get<TShapeComponent>();

                    shapeInstanceComponent.Value = this.ShapeInstanceFactory.Create(
                        collidableShapeComponent.CollidableReference,
                        TShapeComponent.Value,
                        collidableShapeComponent.Simulation);
                }
            }
        }
    }
}