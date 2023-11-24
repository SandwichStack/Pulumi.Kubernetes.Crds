// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Contrib.Kubernetes.CertManager.Acme.V1.Outputs
{

    /// <summary>
    /// A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.
    /// </summary>
    [OutputType]
    public sealed class ChallengeSpecSolverDns01DigitaloceanTokenSecretRef
    {
        /// <summary>
        /// The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private ChallengeSpecSolverDns01DigitaloceanTokenSecretRef(
            string key,

            string name)
        {
            Key = key;
            Name = name;
        }
    }
}
