// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestAzuredevopsArgs : global::Pulumi.ResourceArgs
    {
        [Input("api")]
        public Input<string>? Api { get; set; }

        [Input("labels")]
        private InputList<string>? _labels;
        public InputList<string> Labels
        {
            get => _labels ?? (_labels = new InputList<string>());
            set => _labels = value;
        }

        [Input("organization", required: true)]
        public Input<string> Organization { get; set; } = null!;

        [Input("project", required: true)]
        public Input<string> Project { get; set; } = null!;

        [Input("repo", required: true)]
        public Input<string> Repo { get; set; } = null!;

        [Input("tokenRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestAzuredevopsTokenRefArgs>? TokenRef { get; set; }

        public ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestAzuredevopsArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestAzuredevopsArgs Empty => new ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestAzuredevopsArgs();
    }
}
