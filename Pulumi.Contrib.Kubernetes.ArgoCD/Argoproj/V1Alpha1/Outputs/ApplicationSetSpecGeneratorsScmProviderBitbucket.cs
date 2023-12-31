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
    public sealed class ApplicationSetSpecGeneratorsScmProviderBitbucket
    {
        public readonly bool AllBranches;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsScmProviderBitbucketAppPasswordRef AppPasswordRef;
        public readonly string Owner;
        public readonly string User;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsScmProviderBitbucket(
            bool allBranches,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsScmProviderBitbucketAppPasswordRef appPasswordRef,

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
