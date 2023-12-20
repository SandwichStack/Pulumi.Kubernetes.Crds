// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucketServerArgs : global::Pulumi.ResourceArgs
    {
        [Input("allBranches")]
        public Input<bool>? AllBranches { get; set; }

        [Input("api", required: true)]
        public Input<string> Api { get; set; } = null!;

        [Input("basicAuth")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucketServerBasicAuthArgs>? BasicAuth { get; set; }

        [Input("project", required: true)]
        public Input<string> Project { get; set; } = null!;

        public ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucketServerArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucketServerArgs Empty => new ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucketServerArgs();
    }
}
