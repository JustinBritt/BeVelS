namespace BeVelS.Graphics.PostProcessors.Classes
{
    using System;
    using System.Linq;
    using System.Text;

    using Veldrid;
    using Veldrid.SPIRV;

    using BeVelS.Common.Utilities.Classes;

    using BeVelS.Graphics.DepthStencilStates.Extensions.Descriptions;
    using BeVelS.Graphics.DepthStencilStates.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.GraphicsPipelines.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.PostProcessors.Interfaces;
    using BeVelS.Graphics.ResourceLayouts.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.ResourceSets.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shaders.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.ShaderSets.InterfacesFactories.Descriptions;
    
    using BeVelS.Licensing.Classes;

    internal sealed class CompressToSwap : ICompressToSwap
    {
        private const string EntryPoint = "main";

        [BepuPhysicsLicensedCode(
            boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
            copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
            copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
            source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/PostProcessing/CompressToSwap.hlsl",
            BepuPhysicsLicensedCodeAttribute.FormattingChanges,
            "hlsl -> glsl")]
        private const string VertexCode = @"
#version 450

vec2 GetWholeScreenTriangleVertexNDC(
    uint vertexIndex)
{
    return vec2((vertexIndex << 2) & 4, (vertexIndex << 1) & 4) - 1;
}

layout(location = 0) out vec4 fsin_Position;

void main()
{
    vec4 Position = vec4(GetWholeScreenTriangleVertexNDC(gl_VertexIndex), 0.5, 1);

    fsin_Position = Position;

    gl_Position = Position;
}";

        [BepuPhysicsLicensedCode(
            boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
            copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
            copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
            source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/PostProcessing/CompressToSwap.hlsl",
            BepuPhysicsLicensedCodeAttribute.FormattingChanges,
            "hlsl -> glsl",
            "Added gamma",
            "Moved dithering to EstimateDither")]
        private const string FragmentCode = @"
#version 450

#extension GL_EXT_samplerless_texture_functions : enable

vec3 saturate(
    vec3 value)
{
    return clamp(value, vec3(0), vec3(1));
}

// Estimate dither amount from screen position.
float EstimateDither(
    vec3 position)
{
    float dither = position.x * position.x + position.y;
	
    dither = uint(dither) * 776531419;
	
    dither = uint(dither) * 961748927;
	
    dither = uint(dither) * 217645199;
	
    dither = (uint(dither) & 65535) / 65535.0;

    return dither;
}

float gamma(
    float u) 
{
    if (u <= 0.0031308)
    {
        return 12.92 * u;
    }
    else
    {
        return 1.055 * pow(u, 1.0/2.4) - 0.055;
    }
}

layout(set = 0, binding = 0) uniform texture2D ColorTexture;

layout(location = 0) in vec4 fsin_Position;
layout(location = 0) out vec4 fsout_Color;

void main()
{
    const float ditherWidth = 1.0 / 255.0;

    float dither = EstimateDither(fsin_Position.xyz);

    vec3 fetchedColor = texelFetch(ColorTexture, ivec2(gl_FragCoord.xy), 0).xyz;

    vec3 adjustedColor = saturate(vec3(gamma(fetchedColor.x), gamma(fetchedColor.y), gamma(fetchedColor.z)));

    adjustedColor = saturate(adjustedColor + vec3(ditherWidth * (dither - 0.5f)));

    fsout_Color = vec4(adjustedColor, 1);
}";

        [BepuPhysicsLicensedCode(
            boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
            copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
            copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
            source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/PostProcessing/CompressToSwap.cs",
            BepuPhysicsLicensedCodeAttribute.FormattingChanges,
            "Use Veldrid instead of SharpDX")]
        public CompressToSwap(
            IDepthStencilStateDescriptionFactory depthStencilStateDescriptionFactory,
            IGraphicsPipelineDescriptionFactory graphicsPipelineDescriptionFactory,
            IResourceLayoutDescriptionFactory resourceLayoutDescriptionFactory,
            IResourceLayoutElementDescriptionFactory resourceLayoutElementDescriptionFactory,
            IShaderDescriptionFactory shaderDescriptionFactory,
            IShaderSetDescriptionFactory shaderSetDescriptionFactory,
            BlendStateDescription blendStateDescription,
            GraphicsDevice graphicsDevice,
            OutputDescription outputDescription,
            RasterizerStateDescription rasterizerStateDescription)
        {
            this.Shaders = graphicsDevice.ResourceFactory.CreateFromSpirv(
                vertexShaderDescription: shaderDescriptionFactory.Create(
                    ShaderStages.Vertex,
                    Encoding.UTF8.GetBytes(
                        VertexCode),
                    EntryPoint),
                fragmentShaderDescription: shaderDescriptionFactory.Create(
                    ShaderStages.Fragment,
                    Encoding.UTF8.GetBytes(
                        FragmentCode),
                    EntryPoint));

            this.ResourceLayout = graphicsDevice.ResourceFactory.CreateResourceLayout(
                resourceLayoutDescriptionFactory.Create(
                    resourceLayoutElementDescriptionFactory.Create(
                        "ColorTexture",
                        ResourceKind.TextureReadOnly,
                        ShaderStages.Fragment)));

            this.Pipeline = graphicsDevice.ResourceFactory.CreateGraphicsPipeline(
                graphicsPipelineDescriptionFactory.Create(
                    blendState: blendStateDescription,
                    depthStencilStateDescription: depthStencilStateDescriptionFactory.CreateD3D11Default().WithoutDepthTest().WithoutDepthWrite(),
                    rasterizerState: rasterizerStateDescription,
                    primitiveTopology: PrimitiveTopology.TriangleList,
                    shaderSet: shaderSetDescriptionFactory.Create(
                        vertexLayouts: Array.Empty<VertexLayoutDescription>(),
                        shaders: this.Shaders),
                    resourceLayouts: Array.Empty<ResourceLayout>().Prepend(this.ResourceLayout).ToArray(),
                    outputs: outputDescription));
        }

        public Pipeline Pipeline { get; }

        public ResourceLayout ResourceLayout { get; }

        public ResourceSet ResourceSet { get; private set; }

        public Shader[] Shaders { get; }

        public void Render(
            IResourceSetDescriptionFactory resourceSetDescriptionFactory,
            TextureView colorTextureView,
            CommandList commandList,
            GraphicsDevice graphicsDevice)
        {
            this.ResourceSet = graphicsDevice.ResourceFactory.CreateResourceSet(
                resourceSetDescriptionFactory.Create(
                    this.ResourceLayout,
                    colorTextureView));

            commandList.SetPipeline(
                this.Pipeline);

            commandList.SetGraphicsResourceSet(
                0,
                this.ResourceSet);

            commandList.Draw(
                3,
                1,
                0,
                0);
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                this.Pipeline.Dispose();

                this.ResourceLayout.Dispose();

                this.ResourceSet.Dispose();

                foreach (Shader shader in this.Shaders)
                {
                    shader.Dispose();
                }
            }
        }

#if DEBUG
        ~CompressToSwap()
        {
            DisposeUtilities.CheckForUndisposed(
                disposed,
                this);
        }
#endif
    }
}