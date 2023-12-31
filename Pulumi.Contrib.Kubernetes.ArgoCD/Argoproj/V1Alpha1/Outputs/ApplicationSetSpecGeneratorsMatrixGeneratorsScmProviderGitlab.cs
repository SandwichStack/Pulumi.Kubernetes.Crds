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
    public sealed class ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderGitlab
    {
        public readonly bool AllBranches;
        public readonly string Api;
        public readonly string Group;
        public readonly bool IncludeSubgroups;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderGitlabTokenRef TokenRef;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderGitlab(
            bool allBranches,

            string api,

            string group,

            bool includeSubgroups,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderGitlabTokenRef tokenRef)
        {
            AllBranches = allBranches;
            Api = api;
            Group = group;
            IncludeSubgroups = includeSubgroups;
            TokenRef = tokenRef;
        }
    }
}
