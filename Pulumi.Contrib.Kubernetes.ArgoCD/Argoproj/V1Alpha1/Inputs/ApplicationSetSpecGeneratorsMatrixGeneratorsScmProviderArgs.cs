// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderArgs : global::Pulumi.ResourceArgs
    {
        [Input("awsCodeCommit")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderAwsCodeCommitArgs>? AwsCodeCommit { get; set; }

        [Input("azureDevOps")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderAzureDevOpsArgs>? AzureDevOps { get; set; }

        [Input("bitbucket")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucketArgs>? Bitbucket { get; set; }

        [Input("bitbucketServer")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucketServerArgs>? BitbucketServer { get; set; }

        [Input("cloneProtocol")]
        public Input<string>? CloneProtocol { get; set; }

        [Input("filters")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderFiltersArgs>? _filters;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderFiltersArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderFiltersArgs>());
            set => _filters = value;
        }

        [Input("gitea")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderGiteaArgs>? Gitea { get; set; }

        [Input("github")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderGithubArgs>? Github { get; set; }

        [Input("gitlab")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderGitlabArgs>? Gitlab { get; set; }

        [Input("requeueAfterSeconds")]
        public Input<int>? RequeueAfterSeconds { get; set; }

        [Input("template")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateArgs>? Template { get; set; }

        [Input("values")]
        private InputMap<string>? _values;
        public InputMap<string> Values
        {
            get => _values ?? (_values = new InputMap<string>());
            set => _values = value;
        }

        public ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderArgs Empty => new ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderArgs();
    }
}
