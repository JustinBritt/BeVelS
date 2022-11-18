namespace BeVelS.Common.Utilities.Classes
{
    using System;
    using System.Diagnostics;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/Helpers.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Moved message to const string")]
    public static class DisposeUtilities
    {
        private const string undisposed = "An object was not disposed prior to finalization. It is of type ";

        [Conditional("DEBUG")]
        public static void CheckForUndisposed(
            bool disposed,
            object o)
        {
            Debug.Assert(
                disposed,
                undisposed + o.GetType());
        }

        public static void Dispose<T>(
            ref T disposable)
            where T : IDisposable
        {
            if (disposable != null)
                disposable.Dispose();
            disposable = default(T);
        }
    }
}