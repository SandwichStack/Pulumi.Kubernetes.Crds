// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Certmanager.V1
{

    /// <summary>
    /// Use the 'ACME DNS' (https://github.com/joohoi/acme-dns) API to manage DNS01 challenge records.
    /// </summary>
    [OutputType]
    public sealed class ClusterIssuerSpecAcmeSolversDns01AcmeDNS
    {
        /// <summary>
        /// A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Certmanager.V1.ClusterIssuerSpecAcmeSolversDns01AcmeDNSAccountSecretRef AccountSecretRef;
        public readonly string Host;

        [OutputConstructor]
        private ClusterIssuerSpecAcmeSolversDns01AcmeDNS(
            Pulumi.Kubernetes.Types.Outputs.Certmanager.V1.ClusterIssuerSpecAcmeSolversDns01AcmeDNSAccountSecretRef accountSecretRef,

            string host)
        {
            AccountSecretRef = accountSecretRef;
            Host = host;
        }
    }
}