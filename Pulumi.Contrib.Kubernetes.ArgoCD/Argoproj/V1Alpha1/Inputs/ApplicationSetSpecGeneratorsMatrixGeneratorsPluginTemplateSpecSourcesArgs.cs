// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesArgs : global::Pulumi.ResourceArgs
    {
        [Input("chart")]
        public Input<string>? Chart { get; set; }

        [Input("directory")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesDirectoryArgs>? Directory { get; set; }

        [Input("helm")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesHelmArgs>? Helm { get; set; }

        [Input("kustomize")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesKustomizeArgs>? Kustomize { get; set; }

        [Input("path")]
        public Input<string>? Path { get; set; }

        [Input("plugin")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesPluginArgs>? Plugin { get; set; }

        [Input("ref")]
        public Input<string>? Ref { get; set; }

        [Input("repoURL", required: true)]
        public Input<string> RepoURL { get; set; } = null!;

        [Input("targetRevision")]
        public Input<string>? TargetRevision { get; set; }

        public ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesArgs Empty => new ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesArgs();
    }
}
