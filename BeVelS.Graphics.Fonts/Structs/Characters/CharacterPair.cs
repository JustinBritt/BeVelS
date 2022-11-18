namespace BeVelS.Graphics.Fonts.Structs.Characters
{
    using System;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoContentLoader/FontContent.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges)]
    public struct CharacterPair : IEquatable<CharacterPair>
    {
        public readonly char A;
        public readonly char B;

        public CharacterPair(
            char a,
            char b)
        {
            this.A = a;

            this.B = b;
        }

        // Order matters!
        public bool Equals(
            CharacterPair other)
        {
            return this.A == other.A && this.B == other.B;
        }

        public override int GetHashCode()
        {
            return (this.A * 7919) ^ (this.B * 6263);
        }

        public override string ToString()
        {
            return "{" + this.A + ", " + this.B + "}";
        }
    }
}