// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Contrib.Kubernetes.CertManager.Certmanager.V1.Outputs
{

    /// <summary>
    /// PKCS12 configures options for storing a PKCS12 keystore in the `spec.secretName` Secret resource.
    /// </summary>
    [OutputType]
    public sealed class CertificateSpecKeystoresPkcs12
    {
        /// <summary>
        /// Create enables PKCS12 keystore creation for the Certificate. If true, a file named `keystore.p12` will be created in the target Secret resource, encrypted using the password stored in `passwordSecretRef`. The keystore file will be updated immediately. If the issuer provided a CA certificate, a file named `truststore.p12` will also be created in the target Secret resource, encrypted using the password stored in `passwordSecretRef` containing the issuing Certificate Authority
        /// </summary>
        public readonly bool Create;
        /// <summary>
        /// PasswordSecretRef is a reference to a key in a Secret resource containing the password used to encrypt the PKCS12 keystore.
        /// </summary>
        public readonly CertificateSpecKeystoresPkcs12PasswordSecretRef PasswordSecretRef;

        [OutputConstructor]
        private CertificateSpecKeystoresPkcs12(
            bool create,

            CertificateSpecKeystoresPkcs12PasswordSecretRef passwordSecretRef)
        {
            Create = create;
            PasswordSecretRef = passwordSecretRef;
        }
    }
}
