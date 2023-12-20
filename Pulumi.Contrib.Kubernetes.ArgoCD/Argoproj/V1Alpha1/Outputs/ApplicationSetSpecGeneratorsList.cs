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
    public sealed class ApplicationSetSpecGeneratorsList
    {
        public readonly ImmutableArray<ImmutableDictionary<string, object>> Elements;
        public readonly string ElementsYaml;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsListTemplate Template;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsList(
            ImmutableArray<ImmutableDictionary<string, object>> elements,

            string elementsYaml,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsListTemplate template)
        {
            Elements = elements;
            ElementsYaml = elementsYaml;
            Template = template;
        }
    }
}
