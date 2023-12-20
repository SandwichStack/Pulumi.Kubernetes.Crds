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
    /// Jsonnet holds options specific to Jsonnet
    /// </summary>
    [OutputType]
    public sealed class ApplicationStatusSyncComparedToSourcesDirectoryJsonnet
    {
        /// <summary>
        /// ExtVars is a list of Jsonnet External Variables
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedToSourcesDirectoryJsonnetExtVars> ExtVars;
        /// <summary>
        /// Additional library search dirs
        /// </summary>
        public readonly ImmutableArray<string> Libs;
        /// <summary>
        /// TLAS is a list of Jsonnet Top-level Arguments
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedToSourcesDirectoryJsonnetTlas> Tlas;

        [OutputConstructor]
        private ApplicationStatusSyncComparedToSourcesDirectoryJsonnet(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedToSourcesDirectoryJsonnetExtVars> extVars,

            ImmutableArray<string> libs,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedToSourcesDirectoryJsonnetTlas> tlas)
        {
            ExtVars = extVars;
            Libs = libs;
            Tlas = tlas;
        }
    }
}