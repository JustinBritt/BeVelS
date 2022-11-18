namespace BeVelS.Graphics.Recorders.Interfaces
{
    using System;
    using System.Threading.Tasks;

    using SixLabors.ImageSharp;
    using SixLabors.ImageSharp.PixelFormats;

    public interface IAnimatedGifRecorder : IDisposable
    {
        Image AnimatedGif { get; }

        void AddImage(
            Image image);

        Task Save(
            string path);
    }
}