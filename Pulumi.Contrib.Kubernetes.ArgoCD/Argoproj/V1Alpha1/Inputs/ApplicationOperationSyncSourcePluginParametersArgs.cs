// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationOperationSyncSourcePluginParametersArgs : global::Pulumi.ResourceArgs
    {
        [Input("array")]
        private InputList<string>? _array;

        /// <summary>
        /// Array is the value of an array type parameter.
        /// </summary>
        public InputList<string> Array
        {
            get => _array ?? (_array = new InputList<string>());
            set => _array = value;
        }

        [Input("map")]
        private InputMap<string>? _map;

        /// <summary>
        /// Map is the value of a map type parameter.
        /// </summary>
        public InputMap<string> Map
        {
            get => _map ?? (_map = new InputMap<string>());
            set => _map = value;
        }

        /// <summary>
        /// Name is the name identifying a parameter.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// String_ is the value of a string type parameter.
        /// </summary>
        [Input("string")]
        public Input<string>? String { get; set; }

        public ApplicationOperationSyncSourcePluginParametersArgs()
        {
        }
        public static new ApplicationOperationSyncSourcePluginParametersArgs Empty => new ApplicationOperationSyncSourcePluginParametersArgs();
    }
}
