// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Contrib.Kubernetes.CertManager.Acme.V1.Inputs
{

    /// <summary>
    /// Use the Cloudflare API to manage DNS01 challenge records.
    /// </summary>
    public class ChallengeSpecSolverDns01CloudflareArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// API key to use to authenticate with Cloudflare. Note: using an API token to authenticate is now the recommended method as it allows greater control of permissions.
        /// </summary>
        [Input("apiKeySecretRef")]
        public Input<ChallengeSpecSolverDns01CloudflareApiKeySecretRefArgs>? ApiKeySecretRef { get; set; }

        /// <summary>
        /// API token used to authenticate with Cloudflare.
        /// </summary>
        [Input("apiTokenSecretRef")]
        public Input<ChallengeSpecSolverDns01CloudflareApiTokenSecretRefArgs>? ApiTokenSecretRef { get; set; }

        /// <summary>
        /// Email of the account, only required when using API key based authentication.
        /// </summary>
        [Input("email")]
        public Input<string>? Email { get; set; }

        public ChallengeSpecSolverDns01CloudflareArgs()
        {
        }
        public static new ChallengeSpecSolverDns01CloudflareArgs Empty => new ChallengeSpecSolverDns01CloudflareArgs();
    }
}
