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
    public sealed class ApplicationSetSpecGeneratorsMergeTemplateSpecSourceKustomizePatches
    {
        public readonly ImmutableDictionary<string, bool> Options;
        public readonly string Patch;
        public readonly string Path;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeTemplateSpecSourceKustomizePatchesTarget Target;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMergeTemplateSpecSourceKustomizePatches(
            ImmutableDictionary<string, bool> options,

            string patch,

            string path,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeTemplateSpecSourceKustomizePatchesTarget target)
        {
            Options = options;
            Patch = patch;
            Path = path;
            Target = target;
        }
    }
}
