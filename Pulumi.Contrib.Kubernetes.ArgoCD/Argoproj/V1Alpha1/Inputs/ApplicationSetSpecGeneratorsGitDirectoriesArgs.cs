// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    public class ApplicationSetSpecGeneratorsGitDirectoriesArgs : global::Pulumi.ResourceArgs
    {
        [Input("exclude")]
        public Input<bool>? Exclude { get; set; }

        [Input("path", required: true)]
        public Input<string> Path { get; set; } = null!;

        public ApplicationSetSpecGeneratorsGitDirectoriesArgs()
        {
        }
        public static new ApplicationSetSpecGeneratorsGitDirectoriesArgs Empty => new ApplicationSetSpecGeneratorsGitDirectoriesArgs();
    }
}
