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
    public sealed class ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectoryJsonnet
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectoryJsonnetExtVars> ExtVars;
        public readonly ImmutableArray<string> Libs;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectoryJsonnetTlas> Tlas;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectoryJsonnet(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectoryJsonnetExtVars> extVars,

            ImmutableArray<string> libs,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectoryJsonnetTlas> tlas)
        {
            ExtVars = extVars;
            Libs = libs;
            Tlas = tlas;
        }
    }
}
