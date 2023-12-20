// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestGiteaArgs : global::Pulumi.ResourceArgs
    {
        [Input("api", required: true)]
        public Input<string> Api { get; set; } = null!;

        [Input("insecure")]
        public Input<bool>? Insecure { get; set; }

        [Input("owner", required: true)]
        public Input<string> Owner { get; set; } = null!;

        [Input("repo", required: true)]
        public Input<string> Repo { get; set; } = null!;

        [Input("tokenRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestGiteaTokenRefArgs>? TokenRef { get; set; }

        public ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestGiteaArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestGiteaArgs Empty => new ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestGiteaArgs();
    }
}
