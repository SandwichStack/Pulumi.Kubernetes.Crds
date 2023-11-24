// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;

namespace Pulumi.Contrib.Kubernetes.CertManager.Acme.V1.Outputs
{

    /// <summary>
    /// A null or empty node selector term matches no objects. The requirements of them are ANDed. The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.
    /// </summary>
    [OutputType]
    public sealed class ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
    {
        /// <summary>
        /// A list of node selector requirements by node's labels.
        /// </summary>
        public readonly ImmutableArray<ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions> MatchExpressions;
        /// <summary>
        /// A list of node selector requirements by node's fields.
        /// </summary>
        public readonly ImmutableArray<ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields> MatchFields;

        [OutputConstructor]
        private ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms(
            ImmutableArray<ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions> matchExpressions,

            ImmutableArray<ChallengeSpecSolverHttp01IngressPodTemplateSpecAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields> matchFields)
        {
            MatchExpressions = matchExpressions;
            MatchFields = matchFields;
        }
    }
}