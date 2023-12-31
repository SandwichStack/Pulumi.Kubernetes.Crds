// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Contrib.Kubernetes.CertManager.Acme.V1.Outputs
{

    /// <summary>
    /// Use the Akamai DNS zone management API to manage DNS01 challenge records.
    /// </summary>
    [OutputType]
    public sealed class ChallengeSpecSolverDns01Akamai
    {
        /// <summary>
        /// A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.
        /// </summary>
        public readonly ChallengeSpecSolverDns01AkamaiAccessTokenSecretRef AccessTokenSecretRef;
        /// <summary>
        /// A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.
        /// </summary>
        public readonly ChallengeSpecSolverDns01AkamaiClientSecretSecretRef ClientSecretSecretRef;
        /// <summary>
        /// A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.
        /// </summary>
        public readonly ChallengeSpecSolverDns01AkamaiClientTokenSecretRef ClientTokenSecretRef;
        public readonly string ServiceConsumerDomain;

        [OutputConstructor]
        private ChallengeSpecSolverDns01Akamai(
            ChallengeSpecSolverDns01AkamaiAccessTokenSecretRef accessTokenSecretRef,

            ChallengeSpecSolverDns01AkamaiClientSecretSecretRef clientSecretSecretRef,

            ChallengeSpecSolverDns01AkamaiClientTokenSecretRef clientTokenSecretRef,

            string serviceConsumerDomain)
        {
            AccessTokenSecretRef = accessTokenSecretRef;
            ClientSecretSecretRef = clientSecretSecretRef;
            ClientTokenSecretRef = clientTokenSecretRef;
            ServiceConsumerDomain = serviceConsumerDomain;
        }
    }
}
