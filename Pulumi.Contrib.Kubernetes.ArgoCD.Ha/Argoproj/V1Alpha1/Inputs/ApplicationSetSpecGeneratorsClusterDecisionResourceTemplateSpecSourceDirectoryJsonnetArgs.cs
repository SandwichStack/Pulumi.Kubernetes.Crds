// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetArgs : global::Pulumi.ResourceArgs
    {
        [Input("extVars")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetExtVarsArgs>? _extVars;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetExtVarsArgs> ExtVars
        {
            get => _extVars ?? (_extVars = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetExtVarsArgs>());
            set => _extVars = value;
        }

        [Input("libs")]
        private InputList<string>? _libs;
        public InputList<string> Libs
        {
            get => _libs ?? (_libs = new InputList<string>());
            set => _libs = value;
        }

        [Input("tlas")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetTlasArgs>? _tlas;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetTlasArgs> Tlas
        {
            get => _tlas ?? (_tlas = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetTlasArgs>());
            set => _tlas = value;
        }

        public ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetArgs Empty => new ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetArgs();
    }
}
