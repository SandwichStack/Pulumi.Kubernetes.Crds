// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecTemplateSpecSourceDirectoryArgs : global::Pulumi.ResourceArgs
    {
        [Input("exclude")]
        public Input<string>? Exclude { get; set; }

        [Input("include")]
        public Input<string>? Include { get; set; }

        [Input("jsonnet")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecTemplateSpecSourceDirectoryJsonnetArgs>? Jsonnet { get; set; }

        [Input("recurse")]
        public Input<bool>? Recurse { get; set; }

        public ApplicationSetSpecTemplateSpecSourceDirectoryArgs()
        {
        }
        public static new ApplicationSetSpecTemplateSpecSourceDirectoryArgs Empty => new ApplicationSetSpecTemplateSpecSourceDirectoryArgs();
    }
}
