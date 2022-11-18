namespace BeVelS.Physics.TimeSteps.Factories
{
    using System;

    using log4net;

    using BeVelS.Physics.TimeSteps.Classes;
    using BeVelS.Physics.TimeSteps.Interfaces;
    using BeVelS.Physics.TimeSteps.InterfacesFactories;

    internal sealed class VariableTimestepFactory : IVariableTimestepFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VariableTimestepFactory()
        {
        }

        public IVariableTimestep Create()
        {
            IVariableTimestep variableTimestep = null;

            try
            {
                variableTimestep = new VariableTimestep();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return variableTimestep;
        }
    }
}