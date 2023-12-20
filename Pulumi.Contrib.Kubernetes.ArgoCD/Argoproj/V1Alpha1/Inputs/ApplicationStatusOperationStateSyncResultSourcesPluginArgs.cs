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
    /// Plugin holds config management plugin specific options
    /// </summary>
    public class ApplicationStatusOperationStateSyncResultSourcesPluginArgs : global::Pulumi.ResourceArgs
    {
        [Input("env")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultSourcesPluginEnvArgs>? _env;

        /// <summary>
        /// Env is a list of environment variable entries
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultSourcesPluginEnvArgs> Env
        {
            get => _env ?? (_env = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultSourcesPluginEnvArgs>());
            set => _env = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("parameters")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultSourcesPluginParametersArgs>? _parameters;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultSourcesPluginParametersArgs> Parameters
        {
            get => _parameters ?? (_parameters = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultSourcesPluginParametersArgs>());
            set => _parameters = value;
        }

        public ApplicationStatusOperationStateSyncResultSourcesPluginArgs()
        {
        }
        public static new ApplicationStatusOperationStateSyncResultSourcesPluginArgs Empty => new ApplicationStatusOperationStateSyncResultSourcesPluginArgs();
    }
}
