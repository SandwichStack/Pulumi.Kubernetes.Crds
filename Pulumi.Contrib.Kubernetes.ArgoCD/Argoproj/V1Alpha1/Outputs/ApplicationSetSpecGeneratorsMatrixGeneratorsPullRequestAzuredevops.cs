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
    public sealed class ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestAzuredevops
    {
        public readonly string Api;
        public readonly ImmutableArray<string> Labels;
        public readonly string Organization;
        public readonly string Project;
        public readonly string Repo;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestAzuredevopsTokenRef TokenRef;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestAzuredevops(
            string api,

            ImmutableArray<string> labels,

            string organization,

            string project,

            string repo,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestAzuredevopsTokenRef tokenRef)
        {
            Api = api;
            Labels = labels;
            Organization = organization;
            Project = project;
            Repo = repo;
            TokenRef = tokenRef;
        }
    }
}
