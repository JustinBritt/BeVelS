namespace BeVelS.Graphics.BufferConstants.Factories.FragmentConstants
{
    using System;
    using System.Numerics;

    using log4net;

    using BeVelS.Graphics.BufferConstants.InterfacesFactories.FragmentConstants;
    using BeVelS.Graphics.BufferConstants.Structs.FragmentConstants;

    internal sealed class CapsuleFragmentConstantsFactory : ICapsuleFragmentConstantsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CapsuleFragmentConstantsFactory()
        {
        }

        public CapsuleFragmentConstants Create(
            Vector3 cameraBackward,
            Vector3 cameraRight,
            Vector3 cameraUp,
            float farClip,
            float nearClip,
            Vector2 pixelSizeAtUnitPlane)
        {
            CapsuleFragmentConstants fragmentConstants = default;

            try
            {
                fragmentConstants.CameraBackward = cameraBackward;

                fragmentConstants.CameraRight = cameraRight;

                fragmentConstants.CameraUp = cameraUp;

                fragmentConstants.FarClip = farClip;

                fragmentConstants.NearClip = nearClip;

                fragmentConstants.PixelSizeAtUnitPlane = pixelSizeAtUnitPlane;
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return fragmentConstants;
        }
    }
}