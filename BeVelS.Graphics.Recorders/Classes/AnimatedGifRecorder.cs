namespace BeVelS.Graphics.Recorders.Classes
{
    using System.IO;
    using System.Threading.Tasks;

    using SixLabors.ImageSharp;
    using SixLabors.ImageSharp.Formats.Gif;
    using SixLabors.ImageSharp.PixelFormats;

    using BeVelS.Graphics.Recorders.Interfaces;

    internal sealed class AnimatedGifRecorder : IAnimatedGifRecorder
    {
        public AnimatedGifRecorder(
            int height,
            int width)
        {
            this.AnimatedGif = new Image<Rgba32>(
                width: width,
                height: height);

            // https://github.com/SixLabors/ImageSharp/issues/942#issuecomment-506094151
            this.AnimatedGif.Metadata.GetFormatMetadata(GifFormat.Instance).ColorTableMode = GifColorTableMode.Local;
        }

        public Image AnimatedGif { get; private set; }

        public void AddFrame(
            ImageFrame imageFrame)
        {
            this.AnimatedGif.Frames.AddFrame(
                imageFrame);
        }

        public void AddImage(
            Image image)
        {
            this.AddFrame(
                image.Frames[0]);
        }

        // https://stackoverflow.com/questions/61563814/net-core-api-saving-image-upload-asynchronously-with-imagesharp-memorystream-a
        public Task Save(
            string path)
        {
            return Task.Run(async () =>
            {
                using (MemoryStream memoryStream = new MemoryStream())
                using (FileStream fileStream = File.OpenWrite(path))
                {
                    this.AnimatedGif.SaveAsGif(
                        memoryStream);

                    memoryStream.Seek(
                        0,
                        SeekOrigin.Begin);

                    await memoryStream.CopyToAsync(fileStream).ConfigureAwait(false);

                    fileStream.Flush();

                    memoryStream.Close();

                    fileStream.Close();
                }
            });
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                this.AnimatedGif.Dispose();
            }
        }
    }
}