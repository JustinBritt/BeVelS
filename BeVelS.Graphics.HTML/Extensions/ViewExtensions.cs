namespace BeVelS.Graphics.HTML.Extensions
{
    using UltralightNet;

    public static class ViewExtensions
    {
        public static View WithHTML(
            this View view,
            string HTML)
        {
            view.HTML = HTML;

            return view;
        }

        public static View WithURL(
            this View view,
            string URL)
        {
            view.URL = URL;

            return view;
        }
    }
}