// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecDestinationArgs : global::Pulumi.ResourceArgs
    {
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        [Input("server")]
        public Input<string>? Server { get; set; }

        public ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecDestinationArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecDestinationArgs Empty => new ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecDestinationArgs();
    }
}