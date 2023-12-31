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
    public sealed class ApplicationSetSpecGeneratorsClustersSelector
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsClustersSelectorMatchExpressions> MatchExpressions;
        public readonly ImmutableDictionary<string, string> MatchLabels;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsClustersSelector(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsClustersSelectorMatchExpressions> matchExpressions,

            ImmutableDictionary<string, string> matchLabels)
        {
            MatchExpressions = matchExpressions;
            MatchLabels = matchLabels;
        }
    }
}
