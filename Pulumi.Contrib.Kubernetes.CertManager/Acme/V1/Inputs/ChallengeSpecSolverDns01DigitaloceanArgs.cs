// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Contrib.Kubernetes.CertManager.Acme.V1.Inputs
{

    /// <summary>
    /// Use the DigitalOcean DNS API to manage DNS01 challenge records.
    /// </summary>
    public class ChallengeSpecSolverDns01DigitaloceanArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.
        /// </summary>
        [Input("tokenSecretRef", required: true)]
        public Input<ChallengeSpecSolverDns01DigitaloceanTokenSecretRefArgs> TokenSecretRef { get; set; } = null!;

        public ChallengeSpecSolverDns01DigitaloceanArgs()
        {
        }
        public static new ChallengeSpecSolverDns01DigitaloceanArgs Empty => new ChallengeSpecSolverDns01DigitaloceanArgs();
    }
}
