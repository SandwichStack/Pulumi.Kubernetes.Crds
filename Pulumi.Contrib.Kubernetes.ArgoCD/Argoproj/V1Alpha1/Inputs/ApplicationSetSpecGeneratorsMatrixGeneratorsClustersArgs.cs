// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMatrixGeneratorsClustersArgs : global::Pulumi.ResourceArgs
    {
        [Input("selector")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsClustersSelectorArgs>? Selector { get; set; }

        [Input("template")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateArgs>? Template { get; set; }

        [Input("values")]
        private InputMap<string>? _values;
        public InputMap<string> Values
        {
            get => _values ?? (_values = new InputMap<string>());
            set => _values = value;
        }

        public ApplicationSetSpecGeneratorsMatrixGeneratorsClustersArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMatrixGeneratorsClustersArgs Empty => new ApplicationSetSpecGeneratorsMatrixGeneratorsClustersArgs();
    }
}