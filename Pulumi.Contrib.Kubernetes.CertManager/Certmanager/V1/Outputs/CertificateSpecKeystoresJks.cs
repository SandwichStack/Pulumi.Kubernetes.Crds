// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Contrib.Kubernetes.CertManager.Certmanager.V1.Outputs
{

    /// <summary>
    /// JKS configures options for storing a JKS keystore in the `spec.secretName` Secret resource.
    /// </summary>
    [OutputType]
    public sealed class CertificateSpecKeystoresJks
    {
        /// <summary>
        /// Create enables JKS keystore creation for the Certificate. If true, a file named `keystore.jks` will be created in the target Secret resource, encrypted using the password stored in `passwordSecretRef`. The keystore file will be updated immediately. If the issuer provided a CA certificate, a file named `truststore.jks` will also be created in the target Secret resource, encrypted using the password stored in `passwordSecretRef` containing the issuing Certificate Authority
        /// </summary>
        public readonly bool Create;
        /// <summary>
        /// PasswordSecretRef is a reference to a key in a Secret resource containing the password used to encrypt the JKS keystore.
        /// </summary>
        public readonly CertificateSpecKeystoresJksPasswordSecretRef PasswordSecretRef;

        [OutputConstructor]
        private CertificateSpecKeystoresJks(
            bool create,

            CertificateSpecKeystoresJksPasswordSecretRef passwordSecretRef)
        {
            Create = create;
            PasswordSecretRef = passwordSecretRef;
        }
    }
}
