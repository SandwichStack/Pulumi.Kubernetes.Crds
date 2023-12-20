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
    public sealed class ApplicationSetStatus
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetStatusApplicationStatus> ApplicationStatus;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetStatusConditions> Conditions;

        [OutputConstructor]
        private ApplicationSetStatus(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetStatusApplicationStatus> applicationStatus,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationSetStatusConditions> conditions)
        {
            ApplicationStatus = applicationStatus;
            Conditions = conditions;
        }
    }
}
