// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucketServerBasicAuthPasswordRefArgs : global::Pulumi.ResourceArgs
    {
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        [Input("secretName", required: true)]
        public Input<string> SecretName { get; set; } = null!;

        public ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucketServerBasicAuthPasswordRefArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucketServerBasicAuthPasswordRefArgs Empty => new ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucketServerBasicAuthPasswordRefArgs();
    }
}
