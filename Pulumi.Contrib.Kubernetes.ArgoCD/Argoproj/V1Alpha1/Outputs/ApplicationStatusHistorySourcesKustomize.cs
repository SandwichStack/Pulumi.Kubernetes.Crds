// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1
{

    /// <summary>
    /// Kustomize holds kustomize specific options
    /// </summary>
    [OutputType]
    public sealed class ApplicationStatusHistorySourcesKustomize
    {
        /// <summary>
        /// CommonAnnotations is a list of additional annotations to add to rendered manifests
        /// </summary>
        public readonly ImmutableDictionary<string, string> CommonAnnotations;
        /// <summary>
        /// CommonAnnotationsEnvsubst specifies whether to apply env variables substitution for annotation values
        /// </summary>
        public readonly bool CommonAnnotationsEnvsubst;
        /// <summary>
        /// CommonLabels is a list of additional labels to add to rendered manifests
        /// </summary>
        public readonly ImmutableDictionary<string, string> CommonLabels;
        /// <summary>
        /// ForceCommonAnnotations specifies whether to force applying common annotations to resources for Kustomize apps
        /// </summary>
        public readonly bool ForceCommonAnnotations;
        /// <summary>
        /// ForceCommonLabels specifies whether to force applying common labels to resources for Kustomize apps
        /// </summary>
        public readonly bool ForceCommonLabels;
        /// <summary>
        /// Images is a list of Kustomize image override specifications
        /// </summary>
        public readonly ImmutableArray<string> Images;
        /// <summary>
        /// NamePrefix is a prefix appended to resources for Kustomize apps
        /// </summary>
        public readonly string NamePrefix;
        /// <summary>
        /// NameSuffix is a suffix appended to resources for Kustomize apps
        /// </summary>
        public readonly string NameSuffix;
        /// <summary>
        /// Namespace sets the namespace that Kustomize adds to all resources
        /// </summary>
        public readonly string Namespace;
        /// <summary>
        /// Replicas is a list of Kustomize Replicas override specifications
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusHistorySourcesKustomizeReplicas> Replicas;
        /// <summary>
        /// Version controls which version of Kustomize to use for rendering manifests
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private ApplicationStatusHistorySourcesKustomize(
            ImmutableDictionary<string, string> commonAnnotations,

            bool commonAnnotationsEnvsubst,

            ImmutableDictionary<string, string> commonLabels,

            bool forceCommonAnnotations,

            bool forceCommonLabels,

            ImmutableArray<string> images,

            string namePrefix,

            string nameSuffix,

            string @namespace,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusHistorySourcesKustomizeReplicas> replicas,

            string version)
        {
            CommonAnnotations = commonAnnotations;
            CommonAnnotationsEnvsubst = commonAnnotationsEnvsubst;
            CommonLabels = commonLabels;
            ForceCommonAnnotations = forceCommonAnnotations;
            ForceCommonLabels = forceCommonLabels;
            Images = images;
            NamePrefix = namePrefix;
            NameSuffix = nameSuffix;
            Namespace = @namespace;
            Replicas = replicas;
            Version = version;
        }
    }
}
