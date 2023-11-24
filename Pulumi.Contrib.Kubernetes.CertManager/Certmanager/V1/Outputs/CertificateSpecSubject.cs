// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;

namespace Pulumi.Contrib.Kubernetes.CertManager.Certmanager.V1.Outputs
{

    /// <summary>
    /// Requested set of X509 certificate subject attributes. More info: https://datatracker.ietf.org/doc/html/rfc5280#section-4.1.2.6 
    ///  The common name attribute is specified separately in the `commonName` field. Cannot be set if the `literalSubject` field is set.
    /// </summary>
    [OutputType]
    public sealed class CertificateSpecSubject
    {
        /// <summary>
        /// Countries to be used on the Certificate.
        /// </summary>
        public readonly ImmutableArray<string> Countries;
        /// <summary>
        /// Cities to be used on the Certificate.
        /// </summary>
        public readonly ImmutableArray<string> Localities;
        /// <summary>
        /// Organizational Units to be used on the Certificate.
        /// </summary>
        public readonly ImmutableArray<string> OrganizationalUnits;
        /// <summary>
        /// Organizations to be used on the Certificate.
        /// </summary>
        public readonly ImmutableArray<string> Organizations;
        /// <summary>
        /// Postal codes to be used on the Certificate.
        /// </summary>
        public readonly ImmutableArray<string> PostalCodes;
        /// <summary>
        /// State/Provinces to be used on the Certificate.
        /// </summary>
        public readonly ImmutableArray<string> Provinces;
        /// <summary>
        /// Serial number to be used on the Certificate.
        /// </summary>
        public readonly string SerialNumber;
        /// <summary>
        /// Street addresses to be used on the Certificate.
        /// </summary>
        public readonly ImmutableArray<string> StreetAddresses;

        [OutputConstructor]
        private CertificateSpecSubject(
            ImmutableArray<string> countries,

            ImmutableArray<string> localities,

            ImmutableArray<string> organizationalUnits,

            ImmutableArray<string> organizations,

            ImmutableArray<string> postalCodes,

            ImmutableArray<string> provinces,

            string serialNumber,

            ImmutableArray<string> streetAddresses)
        {
            Countries = countries;
            Localities = localities;
            OrganizationalUnits = organizationalUnits;
            Organizations = organizations;
            PostalCodes = postalCodes;
            Provinces = provinces;
            SerialNumber = serialNumber;
            StreetAddresses = streetAddresses;
        }
    }
}
