// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1
{

    /// <summary>
    /// ApplicationSource contains all required information about the source of an application
    /// </summary>
    [OutputType]
    public sealed class ApplicationStatusOperationStateOperationSyncSources
    {
        /// <summary>
        /// Chart is a Helm chart name, and must be specified for applications sourced from a Helm repo.
        /// </summary>
        public readonly string Chart;
        /// <summary>
        /// Directory holds path/directory specific options
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncSourcesDirectory Directory;
        /// <summary>
        /// Helm holds helm specific options
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncSourcesHelm Helm;
        /// <summary>
        /// Kustomize holds kustomize specific options
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncSourcesKustomize Kustomize;
        /// <summary>
        /// Path is a directory path within the Git repository, and is only valid for applications sourced from Git.
        /// </summary>
        public readonly string Path;
        /// <summary>
        /// Plugin holds config management plugin specific options
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncSourcesPlugin Plugin;
        /// <summary>
        /// Ref is reference to another source within sources field. This field will not be used if used with a `source` tag.
        /// </summary>
        public readonly string Ref;
        /// <summary>
        /// RepoURL is the URL to the repository (Git or Helm) that contains the application manifests
        /// </summary>
        public readonly string RepoURL;
        /// <summary>
        /// TargetRevision defines the revision of the source to sync the application to. In case of Git, this can be commit, tag, or branch. If omitted, will equal to HEAD. In case of Helm, this is a semver tag for the Chart's version.
        /// </summary>
        public readonly string TargetRevision;

        [OutputConstructor]
        private ApplicationStatusOperationStateOperationSyncSources(
            string chart,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncSourcesDirectory directory,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncSourcesHelm helm,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncSourcesKustomize kustomize,

            string path,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncSourcesPlugin plugin,

            string @ref,

            string repoURL,

            string targetRevision)
        {
            Chart = chart;
            Directory = directory;
            Helm = helm;
            Kustomize = kustomize;
            Path = path;
            Plugin = plugin;
            Ref = @ref;
            RepoURL = repoURL;
            TargetRevision = targetRevision;
        }
    }
}
