// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsClusterDecisionResourceArgs : global::Pulumi.ResourceArgs
    {
        [Input("configMapRef", required: true)]
        public Input<string> ConfigMapRef { get; set; } = null!;

        [Input("labelSelector")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsClusterDecisionResourceLabelSelectorArgs>? LabelSelector { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("requeueAfterSeconds")]
        public Input<int>? RequeueAfterSeconds { get; set; }

        [Input("template")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateArgs>? Template { get; set; }

        [Input("values")]
        private InputMap<string>? _values;
        public InputMap<string> Values
        {
            get => _values ?? (_values = new InputMap<string>());
            set => _values = value;
        }

        public ApplicationSetSpecGeneratorsClusterDecisionResourceArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsClusterDecisionResourceArgs Empty => new ApplicationSetSpecGeneratorsClusterDecisionResourceArgs();
    }
}
