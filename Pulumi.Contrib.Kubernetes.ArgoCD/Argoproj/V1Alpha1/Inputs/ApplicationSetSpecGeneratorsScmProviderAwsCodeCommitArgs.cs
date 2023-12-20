// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsScmProviderAwsCodeCommitArgs : global::Pulumi.ResourceArgs
    {
        [Input("allBranches")]
        public Input<bool>? AllBranches { get; set; }

        [Input("region")]
        public Input<string>? Region { get; set; }

        [Input("role")]
        public Input<string>? Role { get; set; }

        [Input("tagFilters")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsScmProviderAwsCodeCommitTagFiltersArgs>? _tagFilters;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsScmProviderAwsCodeCommitTagFiltersArgs> TagFilters
        {
            get => _tagFilters ?? (_tagFilters = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsScmProviderAwsCodeCommitTagFiltersArgs>());
            set => _tagFilters = value;
        }

        public ApplicationSetSpecGeneratorsScmProviderAwsCodeCommitArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsScmProviderAwsCodeCommitArgs Empty => new ApplicationSetSpecGeneratorsScmProviderAwsCodeCommitArgs();
    }
}
