namespace BeVelS.Graphics.RasterizerStates.Extensions.Descriptions
{
    using Veldrid;

    public static class RasterizerStateDescriptionExtensions
    {
        public static RasterizerStateDescription WithCounterClockwiseFrontFace(
            this RasterizerStateDescription rasterizerStateDescription)
        {
            rasterizerStateDescription.FrontFace = FrontFace.CounterClockwise;

            return rasterizerStateDescription;
        }
    }
}