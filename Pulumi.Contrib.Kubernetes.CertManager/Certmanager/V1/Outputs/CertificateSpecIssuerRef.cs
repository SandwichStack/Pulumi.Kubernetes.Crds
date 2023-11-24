// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Contrib.Kubernetes.CertManager.Certmanager.V1.Outputs
{

    /// <summary>
    /// Reference to the issuer responsible for issuing the certificate. If the issuer is namespace-scoped, it must be in the same namespace as the Certificate. If the issuer is cluster-scoped, it can be used from any namespace. 
    ///  The `name` field of the reference must always be specified.
    /// </summary>
    [OutputType]
    public sealed class CertificateSpecIssuerRef
    {
        /// <summary>
        /// Group of the resource being referred to.
        /// </summary>
        public readonly string Group;
        /// <summary>
        /// Kind of the resource being referred to.
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// Name of the resource being referred to.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private CertificateSpecIssuerRef(
            string group,

            string kind,

            string name)
        {
            Group = group;
            Kind = kind;
            Name = name;
        }
    }
}
