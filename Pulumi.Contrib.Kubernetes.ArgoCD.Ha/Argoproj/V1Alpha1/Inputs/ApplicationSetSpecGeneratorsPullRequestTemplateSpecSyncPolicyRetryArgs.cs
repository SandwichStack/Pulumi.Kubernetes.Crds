// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsPullRequestTemplateSpecSyncPolicyRetryArgs : global::Pulumi.ResourceArgs
    {
        [Input("backoff")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsPullRequestTemplateSpecSyncPolicyRetryBackoffArgs>? Backoff { get; set; }

        [Input("limit")]
        public Input<int>? Limit { get; set; }

        public ApplicationSetSpecGeneratorsPullRequestTemplateSpecSyncPolicyRetryArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsPullRequestTemplateSpecSyncPolicyRetryArgs Empty => new ApplicationSetSpecGeneratorsPullRequestTemplateSpecSyncPolicyRetryArgs();
    }
}
