// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesPluginArgs : global::Pulumi.ResourceArgs
    {
        [Input("env")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesPluginEnvArgs>? _env;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesPluginEnvArgs> Env
        {
            get => _env ?? (_env = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesPluginEnvArgs>());
            set => _env = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("parameters")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesPluginParametersArgs>? _parameters;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesPluginParametersArgs> Parameters
        {
            get => _parameters ?? (_parameters = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesPluginParametersArgs>());
            set => _parameters = value;
        }

        public ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesPluginArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesPluginArgs Empty => new ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesPluginArgs();
    }
}
