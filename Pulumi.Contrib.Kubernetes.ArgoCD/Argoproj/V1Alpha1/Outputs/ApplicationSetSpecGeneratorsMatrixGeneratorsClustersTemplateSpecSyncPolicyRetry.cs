// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1
{

    [OutputType]
    public sealed class ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSyncPolicyRetry
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSyncPolicyRetryBackoff Backoff;
        public readonly int Limit;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSyncPolicyRetry(
            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSyncPolicyRetryBackoff backoff,

            int limit)
        {
            Backoff = backoff;
            Limit = limit;
        }
    }
}
