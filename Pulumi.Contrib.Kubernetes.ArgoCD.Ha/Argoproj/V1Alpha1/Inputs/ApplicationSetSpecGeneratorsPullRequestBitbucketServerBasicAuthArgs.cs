// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsPullRequestBitbucketServerBasicAuthArgs : global::Pulumi.ResourceArgs
    {
        [Input("passwordRef", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPullRequestBitbucketServerBasicAuthPasswordRefArgs> PasswordRef { get; set; } = null!;

        [Input("username", required: true)]
        public Input<string> Username { get; set; } = null!;

        public ApplicationSetSpecGeneratorsPullRequestBitbucketServerBasicAuthArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsPullRequestBitbucketServerBasicAuthArgs Empty => new ApplicationSetSpecGeneratorsPullRequestBitbucketServerBasicAuthArgs();
    }
}
