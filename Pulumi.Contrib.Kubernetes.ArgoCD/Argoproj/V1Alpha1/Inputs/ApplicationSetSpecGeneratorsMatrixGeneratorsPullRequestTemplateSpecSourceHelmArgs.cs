// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceHelmArgs : global::Pulumi.ResourceArgs
    {
        [Input("fileParameters")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceHelmFileParametersArgs>? _fileParameters;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceHelmFileParametersArgs> FileParameters
        {
            get => _fileParameters ?? (_fileParameters = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceHelmFileParametersArgs>());
            set => _fileParameters = value;
        }

        [Input("ignoreMissingValueFiles")]
        public Input<bool>? IgnoreMissingValueFiles { get; set; }

        [Input("parameters")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceHelmParametersArgs>? _parameters;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceHelmParametersArgs> Parameters
        {
            get => _parameters ?? (_parameters = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceHelmParametersArgs>());
            set => _parameters = value;
        }

        [Input("passCredentials")]
        public Input<bool>? PassCredentials { get; set; }

        [Input("releaseName")]
        public Input<string>? ReleaseName { get; set; }

        [Input("skipCrds")]
        public Input<bool>? SkipCrds { get; set; }

        [Input("valueFiles")]
        private InputList<string>? _valueFiles;
        public InputList<string> ValueFiles
        {
            get => _valueFiles ?? (_valueFiles = new InputList<string>());
            set => _valueFiles = value;
        }

        [Input("values")]
        public Input<string>? Values { get; set; }

        [Input("valuesObject")]
        private InputMap<object>? _valuesObject;
        public InputMap<object> ValuesObject
        {
            get => _valuesObject ?? (_valuesObject = new InputMap<object>());
            set => _valuesObject = value;
        }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceHelmArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceHelmArgs Empty => new ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceHelmArgs();
    }
}
