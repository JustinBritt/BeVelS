namespace BeVelS.Graphics.BlendStates.Extensions.Descriptions
{
    using Veldrid;

    public static class BlendStateDescriptionExtensions
    {
        public static BlendStateDescription WithAlphaToCoverage(
            this BlendStateDescription blendStateDescription)
        {
            blendStateDescription.AlphaToCoverageEnabled = true;

            return blendStateDescription;
        }
    }
}