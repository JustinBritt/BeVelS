namespace BeVelS.Physics.Constraints.Classes
{
    using BepuPhysics;

    using BepuUtilities;
    using BepuUtilities.Collections;
    using BepuUtilities.Memory;

    using BeVelS.Common.Parallelism.Classes;
    using BeVelS.Common.Parallelism.Interfaces;

    using BeVelS.Licensing.Classes;

    using BeVelS.Physics.Constraints.Interfaces;
    using BeVelS.Physics.Constraints.Structs.Lines;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/Constraints/LineExtractor.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Added GetLines method")]
    public sealed class LineExtractor : ILineExtractor
    {
        internal QuickList<LineInstance> lines;
        
        ConstraintLineExtractor constraints;
        
        BoundingBoxLineExtractor boundingBoxes;

        BufferPool pool;
        
        IParallelLooper looper;
        
        LooperAction executeJobAction;

        public bool ShowConstraints = true;

        public bool ShowContacts;
        
        public bool ShowBoundingBoxes;

        public LineExtractor(
            BufferPool pool,
            IParallelLooper looper,
            int initialLineCapacity = 8192)
        {
            this.lines = new QuickList<LineInstance>(
                initialLineCapacity,
                pool);

            this.constraints = new ConstraintLineExtractor();
            
            this.boundingBoxes = new BoundingBoxLineExtractor();
            
            this.pool = pool;
            
            this.looper = looper;
            
            this.executeJobAction = ExecuteJob;

        }

        Simulation[] simulations;

        Simulation simulation;
        
        QuickList<ConstraintLineExtractor.ThreadJob> constraintJobs;
        
        QuickList<BoundingBoxLineExtractor.ThreadJob> boundingBoxJobs;

        void ExecuteJob(
            int jobIndex,
            int workerIndex)
        {
            if (jobIndex >= this.constraintJobs.Count)
            {
                // This is a bounding box job.
                var job = this.boundingBoxJobs[jobIndex - this.constraintJobs.Count];

                var simulation = this.simulations == null ? this.simulation : this.simulations[job.SimulationIndex];
                
                this.boundingBoxes.ExecuteJob(
                    this.lines.Span,
                    simulation,
                    job);
            }
            else
            {
                // This is a constraint job.
                var job = this.constraintJobs[jobIndex];
                
                var simulation = this.simulations == null ? this.simulation : this.simulations[job.SimulationIndex];
                
                this.constraints.ExecuteJob(
                    this.lines.Span,
                    simulation,
                    job);
            }
        }

        public void Extract(
            Simulation[] simulations,
            IThreadDispatcher threadDispatcher = null)
        {
            if (this.ShowConstraints || this.ShowContacts)
            {
                this.constraintJobs = new QuickList<ConstraintLineExtractor.ThreadJob>(
                    128,
                    this.pool);

                for (int i = 0; i < simulations.Length; ++i)
                {
                    this.constraints.CreateJobs(
                        simulations[i],
                        i,
                        this.ShowConstraints,
                        this.ShowContacts,
                        ref this.lines,
                        ref this.constraintJobs,
                        this.pool);
                }
            }

            if (this.ShowBoundingBoxes)
            {
                this.boundingBoxJobs = new QuickList<BoundingBoxLineExtractor.ThreadJob>(
                    128,
                    this.pool);

                for (int i = 0; i < simulations.Length; ++i)
                {
                    this.boundingBoxes.CreateJobs(
                        simulations[i],
                        i,
                        ref this.lines,
                        ref this.boundingBoxJobs,
                        this.pool);
                }
            }

            this.simulations = simulations;

            this.looper.Dispatcher = threadDispatcher;
            
            this.looper.For(
                0,
                this.constraintJobs.Count + this.boundingBoxJobs.Count,
                this.executeJobAction);
            
            this.looper.Dispatcher = null;

            if (this.constraintJobs.Span.Allocated)
            {
                this.constraintJobs.Dispose(
                    this.pool);
            
                this.constraintJobs = default;
            }
            if (this.boundingBoxJobs.Span.Allocated)
            {
                this.boundingBoxJobs.Dispose(
                    this.pool);
                
                this.boundingBoxJobs = default;
            }
            
            this.simulations = null;
        }

        public void Extract(
            Simulation simulation,
            IThreadDispatcher threadDispatcher = null)
        {
            this.simulation = simulation;

            if (this.ShowConstraints || this.ShowContacts)
            {
                this.constraintJobs = new QuickList<ConstraintLineExtractor.ThreadJob>(
                    128,
                    this.pool);

                this.constraints.CreateJobs(
                    simulation,
                    0,
                    this.ShowConstraints,
                    this.ShowContacts,
                    ref this.lines,
                    ref this.constraintJobs,
                    this.pool);
            }
            if (this.ShowBoundingBoxes)
            {
                this.boundingBoxJobs = new QuickList<BoundingBoxLineExtractor.ThreadJob>(
                    128, 
                    this.pool);

                this.boundingBoxes.CreateJobs(
                    simulation,
                    0,
                    ref this.lines,
                    ref this.boundingBoxJobs,
                    this.pool);
            }

            this.looper.Dispatcher = threadDispatcher;
            
            this.looper.For(
                0,
                this.constraintJobs.Count + this.boundingBoxJobs.Count,
                this.executeJobAction);
            
            this.looper.Dispatcher = null;

            if (this.constraintJobs.Span.Allocated)
            {
                this.constraintJobs.Dispose(
                    this.pool);
                
                this.constraintJobs = default;
            }
            if (this.boundingBoxJobs.Span.Allocated)
            {
                this.boundingBoxJobs.Dispose(
                    this.pool);
                
                this.boundingBoxJobs = default;
            }

            this.simulation = null;
        }

        public ref LineInstance Allocate()
        {
            return ref this.lines.Allocate(
                this.pool);
        }

        public ref LineInstance Allocate(
            int count)
        {
            return ref this.lines.Allocate(
                count,
                this.pool);
        }

        public void ClearInstances()
        {
            this.lines.Count = 0;
        }

        public QuickList<LineInstance> GetLines()
        {
            return this.lines;
        }

        public void Dispose()
        {
            this.lines.Dispose(
                this.pool);
        }
    }
}