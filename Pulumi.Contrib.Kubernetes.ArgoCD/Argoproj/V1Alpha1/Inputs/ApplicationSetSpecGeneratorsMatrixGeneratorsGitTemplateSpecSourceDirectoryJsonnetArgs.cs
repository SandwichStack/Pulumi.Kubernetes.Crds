// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceDirectoryJsonnetArgs : global::Pulumi.ResourceArgs
    {
        [Input("extVars")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceDirectoryJsonnetExtVarsArgs>? _extVars;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceDirectoryJsonnetExtVarsArgs> ExtVars
        {
            get => _extVars ?? (_extVars = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceDirectoryJsonnetExtVarsArgs>());
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
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceDirectoryJsonnetTlasArgs>? _tlas;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceDirectoryJsonnetTlasArgs> Tlas
        {
            get => _tlas ?? (_tlas = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceDirectoryJsonnetTlasArgs>());
            set => _tlas = value;
        }

        public ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceDirectoryJsonnetArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceDirectoryJsonnetArgs Empty => new ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceDirectoryJsonnetArgs();
    }
}