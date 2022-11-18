namespace BeVelS.Physics.Constraints.InterfacesAbstractFactories
{
    using BeVelS.Physics.Constraints.InterfacesFactories;

    public interface IConstraintsAbstractFactory
    {
        IBallSocketFactory CreateBallSocketFactory();

        ILineExtractorFactory CreateLineExtractorFactory();

        IPointOnLineServoFactory CreatePointOnLineServoFactory();

        ISpringSettingsFactory CreateSpringSettingsFactory();
    }
}