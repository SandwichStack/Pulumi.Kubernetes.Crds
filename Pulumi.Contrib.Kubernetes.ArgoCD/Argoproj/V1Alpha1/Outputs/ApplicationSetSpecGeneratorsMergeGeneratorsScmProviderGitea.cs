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
    public sealed class ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderGitea
    {
        public readonly bool AllBranches;
        public readonly string Api;
        public readonly bool Insecure;
        public readonly string Owner;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderGiteaTokenRef TokenRef;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderGitea(
            bool allBranches,

            string api,

            bool insecure,

            string owner,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderGiteaTokenRef tokenRef)
        {
            AllBranches = allBranches;
            Api = api;
            Insecure = insecure;
            Owner = owner;
            TokenRef = tokenRef;
        }
    }
}
