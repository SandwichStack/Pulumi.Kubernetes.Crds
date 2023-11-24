// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Contrib.Kubernetes.CertManager.Certmanager.V1.Outputs
{

    /// <summary>
    /// ExternalAccountBinding is a reference to a CA external account of the ACME server. If set, upon registration cert-manager will attempt to associate the given external account credentials with the registered ACME account.
    /// </summary>
    [OutputType]
    public sealed class IssuerSpecAcmeExternalAccountBinding
    {
        /// <summary>
        /// Deprecated: keyAlgorithm field exists for historical compatibility reasons and should not be used. The algorithm is now hardcoded to HS256 in golang/x/crypto/acme.
        /// </summary>
        public readonly string KeyAlgorithm;
        /// <summary>
        /// keyID is the ID of the CA key that the External Account is bound to.
        /// </summary>
        public readonly string KeyID;
        /// <summary>
        /// keySecretRef is a Secret Key Selector referencing a data item in a Kubernetes Secret which holds the symmetric MAC key of the External Account Binding. The `key` is the index string that is paired with the key data in the Secret and should not be confused with the key data itself, or indeed with the External Account Binding keyID above. The secret key stored in the Secret **must** be un-padded, base64 URL encoded data.
        /// </summary>
        public readonly IssuerSpecAcmeExternalAccountBindingKeySecretRef KeySecretRef;

        [OutputConstructor]
        private IssuerSpecAcmeExternalAccountBinding(
            string keyAlgorithm,

            string keyID,

            IssuerSpecAcmeExternalAccountBindingKeySecretRef keySecretRef)
        {
            KeyAlgorithm = keyAlgorithm;
            KeyID = keyID;
            KeySecretRef = keySecretRef;
        }
    }
}
