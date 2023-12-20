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
    public sealed class ApplicationSetSpecGeneratorsScmProviderGitlab
    {
        public readonly bool AllBranches;
        public readonly string Api;
        public readonly string Group;
        public readonly bool IncludeSharedProjects;
        public readonly bool IncludeSubgroups;
        public readonly bool Insecure;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsScmProviderGitlabTokenRef TokenRef;
        public readonly string Topic;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsScmProviderGitlab(
            bool allBranches,

            string api,

            string group,

            bool includeSharedProjects,

            bool includeSubgroups,

            bool insecure,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsScmProviderGitlabTokenRef tokenRef,

            string topic)
        {
            AllBranches = allBranches;
            Api = api;
            Group = group;
            IncludeSharedProjects = includeSharedProjects;
            IncludeSubgroups = includeSubgroups;
            Insecure = insecure;
            TokenRef = tokenRef;
            Topic = topic;
        }
    }
}
