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
    public sealed class ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourceDirectory
    {
        public readonly string Exclude;
        public readonly string Include;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourceDirectoryJsonnet Jsonnet;
        public readonly bool Recurse;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourceDirectory(
            string exclude,

            string include,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourceDirectoryJsonnet jsonnet,

            bool recurse)
        {
            Exclude = exclude;
            Include = include;
            Jsonnet = jsonnet;
            Recurse = recurse;
        }
    }
}
