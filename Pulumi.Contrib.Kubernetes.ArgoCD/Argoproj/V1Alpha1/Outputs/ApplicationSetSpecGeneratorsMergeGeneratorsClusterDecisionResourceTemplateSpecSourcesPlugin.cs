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
    public sealed class ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesPlugin
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesPluginEnv> Env;
        public readonly string Name;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesPluginParameters> Parameters;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesPlugin(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesPluginEnv> env,

            string name,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesPluginParameters> parameters)
        {
            Env = env;
            Name = name;
            Parameters = parameters;
        }
    }
}
