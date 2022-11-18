namespace BeVelS.Licensing.Classes
{
    using System;

    [AttributeUsage(AttributeTargets.All)]
    public sealed class BepuPhysicsLicensedCodeAttribute : Attribute
    {
        public const string ApacheLicenseVersion20Boilerplate = @"
Licensed under the Apache License, Version 2.0 (the ""License"");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an ""AS IS"" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.";

        public const string BepuPhysicsCopyrightOwner = "Ross Nordby";

        public const string BepuPhysicsCopyrightYears = "2017 to present";

        public const string FormattingChanges = "Formatting changes";

        public BepuPhysicsLicensedCodeAttribute(
            string boilerplate,
            string copyrightOwner,
            string copyrightYears,
            string source,
            params string[] changes)
        {
            this.Boilerplate = boilerplate;

            this.Changes = changes;

            this.CopyrightOwner = copyrightOwner;

            this.CopyrightYears = copyrightYears;

            this.Source = source;
        }

        public string Boilerplate { get; }

        public string[] Changes { get; }

        public string CopyrightOwner { get; }

        public string CopyrightYears { get; }

        public string Source { get; }
    }
}