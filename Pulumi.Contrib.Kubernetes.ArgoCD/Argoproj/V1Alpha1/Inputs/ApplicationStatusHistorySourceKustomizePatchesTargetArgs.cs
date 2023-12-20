// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationStatusHistorySourceKustomizePatchesTargetArgs : global::Pulumi.ResourceArgs
    {
        [Input("annotationSelector")]
        public Input<string>? AnnotationSelector { get; set; }

        [Input("group")]
        public Input<string>? Group { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("labelSelector")]
        public Input<string>? LabelSelector { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public ApplicationStatusHistorySourceKustomizePatchesTargetArgs()
        {
        }
        public static new ApplicationStatusHistorySourceKustomizePatchesTargetArgs Empty => new ApplicationStatusHistorySourceKustomizePatchesTargetArgs();
    }
}
