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
    public sealed class ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesHelmParameters
    {
        public readonly bool ForceString;
        public readonly string Name;
        public readonly string Value;

        [OutputConstructor]
        private ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesHelmParameters(
            bool forceString,

            string name,

            string value)
        {
            ForceString = forceString;
            Name = name;
            Value = value;
        }
    }
}
