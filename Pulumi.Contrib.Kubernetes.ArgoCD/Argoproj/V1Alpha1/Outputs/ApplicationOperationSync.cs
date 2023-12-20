// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1
{

    /// <summary>
    /// Sync contains parameters for the operation
    /// </summary>
    [OutputType]
    public sealed class ApplicationOperationSync
    {
        /// <summary>
        /// DryRun specifies to perform a `kubectl apply --dry-run` without actually performing the sync
        /// </summary>
        public readonly bool DryRun;
        /// <summary>
        /// Manifests is an optional field that overrides sync source with a local directory for development
        /// </summary>
        public readonly ImmutableArray<string> Manifests;
        /// <summary>
        /// Prune specifies to delete resources from the cluster that are no longer tracked in git
        /// </summary>
        public readonly bool Prune;
        /// <summary>
        /// Resources describes which resources shall be part of the sync
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationOperationSyncResources> Resources;
        /// <summary>
        /// Revision is the revision (Git) or chart version (Helm) which to sync the application to If omitted, will use the revision specified in app spec.
        /// </summary>
        public readonly string Revision;
        /// <summary>
        /// Revisions is the list of revision (Git) or chart version (Helm) which to sync each source in sources field for the application to If omitted, will use the revision specified in app spec.
        /// </summary>
        public readonly ImmutableArray<string> Revisions;
        /// <summary>
        /// Source overrides the source definition set in the application. This is typically set in a Rollback operation and is nil during a Sync operation
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationOperationSyncSource Source;
        /// <summary>
        /// Sources overrides the source definition set in the application. This is typically set in a Rollback operation and is nil during a Sync operation
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationOperationSyncSources> Sources;
        /// <summary>
        /// SyncOptions provide per-sync sync-options, e.g. Validate=false
        /// </summary>
        public readonly ImmutableArray<string> SyncOptions;
        /// <summary>
        /// SyncStrategy describes how to perform the sync
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationOperationSyncSyncStrategy SyncStrategy;

        [OutputConstructor]
        private ApplicationOperationSync(
            bool dryRun,

            ImmutableArray<string> manifests,

            bool prune,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationOperationSyncResources> resources,

            string revision,

            ImmutableArray<string> revisions,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationOperationSyncSource source,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationOperationSyncSources> sources,

            ImmutableArray<string> syncOptions,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationOperationSyncSyncStrategy syncStrategy)
        {
            DryRun = dryRun;
            Manifests = manifests;
            Prune = prune;
            Resources = resources;
            Revision = revision;
            Revisions = revisions;
            Source = source;
            Sources = sources;
            SyncOptions = syncOptions;
            SyncStrategy = syncStrategy;
        }
    }
}