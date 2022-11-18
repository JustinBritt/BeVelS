namespace BeVelS.InterfacesAbstractFactories
{
    using BeVelS.Audio.Caching.InterfacesAbstractFactories;
    using BeVelS.Audio.Channels.InterfacesAbstractFactories;
    using BeVelS.Audio.Mixers.InterfacesAbstractFactories;
    using BeVelS.Audio.PlaybackEngines.InterfacesAbstractFactories;
    using BeVelS.Audio.Players.InterfacesAbstractFactories;
    using BeVelS.Audio.Readers.InterfacesAbstractFactories;
    using BeVelS.Audio.Resamplers.InterfacesAbstractFactories;
    using BeVelS.Common.Comparers.InterfacesAbstractFactories;
    using BeVelS.Common.Parallelism.InterfacesAbstractFactories;
    using BeVelS.Common.Stopwatches.InterfacesAbstractFactories;
    using BeVelS.Common.Threading.InterfacesAbstractFactories;
    using BeVelS.Common.Triangles.InterfacesAbstractFactories;
    using BeVelS.Common.Utilities.InterfacesAbstractFactories;
    using BeVelS.Common.Vectors.InterfacesAbstractFactories;
    using BeVelS.Dependencies.AssimpNet.InterfacesAbstractFactories;
    using BeVelS.Graphics.BlendStates.InterfacesAbstractFactories;
    using BeVelS.Graphics.BufferConstants.InterfacesAbstractFactories;
    using BeVelS.Graphics.Buffers.InterfacesAbstractFactories;
    using BeVelS.Graphics.Debugging.InterfacesAbstractFactories;
    using BeVelS.Graphics.DepthStencilStates.InterfacesAbstractFactories;
    using BeVelS.Graphics.Glyphs.InterfacesAbstractFactories;
    using BeVelS.Graphics.GraphDataSeries.InterfacesAbstractFactories;
    using BeVelS.Graphics.GraphicsPipelines.InterfacesAbstractFactories;
    using BeVelS.Graphics.HTML.InterfacesAbstractFactories;
    using BeVelS.Graphics.KTX.InterfacesAbstractFactories;
    using BeVelS.Graphics.Images.InterfacesAbstractFactories;
    using BeVelS.Graphics.RasterizerStates.InterfacesAbstractFactories;
    using BeVelS.Graphics.ResourceSets.InterfacesAbstractFactories;
    using BeVelS.Graphics.Samplers.InterfacesAbstractFactories;
    using BeVelS.Graphics.ShaderSets.InterfacesAbstractFactories;
    using BeVelS.Graphics.Swapchains.InterfacesAbstractFactories;
    using BeVelS.Graphics.Text.InterfacesAbstractFactories;
    using BeVelS.Graphics.Textures.InterfacesAbstractFactories;
    using BeVelS.Graphics.UILines.InterfacesAbstractFactories;
    using BeVelS.Graphics.VertexLayouts.InterfacesAbstractFactories;
    using BeVelS.Graphics.Vertices.InterfacesAbstractFactories;
    using BeVelS.Physics.InterfacesAbstractFactories;
    using BeVelS.Physics.Callbacks.InterfacesAbstractFactories;
    using BeVelS.Physics.Collidables.InterfacesAbstractFactories;
    using BeVelS.Physics.Constraints.InterfacesAbstractFactories;
    using BeVelS.Physics.TimeSteps.InterfacesAbstractFactories;

    public interface IBeVelSAbstractFactory
    {
        ICachingAbstractFactory CreateAudioCachingAbstractFactory();

        IChannelsAbstractFactory CreateAudioChannelsAbstractFactory();

        IMixersAbstractFactory CreateAudioMixersAbstractFactory();

        IPlaybackEnginesAbstractFactory CreateAudioPlaybackEnginesAbstractFactory();

        IPlayersAbstractFactory CreateAudioPlayersAbstractFactory();

        IReadersAbstractFactory CreateAudioReadersAbstractFactory();

        IResamplersAbstractFactory CreateAudioResamplersAbstractFactory();

        IComparersAbstractFactory CreateCommonComparersAbstractFactory();

        BeVelS.Common.Meshes.InterfacesAbstractFactories.IMeshesAbstractFactory CreateCommonMeshesAbstractFactory();

        IParallelismAbstractFactory CreateCommonParallelismAbstractFactory();

        IStopwatchesAbstractFactory CreateCommonStopwatchesAbstractFactory();

        IThreadingAbstractFactory CreateCommonThreadingAbstractFactory();

        ITrianglesAbstractFactory CreateCommonTrianglesAbstractFactory();

        IUtilitiesAbstractFactory CreateCommonUtilitiesAbstractFactory();

        IVectorsAbstractFactory CreateCommonVectorsAbstractFactory();

        IAssimpNetAbstractFactory CreateDependenciesAssimpNetAbstractFactory();

        BeVelS.ECS.Components.Cameras.InterfacesAbstractFactories.ICamerasAbstractFactory CreateECSComponentsCamerasAbstractFactory();

        BeVelS.ECS.Components.CollidableShapes.InterfacesAbstractFactories.ICollidableShapesAbstractFactory CreateECSComponentsCollidableShapesAbstractFactory();

        BeVelS.ECS.Components.Debugging.InterfacesAbstractFactories.IDebuggingAbstractFactory CreateECSComponentDebuggingAbstractFactory();

        BeVelS.ECS.Components.Fonts.InterfacesAbstractFactories.IFontsAbstractFactory CreateECSComponentsFontsAbstractFactory();

        BeVelS.ECS.Components.Framebuffers.InterfacesAbstractFactories.IFramebuffersAbstractFactory CreateECSComponentsFramebuffersAbstractFactory();

        BeVelS.ECS.Components.Guids.InterfacesAbstractFactories.IGuidsAbstractFactory CreateECSComponentsGuidsAbstractFactory();

        BeVelS.ECS.Components.RenderTargets.InterfacesAbstractFactories.IRenderTargetsAbstractFactory CreateECSComponentsRenderTargetsAbstractFactory();

        BeVelS.ECS.Components.Resolutions.InterfacesAbstractFactories.IResolutionsAbstractFactory CreateECSComponentsResolutionsAbstractFactory();

        BeVelS.ECS.Components.Shapes.InterfacesAbstractFactories.IShapesAbstractFactory CreateECSComponentsShapesAbstractFactory();

        BeVelS.ECS.Messages.Cameras.InterfacesAbstractFactories.ICamerasAbstractFactory CreateECSMessagesCamerasAbstractFactory();

        BeVelS.ECS.Messages.CommandLists.InterfacesAbstractFactories.ICommandListsAbstractFactory CreateECSMessagesCommandListsAbstractFactory();

        BeVelS.ECS.Messages.Debugging.InterfacesAbstractFactories.IDebuggingAbstractFactory CreateECSMessagesDebuggingAbstractFactory();

        BeVelS.ECS.Messages.PlaybackEngines.InterfacesAbstractFactories.IPlaybackEnginesAbstractFactory CreateECSMessagesPlaybackEnginesAbstractFactory();

        BeVelS.ECS.Messages.Recorders.InterfacesAbstractFactories.IRecordersAbstractFactory CreateECSMessagesRecordersAbstractFactory();

        BeVelS.ECS.Messages.Renderers.InterfacesAbstractFactories.IRenderersAbstractFactory CreateECSMessagesRenderersAbstractFactory();

        BeVelS.ECS.QuasiSystems.Runners.InterfacesAbstractFactories.IRunnersAbstractFactory CreateECSQuasiSystemsRunnersAbstractFactory();

        BeVelS.ECS.Systems.InterfacesAbstractFactories.ISystemsAbstractFactory CreateECSSystemsAbstractFactory();

        BeVelS.ECS.Systems.BufferPools.InterfacesAbstractFactories.IBufferPoolsAbstractFactory CreateECSSystemsBufferPoolsAbstractFactory();

        BeVelS.ECS.Systems.Cameras.InterfacesAbstractFactories.ICamerasAbstractFactory CreateECSSystemsCamerasAbstractFactory();

        BeVelS.ECS.Systems.CollidableShapes.InterfacesAbstractFactories.ICollidableShapesAbstractFactory CreateECSSystemsCollidableShapesAbstractFactory();

        BeVelS.ECS.Systems.CommandLists.InterfacesAbstractFactories.ICommandListsAbstractFactory CreateECSSystemsCommandListsAbstractFactory();

        BeVelS.ECS.Systems.Debugging.InterfacesAbstractFactories.IDebuggingAbstractFactory CreateECSSystemsDebuggingAbstractFactory();

        BeVelS.ECS.Systems.Fonts.InterfacesAbstractFactories.IFontsAbstractFactory CreateECSSystemsFontsAbstractFactory();

        BeVelS.ECS.Systems.Framebuffers.InterfacesAbstractFactories.IFramebuffersAbstractFactory CreateECSSystemsFramebuffersAbstractFactory();

        BeVelS.ECS.Systems.GraphicsDevices.InterfacesAbstractFactories.IGraphicsDevicesAbstractFactory CreateECSSystemsGraphicsDevicesAbstractFactory();

        BeVelS.ECS.Systems.PlaybackEngines.InterfacesAbstractFactories.IPlaybackEnginesAbstractFactory CreateECSSystemsPlaybackEnginesAbstractFactory();

        BeVelS.ECS.Systems.Recorders.InterfacesAbstractFactories.IRecordersAbstractFactory CreateECSSystemsRecordersAbstractFactory();

        BeVelS.ECS.Systems.RenderSurfaces.InterfacesAbstractFactories.IRenderSurfacesAbstractFactory CreateECSSystemsRenderSurfacesAbstractFactory();

        BeVelS.ECS.Systems.RenderTargets.InterfacesAbstractFactories.IRenderTargetsAbstractFactory CreateECSSystemsRenderTargetsAbstractFactory();

        BeVelS.ECS.Systems.Resolutions.InterfacesAbstractFactories.IResolutionsAbstractFactory CreateECSSystemsResolutionsAbstractFactory();

        BeVelS.ECS.Systems.Simulations.InterfacesAbstractFactories.ISimulationsAbstractFactory CreateECSSystemsSimulationsAbstractFactory();

        BeVelS.ECS.Systems.TimeSteps.InterfacesAbstractFactories.ITimeStepsAbstractFactory CreateECSSystemsTimeStepsAbstractFactory();

        BeVelS.ECS.Systems.Viewports.InterfacesAbstractFactories.IViewportsAbstractFactory CreateECSSystemsViewportsAbstractFactory();

        IBlendStatesAbstractFactory CreateGraphicsBlendStatesAbstractFactory();

        IBufferConstantsAbstractFactory CreateGraphicsBufferConstantsAbstractFactory();

        IBuffersAbstractFactory CreateGraphicsBuffersAbstractFactory();

        BeVelS.Graphics.Cameras.InterfacesAbstractFactories.ICamerasAbstractFactory CreateGraphicsCamerasAbstractFactory();

        BeVelS.Graphics.CommandLists.InterfacesAbstractFactories.ICommandListsAbstractFactory CreateGraphicsCommandListsAbstractFactory();

        IDebuggingAbstractFactory CreateGraphicsDebuggingAbstractFactory();

        IDepthStencilStatesAbstractFactory CreateGraphicsDepthStencilStatesAbstractFactory();

        BeVelS.Graphics.Fonts.InterfacesAbstractFactories.IFontsAbstractFactory CreateGraphicsFontsAbstractFactory();

        BeVelS.Graphics.Framebuffers.InterfacesAbstractFactories.IFramebuffersAbstractFactory CreateGraphicsFramebuffersAbstractFactory();

        IGlyphsAbstractFactory CreateGraphicsGlyphsAbstractFactory();

        IGraphDataSeriesAbstractFactory CreateGraphicsGraphDataSeriesAbstractFactory();

        BeVelS.Graphics.GraphicsDevices.InterfacesAbstractFactories.IGraphicsDevicesAbstractFactory CreateGraphicsGraphicsDevicesAbstractFactory();

        IGraphicsPipelinesAbstractFactory CreateGraphicsGraphicsPipelinesAbstractFactory();

        IHTMLAbstractFactory CreateGraphicsHTMLAbstractFactory();

        IImagesAbstractFactory CreateGraphicsImagesAbstractFactory();

        IKTXAbstractFactory CreateGraphicsKTXAbstractFactory();

        BeVelS.Graphics.Meshes.InterfacesAbstractFactories.IMeshesAbstractFactory CreateGraphicsMeshesAbstractFactory();

        BeVelS.Graphics.PostProcessors.InterfacesAbstractFactories.IPostProcessorsAbstractFactory CreateGraphicsPostProcessorsAbstractFactory();

        IRasterizerStatesAbstractFactory CreateGraphicsRasterizerStatesAbstractFactory();

        BeVelS.Graphics.Recorders.InterfacesAbstractFactories.IRecordersAbstractFactory CreateGraphicsRecordersAbstractFactory();

        IResourceSetsAbstractFactory CreateGraphicsResourceSetsAbstractFactory();

        ISamplersAbstractFactory CreateGraphicsSamplersAbstractFactory();

        IShaderSetsAbstractFactory CreateGraphicsShaderSetsAbstractFactory();

        BeVelS.Graphics.Shapes.InterfacesAbstractFactories.IShapesAbstractFactory CreateGraphicsShapesAbstractFactory();

        ISwapchainsAbstractFactory CreateGraphicsSwapchainsAbstractFactory();

        ITextAbstractFactory CreateGraphicsTextAbstractFactory();

        ITexturesAbstractFactory CreateGraphicsTexturesAbstractFactory();

        IUILinesAbstractFactory CreateGraphicsUILinesAbstractFactory();

        IVertexLayoutsAbstractFactory CreateGraphicsVertexLayoutsAbstractFactory();

        IVerticesAbstractFactory CreateGraphicsVerticesAbstractFactory();

        BeVelS.Graphics.Viewports.InterfacesAbstractFactories.IViewportsAbstractFactory CreateGraphicsViewportsAbstractFactory();

        IPhysicsAbstractFactory CreatePhysicsAbstractFactory();

        ICallbacksAbstractFactory CreatePhysicsCallbacksAbstractFactory();

        ICollidablesAbstractFactory CreatePhysicsCollidablesAbstractFactory();

        IConstraintsAbstractFactory CreatePhysicsConstraintsAbstractFactory();

        BeVelS.Physics.Meshes.InterfacesAbstractFactories.IMeshesAbstractFactory CreatePhysicsMeshesAbstractFactory();

        ITimeStepsAbstractFactory CreatePhysicsTimeStepsAbstractFactory();
    }
}