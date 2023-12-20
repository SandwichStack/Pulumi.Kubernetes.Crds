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
    public sealed class ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestGitea
    {
        public readonly string Api;
        public readonly bool Insecure;
        public readonly string Owner;
        public readonly string Repo;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestGiteaTokenRef TokenRef;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestGitea(
            string api,

            bool insecure,

            string owner,

            string repo,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestGiteaTokenRef tokenRef)
        {
            Api = api;
            Insecure = insecure;
            Owner = owner;
            Repo = repo;
            TokenRef = tokenRef;
        }
    }
}