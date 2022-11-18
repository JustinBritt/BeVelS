namespace BeVelS.Graphics.Recorders.Classes.Configurations
{
    using System;

    using BeVelS.Graphics.Recorders.Interfaces.Configurations;

    internal sealed class AnimatedGifRecorderConfiguration : IAnimatedGifRecorderConfiguration
    {
        private const string fileExtension = ".gif";

        public AnimatedGifRecorderConfiguration(
            string outputDirectory)
        {
            this.OutputDirectory = outputDirectory;

            this.Guid = Guid.NewGuid();

            this.OutputPath = this.OutputDirectory + this.Guid + fileExtension;
        }

        public Guid Guid { get; }

        public string OutputDirectory { get; }

        public string OutputPath { get; }
    }
}