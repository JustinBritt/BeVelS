namespace BeVelS.Graphics.Recorders.Classes
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using SixLabors.ImageSharp;
    using SixLabors.ImageSharp.ColorSpaces.Companding;
    using SixLabors.ImageSharp.PixelFormats;

    using Veldrid;

    using BeVelS.Common.Utilities.Classes;

    using BeVelS.Graphics.Recorders.Interfaces;

    internal sealed class FrameRecorder : IFrameRecorder
    {
        public FrameRecorder(
            GraphicsDevice graphicsDevice,
            Texture sourceTexture)
        {
            this.StagingTexture = this.CreateStagingTexture2D(
                graphicsDevice,
                sourceTexture);
        }

        public Texture StagingTexture { get; private set; }

        public void CopyToStagingTexture(
            CommandList commandList,
            GraphicsDevice graphicsDevice,
            Texture sourceTexture)
        {
            if (sourceTexture.Height != this.StagingTexture.Height || sourceTexture.Width != this.StagingTexture.Width)
            {
                this.StagingTexture = this.CreateStagingTexture2D(
                    graphicsDevice,
                    sourceTexture);
            }

            commandList.CopyTexture(
                source: sourceTexture,
                destination: this.StagingTexture);
        }

        private Texture CreateStagingTexture2D(
            GraphicsDevice graphicsDevice,
            Texture sourceTexture)
        {
            return graphicsDevice.ResourceFactory.CreateTexture(
                TextureDescription.Texture2D(
                    width: sourceTexture.Width,
                    height: sourceTexture.Height,
                    mipLevels: sourceTexture.MipLevels,
                    arrayLayers: sourceTexture.ArrayLayers,
                    format: sourceTexture.Format,
                    usage: TextureUsage.Staging));
        }

        private IPixel gamma(
            IPixel value)
        {
            IPixel gammaCorrected = default;

            Vector4 scaled = value.ToScaledVector4();

            SRgbCompanding.Compress(
                ref scaled);

            gammaCorrected.FromVector4(
                scaled);

            return gammaCorrected;
        }

        private unsafe ReadOnlySpan<T> GetData<T>(
            GraphicsDevice graphicsDevice,
            Texture texture)
            where T : unmanaged
        {
            MappedResourceView<T> map = graphicsDevice.Map<T>(
                texture,
                MapMode.Read);

            Span<T> data = (Span<T>)Array.CreateInstance(
                typeof(T),
                (uint)sizeof(T) * texture.Height * texture.Width);

            fixed (T * pin = &MemoryMarshal.GetReference(data))
            {
                for (uint y = 0; y < texture.Height; y = y + 1)
                {
                    Unsafe.CopyBlock(
                        destination: pin + y * texture.Width,
                        source: (T*)map.MappedResource.Data.ToPointer() + y * map.MappedResource.RowPitch / (uint)sizeof(T),
                        byteCount: texture.Width * (uint)sizeof(T));
                }
            }
                
            graphicsDevice.Unmap(
                texture);

            return data;
        }

        public Image GetImage(
            GraphicsDevice graphicsDevice,
            Texture sourceTexture)
        {
            return sourceTexture.Format switch
            {
                PixelFormat.B8_G8_R8_A8_UNorm => Image.LoadPixelData(
                    this.GetData<Bgra32>(
                        graphicsDevice,
                        sourceTexture),
                    (int)sourceTexture.Width,
                    (int)sourceTexture.Height),

                PixelFormat.R8_G8_B8_A8_UNorm => Image.LoadPixelData(
                    this.GetData<Rgba32>(
                        graphicsDevice,
                        sourceTexture),
                    (int)sourceTexture.Width,
                    (int)sourceTexture.Height),

                _ => throw new NotSupportedException()
            };
        }


        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                if (this.StagingTexture != null && !this.StagingTexture.IsDisposed)
                {
                    this.StagingTexture.Dispose();
                }
            }
        }

#if DEBUG
        ~FrameRecorder()
        {
            DisposeUtilities.CheckForUndisposed(
                disposed,
                this);
        }
#endif
    }
}