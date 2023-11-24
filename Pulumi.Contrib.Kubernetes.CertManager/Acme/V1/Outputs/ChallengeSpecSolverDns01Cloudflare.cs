// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Contrib.Kubernetes.CertManager.Acme.V1.Outputs
{

    /// <summary>
    /// Use the Cloudflare API to manage DNS01 challenge records.
    /// </summary>
    [OutputType]
    public sealed class ChallengeSpecSolverDns01Cloudflare
    {
        /// <summary>
        /// API key to use to authenticate with Cloudflare. Note: using an API token to authenticate is now the recommended method as it allows greater control of permissions.
        /// </summary>
        public readonly ChallengeSpecSolverDns01CloudflareApiKeySecretRef ApiKeySecretRef;
        /// <summary>
        /// API token used to authenticate with Cloudflare.
        /// </summary>
        public readonly ChallengeSpecSolverDns01CloudflareApiTokenSecretRef ApiTokenSecretRef;
        /// <summary>
        /// Email of the account, only required when using API key based authentication.
        /// </summary>
        public readonly string Email;

        [OutputConstructor]
        private ChallengeSpecSolverDns01Cloudflare(
            ChallengeSpecSolverDns01CloudflareApiKeySecretRef apiKeySecretRef,

            ChallengeSpecSolverDns01CloudflareApiTokenSecretRef apiTokenSecretRef,

            string email)
        {
            ApiKeySecretRef = apiKeySecretRef;
            ApiTokenSecretRef = apiTokenSecretRef;
            Email = email;
        }
    }
}