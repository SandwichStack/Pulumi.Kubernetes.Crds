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
    public sealed class ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSyncPolicyManagedNamespaceMetadata
    {
        public readonly ImmutableDictionary<string, string> Annotations;
        public readonly ImmutableDictionary<string, string> Labels;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSyncPolicyManagedNamespaceMetadata(
            ImmutableDictionary<string, string> annotations,

            ImmutableDictionary<string, string> labels)
        {
            Annotations = annotations;
            Labels = labels;
        }
    }
}
