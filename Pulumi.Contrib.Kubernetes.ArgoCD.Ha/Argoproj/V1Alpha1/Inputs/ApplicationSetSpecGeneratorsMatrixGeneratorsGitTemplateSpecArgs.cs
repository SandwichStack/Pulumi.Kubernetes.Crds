// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecArgs : global::Pulumi.ResourceArgs
    {
        [Input("destination", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecDestinationArgs> Destination { get; set; } = null!;

        [Input("ignoreDifferences")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecIgnoreDifferencesArgs>? _ignoreDifferences;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecIgnoreDifferencesArgs> IgnoreDifferences
        {
            get => _ignoreDifferences ?? (_ignoreDifferences = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecIgnoreDifferencesArgs>());
            set => _ignoreDifferences = value;
        }

        [Input("info")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecInfoArgs>? _info;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecInfoArgs> Info
        {
            get => _info ?? (_info = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecInfoArgs>());
            set => _info = value;
        }

        [Input("project", required: true)]
        public Input<string> Project { get; set; } = null!;

        [Input("revisionHistoryLimit")]
        public Input<int>? RevisionHistoryLimit { get; set; }

        [Input("source")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceArgs>? Source { get; set; }

        [Input("sources")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesArgs>? _sources;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesArgs> Sources
        {
            get => _sources ?? (_sources = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesArgs>());
            set => _sources = value;
        }

        [Input("syncPolicy")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSyncPolicyArgs>? SyncPolicy { get; set; }

        public ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecArgs Empty => new ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecArgs();
    }
}