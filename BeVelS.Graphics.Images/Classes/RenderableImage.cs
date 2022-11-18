namespace BeVelS.Graphics.Images.Classes
{
    using System;
    using System.Diagnostics;

    using Veldrid;
    using Veldrid.ImageSharp;

    using BeVelS.Common.Utilities.Classes;
    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.Images.Interfaces;
    using BeVelS.Graphics.Textures.Interfaces;
    using BeVelS.Graphics.Textures.InterfacesFactories;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/UI/RenderableImage.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges)]
    internal sealed class RenderableImage : IRenderableImage
    {
        public unsafe RenderableImage(
            IVector2Factory vector2Factory,
            ITextureContentFactory textureContentFactory,
            GraphicsDevice graphicsDevice,
            int width,
            int height,
            bool srgb = false)
        {
            this.ImageTexture = this.InitializeTexture(
                graphicsDevice,
                width,
                height,
                srgb);

            this.Content = textureContentFactory.Create(
                vector2Factory: vector2Factory,
                width: width,
                height: height,
                mipLevels: 1,
                texelSizeInBytes: 4);
        }

        public unsafe RenderableImage(
            GraphicsDevice graphicsDevice,
            ITextureContent imageContent,
            bool srgb = false)
        {
            if (imageContent.TexelSizeInBytes != 4)
            {
                throw new ArgumentException(
                    "The renderable image assumes an R8G8B8A8_UNorm or R8G8B8A8_UNorm_SRgb texture.");
            }

            Debug.Assert(
                imageContent.MipLevels == 1,
                "We ignore any mip levels stored in the content; if the content pipeline output them, something's likely mismatched.");

            this.ImageTexture = this.InitializeTexture(
                graphicsDevice,
                imageContent.Width,
                imageContent.Height,
                srgb);

            this.Content = imageContent;

            this.UpdateTexture(
                this.Content,
                graphicsDevice,
                this.ImageTexture);
        }

        public RenderableImage(
            IVector2Factory vector2Factory,
            IImageSharpTextureFactory ImageSharpTextureFactory,
            ITextureContentFactory textureContentFactory,
            GraphicsDevice graphicsDevice,
            string path,
            bool mipmap = false,
            bool srgb = false)
        {
            this.ImageTexture = this.CreateTexture(
                graphicsDevice,
                ImageSharpTextureFactory.Create(
                    graphicsDevice,
                    path,
                    mipmap: mipmap,
                    srgb: srgb));

            this.Content = textureContentFactory.Create(
                vector2Factory: vector2Factory,
                width: (int)this.ImageTexture.Width,
                height: (int)this.ImageTexture.Height,
                mipLevels: 1,
                texelSizeInBytes: 4);
        }

        public ITextureContent Content { get; }

        public Texture ImageTexture { get; }

        private Texture CreateTexture(
            GraphicsDevice graphicsDevice,
            ImageSharpTexture imageSharpTexture)
        {
            return imageSharpTexture.CreateDeviceTexture(
                graphicsDevice,
                graphicsDevice.ResourceFactory);
        }

        private Texture InitializeTexture(
            GraphicsDevice graphicsDevice,
            int width,
            int height,
            bool srgb = false)
        {
            return graphicsDevice.ResourceFactory.CreateTexture(
                TextureDescription.Texture2D(
                    width: (uint)width,
                    height: (uint)height,
                    mipLevels: (uint)MathF.Floor(MathF.Log(MathF.Min(width, height), 2)) + 1,
                    arrayLayers: (uint)1,
                    format: srgb ? PixelFormat.R8_G8_B8_A8_UNorm_SRgb : PixelFormat.R8_G8_B8_A8_UNorm,
                    usage: TextureUsage.GenerateMipmaps | TextureUsage.Storage));
        }

        public unsafe void UpdateTexture(
            ITextureContent content,
            GraphicsDevice graphicsDevice,
            Texture texture)
        {
            byte * data = this.Content.Pin();

            for (int mipLevel = 0; mipLevel < content.MipLevels; mipLevel = mipLevel + 1)
            {
                for (int y = 0; y < content.Dimensions[mipLevel].Y; y = y + 1)
                {
                    for (int x = 0; x < content.Dimensions[mipLevel].X; x = x + 1)
                    {
                        graphicsDevice.UpdateTexture(
                            texture: texture,
                            source: (IntPtr)(data + 4 * content.GetOffset(x, y, mipLevel)),
                            sizeInBytes: (uint)(4),
                            x: (uint)x,
                            y: (uint)y,
                            z: (uint)0,
                            width: (uint)1,
                            height: (uint)1,
                            depth: (uint)1,
                            mipLevel: (uint)mipLevel,
                            arrayLayer: (uint)0);
                    }
                }
            }

            this.Content.Unpin();
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                this.ImageTexture.Dispose();
            }
        }

#if DEBUG
        ~RenderableImage()
        {
            DisposeUtilities.CheckForUndisposed(
                disposed,
                this);
        }
#endif
    }
}