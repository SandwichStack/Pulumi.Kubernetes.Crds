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
    /// Sync contains information about the application's current sync status
    /// </summary>
    [OutputType]
    public sealed class ApplicationStatusSync
    {
        /// <summary>
        /// ComparedTo contains information about what has been compared
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedTo ComparedTo;
        /// <summary>
        /// Revision contains information about the revision the comparison has been performed to
        /// </summary>
        public readonly string Revision;
        /// <summary>
        /// Revisions contains information about the revisions of multiple sources the comparison has been performed to
        /// </summary>
        public readonly ImmutableArray<string> Revisions;
        /// <summary>
        /// Status is the sync state of the comparison
        /// </summary>
        public readonly string Status;

        [OutputConstructor]
        private ApplicationStatusSync(
            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedTo comparedTo,

            string revision,

            ImmutableArray<string> revisions,

            string status)
        {
            ComparedTo = comparedTo;
            Revision = revision;
            Revisions = revisions;
            Status = status;
        }
    }
}
