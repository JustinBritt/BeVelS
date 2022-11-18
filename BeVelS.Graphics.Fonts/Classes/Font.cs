namespace BeVelS.Graphics.Fonts.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Veldrid;

    using BeVelS.Common.Utilities.Classes;
    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Fonts.Interfaces;
    using BeVelS.Graphics.Fonts.Structs.Characters;
    using BeVelS.Graphics.Fonts.Structs.Sources;
    using BeVelS.Graphics.Glyphs.Structs;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/UI/Font.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Use Veldrid instead of SharpDX")]
    internal sealed class Font : IFont
    {
        public unsafe Font(
            IVector2Factory vector2Factory,
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            IFontContent font)
        {
            this.Content = font;

            this.SourcesBuffer = this.CreateSourcesBuffer(
                bufferDescriptionFactory,
                graphicsDevice,
                font.Characters.Count);

            this.AtlasStagingTexture = graphicsDevice.ResourceFactory.CreateTexture(
                TextureDescription.Texture2D(
                    width: (uint)font.Atlas.Width,
                    height: (uint)font.Atlas.Height,
                    mipLevels: (uint)font.Atlas.MipLevels,
                    arrayLayers: 1,
                    format: PixelFormat.R8_G8_B8_A8_UNorm,
                    usage: TextureUsage.Sampled));

            this.UpdateTexture(
                font,
                graphicsDevice,
                this.AtlasStagingTexture);

            this.SourceIds = new Dictionary<char, int>();

            int nextSourceId = 0;

            GlyphSource[] sourcesData = new GlyphSource[font.Characters.Count];

            foreach (KeyValuePair<char, CharacterData> character in font.Characters)
            {
                this.SourceIds.Add(
                    character.Key,
                    nextSourceId);

                sourcesData[nextSourceId] = new GlyphSource() 
                { 
                    DistanceScale = character.Value.DistanceScale,

                    Minimum = vector2Factory.Create(
                        character.Value.SourceMinimum.X,
                        character.Value.SourceMinimum.Y),

                    PackedSpan = character.Value.SourceSpan.X | (character.Value.SourceSpan.Y << 16)
                };

                ++nextSourceId;
            }

            this.UpdateSourcesBuffer(
                graphicsDevice,
                sourcesData,
                this.SourcesBuffer);
        }

        public Texture AtlasStagingTexture { get; private set; }

        public IFontContent Content { get; private set; }

        public DeviceBuffer SourcesBuffer { get; private set; }

        public Dictionary<char, int> SourceIds { get; }

        public int GetSourceId(
            char character)
        {
            if (this.SourceIds.TryGetValue(character, out int sourceId))
            {
                return sourceId;
            }
            return -1;
        }

        private unsafe DeviceBuffer CreateSourcesBuffer(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            int numberCharacters)
        {
            return graphicsDevice.ResourceFactory.CreateBuffer(
                bufferDescriptionFactory.Create(
                    (uint)(numberCharacters * Unsafe.SizeOf<GlyphInstance>()),
                    BufferUsage.StructuredBufferReadOnly,
                    (uint)(Unsafe.SizeOf<GlyphInstance>())));
        }

        private unsafe void UpdateSourcesBuffer(
            GraphicsDevice graphicsDevice,
            ReadOnlySpan<GlyphSource> sources,
            DeviceBuffer sourcesBuffer)
        {
            graphicsDevice.UpdateBuffer(
                sourcesBuffer,
                0,
                sources);
        }

        public unsafe void UpdateTexture(
            IFontContent font,
            GraphicsDevice graphicsDevice,
            Texture texture)
        {
            byte * data = font.Atlas.Pin();

            for (int mipLevel = 0; mipLevel < font.Atlas.MipLevels; mipLevel = mipLevel + 1)
            {
                for (int y = 0; y < font.Atlas.Dimensions[mipLevel].Y; y = y + 1)
                {
                    for (int x = 0; x < font.Atlas.Dimensions[mipLevel].X; x = x + 1)
                    {
                        graphicsDevice.UpdateTexture<uint>(
                            texture: texture,
                            source: new Span<uint>(
                                data + font.Atlas.GetOffset(x, y, mipLevel),
                                4).ToArray(),
                            x: (uint)x,
                            y: (uint)y,
                            z: 0,
                            width: (uint)1,
                            height: (uint)1,
                            depth: 1,
                            mipLevel: (uint)mipLevel,
                            arrayLayer: 0);
                    }
                }
            }

            font.Atlas.Unpin();
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                this.AtlasStagingTexture.Dispose();

                this.SourcesBuffer.Dispose();
            }
        }

#if DEBUG
        ~Font()
        {
            DisposeUtilities.CheckForUndisposed(
                disposed,
                this);
        }
#endif
    }
}