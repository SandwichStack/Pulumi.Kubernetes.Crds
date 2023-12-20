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
    public sealed class ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceKustomizePatchesTarget
    {
        public readonly string AnnotationSelector;
        public readonly string Group;
        public readonly string Kind;
        public readonly string LabelSelector;
        public readonly string Name;
        public readonly string Namespace;
        public readonly string Version;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceKustomizePatchesTarget(
            string annotationSelector,

            string group,

            string kind,

            string labelSelector,

            string name,

            string @namespace,

            string version)
        {
            AnnotationSelector = annotationSelector;
            Group = group;
            Kind = kind;
            LabelSelector = labelSelector;
            Name = name;
            Namespace = @namespace;
            Version = version;
        }
    }
}
