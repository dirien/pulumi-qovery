// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace ediri.Qovery
{
    public static class GetHelm
    {
        /// <summary>
        /// ## # qovery.Helm (Data Source)
        /// 
        /// Provides a Qovery helm resource.
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Qovery = Pulumi.Qovery;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var myHelm = Qovery.GetHelm.Invoke(new()
        ///     {
        ///         Id = "&lt;helm_id&gt;",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetHelmResult> InvokeAsync(GetHelmArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetHelmResult>("qovery:index/getHelm:getHelm", args ?? new GetHelmArgs(), options.WithDefaults());

        /// <summary>
        /// ## # qovery.Helm (Data Source)
        /// 
        /// Provides a Qovery helm resource.
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Qovery = Pulumi.Qovery;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var myHelm = Qovery.GetHelm.Invoke(new()
        ///     {
        ///         Id = "&lt;helm_id&gt;",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetHelmResult> Invoke(GetHelmInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetHelmResult>("qovery:index/getHelm:getHelm", args ?? new GetHelmInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetHelmArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Advanced settings.
        /// </summary>
        [Input("advancedSettingsJson")]
        public string? AdvancedSettingsJson { get; set; }

        [Input("deploymentRestrictions")]
        private List<Inputs.GetHelmDeploymentRestrictionArgs>? _deploymentRestrictions;

        /// <summary>
        /// List of deployment restrictions
        /// </summary>
        public List<Inputs.GetHelmDeploymentRestrictionArgs> DeploymentRestrictions
        {
            get => _deploymentRestrictions ?? (_deploymentRestrictions = new List<Inputs.GetHelmDeploymentRestrictionArgs>());
            set => _deploymentRestrictions = value;
        }

        /// <summary>
        /// Id of the deployment stage.
        /// </summary>
        [Input("deploymentStageId")]
        public string? DeploymentStageId { get; set; }

        [Input("environmentVariableAliases")]
        private List<Inputs.GetHelmEnvironmentVariableAliasArgs>? _environmentVariableAliases;

        /// <summary>
        /// List of environment variable aliases linked to this helm.
        /// </summary>
        public List<Inputs.GetHelmEnvironmentVariableAliasArgs> EnvironmentVariableAliases
        {
            get => _environmentVariableAliases ?? (_environmentVariableAliases = new List<Inputs.GetHelmEnvironmentVariableAliasArgs>());
            set => _environmentVariableAliases = value;
        }

        [Input("environmentVariableOverrides")]
        private List<Inputs.GetHelmEnvironmentVariableOverrideArgs>? _environmentVariableOverrides;

        /// <summary>
        /// List of environment variable overrides linked to this helm.
        /// </summary>
        public List<Inputs.GetHelmEnvironmentVariableOverrideArgs> EnvironmentVariableOverrides
        {
            get => _environmentVariableOverrides ?? (_environmentVariableOverrides = new List<Inputs.GetHelmEnvironmentVariableOverrideArgs>());
            set => _environmentVariableOverrides = value;
        }

        [Input("environmentVariables")]
        private List<Inputs.GetHelmEnvironmentVariableArgs>? _environmentVariables;

        /// <summary>
        /// List of environment variables linked to this helm.
        /// </summary>
        public List<Inputs.GetHelmEnvironmentVariableArgs> EnvironmentVariables
        {
            get => _environmentVariables ?? (_environmentVariables = new List<Inputs.GetHelmEnvironmentVariableArgs>());
            set => _environmentVariables = value;
        }

        /// <summary>
        /// Id of the helm.
        /// </summary>
        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        [Input("secretAliases")]
        private List<Inputs.GetHelmSecretAliasArgs>? _secretAliases;

        /// <summary>
        /// List of secret aliases linked to this helm.
        /// </summary>
        public List<Inputs.GetHelmSecretAliasArgs> SecretAliases
        {
            get => _secretAliases ?? (_secretAliases = new List<Inputs.GetHelmSecretAliasArgs>());
            set => _secretAliases = value;
        }

        [Input("secretOverrides")]
        private List<Inputs.GetHelmSecretOverrideArgs>? _secretOverrides;

        /// <summary>
        /// List of secret overrides linked to this helm.
        /// </summary>
        public List<Inputs.GetHelmSecretOverrideArgs> SecretOverrides
        {
            get => _secretOverrides ?? (_secretOverrides = new List<Inputs.GetHelmSecretOverrideArgs>());
            set => _secretOverrides = value;
        }

        [Input("secrets")]
        private List<Inputs.GetHelmSecretArgs>? _secrets;

        /// <summary>
        /// List of secrets linked to this helm.
        /// </summary>
        public List<Inputs.GetHelmSecretArgs> Secrets
        {
            get => _secrets ?? (_secrets = new List<Inputs.GetHelmSecretArgs>());
            set => _secrets = value;
        }

        public GetHelmArgs()
        {
        }
        public static new GetHelmArgs Empty => new GetHelmArgs();
    }

    public sealed class GetHelmInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Advanced settings.
        /// </summary>
        [Input("advancedSettingsJson")]
        public Input<string>? AdvancedSettingsJson { get; set; }

        [Input("deploymentRestrictions")]
        private InputList<Inputs.GetHelmDeploymentRestrictionInputArgs>? _deploymentRestrictions;

        /// <summary>
        /// List of deployment restrictions
        /// </summary>
        public InputList<Inputs.GetHelmDeploymentRestrictionInputArgs> DeploymentRestrictions
        {
            get => _deploymentRestrictions ?? (_deploymentRestrictions = new InputList<Inputs.GetHelmDeploymentRestrictionInputArgs>());
            set => _deploymentRestrictions = value;
        }

        /// <summary>
        /// Id of the deployment stage.
        /// </summary>
        [Input("deploymentStageId")]
        public Input<string>? DeploymentStageId { get; set; }

        [Input("environmentVariableAliases")]
        private InputList<Inputs.GetHelmEnvironmentVariableAliasInputArgs>? _environmentVariableAliases;

        /// <summary>
        /// List of environment variable aliases linked to this helm.
        /// </summary>
        public InputList<Inputs.GetHelmEnvironmentVariableAliasInputArgs> EnvironmentVariableAliases
        {
            get => _environmentVariableAliases ?? (_environmentVariableAliases = new InputList<Inputs.GetHelmEnvironmentVariableAliasInputArgs>());
            set => _environmentVariableAliases = value;
        }

        [Input("environmentVariableOverrides")]
        private InputList<Inputs.GetHelmEnvironmentVariableOverrideInputArgs>? _environmentVariableOverrides;

        /// <summary>
        /// List of environment variable overrides linked to this helm.
        /// </summary>
        public InputList<Inputs.GetHelmEnvironmentVariableOverrideInputArgs> EnvironmentVariableOverrides
        {
            get => _environmentVariableOverrides ?? (_environmentVariableOverrides = new InputList<Inputs.GetHelmEnvironmentVariableOverrideInputArgs>());
            set => _environmentVariableOverrides = value;
        }

        [Input("environmentVariables")]
        private InputList<Inputs.GetHelmEnvironmentVariableInputArgs>? _environmentVariables;

        /// <summary>
        /// List of environment variables linked to this helm.
        /// </summary>
        public InputList<Inputs.GetHelmEnvironmentVariableInputArgs> EnvironmentVariables
        {
            get => _environmentVariables ?? (_environmentVariables = new InputList<Inputs.GetHelmEnvironmentVariableInputArgs>());
            set => _environmentVariables = value;
        }

        /// <summary>
        /// Id of the helm.
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        [Input("secretAliases")]
        private InputList<Inputs.GetHelmSecretAliasInputArgs>? _secretAliases;

        /// <summary>
        /// List of secret aliases linked to this helm.
        /// </summary>
        public InputList<Inputs.GetHelmSecretAliasInputArgs> SecretAliases
        {
            get => _secretAliases ?? (_secretAliases = new InputList<Inputs.GetHelmSecretAliasInputArgs>());
            set => _secretAliases = value;
        }

        [Input("secretOverrides")]
        private InputList<Inputs.GetHelmSecretOverrideInputArgs>? _secretOverrides;

        /// <summary>
        /// List of secret overrides linked to this helm.
        /// </summary>
        public InputList<Inputs.GetHelmSecretOverrideInputArgs> SecretOverrides
        {
            get => _secretOverrides ?? (_secretOverrides = new InputList<Inputs.GetHelmSecretOverrideInputArgs>());
            set => _secretOverrides = value;
        }

        [Input("secrets")]
        private InputList<Inputs.GetHelmSecretInputArgs>? _secrets;

        /// <summary>
        /// List of secrets linked to this helm.
        /// </summary>
        public InputList<Inputs.GetHelmSecretInputArgs> Secrets
        {
            get => _secrets ?? (_secrets = new InputList<Inputs.GetHelmSecretInputArgs>());
            set => _secrets = value;
        }

        public GetHelmInvokeArgs()
        {
        }
        public static new GetHelmInvokeArgs Empty => new GetHelmInvokeArgs();
    }


    [OutputType]
    public sealed class GetHelmResult
    {
        /// <summary>
        /// Advanced settings.
        /// </summary>
        public readonly string AdvancedSettingsJson;
        /// <summary>
        /// List of built-in environment variables linked to this helm.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetHelmBuiltInEnvironmentVariableResult> BuiltInEnvironmentVariables;
        /// <summary>
        /// List of deployment restrictions
        /// </summary>
        public readonly ImmutableArray<Outputs.GetHelmDeploymentRestrictionResult> DeploymentRestrictions;
        /// <summary>
        /// Id of the deployment stage.
        /// </summary>
        public readonly string DeploymentStageId;
        /// <summary>
        /// Id of the environment.
        /// </summary>
        public readonly string EnvironmentId;
        /// <summary>
        /// List of environment variable aliases linked to this helm.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetHelmEnvironmentVariableAliasResult> EnvironmentVariableAliases;
        /// <summary>
        /// List of environment variable overrides linked to this helm.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetHelmEnvironmentVariableOverrideResult> EnvironmentVariableOverrides;
        /// <summary>
        /// List of environment variables linked to this helm.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetHelmEnvironmentVariableResult> EnvironmentVariables;
        /// <summary>
        /// The helm external FQDN host [NOTE: only if your helm is using a publicly accessible port].
        /// </summary>
        public readonly string ExternalHost;
        /// <summary>
        /// Id of the helm.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The helm internal host.
        /// </summary>
        public readonly string InternalHost;
        /// <summary>
        /// Name of the helm.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// List of secret aliases linked to this helm.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetHelmSecretAliasResult> SecretAliases;
        /// <summary>
        /// List of secret overrides linked to this helm.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetHelmSecretOverrideResult> SecretOverrides;
        /// <summary>
        /// List of secrets linked to this helm.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetHelmSecretResult> Secrets;

        [OutputConstructor]
        private GetHelmResult(
            string advancedSettingsJson,

            ImmutableArray<Outputs.GetHelmBuiltInEnvironmentVariableResult> builtInEnvironmentVariables,

            ImmutableArray<Outputs.GetHelmDeploymentRestrictionResult> deploymentRestrictions,

            string deploymentStageId,

            string environmentId,

            ImmutableArray<Outputs.GetHelmEnvironmentVariableAliasResult> environmentVariableAliases,

            ImmutableArray<Outputs.GetHelmEnvironmentVariableOverrideResult> environmentVariableOverrides,

            ImmutableArray<Outputs.GetHelmEnvironmentVariableResult> environmentVariables,

            string externalHost,

            string id,

            string internalHost,

            string name,

            ImmutableArray<Outputs.GetHelmSecretAliasResult> secretAliases,

            ImmutableArray<Outputs.GetHelmSecretOverrideResult> secretOverrides,

            ImmutableArray<Outputs.GetHelmSecretResult> secrets)
        {
            AdvancedSettingsJson = advancedSettingsJson;
            BuiltInEnvironmentVariables = builtInEnvironmentVariables;
            DeploymentRestrictions = deploymentRestrictions;
            DeploymentStageId = deploymentStageId;
            EnvironmentId = environmentId;
            EnvironmentVariableAliases = environmentVariableAliases;
            EnvironmentVariableOverrides = environmentVariableOverrides;
            EnvironmentVariables = environmentVariables;
            ExternalHost = externalHost;
            Id = id;
            InternalHost = internalHost;
            Name = name;
            SecretAliases = secretAliases;
            SecretOverrides = secretOverrides;
            Secrets = secrets;
        }
    }
}
