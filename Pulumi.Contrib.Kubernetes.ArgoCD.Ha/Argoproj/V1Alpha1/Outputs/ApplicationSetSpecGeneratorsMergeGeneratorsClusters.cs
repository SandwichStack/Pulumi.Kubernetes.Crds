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
    public sealed class ApplicationSetSpecGeneratorsMergeGeneratorsClusters
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsClustersSelector Selector;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplate Template;
        public readonly ImmutableDictionary<string, string> Values;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMergeGeneratorsClusters(
            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsClustersSelector selector,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplate template,

            ImmutableDictionary<string, string> values)
        {
            Selector = selector;
            Template = template;
            Values = values;
        }
    }
}
