namespace BeVelS.Graphics.HTML.Classes
{
    using System;

    using UltralightNet;

    using Veldrid;

    using BeVelS.Graphics.HTML.Interfaces;
    
    internal sealed class HTMLTexture : IHTMLTexture
    {
        public HTMLTexture(
            ULBitmap[] ULBitmaps)
        {
            this.ULBitmaps = ULBitmaps;

            this.Format = PixelFormat.R8_G8_B8_A8_UNorm_SRgb;
        }

        private ULBitmap[] ULBitmaps { get; }

        private PixelFormat Format { get; }

        private uint Height => (uint)ULBitmaps[0].Height;

        private uint MipLevels => (uint)ULBitmaps.Length;

        private uint PixelSizeInBytes => sizeof(byte) * ULBitmaps[0].Bpp;

        private uint Width => (uint)ULBitmaps[0].Width;

        public unsafe Texture CreateTexture(
            GraphicsDevice graphicsDevice)
        {
            Texture texture = graphicsDevice.ResourceFactory.CreateTexture(
                TextureDescription.Texture2D(
                width: this.Width,
                height: this.Height,
                mipLevels: this.MipLevels,
                arrayLayers: 1,
                format: this.Format,
                usage: TextureUsage.Sampled));
            
            for (uint mipLevel = 0; mipLevel < this.MipLevels; mipLevel = mipLevel + 1)
            {
                ULBitmap ULBitmap = this.ULBitmaps[mipLevel];

                if (ULBitmap.Format == ULBitmapFormat.BGRA8_UNORM_SRGB && this.Format == PixelFormat.R8_G8_B8_A8_UNorm_SRgb)
                {
                    ULBitmap.SwapRedBlueChannels();
                }

                byte * lockedPixels = ULBitmap.LockPixels();

                graphicsDevice.UpdateTexture(
                    texture: texture,
                    source: (IntPtr)ULBitmap.RawPixels,
                    sizeInBytes: this.PixelSizeInBytes * ULBitmap.Width * ULBitmap.Height,
                    x: 0,
                    y: 0,
                    z: 0,
                    width: ULBitmap.Width,
                    height: ULBitmap.Height,
                    depth: 1,
                    mipLevel: mipLevel,
                    arrayLayer: 0);

                ULBitmap.UnlockPixels();
            }

            return texture;
        }
    }
}