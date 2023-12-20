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
    /// Helm holds helm specific options
    /// </summary>
    [OutputType]
    public sealed class ApplicationOperationSyncSourcesHelm
    {
        /// <summary>
        /// FileParameters are file parameters to the helm template
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationOperationSyncSourcesHelmFileParameters> FileParameters;
        /// <summary>
        /// IgnoreMissingValueFiles prevents helm template from failing when valueFiles do not exist locally by not appending them to helm template --values
        /// </summary>
        public readonly bool IgnoreMissingValueFiles;
        /// <summary>
        /// Parameters is a list of Helm parameters which are passed to the helm template command upon manifest generation
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationOperationSyncSourcesHelmParameters> Parameters;
        /// <summary>
        /// PassCredentials pass credentials to all domains (Helm's --pass-credentials)
        /// </summary>
        public readonly bool PassCredentials;
        /// <summary>
        /// ReleaseName is the Helm release name to use. If omitted it will use the application name
        /// </summary>
        public readonly string ReleaseName;
        /// <summary>
        /// SkipCrds skips custom resource definition installation step (Helm's --skip-crds)
        /// </summary>
        public readonly bool SkipCrds;
        /// <summary>
        /// ValuesFiles is a list of Helm value files to use when generating a template
        /// </summary>
        public readonly ImmutableArray<string> ValueFiles;
        /// <summary>
        /// Values specifies Helm values to be passed to helm template, typically defined as a block. ValuesObject takes precedence over Values, so use one or the other.
        /// </summary>
        public readonly string Values;
        /// <summary>
        /// ValuesObject specifies Helm values to be passed to helm template, defined as a map. This takes precedence over Values.
        /// </summary>
        public readonly ImmutableDictionary<string, object> ValuesObject;
        /// <summary>
        /// Version is the Helm version to use for templating ("3")
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private ApplicationOperationSyncSourcesHelm(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationOperationSyncSourcesHelmFileParameters> fileParameters,

            bool ignoreMissingValueFiles,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationOperationSyncSourcesHelmParameters> parameters,

            bool passCredentials,

            string releaseName,

            bool skipCrds,

            ImmutableArray<string> valueFiles,

            string values,

            ImmutableDictionary<string, object> valuesObject,

            string version)
        {
            FileParameters = fileParameters;
            IgnoreMissingValueFiles = ignoreMissingValueFiles;
            Parameters = parameters;
            PassCredentials = passCredentials;
            ReleaseName = releaseName;
            SkipCrds = skipCrds;
            ValueFiles = valueFiles;
            Values = values;
            ValuesObject = valuesObject;
            Version = version;
        }
    }
}
