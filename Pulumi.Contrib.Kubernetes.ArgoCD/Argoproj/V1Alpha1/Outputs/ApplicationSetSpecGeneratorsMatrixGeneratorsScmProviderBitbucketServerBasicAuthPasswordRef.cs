// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1
{

    [OutputType]
    public sealed class ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucketServerBasicAuthPasswordRef
    {
        public readonly string Key;
        public readonly string SecretName;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucketServerBasicAuthPasswordRef(
            string key,

            string secretName)
        {
            Key = key;
            SecretName = secretName;
        }
    }
}
