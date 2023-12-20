// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    /// <summary>
    /// Kustomize holds kustomize specific options
    /// </summary>
    public class ApplicationSpecSourcesKustomizeArgs : global::Pulumi.ResourceArgs
    {
        [Input("commonAnnotations")]
        private InputMap<string>? _commonAnnotations;

        /// <summary>
        /// CommonAnnotations is a list of additional annotations to add to rendered manifests
        /// </summary>
        public InputMap<string> CommonAnnotations
        {
            get => _commonAnnotations ?? (_commonAnnotations = new InputMap<string>());
            set => _commonAnnotations = value;
        }

        /// <summary>
        /// CommonAnnotationsEnvsubst specifies whether to apply env variables substitution for annotation values
        /// </summary>
        [Input("commonAnnotationsEnvsubst")]
        public Input<bool>? CommonAnnotationsEnvsubst { get; set; }

        [Input("commonLabels")]
        private InputMap<string>? _commonLabels;

        /// <summary>
        /// CommonLabels is a list of additional labels to add to rendered manifests
        /// </summary>
        public InputMap<string> CommonLabels
        {
            get => _commonLabels ?? (_commonLabels = new InputMap<string>());
            set => _commonLabels = value;
        }

        [Input("components")]
        private InputList<string>? _components;

        /// <summary>
        /// Components specifies a list of kustomize components to add to the kustomization before building
        /// </summary>
        public InputList<string> Components
        {
            get => _components ?? (_components = new InputList<string>());
            set => _components = value;
        }

        /// <summary>
        /// ForceCommonAnnotations specifies whether to force applying common annotations to resources for Kustomize apps
        /// </summary>
        [Input("forceCommonAnnotations")]
        public Input<bool>? ForceCommonAnnotations { get; set; }

        /// <summary>
        /// ForceCommonLabels specifies whether to force applying common labels to resources for Kustomize apps
        /// </summary>
        [Input("forceCommonLabels")]
        public Input<bool>? ForceCommonLabels { get; set; }

        [Input("images")]
        private InputList<string>? _images;

        /// <summary>
        /// Images is a list of Kustomize image override specifications
        /// </summary>
        public InputList<string> Images
        {
            get => _images ?? (_images = new InputList<string>());
            set => _images = value;
        }

        /// <summary>
        /// NamePrefix is a prefix appended to resources for Kustomize apps
        /// </summary>
        [Input("namePrefix")]
        public Input<string>? NamePrefix { get; set; }

        /// <summary>
        /// NameSuffix is a suffix appended to resources for Kustomize apps
        /// </summary>
        [Input("nameSuffix")]
        public Input<string>? NameSuffix { get; set; }

        /// <summary>
        /// Namespace sets the namespace that Kustomize adds to all resources
        /// </summary>
        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        [Input("patches")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSpecSourcesKustomizePatchesArgs>? _patches;

        /// <summary>
        /// Patches is a list of Kustomize patches
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSpecSourcesKustomizePatchesArgs> Patches
        {
            get => _patches ?? (_patches = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSpecSourcesKustomizePatchesArgs>());
            set => _patches = value;
        }

        [Input("replicas")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSpecSourcesKustomizeReplicasArgs>? _replicas;

        /// <summary>
        /// Replicas is a list of Kustomize Replicas override specifications
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSpecSourcesKustomizeReplicasArgs> Replicas
        {
            get => _replicas ?? (_replicas = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSpecSourcesKustomizeReplicasArgs>());
            set => _replicas = value;
        }

        /// <summary>
        /// Version controls which version of Kustomize to use for rendering manifests
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public ApplicationSpecSourcesKustomizeArgs()
        {
        }
        public static new ApplicationSpecSourcesKustomizeArgs Empty => new ApplicationSpecSourcesKustomizeArgs();
    }
}
