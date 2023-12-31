// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Contrib.Kubernetes.CertManager.Certmanager.V1.Inputs
{

    /// <summary>
    /// Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).
    /// </summary>
    public class IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityArgs : global::Pulumi.ResourceArgs
    {
        [Input("preferredDuringSchedulingIgnoredDuringExecution")]
        private InputList<IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionArgs>? _preferredDuringSchedulingIgnoredDuringExecution;

        /// <summary>
        /// The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.
        /// </summary>
        public InputList<IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionArgs> PreferredDuringSchedulingIgnoredDuringExecution
        {
            get => _preferredDuringSchedulingIgnoredDuringExecution ?? (_preferredDuringSchedulingIgnoredDuringExecution = new InputList<IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionArgs>());
            set => _preferredDuringSchedulingIgnoredDuringExecution = value;
        }

        [Input("requiredDuringSchedulingIgnoredDuringExecution")]
        private InputList<IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionArgs>? _requiredDuringSchedulingIgnoredDuringExecution;

        /// <summary>
        /// If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.
        /// </summary>
        public InputList<IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionArgs> RequiredDuringSchedulingIgnoredDuringExecution
        {
            get => _requiredDuringSchedulingIgnoredDuringExecution ?? (_requiredDuringSchedulingIgnoredDuringExecution = new InputList<IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionArgs>());
            set => _requiredDuringSchedulingIgnoredDuringExecution = value;
        }

        public IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityArgs()
        {
        }
        public static new IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityArgs Empty => new IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityArgs();
    }
}
