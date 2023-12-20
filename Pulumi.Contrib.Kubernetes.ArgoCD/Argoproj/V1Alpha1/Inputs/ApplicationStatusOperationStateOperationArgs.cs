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
    /// Operation is the original requested operation
    /// </summary>
    public class ApplicationStatusOperationStateOperationArgs : global::Pulumi.ResourceArgs
    {
        [Input("info")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationInfoArgs>? _info;

        /// <summary>
        /// Info is a list of informational items for this operation
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationInfoArgs> Info
        {
            get => _info ?? (_info = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationInfoArgs>());
            set => _info = value;
        }

        /// <summary>
        /// InitiatedBy contains information about who initiated the operations
        /// </summary>
        [Input("initiatedBy")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationInitiatedByArgs>? InitiatedBy { get; set; }

        /// <summary>
        /// Retry controls the strategy to apply if a sync fails
        /// </summary>
        [Input("retry")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationRetryArgs>? Retry { get; set; }

        /// <summary>
        /// Sync contains parameters for the operation
        /// </summary>
        [Input("sync")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncArgs>? Sync { get; set; }

        public ApplicationStatusOperationStateOperationArgs()
        {
        }
        public static new ApplicationStatusOperationStateOperationArgs Empty => new ApplicationStatusOperationStateOperationArgs();
    }
}
