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
    public sealed class ApplicationSetSpecGeneratorsGitTemplateSpecSourcesPlugin
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsGitTemplateSpecSourcesPluginEnv> Env;
        public readonly string Name;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsGitTemplateSpecSourcesPluginParameters> Parameters;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsGitTemplateSpecSourcesPlugin(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsGitTemplateSpecSourcesPluginEnv> env,

            string name,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsGitTemplateSpecSourcesPluginParameters> parameters)
        {
            Env = env;
            Name = name;
            Parameters = parameters;
        }
    }
}
