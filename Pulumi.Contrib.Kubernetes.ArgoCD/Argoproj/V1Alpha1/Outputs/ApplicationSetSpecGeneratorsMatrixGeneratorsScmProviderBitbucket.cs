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
    public sealed class ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucket
    {
        public readonly bool AllBranches;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucketAppPasswordRef AppPasswordRef;
        public readonly string Owner;
        public readonly string User;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucket(
            bool allBranches,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucketAppPasswordRef appPasswordRef,

            string owner,

            string user)
        {
            AllBranches = allBranches;
            AppPasswordRef = appPasswordRef;
            Owner = owner;
            User = user;
        }
    }
}