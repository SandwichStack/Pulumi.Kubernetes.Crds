// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSyncPolicyManagedNamespaceMetadataArgs : global::Pulumi.ResourceArgs
    {
        [Input("annotations")]
        private InputMap<string>? _annotations;
        public InputMap<string> Annotations
        {
            get => _annotations ?? (_annotations = new InputMap<string>());
            set => _annotations = value;
        }

        [Input("labels")]
        private InputMap<string>? _labels;
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        public ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSyncPolicyManagedNamespaceMetadataArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSyncPolicyManagedNamespaceMetadataArgs Empty => new ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSyncPolicyManagedNamespaceMetadataArgs();
    }
}
