namespace BeVelS.Windows.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Windows.InterfacesAbstractFactories;

    public sealed class BeVelSWindowsAbstractFactory : IBeVelSWindowsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BeVelSWindowsAbstractFactory()
        {
        }

        public static IBeVelSWindowsAbstractFactory Create()
        {
            return new BeVelSWindowsAbstractFactory();
        }

        public BeVelS.Audio.Devices.Windows.InterfacesAbstractFactories.IDevicesAbstractFactory CreateAudioDevicesWindowsAbstractFactory()
        {
            BeVelS.Audio.Devices.Windows.InterfacesAbstractFactories.IDevicesAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.Audio.Devices.Windows.AbstractFactories.DevicesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Components.Hosts.Windows.InterfacesAbstractFactories.IHostsWindowsAbstractFactory CreateECSComponentsHostsWindowsAbstractFactory()
        {
            BeVelS.ECS.Components.Hosts.Windows.InterfacesAbstractFactories.IHostsWindowsAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Components.Hosts.Windows.AbstractFactories.HostsWindowsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Components.Inputs.Windows.InterfacesAbstractFactories.IInputsWindowsAbstractFactory CreateECSComponentsInputsWindowsAbstractFactory()
        {
            BeVelS.ECS.Components.Inputs.Windows.InterfacesAbstractFactories.IInputsWindowsAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Components.Inputs.Windows.AbstractFactories.InputsWindowsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Messages.Hosts.Windows.InterfacesAbstractFactories.IHostsWindowsAbstractFactory CreateECSMessagesHostsWindowsAbstractFactory()
        {
            BeVelS.ECS.Messages.Hosts.Windows.InterfacesAbstractFactories.IHostsWindowsAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Messages.Hosts.Windows.AbstractFactories.HostsWindowsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Messages.Inputs.Windows.InterfacesAbstractFactories.IInputsWindowsAbstractFactory CreateECSMessagesInputsWindowsAbstractFactory()
        {
            BeVelS.ECS.Messages.Inputs.Windows.InterfacesAbstractFactories.IInputsWindowsAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Messages.Inputs.Windows.AbstractFactories.InputsWindowsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Systems.Controls.Windows.InterfacesAbstractFactories.IControlsWindowsAbstractFactory CreateECSSystemsControlsWindowsAbstractFactory()
        {
            BeVelS.ECS.Systems.Controls.Windows.InterfacesAbstractFactories.IControlsWindowsAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Systems.Controls.Windows.AbstractFactories.ControlsWindowsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Systems.Hosts.Windows.InterfacesAbstractFactories.IHostsWindowsAbstractFactory CreateECSSystemsHostsWindowsAbstractFactory()
        {
            BeVelS.ECS.Systems.Hosts.Windows.InterfacesAbstractFactories.IHostsWindowsAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Systems.Hosts.Windows.AbstractFactories.HostsWindowsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Systems.Inputs.Windows.InterfacesAbstractFactories.IInputsWindowsAbstractFactory CreateECSSystemsInputsWindowsAbstractFactory()
        {
            BeVelS.ECS.Systems.Inputs.Windows.InterfacesAbstractFactories.IInputsWindowsAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Systems.Inputs.Windows.AbstractFactories.InputsWindowsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}