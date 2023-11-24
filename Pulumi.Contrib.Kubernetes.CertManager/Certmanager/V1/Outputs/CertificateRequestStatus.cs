// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;

namespace Pulumi.Contrib.Kubernetes.CertManager.Certmanager.V1.Outputs
{

    /// <summary>
    /// Status of the CertificateRequest. This is set and managed automatically. Read-only. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
    /// </summary>
    [OutputType]
    public sealed class CertificateRequestStatus
    {
        /// <summary>
        /// The PEM encoded X.509 certificate of the signer, also known as the CA (Certificate Authority). This is set on a best-effort basis by different issuers. If not set, the CA is assumed to be unknown/not available.
        /// </summary>
        public readonly string Ca;
        /// <summary>
        /// The PEM encoded X.509 certificate resulting from the certificate signing request. If not set, the CertificateRequest has either not been completed or has failed. More information on failure can be found by checking the `conditions` field.
        /// </summary>
        public readonly string Certificate;
        /// <summary>
        /// List of status conditions to indicate the status of a CertificateRequest. Known condition types are `Ready`, `InvalidRequest`, `Approved` and `Denied`.
        /// </summary>
        public readonly ImmutableArray<CertificateRequestStatusConditions> Conditions;
        /// <summary>
        /// FailureTime stores the time that this CertificateRequest failed. This is used to influence garbage collection and back-off.
        /// </summary>
        public readonly string FailureTime;

        [OutputConstructor]
        private CertificateRequestStatus(
            string ca,

            string certificate,

            ImmutableArray<CertificateRequestStatusConditions> conditions,

            string failureTime)
        {
            Ca = ca;
            Certificate = certificate;
            Conditions = conditions;
            FailureTime = failureTime;
        }
    }
}