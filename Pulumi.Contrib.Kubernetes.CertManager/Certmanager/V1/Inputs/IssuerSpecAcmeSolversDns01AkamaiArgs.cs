// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Contrib.Kubernetes.CertManager.Certmanager.V1.Inputs
{

    /// <summary>
    /// Use the Akamai DNS zone management API to manage DNS01 challenge records.
    /// </summary>
    public class IssuerSpecAcmeSolversDns01AkamaiArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.
        /// </summary>
        [Input("accessTokenSecretRef", required: true)]
        public Input<IssuerSpecAcmeSolversDns01AkamaiAccessTokenSecretRefArgs> AccessTokenSecretRef { get; set; } = null!;

        /// <summary>
        /// A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.
        /// </summary>
        [Input("clientSecretSecretRef", required: true)]
        public Input<IssuerSpecAcmeSolversDns01AkamaiClientSecretSecretRefArgs> ClientSecretSecretRef { get; set; } = null!;

        /// <summary>
        /// A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.
        /// </summary>
        [Input("clientTokenSecretRef", required: true)]
        public Input<IssuerSpecAcmeSolversDns01AkamaiClientTokenSecretRefArgs> ClientTokenSecretRef { get; set; } = null!;

        [Input("serviceConsumerDomain", required: true)]
        public Input<string> ServiceConsumerDomain { get; set; } = null!;

        public IssuerSpecAcmeSolversDns01AkamaiArgs()
        {
        }
        public static new IssuerSpecAcmeSolversDns01AkamaiArgs Empty => new IssuerSpecAcmeSolversDns01AkamaiArgs();
    }
}
