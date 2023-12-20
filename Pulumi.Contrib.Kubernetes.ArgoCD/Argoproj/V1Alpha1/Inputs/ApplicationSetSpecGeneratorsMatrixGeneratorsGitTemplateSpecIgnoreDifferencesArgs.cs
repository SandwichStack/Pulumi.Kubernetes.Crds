// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecIgnoreDifferencesArgs : global::Pulumi.ResourceArgs
    {
        [Input("group")]
        public Input<string>? Group { get; set; }

        [Input("jqPathExpressions")]
        private InputList<string>? _jqPathExpressions;
        public InputList<string> JqPathExpressions
        {
            get => _jqPathExpressions ?? (_jqPathExpressions = new InputList<string>());
            set => _jqPathExpressions = value;
        }

        [Input("jsonPointers")]
        private InputList<string>? _jsonPointers;
        public InputList<string> JsonPointers
        {
            get => _jsonPointers ?? (_jsonPointers = new InputList<string>());
            set => _jsonPointers = value;
        }

        [Input("kind", required: true)]
        public Input<string> Kind { get; set; } = null!;

        [Input("managedFieldsManagers")]
        private InputList<string>? _managedFieldsManagers;
        public InputList<string> ManagedFieldsManagers
        {
            get => _managedFieldsManagers ?? (_managedFieldsManagers = new InputList<string>());
            set => _managedFieldsManagers = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        public ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecIgnoreDifferencesArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecIgnoreDifferencesArgs Empty => new ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecIgnoreDifferencesArgs();
    }
}
