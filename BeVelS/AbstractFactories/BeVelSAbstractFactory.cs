namespace BeVelS.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Audio.Caching.AbstractFactories;
    using BeVelS.Audio.Caching.InterfacesAbstractFactories;
    using BeVelS.Audio.Channels.AbstractFactories;
    using BeVelS.Audio.Channels.InterfacesAbstractFactories;
    using BeVelS.Audio.Mixers.AbstractFactories;
    using BeVelS.Audio.Mixers.InterfacesAbstractFactories;
    using BeVelS.Audio.PlaybackEngines.AbstractFactories;
    using BeVelS.Audio.PlaybackEngines.InterfacesAbstractFactories;
    using BeVelS.Audio.Players.AbstractFactories;
    using BeVelS.Audio.Players.InterfacesAbstractFactories;
    using BeVelS.Audio.Readers.AbstractFactories;
    using BeVelS.Audio.Readers.InterfacesAbstractFactories;
    using BeVelS.Audio.Resamplers.AbstractFactories;
    using BeVelS.Audio.Resamplers.InterfacesAbstractFactories;
    using BeVelS.Common.Comparers.AbstractFactories;
    using BeVelS.Common.Comparers.InterfacesAbstractFactories;
    using BeVelS.Common.Parallelism.AbstractFactories;
    using BeVelS.Common.Parallelism.InterfacesAbstractFactories;
    using BeVelS.Common.Stopwatches.AbstractFactories;
    using BeVelS.Common.Stopwatches.InterfacesAbstractFactories;
    using BeVelS.Common.Threading.AbstractFactories;
    using BeVelS.Common.Threading.InterfacesAbstractFactories;
    using BeVelS.Common.Triangles.AbstractFactories;
    using BeVelS.Common.Triangles.InterfacesAbstractFactories;
    using BeVelS.Common.Utilities.AbstractFactories;
    using BeVelS.Common.Utilities.InterfacesAbstractFactories;
    using BeVelS.Common.Vectors.AbstractFactories;
    using BeVelS.Common.Vectors.InterfacesAbstractFactories;
    using BeVelS.Dependencies.AssimpNet.AbstractFactories;
    using BeVelS.Dependencies.AssimpNet.InterfacesAbstractFactories;
    using BeVelS.Graphics.BlendStates.AbstractFactories;
    using BeVelS.Graphics.BlendStates.InterfacesAbstractFactories;
    using BeVelS.Graphics.BufferConstants.AbstractFactories;
    using BeVelS.Graphics.BufferConstants.InterfacesAbstractFactories;
    using BeVelS.Graphics.Buffers.AbstractFactories;
    using BeVelS.Graphics.Buffers.InterfacesAbstractFactories;
    using BeVelS.Graphics.Debugging.AbstractFactories;
    using BeVelS.Graphics.Debugging.InterfacesAbstractFactories;
    using BeVelS.Graphics.DepthStencilStates.AbstractFactories;
    using BeVelS.Graphics.DepthStencilStates.InterfacesAbstractFactories;
    using BeVelS.Graphics.Glyphs.AbstractFactories;
    using BeVelS.Graphics.Glyphs.InterfacesAbstractFactories;
    using BeVelS.Graphics.GraphDataSeries.AbstractFactories;
    using BeVelS.Graphics.GraphDataSeries.InterfacesAbstractFactories;
    using BeVelS.Graphics.GraphicsPipelines.AbstractFactories;
    using BeVelS.Graphics.GraphicsPipelines.InterfacesAbstractFactories;
    using BeVelS.Graphics.HTML.AbstractFactories;
    using BeVelS.Graphics.HTML.InterfacesAbstractFactories;
    using BeVelS.Graphics.Images.AbstractFactories;
    using BeVelS.Graphics.Images.InterfacesAbstractFactories;
    using BeVelS.Graphics.KTX.AbstractFactories;
    using BeVelS.Graphics.KTX.InterfacesAbstractFactories;
    using BeVelS.Graphics.PostProcessors.AbstractFactories;
    using BeVelS.Graphics.PostProcessors.InterfacesAbstractFactories;
    using BeVelS.Graphics.RasterizerStates.AbstractFactories;
    using BeVelS.Graphics.RasterizerStates.InterfacesAbstractFactories;
    using BeVelS.Graphics.ResourceSets.AbstractFactories;
    using BeVelS.Graphics.ResourceSets.InterfacesAbstractFactories;
    using BeVelS.Graphics.Samplers.AbstractFactories;
    using BeVelS.Graphics.Samplers.InterfacesAbstractFactories;
    using BeVelS.Graphics.ShaderSets.AbstractFactories;
    using BeVelS.Graphics.ShaderSets.InterfacesAbstractFactories;
    using BeVelS.Graphics.Swapchains.AbstractFactories;
    using BeVelS.Graphics.Swapchains.InterfacesAbstractFactories;
    using BeVelS.Graphics.Text.AbstractFactories;
    using BeVelS.Graphics.Text.InterfacesAbstractFactories;
    using BeVelS.Graphics.Textures.AbstractFactories;
    using BeVelS.Graphics.Textures.InterfacesAbstractFactories;
    using BeVelS.Graphics.UILines.AbstractFactories;
    using BeVelS.Graphics.UILines.InterfacesAbstractFactories;
    using BeVelS.Graphics.VertexLayouts.AbstractFactories;
    using BeVelS.Graphics.VertexLayouts.InterfacesAbstractFactories;
    using BeVelS.Graphics.Vertices.AbstractFactories;
    using BeVelS.Graphics.Vertices.InterfacesAbstractFactories;
    using BeVelS.Physics.AbstractFactories;
    using BeVelS.Physics.Callbacks.AbstractFactories;
    using BeVelS.Physics.Callbacks.InterfacesAbstractFactories;
    using BeVelS.Physics.Collidables.AbstractFactories;
    using BeVelS.Physics.Collidables.InterfacesAbstractFactories;
    using BeVelS.Physics.Constraints.AbstractFactories;
    using BeVelS.Physics.Constraints.InterfacesAbstractFactories;
    using BeVelS.Physics.InterfacesAbstractFactories;
    using BeVelS.Physics.TimeSteps.AbstractFactories;
    using BeVelS.Physics.TimeSteps.InterfacesAbstractFactories;
    using BeVelS.InterfacesAbstractFactories;

    public sealed class BeVelSAbstractFactory : IBeVelSAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BeVelSAbstractFactory()
        {
        }

        public static IBeVelSAbstractFactory Create()
        {
            return new BeVelSAbstractFactory();
        }

        public ICachingAbstractFactory CreateAudioCachingAbstractFactory()
        {
            ICachingAbstractFactory factory = null;

            try
            {
                factory = new CachingAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IChannelsAbstractFactory CreateAudioChannelsAbstractFactory()
        {
            IChannelsAbstractFactory factory = null;

            try
            {
                factory = new ChannelsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IMixersAbstractFactory CreateAudioMixersAbstractFactory()
        {
            IMixersAbstractFactory factory = null;

            try
            {
                factory = new MixersAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IPlaybackEnginesAbstractFactory CreateAudioPlaybackEnginesAbstractFactory()
        {
            IPlaybackEnginesAbstractFactory factory = null;

            try
            {
                factory = new PlaybackEnginesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IPlayersAbstractFactory CreateAudioPlayersAbstractFactory()
        {
            IPlayersAbstractFactory factory = null;

            try
            {
                factory = new PlayersAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IReadersAbstractFactory CreateAudioReadersAbstractFactory()
        {
            IReadersAbstractFactory factory = null;

            try
            {
                factory = new ReadersAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IResamplersAbstractFactory CreateAudioResamplersAbstractFactory()
        {
            IResamplersAbstractFactory factory = null;

            try
            {
                factory = new ResamplersAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IComparersAbstractFactory CreateCommonComparersAbstractFactory()
        {
            IComparersAbstractFactory factory = null;

            try
            {
                factory = new ComparersAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.Common.Meshes.InterfacesAbstractFactories.IMeshesAbstractFactory CreateCommonMeshesAbstractFactory()
        {
            BeVelS.Common.Meshes.InterfacesAbstractFactories.IMeshesAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.Common.Meshes.AbstractFactories.MeshesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IParallelismAbstractFactory CreateCommonParallelismAbstractFactory()
        {
            IParallelismAbstractFactory factory = null;

            try
            {
                factory = new ParallelismAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IStopwatchesAbstractFactory CreateCommonStopwatchesAbstractFactory()
        {
            IStopwatchesAbstractFactory factory = null;

            try
            {
                factory = new StopwatchesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IThreadingAbstractFactory CreateCommonThreadingAbstractFactory()
        {
            IThreadingAbstractFactory factory = null;

            try
            {
                factory = new ThreadingAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
  
        public ITrianglesAbstractFactory CreateCommonTrianglesAbstractFactory()
        {
            ITrianglesAbstractFactory factory = null;

            try
            {
                factory = new TrianglesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IUtilitiesAbstractFactory CreateCommonUtilitiesAbstractFactory()
        {
            IUtilitiesAbstractFactory factory = null;

            try
            {
                factory = new UtilitiesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IVectorsAbstractFactory CreateCommonVectorsAbstractFactory()
        {
            IVectorsAbstractFactory factory = null;

            try
            {
                factory = new VectorsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IAssimpNetAbstractFactory CreateDependenciesAssimpNetAbstractFactory()
        {
            IAssimpNetAbstractFactory factory = null;

            try
            {
                factory = new AssimpNetAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Components.Cameras.InterfacesAbstractFactories.ICamerasAbstractFactory CreateECSComponentsCamerasAbstractFactory()
        {
            BeVelS.ECS.Components.Cameras.InterfacesAbstractFactories.ICamerasAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Components.Cameras.AbstractFactories.CamerasAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Components.CollidableShapes.InterfacesAbstractFactories.ICollidableShapesAbstractFactory CreateECSComponentsCollidableShapesAbstractFactory()
        {
            BeVelS.ECS.Components.CollidableShapes.InterfacesAbstractFactories.ICollidableShapesAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Components.CollidableShapes.AbstractFactories.CollidableShapesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Components.Debugging.InterfacesAbstractFactories.IDebuggingAbstractFactory CreateECSComponentDebuggingAbstractFactory()
        {
            BeVelS.ECS.Components.Debugging.InterfacesAbstractFactories.IDebuggingAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Components.Debugging.AbstractFactories.DebuggingAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Components.Fonts.InterfacesAbstractFactories.IFontsAbstractFactory CreateECSComponentsFontsAbstractFactory()
        {
            BeVelS.ECS.Components.Fonts.InterfacesAbstractFactories.IFontsAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Components.Fonts.AbstractFactories.FontsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Components.Framebuffers.InterfacesAbstractFactories.IFramebuffersAbstractFactory CreateECSComponentsFramebuffersAbstractFactory()
        {
            BeVelS.ECS.Components.Framebuffers.InterfacesAbstractFactories.IFramebuffersAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Components.Framebuffers.AbstractFactories.FramebuffersAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Components.Guids.InterfacesAbstractFactories.IGuidsAbstractFactory CreateECSComponentsGuidsAbstractFactory()
        {
            BeVelS.ECS.Components.Guids.InterfacesAbstractFactories.IGuidsAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Components.Guids.AbstractFactories.GuidsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Components.RenderTargets.InterfacesAbstractFactories.IRenderTargetsAbstractFactory CreateECSComponentsRenderTargetsAbstractFactory()
        {
            BeVelS.ECS.Components.RenderTargets.InterfacesAbstractFactories.IRenderTargetsAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Components.RenderTargets.AbstractFactories.RenderTargetsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Components.Resolutions.InterfacesAbstractFactories.IResolutionsAbstractFactory CreateECSComponentsResolutionsAbstractFactory()
        {
            BeVelS.ECS.Components.Resolutions.InterfacesAbstractFactories.IResolutionsAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Components.Resolutions.AbstractFactories.ResolutionsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Components.Shapes.InterfacesAbstractFactories.IShapesAbstractFactory CreateECSComponentsShapesAbstractFactory()
        {
            BeVelS.ECS.Components.Shapes.InterfacesAbstractFactories.IShapesAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Components.Shapes.AbstractFactories.ShapesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Messages.Cameras.InterfacesAbstractFactories.ICamerasAbstractFactory CreateECSMessagesCamerasAbstractFactory()
        {
            BeVelS.ECS.Messages.Cameras.InterfacesAbstractFactories.ICamerasAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Messages.Cameras.AbstractFactories.CamerasAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Messages.CommandLists.InterfacesAbstractFactories.ICommandListsAbstractFactory CreateECSMessagesCommandListsAbstractFactory()
        {
            BeVelS.ECS.Messages.CommandLists.InterfacesAbstractFactories.ICommandListsAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Messages.CommandLists.AbstractFactories.CommandListsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Messages.Debugging.InterfacesAbstractFactories.IDebuggingAbstractFactory CreateECSMessagesDebuggingAbstractFactory()
        {
            BeVelS.ECS.Messages.Debugging.InterfacesAbstractFactories.IDebuggingAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Messages.Debugging.AbstractFactories.DebuggingAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Messages.PlaybackEngines.InterfacesAbstractFactories.IPlaybackEnginesAbstractFactory CreateECSMessagesPlaybackEnginesAbstractFactory()
        {
            BeVelS.ECS.Messages.PlaybackEngines.InterfacesAbstractFactories.IPlaybackEnginesAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Messages.PlaybackEngines.AbstractFactories.PlaybackEnginesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Messages.Recorders.InterfacesAbstractFactories.IRecordersAbstractFactory CreateECSMessagesRecordersAbstractFactory()
        {
            BeVelS.ECS.Messages.Recorders.InterfacesAbstractFactories.IRecordersAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Messages.Recorders.AbstractFactories.RecordersAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Messages.Renderers.InterfacesAbstractFactories.IRenderersAbstractFactory CreateECSMessagesRenderersAbstractFactory()
        {
            BeVelS.ECS.Messages.Renderers.InterfacesAbstractFactories.IRenderersAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Messages.Renderers.AbstractFactories.RenderersAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.QuasiSystems.Runners.InterfacesAbstractFactories.IRunnersAbstractFactory CreateECSQuasiSystemsRunnersAbstractFactory()
        {
            BeVelS.ECS.QuasiSystems.Runners.InterfacesAbstractFactories.IRunnersAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.QuasiSystems.Runners.AbstractFactories.RunnersAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Systems.InterfacesAbstractFactories.ISystemsAbstractFactory CreateECSSystemsAbstractFactory()
        {
            BeVelS.ECS.Systems.InterfacesAbstractFactories.ISystemsAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Systems.AbstractFactories.SystemsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Systems.BufferPools.InterfacesAbstractFactories.IBufferPoolsAbstractFactory CreateECSSystemsBufferPoolsAbstractFactory()
        {
            BeVelS.ECS.Systems.BufferPools.InterfacesAbstractFactories.IBufferPoolsAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Systems.BufferPools.AbstractFactories.BufferPoolsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Systems.Cameras.InterfacesAbstractFactories.ICamerasAbstractFactory CreateECSSystemsCamerasAbstractFactory()
        {
            BeVelS.ECS.Systems.Cameras.InterfacesAbstractFactories.ICamerasAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Systems.Cameras.AbstractFactories.CamerasAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Systems.CollidableShapes.InterfacesAbstractFactories.ICollidableShapesAbstractFactory CreateECSSystemsCollidableShapesAbstractFactory()
        {
            BeVelS.ECS.Systems.CollidableShapes.InterfacesAbstractFactories.ICollidableShapesAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Systems.CollidableShapes.AbstractFactories.CollidableShapesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Systems.CommandLists.InterfacesAbstractFactories.ICommandListsAbstractFactory CreateECSSystemsCommandListsAbstractFactory()
        {
            BeVelS.ECS.Systems.CommandLists.InterfacesAbstractFactories.ICommandListsAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Systems.CommandLists.AbstractFactories.CommandListsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Systems.Debugging.InterfacesAbstractFactories.IDebuggingAbstractFactory CreateECSSystemsDebuggingAbstractFactory()
        {
            BeVelS.ECS.Systems.Debugging.InterfacesAbstractFactories.IDebuggingAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Systems.Debugging.AbstractFactories.DebuggingAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Systems.Fonts.InterfacesAbstractFactories.IFontsAbstractFactory CreateECSSystemsFontsAbstractFactory()
        {
            BeVelS.ECS.Systems.Fonts.InterfacesAbstractFactories.IFontsAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Systems.Fonts.AbstractFactories.FontsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Systems.Framebuffers.InterfacesAbstractFactories.IFramebuffersAbstractFactory CreateECSSystemsFramebuffersAbstractFactory()
        {
            BeVelS.ECS.Systems.Framebuffers.InterfacesAbstractFactories.IFramebuffersAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Systems.Framebuffers.AbstractFactories.FramebuffersAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Systems.GraphicsDevices.InterfacesAbstractFactories.IGraphicsDevicesAbstractFactory CreateECSSystemsGraphicsDevicesAbstractFactory()
        {
            BeVelS.ECS.Systems.GraphicsDevices.InterfacesAbstractFactories.IGraphicsDevicesAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Systems.GraphicsDevices.AbstractFactories.GraphicsDevicesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Systems.PlaybackEngines.InterfacesAbstractFactories.IPlaybackEnginesAbstractFactory CreateECSSystemsPlaybackEnginesAbstractFactory()
        {
            BeVelS.ECS.Systems.PlaybackEngines.InterfacesAbstractFactories.IPlaybackEnginesAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Systems.PlaybackEngines.AbstractFactories.PlaybackEnginesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Systems.Recorders.InterfacesAbstractFactories.IRecordersAbstractFactory CreateECSSystemsRecordersAbstractFactory()
        {
            BeVelS.ECS.Systems.Recorders.InterfacesAbstractFactories.IRecordersAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Systems.Recorders.AbstractFactories.RecordersAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Systems.RenderSurfaces.InterfacesAbstractFactories.IRenderSurfacesAbstractFactory CreateECSSystemsRenderSurfacesAbstractFactory()
        {
            BeVelS.ECS.Systems.RenderSurfaces.InterfacesAbstractFactories.IRenderSurfacesAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Systems.RenderSurfaces.AbstractFactories.RenderSurfacesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Systems.RenderTargets.InterfacesAbstractFactories.IRenderTargetsAbstractFactory CreateECSSystemsRenderTargetsAbstractFactory()
        {
            BeVelS.ECS.Systems.RenderTargets.InterfacesAbstractFactories.IRenderTargetsAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Systems.RenderTargets.AbstractFactories.RenderTargetsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Systems.Resolutions.InterfacesAbstractFactories.IResolutionsAbstractFactory CreateECSSystemsResolutionsAbstractFactory()
        {
            BeVelS.ECS.Systems.Resolutions.InterfacesAbstractFactories.IResolutionsAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Systems.Resolutions.AbstractFactories.ResolutionsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Systems.Simulations.InterfacesAbstractFactories.ISimulationsAbstractFactory CreateECSSystemsSimulationsAbstractFactory()
        {
            BeVelS.ECS.Systems.Simulations.InterfacesAbstractFactories.ISimulationsAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Systems.Simulations.AbstractFactories.SimulationsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Systems.TimeSteps.InterfacesAbstractFactories.ITimeStepsAbstractFactory CreateECSSystemsTimeStepsAbstractFactory()
        {
            BeVelS.ECS.Systems.TimeSteps.InterfacesAbstractFactories.ITimeStepsAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Systems.TimeSteps.AbstractFactories.TimeStepsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.ECS.Systems.Viewports.InterfacesAbstractFactories.IViewportsAbstractFactory CreateECSSystemsViewportsAbstractFactory()
        {
            BeVelS.ECS.Systems.Viewports.InterfacesAbstractFactories.IViewportsAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.ECS.Systems.Viewports.AbstractFactories.ViewportsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IBlendStatesAbstractFactory CreateGraphicsBlendStatesAbstractFactory()
        {
            IBlendStatesAbstractFactory factory = null;

            try
            {
                factory = new BlendStatesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IBufferConstantsAbstractFactory CreateGraphicsBufferConstantsAbstractFactory()
        {
            IBufferConstantsAbstractFactory factory = null;

            try
            {
                factory = new BufferConstantsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IBuffersAbstractFactory CreateGraphicsBuffersAbstractFactory()
        {
            IBuffersAbstractFactory factory = null;

            try
            {
                factory = new BuffersAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.Graphics.Cameras.InterfacesAbstractFactories.ICamerasAbstractFactory CreateGraphicsCamerasAbstractFactory()
        {
            BeVelS.Graphics.Cameras.InterfacesAbstractFactories.ICamerasAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.Graphics.Cameras.AbstractFactories.CamerasAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.Graphics.CommandLists.InterfacesAbstractFactories.ICommandListsAbstractFactory CreateGraphicsCommandListsAbstractFactory()
        {
            BeVelS.Graphics.CommandLists.InterfacesAbstractFactories.ICommandListsAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.Graphics.CommandLists.AbstractFactories.CommandListsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IDebuggingAbstractFactory CreateGraphicsDebuggingAbstractFactory()
        {
            IDebuggingAbstractFactory factory = null;

            try
            {
                factory = new DebuggingAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IDepthStencilStatesAbstractFactory CreateGraphicsDepthStencilStatesAbstractFactory()
        {
            IDepthStencilStatesAbstractFactory factory = null;

            try
            {
                factory = new DepthStencilStatesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.Graphics.Fonts.InterfacesAbstractFactories.IFontsAbstractFactory CreateGraphicsFontsAbstractFactory()
        {
            BeVelS.Graphics.Fonts.InterfacesAbstractFactories.IFontsAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.Graphics.Fonts.AbstractFactories.FontsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.Graphics.Framebuffers.InterfacesAbstractFactories.IFramebuffersAbstractFactory CreateGraphicsFramebuffersAbstractFactory()
        {
            BeVelS.Graphics.Framebuffers.InterfacesAbstractFactories.IFramebuffersAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.Graphics.Framebuffers.AbstractFactories.FramebuffersAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IGlyphsAbstractFactory CreateGraphicsGlyphsAbstractFactory()
        {
            IGlyphsAbstractFactory factory = null;

            try
            {
                factory = new GlyphsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IGraphDataSeriesAbstractFactory CreateGraphicsGraphDataSeriesAbstractFactory()
        {
            IGraphDataSeriesAbstractFactory factory = null;

            try
            {
                factory = new GraphDataSeriesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.Graphics.GraphicsDevices.InterfacesAbstractFactories.IGraphicsDevicesAbstractFactory CreateGraphicsGraphicsDevicesAbstractFactory()
        {
            BeVelS.Graphics.GraphicsDevices.InterfacesAbstractFactories.IGraphicsDevicesAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.Graphics.GraphicsDevices.AbstractFactories.GraphicsDevicesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IGraphicsPipelinesAbstractFactory CreateGraphicsGraphicsPipelinesAbstractFactory()
        {
            IGraphicsPipelinesAbstractFactory factory = null;

            try
            {
                factory = new GraphicsPipelinesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IHTMLAbstractFactory CreateGraphicsHTMLAbstractFactory()
        {
            IHTMLAbstractFactory factory = null;

            try
            {
                factory = new HTMLAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IImagesAbstractFactory CreateGraphicsImagesAbstractFactory()
        {
            IImagesAbstractFactory factory = null;

            try
            {
                factory = new ImagesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IKTXAbstractFactory CreateGraphicsKTXAbstractFactory()
        {
            IKTXAbstractFactory factory = null;

            try
            {
                factory = new KTXAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.Graphics.Meshes.InterfacesAbstractFactories.IMeshesAbstractFactory CreateGraphicsMeshesAbstractFactory()
        {
            BeVelS.Graphics.Meshes.InterfacesAbstractFactories.IMeshesAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.Graphics.Meshes.AbstractFactories.MeshesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.Graphics.PostProcessors.InterfacesAbstractFactories.IPostProcessorsAbstractFactory CreateGraphicsPostProcessorsAbstractFactory()
        {
            IPostProcessorsAbstractFactory factory = null;

            try
            {
                factory = new PostProcessorsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IRasterizerStatesAbstractFactory CreateGraphicsRasterizerStatesAbstractFactory()
        {
            IRasterizerStatesAbstractFactory factory = null;

            try
            {
                factory = new RasterizerStatesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.Graphics.Recorders.InterfacesAbstractFactories.IRecordersAbstractFactory CreateGraphicsRecordersAbstractFactory()
        {
            BeVelS.Graphics.Recorders.InterfacesAbstractFactories.IRecordersAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.Graphics.Recorders.AbstractFactories.RecordersAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IResourceSetsAbstractFactory CreateGraphicsResourceSetsAbstractFactory()
        {
            IResourceSetsAbstractFactory factory = null;

            try
            {
                factory = new ResourceSetsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISamplersAbstractFactory CreateGraphicsSamplersAbstractFactory()
        {
            ISamplersAbstractFactory factory = null;

            try
            {
                factory = new SamplersAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IShaderSetsAbstractFactory CreateGraphicsShaderSetsAbstractFactory()
        {
            IShaderSetsAbstractFactory factory = null;

            try
            {
                factory = new ShaderSetsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.Graphics.Shapes.InterfacesAbstractFactories.IShapesAbstractFactory CreateGraphicsShapesAbstractFactory()
        {
            BeVelS.Graphics.Shapes.InterfacesAbstractFactories.IShapesAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.Graphics.Shapes.AbstractFactories.ShapesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISwapchainsAbstractFactory CreateGraphicsSwapchainsAbstractFactory()
        {
            ISwapchainsAbstractFactory factory = null;

            try
            {
                factory = new SwapchainsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITextAbstractFactory CreateGraphicsTextAbstractFactory()
        {
            ITextAbstractFactory factory = null;

            try
            {
                factory = new TextAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITexturesAbstractFactory CreateGraphicsTexturesAbstractFactory()
        {
            ITexturesAbstractFactory factory = null;

            try
            {
                factory = new TexturesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IUILinesAbstractFactory CreateGraphicsUILinesAbstractFactory()
        {
            IUILinesAbstractFactory factory = null;

            try
            {
                factory = new UILinesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IVertexLayoutsAbstractFactory CreateGraphicsVertexLayoutsAbstractFactory()
        {
            IVertexLayoutsAbstractFactory factory = null;

            try
            {
                factory = new VertexLayoutsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IVerticesAbstractFactory CreateGraphicsVerticesAbstractFactory()
        {
            IVerticesAbstractFactory factory = null;

            try
            {
                factory = new VerticesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.Graphics.Viewports.InterfacesAbstractFactories.IViewportsAbstractFactory CreateGraphicsViewportsAbstractFactory()
        {
            BeVelS.Graphics.Viewports.InterfacesAbstractFactories.IViewportsAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.Graphics.Viewports.AbstractFactories.ViewportsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IPhysicsAbstractFactory CreatePhysicsAbstractFactory()
        {
            IPhysicsAbstractFactory factory = null;

            try
            {
                factory = new PhysicsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICallbacksAbstractFactory CreatePhysicsCallbacksAbstractFactory()
        {
            ICallbacksAbstractFactory factory = null;

            try
            {
                factory = new CallbacksAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICollidablesAbstractFactory CreatePhysicsCollidablesAbstractFactory()
        {
            ICollidablesAbstractFactory factory = null;

            try
            {
                factory = new CollidablesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IConstraintsAbstractFactory CreatePhysicsConstraintsAbstractFactory()
        {
            IConstraintsAbstractFactory factory = null;

            try
            {
                factory = new ConstraintsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public BeVelS.Physics.Meshes.InterfacesAbstractFactories.IMeshesAbstractFactory CreatePhysicsMeshesAbstractFactory()
        {
            BeVelS.Physics.Meshes.InterfacesAbstractFactories.IMeshesAbstractFactory factory = null;

            try
            {
                factory = new BeVelS.Physics.Meshes.AbstractFactories.MeshesAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITimeStepsAbstractFactory CreatePhysicsTimeStepsAbstractFactory()
        {
            ITimeStepsAbstractFactory factory = null;

            try
            {
                factory = new TimeStepsAbstractFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}