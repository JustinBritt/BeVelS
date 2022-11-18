namespace BeVelS.Graphics.HTML.Classes
{
    using System.Threading;

    using UltralightNet;
    using UltralightNet.AppCore;

    using BeVelS.Graphics.HTML.Extensions;
    using BeVelS.Graphics.HTML.Interfaces;

    internal sealed class ULBitmapRenderer : IULBitmapRenderer
    {
        public ULBitmapRenderer()
        {
        }

        private View View { get; set; }

        public ULBitmap GetSurfaceBitmap()
        {
            return this.View.Surface.Bitmap;
        }

        public void Render(
            ULConfig config,
            int millisecondsTimeout,
            string platformFileSystemBaseDirectory,
            ULViewConfig viewConfig,
            uint viewHeight,
            string viewHTML,
            uint viewWidth)
        {
            AppCoreMethods.ulEnablePlatformFileSystem(
                platformFileSystemBaseDirectory);

            AppCoreMethods.ulEnablePlatformFontLoader();

            Renderer renderer = ULPlatform.CreateRenderer(
                config);

            this.View = renderer.CreateView(
                viewWidth,
                viewHeight,
                viewConfig)
                .WithHTML(
                HTML: viewHTML);

            bool loaded = false;

            this.View.OnFinishLoading += (frameId, isMainFrame, url) =>
            {
                loaded = true;
            };

            while (!loaded)
            {
                renderer.Update();

                Thread.Sleep(
                    millisecondsTimeout);
            }

            renderer.Update();

            renderer.Render();
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                this.View.Dispose();
            }
        }
    }
}