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
    /// Health contains information about the application's current health status
    /// </summary>
    public class ApplicationStatusHealthArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Message is a human-readable informational message describing the health status
        /// </summary>
        [Input("message")]
        public Input<string>? Message { get; set; }

        /// <summary>
        /// Status holds the status code of the application or resource
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        public ApplicationStatusHealthArgs()
        {
        }
        public static new ApplicationStatusHealthArgs Empty => new ApplicationStatusHealthArgs();
    }
}