// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1
{

    [OutputType]
    public sealed class ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplate
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateMetadata Metadata;
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpec Spec;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplate(
            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateMetadata metadata,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpec spec)
        {
            Metadata = metadata;
            Spec = spec;
        }
    }
}
