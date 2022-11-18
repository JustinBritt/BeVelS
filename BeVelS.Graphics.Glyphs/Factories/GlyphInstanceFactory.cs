namespace BeVelS.Graphics.Glyphs.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BeVelS.Graphics.Glyphs.InterfacesFactories;
    using BeVelS.Graphics.Glyphs.Structs;

    internal sealed class GlyphInstanceFactory : IGlyphInstanceFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public GlyphInstanceFactory()
        {
        }

        public GlyphInstance Create(
            ref Vector2 start,
            ref Vector2 horizontalAxis,
            float scale,
            int sourceId,
            ref Vector4 color,
            ref Vector2 screenToPackedScale)
        {
            GlyphInstance glyphInstance = default;

            try
            {
                glyphInstance = new GlyphInstance(
                    start: ref start,
                    horizontalAxis: ref horizontalAxis,
                    scale: scale,
                    sourceId: sourceId,
                    color: ref color,
                    screenToPackedScale: ref screenToPackedScale);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return glyphInstance;
        }
    }
}