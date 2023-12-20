// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    /// <summary>
    /// SyncResult is the result of a Sync operation
    /// </summary>
    public class ApplicationStatusOperationStateSyncResultArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// ManagedNamespaceMetadata contains the current sync state of managed namespace metadata
        /// </summary>
        [Input("managedNamespaceMetadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultManagedNamespaceMetadataArgs>? ManagedNamespaceMetadata { get; set; }

        [Input("resources")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultResourcesArgs>? _resources;

        /// <summary>
        /// Resources contains a list of sync result items for each individual resource in a sync operation
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultResourcesArgs> Resources
        {
            get => _resources ?? (_resources = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultResourcesArgs>());
            set => _resources = value;
        }

        /// <summary>
        /// Revision holds the revision this sync operation was performed to
        /// </summary>
        [Input("revision", required: true)]
        public Input<string> Revision { get; set; } = null!;

        [Input("revisions")]
        private InputList<string>? _revisions;

        /// <summary>
        /// Revisions holds the revision this sync operation was performed for respective indexed source in sources field
        /// </summary>
        public InputList<string> Revisions
        {
            get => _revisions ?? (_revisions = new InputList<string>());
            set => _revisions = value;
        }

        /// <summary>
        /// Source records the application source information of the sync, used for comparing auto-sync
        /// </summary>
        [Input("source")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultSourceArgs>? Source { get; set; }

        [Input("sources")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultSourcesArgs>? _sources;

        /// <summary>
        /// Source records the application source information of the sync, used for comparing auto-sync
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultSourcesArgs> Sources
        {
            get => _sources ?? (_sources = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultSourcesArgs>());
            set => _sources = value;
        }

        public ApplicationStatusOperationStateSyncResultArgs()
        {
        }
        public static new ApplicationStatusOperationStateSyncResultArgs Empty => new ApplicationStatusOperationStateSyncResultArgs();
    }
}
