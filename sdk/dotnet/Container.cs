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
    /// <summary>
    /// ## # qovery.Container (Resource)
    /// 
    /// Provides a Qovery container resource. This can be used to create and manage Qovery container registry.
    /// 
    /// ## Import
    /// 
    /// ```sh
    /// $ pulumi import qovery:index/container:Container my_container "&lt;container_id&gt;"
    /// ```
    /// </summary>
    [QoveryResourceType("qovery:index/container:Container")]
    public partial class Container : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Advanced settings.
        /// </summary>
        [Output("advancedSettingsJson")]
        public Output<string> AdvancedSettingsJson { get; private set; } = null!;

        /// <summary>
        /// List of arguments of this container.
        /// </summary>
        [Output("arguments")]
        public Output<ImmutableArray<string>> Arguments { get; private set; } = null!;

        /// <summary>
        /// Specify if the container will be automatically updated after receiving a new image tag.
        /// </summary>
        [Output("autoDeploy")]
        public Output<bool> AutoDeploy { get; private set; } = null!;

        /// <summary>
        /// Specify if the environment preview option is activated or not for this container.
        /// </summary>
        [Output("autoPreview")]
        public Output<bool> AutoPreview { get; private set; } = null!;

        /// <summary>
        /// List of built-in environment variables linked to this container.
        /// </summary>
        [Output("builtInEnvironmentVariables")]
        public Output<ImmutableArray<Outputs.ContainerBuiltInEnvironmentVariable>> BuiltInEnvironmentVariables { get; private set; } = null!;

        /// <summary>
        /// CPU of the container in millicores (m) [1000m = 1 CPU]. - Must be: `&gt;= 10`. - Default: `500`.
        /// </summary>
        [Output("cpu")]
        public Output<int> Cpu { get; private set; } = null!;

        /// <summary>
        /// List of custom domains linked to this container.
        /// </summary>
        [Output("customDomains")]
        public Output<ImmutableArray<Outputs.ContainerCustomDomain>> CustomDomains { get; private set; } = null!;

        /// <summary>
        /// Id of the deployment stage.
        /// </summary>
        [Output("deploymentStageId")]
        public Output<string> DeploymentStageId { get; private set; } = null!;

        /// <summary>
        /// Entrypoint of the container.
        /// </summary>
        [Output("entrypoint")]
        public Output<string?> Entrypoint { get; private set; } = null!;

        /// <summary>
        /// Id of the environment.
        /// </summary>
        [Output("environmentId")]
        public Output<string> EnvironmentId { get; private set; } = null!;

        /// <summary>
        /// List of environment variable aliases linked to this container.
        /// </summary>
        [Output("environmentVariableAliases")]
        public Output<ImmutableArray<Outputs.ContainerEnvironmentVariableAlias>> EnvironmentVariableAliases { get; private set; } = null!;

        /// <summary>
        /// List of environment variable overrides linked to this container.
        /// </summary>
        [Output("environmentVariableOverrides")]
        public Output<ImmutableArray<Outputs.ContainerEnvironmentVariableOverride>> EnvironmentVariableOverrides { get; private set; } = null!;

        /// <summary>
        /// List of environment variables linked to this container.
        /// </summary>
        [Output("environmentVariables")]
        public Output<ImmutableArray<Outputs.ContainerEnvironmentVariable>> EnvironmentVariables { get; private set; } = null!;

        /// <summary>
        /// The container external FQDN host [NOTE: only if your container is using a publicly accessible port].
        /// </summary>
        [Output("externalHost")]
        public Output<string> ExternalHost { get; private set; } = null!;

        /// <summary>
        /// Configuration for the healthchecks that are going to be executed against your service
        /// </summary>
        [Output("healthchecks")]
        public Output<Outputs.ContainerHealthchecks> Healthchecks { get; private set; } = null!;

        /// <summary>
        /// Name of the container image.
        /// </summary>
        [Output("imageName")]
        public Output<string> ImageName { get; private set; } = null!;

        /// <summary>
        /// The container internal host.
        /// </summary>
        [Output("internalHost")]
        public Output<string> InternalHost { get; private set; } = null!;

        /// <summary>
        /// Maximum number of instances running for the container. - Must be: `&gt;= -1`. - Default: `1`.
        /// </summary>
        [Output("maxRunningInstances")]
        public Output<int> MaxRunningInstances { get; private set; } = null!;

        /// <summary>
        /// RAM of the container in MB [1024MB = 1GB]. - Must be: `&gt;= 10`. - Default: `512`.
        /// </summary>
        [Output("memory")]
        public Output<int> Memory { get; private set; } = null!;

        /// <summary>
        /// Minimum number of instances running for the container. - Must be: `&gt;= 1`. - Default: `1`.
        /// </summary>
        [Output("minRunningInstances")]
        public Output<int> MinRunningInstances { get; private set; } = null!;

        /// <summary>
        /// Name of the container.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// List of ports linked to this container.
        /// </summary>
        [Output("ports")]
        public Output<ImmutableArray<Outputs.ContainerPort>> Ports { get; private set; } = null!;

        /// <summary>
        /// Id of the registry.
        /// </summary>
        [Output("registryId")]
        public Output<string> RegistryId { get; private set; } = null!;

        /// <summary>
        /// List of secret aliases linked to this container.
        /// </summary>
        [Output("secretAliases")]
        public Output<ImmutableArray<Outputs.ContainerSecretAlias>> SecretAliases { get; private set; } = null!;

        /// <summary>
        /// List of secret overrides linked to this container.
        /// </summary>
        [Output("secretOverrides")]
        public Output<ImmutableArray<Outputs.ContainerSecretOverride>> SecretOverrides { get; private set; } = null!;

        /// <summary>
        /// List of secrets linked to this container.
        /// </summary>
        [Output("secrets")]
        public Output<ImmutableArray<Outputs.ContainerSecret>> Secrets { get; private set; } = null!;

        /// <summary>
        /// List of storages linked to this container.
        /// </summary>
        [Output("storages")]
        public Output<ImmutableArray<Outputs.ContainerStorage>> Storages { get; private set; } = null!;

        /// <summary>
        /// Tag of the container image.
        /// </summary>
        [Output("tag")]
        public Output<string> Tag { get; private set; } = null!;


        /// <summary>
        /// Create a Container resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Container(string name, ContainerArgs args, CustomResourceOptions? options = null)
            : base("qovery:index/container:Container", name, args ?? new ContainerArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Container(string name, Input<string> id, ContainerState? state = null, CustomResourceOptions? options = null)
            : base("qovery:index/container:Container", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/dirien/pulumi-qovery",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Container resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Container Get(string name, Input<string> id, ContainerState? state = null, CustomResourceOptions? options = null)
        {
            return new Container(name, id, state, options);
        }
    }

    public sealed class ContainerArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Advanced settings.
        /// </summary>
        [Input("advancedSettingsJson")]
        public Input<string>? AdvancedSettingsJson { get; set; }

        [Input("arguments")]
        private InputList<string>? _arguments;

        /// <summary>
        /// List of arguments of this container.
        /// </summary>
        public InputList<string> Arguments
        {
            get => _arguments ?? (_arguments = new InputList<string>());
            set => _arguments = value;
        }

        /// <summary>
        /// Specify if the container will be automatically updated after receiving a new image tag.
        /// </summary>
        [Input("autoDeploy")]
        public Input<bool>? AutoDeploy { get; set; }

        /// <summary>
        /// Specify if the environment preview option is activated or not for this container.
        /// </summary>
        [Input("autoPreview")]
        public Input<bool>? AutoPreview { get; set; }

        /// <summary>
        /// CPU of the container in millicores (m) [1000m = 1 CPU]. - Must be: `&gt;= 10`. - Default: `500`.
        /// </summary>
        [Input("cpu")]
        public Input<int>? Cpu { get; set; }

        [Input("customDomains")]
        private InputList<Inputs.ContainerCustomDomainArgs>? _customDomains;

        /// <summary>
        /// List of custom domains linked to this container.
        /// </summary>
        public InputList<Inputs.ContainerCustomDomainArgs> CustomDomains
        {
            get => _customDomains ?? (_customDomains = new InputList<Inputs.ContainerCustomDomainArgs>());
            set => _customDomains = value;
        }

        /// <summary>
        /// Id of the deployment stage.
        /// </summary>
        [Input("deploymentStageId")]
        public Input<string>? DeploymentStageId { get; set; }

        /// <summary>
        /// Entrypoint of the container.
        /// </summary>
        [Input("entrypoint")]
        public Input<string>? Entrypoint { get; set; }

        /// <summary>
        /// Id of the environment.
        /// </summary>
        [Input("environmentId", required: true)]
        public Input<string> EnvironmentId { get; set; } = null!;

        [Input("environmentVariableAliases")]
        private InputList<Inputs.ContainerEnvironmentVariableAliasArgs>? _environmentVariableAliases;

        /// <summary>
        /// List of environment variable aliases linked to this container.
        /// </summary>
        public InputList<Inputs.ContainerEnvironmentVariableAliasArgs> EnvironmentVariableAliases
        {
            get => _environmentVariableAliases ?? (_environmentVariableAliases = new InputList<Inputs.ContainerEnvironmentVariableAliasArgs>());
            set => _environmentVariableAliases = value;
        }

        [Input("environmentVariableOverrides")]
        private InputList<Inputs.ContainerEnvironmentVariableOverrideArgs>? _environmentVariableOverrides;

        /// <summary>
        /// List of environment variable overrides linked to this container.
        /// </summary>
        public InputList<Inputs.ContainerEnvironmentVariableOverrideArgs> EnvironmentVariableOverrides
        {
            get => _environmentVariableOverrides ?? (_environmentVariableOverrides = new InputList<Inputs.ContainerEnvironmentVariableOverrideArgs>());
            set => _environmentVariableOverrides = value;
        }

        [Input("environmentVariables")]
        private InputList<Inputs.ContainerEnvironmentVariableArgs>? _environmentVariables;

        /// <summary>
        /// List of environment variables linked to this container.
        /// </summary>
        public InputList<Inputs.ContainerEnvironmentVariableArgs> EnvironmentVariables
        {
            get => _environmentVariables ?? (_environmentVariables = new InputList<Inputs.ContainerEnvironmentVariableArgs>());
            set => _environmentVariables = value;
        }

        /// <summary>
        /// Configuration for the healthchecks that are going to be executed against your service
        /// </summary>
        [Input("healthchecks", required: true)]
        public Input<Inputs.ContainerHealthchecksArgs> Healthchecks { get; set; } = null!;

        /// <summary>
        /// Name of the container image.
        /// </summary>
        [Input("imageName", required: true)]
        public Input<string> ImageName { get; set; } = null!;

        /// <summary>
        /// Maximum number of instances running for the container. - Must be: `&gt;= -1`. - Default: `1`.
        /// </summary>
        [Input("maxRunningInstances")]
        public Input<int>? MaxRunningInstances { get; set; }

        /// <summary>
        /// RAM of the container in MB [1024MB = 1GB]. - Must be: `&gt;= 10`. - Default: `512`.
        /// </summary>
        [Input("memory")]
        public Input<int>? Memory { get; set; }

        /// <summary>
        /// Minimum number of instances running for the container. - Must be: `&gt;= 1`. - Default: `1`.
        /// </summary>
        [Input("minRunningInstances")]
        public Input<int>? MinRunningInstances { get; set; }

        /// <summary>
        /// Name of the container.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("ports")]
        private InputList<Inputs.ContainerPortArgs>? _ports;

        /// <summary>
        /// List of ports linked to this container.
        /// </summary>
        public InputList<Inputs.ContainerPortArgs> Ports
        {
            get => _ports ?? (_ports = new InputList<Inputs.ContainerPortArgs>());
            set => _ports = value;
        }

        /// <summary>
        /// Id of the registry.
        /// </summary>
        [Input("registryId", required: true)]
        public Input<string> RegistryId { get; set; } = null!;

        [Input("secretAliases")]
        private InputList<Inputs.ContainerSecretAliasArgs>? _secretAliases;

        /// <summary>
        /// List of secret aliases linked to this container.
        /// </summary>
        public InputList<Inputs.ContainerSecretAliasArgs> SecretAliases
        {
            get => _secretAliases ?? (_secretAliases = new InputList<Inputs.ContainerSecretAliasArgs>());
            set => _secretAliases = value;
        }

        [Input("secretOverrides")]
        private InputList<Inputs.ContainerSecretOverrideArgs>? _secretOverrides;

        /// <summary>
        /// List of secret overrides linked to this container.
        /// </summary>
        public InputList<Inputs.ContainerSecretOverrideArgs> SecretOverrides
        {
            get => _secretOverrides ?? (_secretOverrides = new InputList<Inputs.ContainerSecretOverrideArgs>());
            set => _secretOverrides = value;
        }

        [Input("secrets")]
        private InputList<Inputs.ContainerSecretArgs>? _secrets;

        /// <summary>
        /// List of secrets linked to this container.
        /// </summary>
        public InputList<Inputs.ContainerSecretArgs> Secrets
        {
            get => _secrets ?? (_secrets = new InputList<Inputs.ContainerSecretArgs>());
            set => _secrets = value;
        }

        [Input("storages")]
        private InputList<Inputs.ContainerStorageArgs>? _storages;

        /// <summary>
        /// List of storages linked to this container.
        /// </summary>
        public InputList<Inputs.ContainerStorageArgs> Storages
        {
            get => _storages ?? (_storages = new InputList<Inputs.ContainerStorageArgs>());
            set => _storages = value;
        }

        /// <summary>
        /// Tag of the container image.
        /// </summary>
        [Input("tag", required: true)]
        public Input<string> Tag { get; set; } = null!;

        public ContainerArgs()
        {
        }
        public static new ContainerArgs Empty => new ContainerArgs();
    }

    public sealed class ContainerState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Advanced settings.
        /// </summary>
        [Input("advancedSettingsJson")]
        public Input<string>? AdvancedSettingsJson { get; set; }

        [Input("arguments")]
        private InputList<string>? _arguments;

        /// <summary>
        /// List of arguments of this container.
        /// </summary>
        public InputList<string> Arguments
        {
            get => _arguments ?? (_arguments = new InputList<string>());
            set => _arguments = value;
        }

        /// <summary>
        /// Specify if the container will be automatically updated after receiving a new image tag.
        /// </summary>
        [Input("autoDeploy")]
        public Input<bool>? AutoDeploy { get; set; }

        /// <summary>
        /// Specify if the environment preview option is activated or not for this container.
        /// </summary>
        [Input("autoPreview")]
        public Input<bool>? AutoPreview { get; set; }

        [Input("builtInEnvironmentVariables")]
        private InputList<Inputs.ContainerBuiltInEnvironmentVariableGetArgs>? _builtInEnvironmentVariables;

        /// <summary>
        /// List of built-in environment variables linked to this container.
        /// </summary>
        public InputList<Inputs.ContainerBuiltInEnvironmentVariableGetArgs> BuiltInEnvironmentVariables
        {
            get => _builtInEnvironmentVariables ?? (_builtInEnvironmentVariables = new InputList<Inputs.ContainerBuiltInEnvironmentVariableGetArgs>());
            set => _builtInEnvironmentVariables = value;
        }

        /// <summary>
        /// CPU of the container in millicores (m) [1000m = 1 CPU]. - Must be: `&gt;= 10`. - Default: `500`.
        /// </summary>
        [Input("cpu")]
        public Input<int>? Cpu { get; set; }

        [Input("customDomains")]
        private InputList<Inputs.ContainerCustomDomainGetArgs>? _customDomains;

        /// <summary>
        /// List of custom domains linked to this container.
        /// </summary>
        public InputList<Inputs.ContainerCustomDomainGetArgs> CustomDomains
        {
            get => _customDomains ?? (_customDomains = new InputList<Inputs.ContainerCustomDomainGetArgs>());
            set => _customDomains = value;
        }

        /// <summary>
        /// Id of the deployment stage.
        /// </summary>
        [Input("deploymentStageId")]
        public Input<string>? DeploymentStageId { get; set; }

        /// <summary>
        /// Entrypoint of the container.
        /// </summary>
        [Input("entrypoint")]
        public Input<string>? Entrypoint { get; set; }

        /// <summary>
        /// Id of the environment.
        /// </summary>
        [Input("environmentId")]
        public Input<string>? EnvironmentId { get; set; }

        [Input("environmentVariableAliases")]
        private InputList<Inputs.ContainerEnvironmentVariableAliasGetArgs>? _environmentVariableAliases;

        /// <summary>
        /// List of environment variable aliases linked to this container.
        /// </summary>
        public InputList<Inputs.ContainerEnvironmentVariableAliasGetArgs> EnvironmentVariableAliases
        {
            get => _environmentVariableAliases ?? (_environmentVariableAliases = new InputList<Inputs.ContainerEnvironmentVariableAliasGetArgs>());
            set => _environmentVariableAliases = value;
        }

        [Input("environmentVariableOverrides")]
        private InputList<Inputs.ContainerEnvironmentVariableOverrideGetArgs>? _environmentVariableOverrides;

        /// <summary>
        /// List of environment variable overrides linked to this container.
        /// </summary>
        public InputList<Inputs.ContainerEnvironmentVariableOverrideGetArgs> EnvironmentVariableOverrides
        {
            get => _environmentVariableOverrides ?? (_environmentVariableOverrides = new InputList<Inputs.ContainerEnvironmentVariableOverrideGetArgs>());
            set => _environmentVariableOverrides = value;
        }

        [Input("environmentVariables")]
        private InputList<Inputs.ContainerEnvironmentVariableGetArgs>? _environmentVariables;

        /// <summary>
        /// List of environment variables linked to this container.
        /// </summary>
        public InputList<Inputs.ContainerEnvironmentVariableGetArgs> EnvironmentVariables
        {
            get => _environmentVariables ?? (_environmentVariables = new InputList<Inputs.ContainerEnvironmentVariableGetArgs>());
            set => _environmentVariables = value;
        }

        /// <summary>
        /// The container external FQDN host [NOTE: only if your container is using a publicly accessible port].
        /// </summary>
        [Input("externalHost")]
        public Input<string>? ExternalHost { get; set; }

        /// <summary>
        /// Configuration for the healthchecks that are going to be executed against your service
        /// </summary>
        [Input("healthchecks")]
        public Input<Inputs.ContainerHealthchecksGetArgs>? Healthchecks { get; set; }

        /// <summary>
        /// Name of the container image.
        /// </summary>
        [Input("imageName")]
        public Input<string>? ImageName { get; set; }

        /// <summary>
        /// The container internal host.
        /// </summary>
        [Input("internalHost")]
        public Input<string>? InternalHost { get; set; }

        /// <summary>
        /// Maximum number of instances running for the container. - Must be: `&gt;= -1`. - Default: `1`.
        /// </summary>
        [Input("maxRunningInstances")]
        public Input<int>? MaxRunningInstances { get; set; }

        /// <summary>
        /// RAM of the container in MB [1024MB = 1GB]. - Must be: `&gt;= 10`. - Default: `512`.
        /// </summary>
        [Input("memory")]
        public Input<int>? Memory { get; set; }

        /// <summary>
        /// Minimum number of instances running for the container. - Must be: `&gt;= 1`. - Default: `1`.
        /// </summary>
        [Input("minRunningInstances")]
        public Input<int>? MinRunningInstances { get; set; }

        /// <summary>
        /// Name of the container.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("ports")]
        private InputList<Inputs.ContainerPortGetArgs>? _ports;

        /// <summary>
        /// List of ports linked to this container.
        /// </summary>
        public InputList<Inputs.ContainerPortGetArgs> Ports
        {
            get => _ports ?? (_ports = new InputList<Inputs.ContainerPortGetArgs>());
            set => _ports = value;
        }

        /// <summary>
        /// Id of the registry.
        /// </summary>
        [Input("registryId")]
        public Input<string>? RegistryId { get; set; }

        [Input("secretAliases")]
        private InputList<Inputs.ContainerSecretAliasGetArgs>? _secretAliases;

        /// <summary>
        /// List of secret aliases linked to this container.
        /// </summary>
        public InputList<Inputs.ContainerSecretAliasGetArgs> SecretAliases
        {
            get => _secretAliases ?? (_secretAliases = new InputList<Inputs.ContainerSecretAliasGetArgs>());
            set => _secretAliases = value;
        }

        [Input("secretOverrides")]
        private InputList<Inputs.ContainerSecretOverrideGetArgs>? _secretOverrides;

        /// <summary>
        /// List of secret overrides linked to this container.
        /// </summary>
        public InputList<Inputs.ContainerSecretOverrideGetArgs> SecretOverrides
        {
            get => _secretOverrides ?? (_secretOverrides = new InputList<Inputs.ContainerSecretOverrideGetArgs>());
            set => _secretOverrides = value;
        }

        [Input("secrets")]
        private InputList<Inputs.ContainerSecretGetArgs>? _secrets;

        /// <summary>
        /// List of secrets linked to this container.
        /// </summary>
        public InputList<Inputs.ContainerSecretGetArgs> Secrets
        {
            get => _secrets ?? (_secrets = new InputList<Inputs.ContainerSecretGetArgs>());
            set => _secrets = value;
        }

        [Input("storages")]
        private InputList<Inputs.ContainerStorageGetArgs>? _storages;

        /// <summary>
        /// List of storages linked to this container.
        /// </summary>
        public InputList<Inputs.ContainerStorageGetArgs> Storages
        {
            get => _storages ?? (_storages = new InputList<Inputs.ContainerStorageGetArgs>());
            set => _storages = value;
        }

        /// <summary>
        /// Tag of the container image.
        /// </summary>
        [Input("tag")]
        public Input<string>? Tag { get; set; }

        public ContainerState()
        {
        }
        public static new ContainerState Empty => new ContainerState();
    }
}
