// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecArgs : global::Pulumi.ResourceArgs
    {
        [Input("destination", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecDestinationArgs> Destination { get; set; } = null!;

        [Input("ignoreDifferences")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecIgnoreDifferencesArgs>? _ignoreDifferences;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecIgnoreDifferencesArgs> IgnoreDifferences
        {
            get => _ignoreDifferences ?? (_ignoreDifferences = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecIgnoreDifferencesArgs>());
            set => _ignoreDifferences = value;
        }

        [Input("info")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecInfoArgs>? _info;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecInfoArgs> Info
        {
            get => _info ?? (_info = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecInfoArgs>());
            set => _info = value;
        }

        [Input("project", required: true)]
        public Input<string> Project { get; set; } = null!;

        [Input("revisionHistoryLimit")]
        public Input<int>? RevisionHistoryLimit { get; set; }

        [Input("source")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourceArgs>? Source { get; set; }

        [Input("sources")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesArgs>? _sources;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesArgs> Sources
        {
            get => _sources ?? (_sources = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesArgs>());
            set => _sources = value;
        }

        [Input("syncPolicy")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSyncPolicyArgs>? SyncPolicy { get; set; }

        public ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecArgs Empty => new ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecArgs();
    }
}