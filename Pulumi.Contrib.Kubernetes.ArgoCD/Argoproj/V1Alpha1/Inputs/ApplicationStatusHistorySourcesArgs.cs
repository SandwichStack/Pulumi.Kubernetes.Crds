// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    /// <summary>
    /// ApplicationSource contains all required information about the source of an application
    /// </summary>
    public class ApplicationStatusHistorySourcesArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Chart is a Helm chart name, and must be specified for applications sourced from a Helm repo.
        /// </summary>
        [Input("chart")]
        public Input<string>? Chart { get; set; }

        /// <summary>
        /// Directory holds path/directory specific options
        /// </summary>
        [Input("directory")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusHistorySourcesDirectoryArgs>? Directory { get; set; }

        /// <summary>
        /// Helm holds helm specific options
        /// </summary>
        [Input("helm")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusHistorySourcesHelmArgs>? Helm { get; set; }

        /// <summary>
        /// Kustomize holds kustomize specific options
        /// </summary>
        [Input("kustomize")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusHistorySourcesKustomizeArgs>? Kustomize { get; set; }

        /// <summary>
        /// Path is a directory path within the Git repository, and is only valid for applications sourced from Git.
        /// </summary>
        [Input("path")]
        public Input<string>? Path { get; set; }

        /// <summary>
        /// Plugin holds config management plugin specific options
        /// </summary>
        [Input("plugin")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusHistorySourcesPluginArgs>? Plugin { get; set; }

        /// <summary>
        /// Ref is reference to another source within sources field. This field will not be used if used with a `source` tag.
        /// </summary>
        [Input("ref")]
        public Input<string>? Ref { get; set; }

        /// <summary>
        /// RepoURL is the URL to the repository (Git or Helm) that contains the application manifests
        /// </summary>
        [Input("repoURL", required: true)]
        public Input<string> RepoURL { get; set; } = null!;

        /// <summary>
        /// TargetRevision defines the revision of the source to sync the application to. In case of Git, this can be commit, tag, or branch. If omitted, will equal to HEAD. In case of Helm, this is a semver tag for the Chart's version.
        /// </summary>
        [Input("targetRevision")]
        public Input<string>? TargetRevision { get; set; }

        public ApplicationStatusHistorySourcesArgs()
        {
        }
        public static new ApplicationStatusHistorySourcesArgs Empty => new ApplicationStatusHistorySourcesArgs();
    }
}
