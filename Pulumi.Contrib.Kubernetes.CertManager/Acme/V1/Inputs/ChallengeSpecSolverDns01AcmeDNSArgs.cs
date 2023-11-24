// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Contrib.Kubernetes.CertManager.Acme.V1.Inputs
{

    /// <summary>
    /// Use the 'ACME DNS' (https://github.com/joohoi/acme-dns) API to manage DNS01 challenge records.
    /// </summary>
    public class ChallengeSpecSolverDns01AcmeDNSArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.
        /// </summary>
        [Input("accountSecretRef", required: true)]
        public Input<ChallengeSpecSolverDns01AcmeDNSAccountSecretRefArgs> AccountSecretRef { get; set; } = null!;

        [Input("host", required: true)]
        public Input<string> Host { get; set; } = null!;

        public ChallengeSpecSolverDns01AcmeDNSArgs()
        {
        }
        public static new ChallengeSpecSolverDns01AcmeDNSArgs Empty => new ChallengeSpecSolverDns01AcmeDNSArgs();
    }
}
