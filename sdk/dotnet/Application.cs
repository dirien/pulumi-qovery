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
    /// ## Import
    /// 
    /// ```sh
    ///  $ pulumi import qovery:index/application:Application my_application "&lt;application_id&gt;"
    /// ```
    /// </summary>
    [QoveryResourceType("qovery:index/application:Application")]
    public partial class Application : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Advanced settings.
        /// </summary>
        [Output("advancedSettingsJson")]
        public Output<string> AdvancedSettingsJson { get; private set; } = null!;

        /// <summary>
        /// List of arguments of this application.
        /// </summary>
        [Output("arguments")]
        public Output<ImmutableArray<string>> Arguments { get; private set; } = null!;

        /// <summary>
        /// Specify if the application will be automatically updated after receiving a new image tag.
        /// </summary>
        [Output("autoDeploy")]
        public Output<bool> AutoDeploy { get; private set; } = null!;

        /// <summary>
        /// Specify if the environment preview option is activated or not for this application. - Default: `false`.
        /// </summary>
        [Output("autoPreview")]
        public Output<bool> AutoPreview { get; private set; } = null!;

        /// <summary>
        /// Build Mode of the application. - Can be: `BUILDPACKS`, `DOCKER`. - Default: `BUILDPACKS`.
        /// </summary>
        [Output("buildMode")]
        public Output<string> BuildMode { get; private set; } = null!;

        /// <summary>
        /// Buildpack Language framework. - Required if: `build_mode="BUILDPACKS"`. - Can be: `CLOJURE`, `GO`, `GRADLE`, `GRAILS`,
        /// `JAVA`, `JVM`, `NODE_JS`, `PHP`, `PLAY`, `PYTHON`, `SCALA`.
        /// </summary>
        [Output("buildpackLanguage")]
        public Output<string?> BuildpackLanguage { get; private set; } = null!;

        /// <summary>
        /// List of built-in environment variables linked to this application.
        /// </summary>
        [Output("builtInEnvironmentVariables")]
        public Output<ImmutableArray<Outputs.ApplicationBuiltInEnvironmentVariable>> BuiltInEnvironmentVariables { get; private set; } = null!;

        /// <summary>
        /// CPU of the application in millicores (m) [1000m = 1 CPU]. - Must be: `&gt;= 10`. - Default: `500`.
        /// </summary>
        [Output("cpu")]
        public Output<int> Cpu { get; private set; } = null!;

        /// <summary>
        /// List of custom domains linked to this application.
        /// </summary>
        [Output("customDomains")]
        public Output<ImmutableArray<Outputs.ApplicationCustomDomain>> CustomDomains { get; private set; } = null!;

        /// <summary>
        /// Id of the deployment stage.
        /// </summary>
        [Output("deploymentStageId")]
        public Output<string> DeploymentStageId { get; private set; } = null!;

        /// <summary>
        /// Dockerfile Path of the application. - Required if: `build_mode="DOCKER"`.
        /// </summary>
        [Output("dockerfilePath")]
        public Output<string?> DockerfilePath { get; private set; } = null!;

        /// <summary>
        /// Entrypoint of the application.
        /// </summary>
        [Output("entrypoint")]
        public Output<string> Entrypoint { get; private set; } = null!;

        /// <summary>
        /// Id of the environment.
        /// </summary>
        [Output("environmentId")]
        public Output<string> EnvironmentId { get; private set; } = null!;

        /// <summary>
        /// List of environment variable aliases linked to this application.
        /// </summary>
        [Output("environmentVariableAliases")]
        public Output<ImmutableArray<Outputs.ApplicationEnvironmentVariableAlias>> EnvironmentVariableAliases { get; private set; } = null!;

        /// <summary>
        /// List of environment variable overrides linked to this application.
        /// </summary>
        [Output("environmentVariableOverrides")]
        public Output<ImmutableArray<Outputs.ApplicationEnvironmentVariableOverride>> EnvironmentVariableOverrides { get; private set; } = null!;

        /// <summary>
        /// List of environment variables linked to this application.
        /// </summary>
        [Output("environmentVariables")]
        public Output<ImmutableArray<Outputs.ApplicationEnvironmentVariable>> EnvironmentVariables { get; private set; } = null!;

        /// <summary>
        /// The application external FQDN host [NOTE: only if your application is using a publicly accessible port].
        /// </summary>
        [Output("externalHost")]
        public Output<string> ExternalHost { get; private set; } = null!;

        /// <summary>
        /// Git repository of the application.
        /// </summary>
        [Output("gitRepository")]
        public Output<Outputs.ApplicationGitRepository> GitRepository { get; private set; } = null!;

        /// <summary>
        /// Configuration for the healthchecks that are going to be executed against your service
        /// </summary>
        [Output("healthchecks")]
        public Output<Outputs.ApplicationHealthchecks> Healthchecks { get; private set; } = null!;

        /// <summary>
        /// The application internal host.
        /// </summary>
        [Output("internalHost")]
        public Output<string> InternalHost { get; private set; } = null!;

        /// <summary>
        /// Maximum number of instances running for the application. - Must be: `&gt;= -1`. - Default: `1`.
        /// </summary>
        [Output("maxRunningInstances")]
        public Output<int> MaxRunningInstances { get; private set; } = null!;

        /// <summary>
        /// RAM of the application in MB [1024MB = 1GB]. - Must be: `&gt;= 1`. - Default: `512`.
        /// </summary>
        [Output("memory")]
        public Output<int> Memory { get; private set; } = null!;

        /// <summary>
        /// Minimum number of instances running for the application. - Must be: `&gt;= 0`. - Default: `1`.
        /// </summary>
        [Output("minRunningInstances")]
        public Output<int> MinRunningInstances { get; private set; } = null!;

        /// <summary>
        /// Name of the application.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// List of ports linked to this application.
        /// </summary>
        [Output("ports")]
        public Output<ImmutableArray<Outputs.ApplicationPort>> Ports { get; private set; } = null!;

        /// <summary>
        /// List of secret aliases linked to this application.
        /// </summary>
        [Output("secretAliases")]
        public Output<ImmutableArray<Outputs.ApplicationSecretAlias>> SecretAliases { get; private set; } = null!;

        /// <summary>
        /// List of secret overrides linked to this application.
        /// </summary>
        [Output("secretOverrides")]
        public Output<ImmutableArray<Outputs.ApplicationSecretOverride>> SecretOverrides { get; private set; } = null!;

        /// <summary>
        /// List of secrets linked to this application.
        /// </summary>
        [Output("secrets")]
        public Output<ImmutableArray<Outputs.ApplicationSecret>> Secrets { get; private set; } = null!;

        /// <summary>
        /// List of storages linked to this application.
        /// </summary>
        [Output("storages")]
        public Output<ImmutableArray<Outputs.ApplicationStorage>> Storages { get; private set; } = null!;


        /// <summary>
        /// Create a Application resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Application(string name, ApplicationArgs args, CustomResourceOptions? options = null)
            : base("qovery:index/application:Application", name, args ?? new ApplicationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Application(string name, Input<string> id, ApplicationState? state = null, CustomResourceOptions? options = null)
            : base("qovery:index/application:Application", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "ithub://api.github.com/dirien/pulumi-qovery",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Application resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Application Get(string name, Input<string> id, ApplicationState? state = null, CustomResourceOptions? options = null)
        {
            return new Application(name, id, state, options);
        }
    }

    public sealed class ApplicationArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Advanced settings.
        /// </summary>
        [Input("advancedSettingsJson")]
        public Input<string>? AdvancedSettingsJson { get; set; }

        [Input("arguments")]
        private InputList<string>? _arguments;

        /// <summary>
        /// List of arguments of this application.
        /// </summary>
        public InputList<string> Arguments
        {
            get => _arguments ?? (_arguments = new InputList<string>());
            set => _arguments = value;
        }

        /// <summary>
        /// Specify if the application will be automatically updated after receiving a new image tag.
        /// </summary>
        [Input("autoDeploy")]
        public Input<bool>? AutoDeploy { get; set; }

        /// <summary>
        /// Specify if the environment preview option is activated or not for this application. - Default: `false`.
        /// </summary>
        [Input("autoPreview")]
        public Input<bool>? AutoPreview { get; set; }

        /// <summary>
        /// Build Mode of the application. - Can be: `BUILDPACKS`, `DOCKER`. - Default: `BUILDPACKS`.
        /// </summary>
        [Input("buildMode")]
        public Input<string>? BuildMode { get; set; }

        /// <summary>
        /// Buildpack Language framework. - Required if: `build_mode="BUILDPACKS"`. - Can be: `CLOJURE`, `GO`, `GRADLE`, `GRAILS`,
        /// `JAVA`, `JVM`, `NODE_JS`, `PHP`, `PLAY`, `PYTHON`, `SCALA`.
        /// </summary>
        [Input("buildpackLanguage")]
        public Input<string>? BuildpackLanguage { get; set; }

        /// <summary>
        /// CPU of the application in millicores (m) [1000m = 1 CPU]. - Must be: `&gt;= 10`. - Default: `500`.
        /// </summary>
        [Input("cpu")]
        public Input<int>? Cpu { get; set; }

        [Input("customDomains")]
        private InputList<Inputs.ApplicationCustomDomainArgs>? _customDomains;

        /// <summary>
        /// List of custom domains linked to this application.
        /// </summary>
        public InputList<Inputs.ApplicationCustomDomainArgs> CustomDomains
        {
            get => _customDomains ?? (_customDomains = new InputList<Inputs.ApplicationCustomDomainArgs>());
            set => _customDomains = value;
        }

        /// <summary>
        /// Id of the deployment stage.
        /// </summary>
        [Input("deploymentStageId")]
        public Input<string>? DeploymentStageId { get; set; }

        /// <summary>
        /// Dockerfile Path of the application. - Required if: `build_mode="DOCKER"`.
        /// </summary>
        [Input("dockerfilePath")]
        public Input<string>? DockerfilePath { get; set; }

        /// <summary>
        /// Entrypoint of the application.
        /// </summary>
        [Input("entrypoint")]
        public Input<string>? Entrypoint { get; set; }

        /// <summary>
        /// Id of the environment.
        /// </summary>
        [Input("environmentId", required: true)]
        public Input<string> EnvironmentId { get; set; } = null!;

        [Input("environmentVariableAliases")]
        private InputList<Inputs.ApplicationEnvironmentVariableAliasArgs>? _environmentVariableAliases;

        /// <summary>
        /// List of environment variable aliases linked to this application.
        /// </summary>
        public InputList<Inputs.ApplicationEnvironmentVariableAliasArgs> EnvironmentVariableAliases
        {
            get => _environmentVariableAliases ?? (_environmentVariableAliases = new InputList<Inputs.ApplicationEnvironmentVariableAliasArgs>());
            set => _environmentVariableAliases = value;
        }

        [Input("environmentVariableOverrides")]
        private InputList<Inputs.ApplicationEnvironmentVariableOverrideArgs>? _environmentVariableOverrides;

        /// <summary>
        /// List of environment variable overrides linked to this application.
        /// </summary>
        public InputList<Inputs.ApplicationEnvironmentVariableOverrideArgs> EnvironmentVariableOverrides
        {
            get => _environmentVariableOverrides ?? (_environmentVariableOverrides = new InputList<Inputs.ApplicationEnvironmentVariableOverrideArgs>());
            set => _environmentVariableOverrides = value;
        }

        [Input("environmentVariables")]
        private InputList<Inputs.ApplicationEnvironmentVariableArgs>? _environmentVariables;

        /// <summary>
        /// List of environment variables linked to this application.
        /// </summary>
        public InputList<Inputs.ApplicationEnvironmentVariableArgs> EnvironmentVariables
        {
            get => _environmentVariables ?? (_environmentVariables = new InputList<Inputs.ApplicationEnvironmentVariableArgs>());
            set => _environmentVariables = value;
        }

        /// <summary>
        /// Git repository of the application.
        /// </summary>
        [Input("gitRepository", required: true)]
        public Input<Inputs.ApplicationGitRepositoryArgs> GitRepository { get; set; } = null!;

        /// <summary>
        /// Configuration for the healthchecks that are going to be executed against your service
        /// </summary>
        [Input("healthchecks", required: true)]
        public Input<Inputs.ApplicationHealthchecksArgs> Healthchecks { get; set; } = null!;

        /// <summary>
        /// Maximum number of instances running for the application. - Must be: `&gt;= -1`. - Default: `1`.
        /// </summary>
        [Input("maxRunningInstances")]
        public Input<int>? MaxRunningInstances { get; set; }

        /// <summary>
        /// RAM of the application in MB [1024MB = 1GB]. - Must be: `&gt;= 1`. - Default: `512`.
        /// </summary>
        [Input("memory")]
        public Input<int>? Memory { get; set; }

        /// <summary>
        /// Minimum number of instances running for the application. - Must be: `&gt;= 0`. - Default: `1`.
        /// </summary>
        [Input("minRunningInstances")]
        public Input<int>? MinRunningInstances { get; set; }

        /// <summary>
        /// Name of the application.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("ports")]
        private InputList<Inputs.ApplicationPortArgs>? _ports;

        /// <summary>
        /// List of ports linked to this application.
        /// </summary>
        public InputList<Inputs.ApplicationPortArgs> Ports
        {
            get => _ports ?? (_ports = new InputList<Inputs.ApplicationPortArgs>());
            set => _ports = value;
        }

        [Input("secretAliases")]
        private InputList<Inputs.ApplicationSecretAliasArgs>? _secretAliases;

        /// <summary>
        /// List of secret aliases linked to this application.
        /// </summary>
        public InputList<Inputs.ApplicationSecretAliasArgs> SecretAliases
        {
            get => _secretAliases ?? (_secretAliases = new InputList<Inputs.ApplicationSecretAliasArgs>());
            set => _secretAliases = value;
        }

        [Input("secretOverrides")]
        private InputList<Inputs.ApplicationSecretOverrideArgs>? _secretOverrides;

        /// <summary>
        /// List of secret overrides linked to this application.
        /// </summary>
        public InputList<Inputs.ApplicationSecretOverrideArgs> SecretOverrides
        {
            get => _secretOverrides ?? (_secretOverrides = new InputList<Inputs.ApplicationSecretOverrideArgs>());
            set => _secretOverrides = value;
        }

        [Input("secrets")]
        private InputList<Inputs.ApplicationSecretArgs>? _secrets;

        /// <summary>
        /// List of secrets linked to this application.
        /// </summary>
        public InputList<Inputs.ApplicationSecretArgs> Secrets
        {
            get => _secrets ?? (_secrets = new InputList<Inputs.ApplicationSecretArgs>());
            set => _secrets = value;
        }

        [Input("storages")]
        private InputList<Inputs.ApplicationStorageArgs>? _storages;

        /// <summary>
        /// List of storages linked to this application.
        /// </summary>
        public InputList<Inputs.ApplicationStorageArgs> Storages
        {
            get => _storages ?? (_storages = new InputList<Inputs.ApplicationStorageArgs>());
            set => _storages = value;
        }

        public ApplicationArgs()
        {
        }
        public static new ApplicationArgs Empty => new ApplicationArgs();
    }

    public sealed class ApplicationState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Advanced settings.
        /// </summary>
        [Input("advancedSettingsJson")]
        public Input<string>? AdvancedSettingsJson { get; set; }

        [Input("arguments")]
        private InputList<string>? _arguments;

        /// <summary>
        /// List of arguments of this application.
        /// </summary>
        public InputList<string> Arguments
        {
            get => _arguments ?? (_arguments = new InputList<string>());
            set => _arguments = value;
        }

        /// <summary>
        /// Specify if the application will be automatically updated after receiving a new image tag.
        /// </summary>
        [Input("autoDeploy")]
        public Input<bool>? AutoDeploy { get; set; }

        /// <summary>
        /// Specify if the environment preview option is activated or not for this application. - Default: `false`.
        /// </summary>
        [Input("autoPreview")]
        public Input<bool>? AutoPreview { get; set; }

        /// <summary>
        /// Build Mode of the application. - Can be: `BUILDPACKS`, `DOCKER`. - Default: `BUILDPACKS`.
        /// </summary>
        [Input("buildMode")]
        public Input<string>? BuildMode { get; set; }

        /// <summary>
        /// Buildpack Language framework. - Required if: `build_mode="BUILDPACKS"`. - Can be: `CLOJURE`, `GO`, `GRADLE`, `GRAILS`,
        /// `JAVA`, `JVM`, `NODE_JS`, `PHP`, `PLAY`, `PYTHON`, `SCALA`.
        /// </summary>
        [Input("buildpackLanguage")]
        public Input<string>? BuildpackLanguage { get; set; }

        [Input("builtInEnvironmentVariables")]
        private InputList<Inputs.ApplicationBuiltInEnvironmentVariableGetArgs>? _builtInEnvironmentVariables;

        /// <summary>
        /// List of built-in environment variables linked to this application.
        /// </summary>
        public InputList<Inputs.ApplicationBuiltInEnvironmentVariableGetArgs> BuiltInEnvironmentVariables
        {
            get => _builtInEnvironmentVariables ?? (_builtInEnvironmentVariables = new InputList<Inputs.ApplicationBuiltInEnvironmentVariableGetArgs>());
            set => _builtInEnvironmentVariables = value;
        }

        /// <summary>
        /// CPU of the application in millicores (m) [1000m = 1 CPU]. - Must be: `&gt;= 10`. - Default: `500`.
        /// </summary>
        [Input("cpu")]
        public Input<int>? Cpu { get; set; }

        [Input("customDomains")]
        private InputList<Inputs.ApplicationCustomDomainGetArgs>? _customDomains;

        /// <summary>
        /// List of custom domains linked to this application.
        /// </summary>
        public InputList<Inputs.ApplicationCustomDomainGetArgs> CustomDomains
        {
            get => _customDomains ?? (_customDomains = new InputList<Inputs.ApplicationCustomDomainGetArgs>());
            set => _customDomains = value;
        }

        /// <summary>
        /// Id of the deployment stage.
        /// </summary>
        [Input("deploymentStageId")]
        public Input<string>? DeploymentStageId { get; set; }

        /// <summary>
        /// Dockerfile Path of the application. - Required if: `build_mode="DOCKER"`.
        /// </summary>
        [Input("dockerfilePath")]
        public Input<string>? DockerfilePath { get; set; }

        /// <summary>
        /// Entrypoint of the application.
        /// </summary>
        [Input("entrypoint")]
        public Input<string>? Entrypoint { get; set; }

        /// <summary>
        /// Id of the environment.
        /// </summary>
        [Input("environmentId")]
        public Input<string>? EnvironmentId { get; set; }

        [Input("environmentVariableAliases")]
        private InputList<Inputs.ApplicationEnvironmentVariableAliasGetArgs>? _environmentVariableAliases;

        /// <summary>
        /// List of environment variable aliases linked to this application.
        /// </summary>
        public InputList<Inputs.ApplicationEnvironmentVariableAliasGetArgs> EnvironmentVariableAliases
        {
            get => _environmentVariableAliases ?? (_environmentVariableAliases = new InputList<Inputs.ApplicationEnvironmentVariableAliasGetArgs>());
            set => _environmentVariableAliases = value;
        }

        [Input("environmentVariableOverrides")]
        private InputList<Inputs.ApplicationEnvironmentVariableOverrideGetArgs>? _environmentVariableOverrides;

        /// <summary>
        /// List of environment variable overrides linked to this application.
        /// </summary>
        public InputList<Inputs.ApplicationEnvironmentVariableOverrideGetArgs> EnvironmentVariableOverrides
        {
            get => _environmentVariableOverrides ?? (_environmentVariableOverrides = new InputList<Inputs.ApplicationEnvironmentVariableOverrideGetArgs>());
            set => _environmentVariableOverrides = value;
        }

        [Input("environmentVariables")]
        private InputList<Inputs.ApplicationEnvironmentVariableGetArgs>? _environmentVariables;

        /// <summary>
        /// List of environment variables linked to this application.
        /// </summary>
        public InputList<Inputs.ApplicationEnvironmentVariableGetArgs> EnvironmentVariables
        {
            get => _environmentVariables ?? (_environmentVariables = new InputList<Inputs.ApplicationEnvironmentVariableGetArgs>());
            set => _environmentVariables = value;
        }

        /// <summary>
        /// The application external FQDN host [NOTE: only if your application is using a publicly accessible port].
        /// </summary>
        [Input("externalHost")]
        public Input<string>? ExternalHost { get; set; }

        /// <summary>
        /// Git repository of the application.
        /// </summary>
        [Input("gitRepository")]
        public Input<Inputs.ApplicationGitRepositoryGetArgs>? GitRepository { get; set; }

        /// <summary>
        /// Configuration for the healthchecks that are going to be executed against your service
        /// </summary>
        [Input("healthchecks")]
        public Input<Inputs.ApplicationHealthchecksGetArgs>? Healthchecks { get; set; }

        /// <summary>
        /// The application internal host.
        /// </summary>
        [Input("internalHost")]
        public Input<string>? InternalHost { get; set; }

        /// <summary>
        /// Maximum number of instances running for the application. - Must be: `&gt;= -1`. - Default: `1`.
        /// </summary>
        [Input("maxRunningInstances")]
        public Input<int>? MaxRunningInstances { get; set; }

        /// <summary>
        /// RAM of the application in MB [1024MB = 1GB]. - Must be: `&gt;= 1`. - Default: `512`.
        /// </summary>
        [Input("memory")]
        public Input<int>? Memory { get; set; }

        /// <summary>
        /// Minimum number of instances running for the application. - Must be: `&gt;= 0`. - Default: `1`.
        /// </summary>
        [Input("minRunningInstances")]
        public Input<int>? MinRunningInstances { get; set; }

        /// <summary>
        /// Name of the application.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("ports")]
        private InputList<Inputs.ApplicationPortGetArgs>? _ports;

        /// <summary>
        /// List of ports linked to this application.
        /// </summary>
        public InputList<Inputs.ApplicationPortGetArgs> Ports
        {
            get => _ports ?? (_ports = new InputList<Inputs.ApplicationPortGetArgs>());
            set => _ports = value;
        }

        [Input("secretAliases")]
        private InputList<Inputs.ApplicationSecretAliasGetArgs>? _secretAliases;

        /// <summary>
        /// List of secret aliases linked to this application.
        /// </summary>
        public InputList<Inputs.ApplicationSecretAliasGetArgs> SecretAliases
        {
            get => _secretAliases ?? (_secretAliases = new InputList<Inputs.ApplicationSecretAliasGetArgs>());
            set => _secretAliases = value;
        }

        [Input("secretOverrides")]
        private InputList<Inputs.ApplicationSecretOverrideGetArgs>? _secretOverrides;

        /// <summary>
        /// List of secret overrides linked to this application.
        /// </summary>
        public InputList<Inputs.ApplicationSecretOverrideGetArgs> SecretOverrides
        {
            get => _secretOverrides ?? (_secretOverrides = new InputList<Inputs.ApplicationSecretOverrideGetArgs>());
            set => _secretOverrides = value;
        }

        [Input("secrets")]
        private InputList<Inputs.ApplicationSecretGetArgs>? _secrets;

        /// <summary>
        /// List of secrets linked to this application.
        /// </summary>
        public InputList<Inputs.ApplicationSecretGetArgs> Secrets
        {
            get => _secrets ?? (_secrets = new InputList<Inputs.ApplicationSecretGetArgs>());
            set => _secrets = value;
        }

        [Input("storages")]
        private InputList<Inputs.ApplicationStorageGetArgs>? _storages;

        /// <summary>
        /// List of storages linked to this application.
        /// </summary>
        public InputList<Inputs.ApplicationStorageGetArgs> Storages
        {
            get => _storages ?? (_storages = new InputList<Inputs.ApplicationStorageGetArgs>());
            set => _storages = value;
        }

        public ApplicationState()
        {
        }
        public static new ApplicationState Empty => new ApplicationState();
    }
}