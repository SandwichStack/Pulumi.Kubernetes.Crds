// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Contrib.Kubernetes.CertManager.Certmanager.V1.Inputs
{

    /// <summary>
    /// The Gateway API is a sig-network community API that models service networking in Kubernetes (https://gateway-api.sigs.k8s.io/). The Gateway solver will create HTTPRoutes with the specified labels in the same namespace as the challenge. This solver is experimental, and fields / behaviour may change in the future.
    /// </summary>
    public class ClusterIssuerSpecAcmeSolversHttp01GatewayHTTPRouteArgs : global::Pulumi.ResourceArgs
    {
        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// Custom labels that will be applied to HTTPRoutes created by cert-manager while solving HTTP-01 challenges.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("parentRefs")]
        private InputList<ClusterIssuerSpecAcmeSolversHttp01GatewayHTTPRouteParentRefsArgs>? _parentRefs;

        /// <summary>
        /// When solving an HTTP-01 challenge, cert-manager creates an HTTPRoute. cert-manager needs to know which parentRefs should be used when creating the HTTPRoute. Usually, the parentRef references a Gateway. See: https://gateway-api.sigs.k8s.io/api-types/httproute/#attaching-to-gateways
        /// </summary>
        public InputList<ClusterIssuerSpecAcmeSolversHttp01GatewayHTTPRouteParentRefsArgs> ParentRefs
        {
            get => _parentRefs ?? (_parentRefs = new InputList<ClusterIssuerSpecAcmeSolversHttp01GatewayHTTPRouteParentRefsArgs>());
            set => _parentRefs = value;
        }

        /// <summary>
        /// Optional service type for Kubernetes solver service. Supported values are NodePort or ClusterIP. If unset, defaults to NodePort.
        /// </summary>
        [Input("serviceType")]
        public Input<string>? ServiceType { get; set; }

        public ClusterIssuerSpecAcmeSolversHttp01GatewayHTTPRouteArgs()
        {
        }
        public static new ClusterIssuerSpecAcmeSolversHttp01GatewayHTTPRouteArgs Empty => new ClusterIssuerSpecAcmeSolversHttp01GatewayHTTPRouteArgs();
    }
}