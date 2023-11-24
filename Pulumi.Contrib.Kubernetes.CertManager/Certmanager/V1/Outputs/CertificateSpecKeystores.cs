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
    /// Additional keystore output formats to be stored in the Certificate's Secret.
    /// </summary>
    [OutputType]
    public sealed class CertificateSpecKeystores
    {
        /// <summary>
        /// JKS configures options for storing a JKS keystore in the `spec.secretName` Secret resource.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Certmanager.V1.CertificateSpecKeystoresJks Jks;
        /// <summary>
        /// PKCS12 configures options for storing a PKCS12 keystore in the `spec.secretName` Secret resource.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Certmanager.V1.CertificateSpecKeystoresPkcs12 Pkcs12;

        [OutputConstructor]
        private CertificateSpecKeystores(
            Pulumi.Kubernetes.Types.Outputs.Certmanager.V1.CertificateSpecKeystoresJks jks,

            Pulumi.Kubernetes.Types.Outputs.Certmanager.V1.CertificateSpecKeystoresPkcs12 pkcs12)
        {
            Jks = jks;
            Pkcs12 = pkcs12;
        }
    }
}