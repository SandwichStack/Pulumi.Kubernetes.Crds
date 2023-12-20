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
    /// Directory holds path/directory specific options
    /// </summary>
    [OutputType]
    public sealed class ApplicationStatusOperationStateOperationSyncSourceDirectory
    {
        /// <summary>
        /// Exclude contains a glob pattern to match paths against that should be explicitly excluded from being used during manifest generation
        /// </summary>
        public readonly string Exclude;
        /// <summary>
        /// Include contains a glob pattern to match paths against that should be explicitly included during manifest generation
        /// </summary>
        public readonly string Include;
        /// <summary>
        /// Jsonnet holds options specific to Jsonnet
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncSourceDirectoryJsonnet Jsonnet;
        /// <summary>
        /// Recurse specifies whether to scan a directory recursively for manifests
        /// </summary>
        public readonly bool Recurse;

        [OutputConstructor]
        private ApplicationStatusOperationStateOperationSyncSourceDirectory(
            string exclude,

            string include,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncSourceDirectoryJsonnet jsonnet,

            bool recurse)
        {
            Exclude = exclude;
            Include = include;
            Jsonnet = jsonnet;
            Recurse = recurse;
        }
    }
}