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
    public sealed class ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateMetadata
    {
        public readonly ImmutableDictionary<string, string> Annotations;
        public readonly ImmutableArray<string> Finalizers;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly string Name;
        public readonly string Namespace;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateMetadata(
            ImmutableDictionary<string, string> annotations,

            ImmutableArray<string> finalizers,

            ImmutableDictionary<string, string> labels,

            string name,

            string @namespace)
        {
            Annotations = annotations;
            Finalizers = finalizers;
            Labels = labels;
            Name = name;
            Namespace = @namespace;
        }
    }
}
