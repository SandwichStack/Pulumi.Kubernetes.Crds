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
    public sealed class ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourceKustomizeReplicas
    {
        public readonly Union<int, string> Count;
        public readonly string Name;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourceKustomizeReplicas(
            Union<int, string> count,

            string name)
        {
            Count = count;
            Name = name;
        }
    }
}
