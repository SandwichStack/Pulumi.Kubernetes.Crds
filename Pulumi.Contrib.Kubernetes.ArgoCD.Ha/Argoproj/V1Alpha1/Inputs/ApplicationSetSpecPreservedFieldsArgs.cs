// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecPreservedFieldsArgs : global::Pulumi.ResourceArgs
    {
        [Input("annotations")]
        private InputList<string>? _annotations;
        public InputList<string> Annotations
        {
            get => _annotations ?? (_annotations = new InputList<string>());
            set => _annotations = value;
        }

        public ApplicationSetSpecPreservedFieldsArgs()
        {
        }
        public static new ApplicationSetSpecPreservedFieldsArgs Empty => new ApplicationSetSpecPreservedFieldsArgs();
    }
}