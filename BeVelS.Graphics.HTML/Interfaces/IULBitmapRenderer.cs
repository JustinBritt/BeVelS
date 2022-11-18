namespace BeVelS.Graphics.HTML.Interfaces
{
    using System;

    using UltralightNet;

    public interface IULBitmapRenderer : IDisposable
    {
        ULBitmap GetSurfaceBitmap();

        void Render(
            ULConfig config,
            int millisecondsTimeout,
            string platformFileSystemBaseDirectory,
            ULViewConfig viewConfig,
            uint viewHeight,
            string viewHTML,
            uint viewWidth);
    }
}