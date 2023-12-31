// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMergeGeneratorsListArgs : global::Pulumi.ResourceArgs
    {
        [Input("elements", required: true)]
        private InputList<ImmutableDictionary<string, object>>? _elements;
        public InputList<ImmutableDictionary<string, object>> Elements
        {
            get => _elements ?? (_elements = new InputList<ImmutableDictionary<string, object>>());
            set => _elements = value;
        }

        [Input("elementsYaml")]
        public Input<string>? ElementsYaml { get; set; }

        [Input("template")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateArgs>? Template { get; set; }

        public ApplicationSetSpecGeneratorsMergeGeneratorsListArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMergeGeneratorsListArgs Empty => new ApplicationSetSpecGeneratorsMergeGeneratorsListArgs();
    }
}
