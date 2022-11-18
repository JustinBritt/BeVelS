namespace BeVelS.Graphics.ShaderSets.Factories.Descriptions
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.ShaderSets.InterfacesFactories.Descriptions;

    internal sealed class ShaderSetDescriptionFactory : IShaderSetDescriptionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ShaderSetDescriptionFactory()
        {
        }

        public ShaderSetDescription Create(
            Shader[] shaders)
        {
            ShaderSetDescription shaderSetDescription = default;

            try
            {
                shaderSetDescription = new ShaderSetDescription(
                    Array.Empty<VertexLayoutDescription>(),
                    shaders);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return shaderSetDescription;
        }

        public ShaderSetDescription Create(
            VertexLayoutDescription[] vertexLayouts,
            Shader[] shaders)
        {
            ShaderSetDescription shaderSetDescription = default;

            try
            {
                shaderSetDescription = new ShaderSetDescription(
                    vertexLayouts,
                    shaders);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return shaderSetDescription;
        }

        public ShaderSetDescription Create(
            VertexLayoutDescription[] vertexLayouts,
            Shader[] shaders,
            SpecializationConstant[] specializations)
        {
            ShaderSetDescription shaderSetDescription = default;

            try
            {
                shaderSetDescription = new ShaderSetDescription(
                    vertexLayouts,
                    shaders,
                    specializations);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return shaderSetDescription;
        }
    }
}