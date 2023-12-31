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
    public sealed class ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSyncPolicy
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSyncPolicyAutomated Automated;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSyncPolicyManagedNamespaceMetadata ManagedNamespaceMetadata;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSyncPolicyRetry Retry;
        public readonly ImmutableArray<string> SyncOptions;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSyncPolicy(
            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSyncPolicyAutomated automated,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSyncPolicyManagedNamespaceMetadata managedNamespaceMetadata,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSyncPolicyRetry retry,

            ImmutableArray<string> syncOptions)
        {
            Automated = automated;
            ManagedNamespaceMetadata = managedNamespaceMetadata;
            Retry = retry;
            SyncOptions = syncOptions;
        }
    }
}
