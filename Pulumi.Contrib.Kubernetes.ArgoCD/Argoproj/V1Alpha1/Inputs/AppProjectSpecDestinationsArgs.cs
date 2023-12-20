// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    /// <summary>
    /// ApplicationDestination holds information about the application's destination
    /// </summary>
    public class AppProjectSpecDestinationsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name is an alternate way of specifying the target cluster by its symbolic name. This must be set if Server is not set.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Namespace specifies the target namespace for the application's resources. The namespace will only be set for namespace-scoped resources that have not set a value for .metadata.namespace
        /// </summary>
        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        /// <summary>
        /// Server specifies the URL of the target cluster's Kubernetes control plane API. This must be set if Name is not set.
        /// </summary>
        [Input("server")]
        public Input<string>? Server { get; set; }

        public AppProjectSpecDestinationsArgs()
        {
        }
        public static new AppProjectSpecDestinationsArgs Empty => new AppProjectSpecDestinationsArgs();
    }
}
