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
    public sealed class ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcePlugin
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcePluginEnv> Env;
        public readonly string Name;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcePluginParameters> Parameters;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcePlugin(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcePluginEnv> env,

            string name,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcePluginParameters> parameters)
        {
            Env = env;
            Name = name;
            Parameters = parameters;
        }
    }
}
