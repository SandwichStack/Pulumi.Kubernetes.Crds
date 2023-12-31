// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Contrib.Kubernetes.CertManager.Certmanager.V1.Outputs
{

    /// <summary>
    /// If specified, the pod's scheduling constraints
    /// </summary>
    [OutputType]
    public sealed class IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinity
    {
        /// <summary>
        /// Describes node affinity scheduling rules for the pod.
        /// </summary>
        public readonly IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinity NodeAffinity;
        /// <summary>
        /// Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).
        /// </summary>
        public readonly IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinity PodAffinity;
        /// <summary>
        /// Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).
        /// </summary>
        public readonly IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinity PodAntiAffinity;

        [OutputConstructor]
        private IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinity(
            IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinity nodeAffinity,

            IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinity podAffinity,

            IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinity podAntiAffinity)
        {
            NodeAffinity = nodeAffinity;
            PodAffinity = podAffinity;
            PodAntiAffinity = podAntiAffinity;
        }
    }
}
