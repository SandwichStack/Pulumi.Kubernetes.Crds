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
    public sealed class ApplicationSetSpecGeneratorsPluginTemplateSpecSyncPolicyRetry
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPluginTemplateSpecSyncPolicyRetryBackoff Backoff;
        public readonly int Limit;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsPluginTemplateSpecSyncPolicyRetry(
            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPluginTemplateSpecSyncPolicyRetryBackoff backoff,

            int limit)
        {
            Backoff = backoff;
            Limit = limit;
        }
    }
}
