// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceKustomizePatchesArgs : global::Pulumi.ResourceArgs
    {
        [Input("options")]
        private InputMap<bool>? _options;
        public InputMap<bool> Options
        {
            get => _options ?? (_options = new InputMap<bool>());
            set => _options = value;
        }

        [Input("patch")]
        public Input<string>? Patch { get; set; }

        [Input("path")]
        public Input<string>? Path { get; set; }

        [Input("target")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceKustomizePatchesTargetArgs>? Target { get; set; }

        public ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceKustomizePatchesArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceKustomizePatchesArgs Empty => new ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceKustomizePatchesArgs();
    }
}
