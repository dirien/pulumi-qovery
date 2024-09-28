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
    public static class GetApplication
    {
        /// <summary>
        /// ## # qovery.Application (Data Source)
        /// 
        /// Provides a Qovery application resource. This can be used to create and manage Qovery applications.
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
        ///     var myApplication = Qovery.GetApplication.Invoke(new()
        ///     {
        ///         Id = "&lt;application_id&gt;",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetApplicationResult> InvokeAsync(GetApplicationArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetApplicationResult>("qovery:index/getApplication:getApplication", args ?? new GetApplicationArgs(), options.WithDefaults());

        /// <summary>
        /// ## # qovery.Application (Data Source)
        /// 
        /// Provides a Qovery application resource. This can be used to create and manage Qovery applications.
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
        ///     var myApplication = Qovery.GetApplication.Invoke(new()
        ///     {
        ///         Id = "&lt;application_id&gt;",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetApplicationResult> Invoke(GetApplicationInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetApplicationResult>("qovery:index/getApplication:getApplication", args ?? new GetApplicationInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetApplicationArgs : global::Pulumi.InvokeArgs
    {
        [Input("advancedSettingsJson")]
        public string? AdvancedSettingsJson { get; set; }

        [Input("annotationsGroupIds")]
        private List<string>? _annotationsGroupIds;
        public List<string> AnnotationsGroupIds
        {
            get => _annotationsGroupIds ?? (_annotationsGroupIds = new List<string>());
            set => _annotationsGroupIds = value;
        }

        [Input("arguments")]
        private List<string>? _arguments;
        public List<string> Arguments
        {
            get => _arguments ?? (_arguments = new List<string>());
            set => _arguments = value;
        }

        [Input("autoDeploy")]
        public bool? AutoDeploy { get; set; }

        [Input("autoPreview")]
        public bool? AutoPreview { get; set; }

        [Input("buildpackLanguage")]
        public string? BuildpackLanguage { get; set; }

        [Input("cpu")]
        public int? Cpu { get; set; }

        [Input("customDomains")]
        private List<Inputs.GetApplicationCustomDomainArgs>? _customDomains;
        public List<Inputs.GetApplicationCustomDomainArgs> CustomDomains
        {
            get => _customDomains ?? (_customDomains = new List<Inputs.GetApplicationCustomDomainArgs>());
            set => _customDomains = value;
        }

        [Input("deploymentRestrictions")]
        private List<Inputs.GetApplicationDeploymentRestrictionArgs>? _deploymentRestrictions;
        public List<Inputs.GetApplicationDeploymentRestrictionArgs> DeploymentRestrictions
        {
            get => _deploymentRestrictions ?? (_deploymentRestrictions = new List<Inputs.GetApplicationDeploymentRestrictionArgs>());
            set => _deploymentRestrictions = value;
        }

        [Input("deploymentStageId")]
        public string? DeploymentStageId { get; set; }

        [Input("dockerfilePath")]
        public string? DockerfilePath { get; set; }

        [Input("entrypoint")]
        public string? Entrypoint { get; set; }

        [Input("environmentVariableAliases")]
        private List<Inputs.GetApplicationEnvironmentVariableAliasArgs>? _environmentVariableAliases;
        public List<Inputs.GetApplicationEnvironmentVariableAliasArgs> EnvironmentVariableAliases
        {
            get => _environmentVariableAliases ?? (_environmentVariableAliases = new List<Inputs.GetApplicationEnvironmentVariableAliasArgs>());
            set => _environmentVariableAliases = value;
        }

        [Input("environmentVariableOverrides")]
        private List<Inputs.GetApplicationEnvironmentVariableOverrideArgs>? _environmentVariableOverrides;
        public List<Inputs.GetApplicationEnvironmentVariableOverrideArgs> EnvironmentVariableOverrides
        {
            get => _environmentVariableOverrides ?? (_environmentVariableOverrides = new List<Inputs.GetApplicationEnvironmentVariableOverrideArgs>());
            set => _environmentVariableOverrides = value;
        }

        [Input("environmentVariables")]
        private List<Inputs.GetApplicationEnvironmentVariableArgs>? _environmentVariables;
        public List<Inputs.GetApplicationEnvironmentVariableArgs> EnvironmentVariables
        {
            get => _environmentVariables ?? (_environmentVariables = new List<Inputs.GetApplicationEnvironmentVariableArgs>());
            set => _environmentVariables = value;
        }

        [Input("healthchecks")]
        public Inputs.GetApplicationHealthchecksArgs? Healthchecks { get; set; }

        [Input("iconUri")]
        public string? IconUri { get; set; }

        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        [Input("labelsGroupIds")]
        private List<string>? _labelsGroupIds;
        public List<string> LabelsGroupIds
        {
            get => _labelsGroupIds ?? (_labelsGroupIds = new List<string>());
            set => _labelsGroupIds = value;
        }

        [Input("maxRunningInstances")]
        public int? MaxRunningInstances { get; set; }

        [Input("memory")]
        public int? Memory { get; set; }

        [Input("minRunningInstances")]
        public int? MinRunningInstances { get; set; }

        [Input("secretAliases")]
        private List<Inputs.GetApplicationSecretAliasArgs>? _secretAliases;
        public List<Inputs.GetApplicationSecretAliasArgs> SecretAliases
        {
            get => _secretAliases ?? (_secretAliases = new List<Inputs.GetApplicationSecretAliasArgs>());
            set => _secretAliases = value;
        }

        [Input("secretOverrides")]
        private List<Inputs.GetApplicationSecretOverrideArgs>? _secretOverrides;
        public List<Inputs.GetApplicationSecretOverrideArgs> SecretOverrides
        {
            get => _secretOverrides ?? (_secretOverrides = new List<Inputs.GetApplicationSecretOverrideArgs>());
            set => _secretOverrides = value;
        }

        [Input("secrets")]
        private List<Inputs.GetApplicationSecretArgs>? _secrets;
        public List<Inputs.GetApplicationSecretArgs> Secrets
        {
            get => _secrets ?? (_secrets = new List<Inputs.GetApplicationSecretArgs>());
            set => _secrets = value;
        }

        [Input("storages")]
        private List<Inputs.GetApplicationStorageArgs>? _storages;
        public List<Inputs.GetApplicationStorageArgs> Storages
        {
            get => _storages ?? (_storages = new List<Inputs.GetApplicationStorageArgs>());
            set => _storages = value;
        }

        public GetApplicationArgs()
        {
        }
        public static new GetApplicationArgs Empty => new GetApplicationArgs();
    }

    public sealed class GetApplicationInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("advancedSettingsJson")]
        public Input<string>? AdvancedSettingsJson { get; set; }

        [Input("annotationsGroupIds")]
        private InputList<string>? _annotationsGroupIds;
        public InputList<string> AnnotationsGroupIds
        {
            get => _annotationsGroupIds ?? (_annotationsGroupIds = new InputList<string>());
            set => _annotationsGroupIds = value;
        }

        [Input("arguments")]
        private InputList<string>? _arguments;
        public InputList<string> Arguments
        {
            get => _arguments ?? (_arguments = new InputList<string>());
            set => _arguments = value;
        }

        [Input("autoDeploy")]
        public Input<bool>? AutoDeploy { get; set; }

        [Input("autoPreview")]
        public Input<bool>? AutoPreview { get; set; }

        [Input("buildpackLanguage")]
        public Input<string>? BuildpackLanguage { get; set; }

        [Input("cpu")]
        public Input<int>? Cpu { get; set; }

        [Input("customDomains")]
        private InputList<Inputs.GetApplicationCustomDomainInputArgs>? _customDomains;
        public InputList<Inputs.GetApplicationCustomDomainInputArgs> CustomDomains
        {
            get => _customDomains ?? (_customDomains = new InputList<Inputs.GetApplicationCustomDomainInputArgs>());
            set => _customDomains = value;
        }

        [Input("deploymentRestrictions")]
        private InputList<Inputs.GetApplicationDeploymentRestrictionInputArgs>? _deploymentRestrictions;
        public InputList<Inputs.GetApplicationDeploymentRestrictionInputArgs> DeploymentRestrictions
        {
            get => _deploymentRestrictions ?? (_deploymentRestrictions = new InputList<Inputs.GetApplicationDeploymentRestrictionInputArgs>());
            set => _deploymentRestrictions = value;
        }

        [Input("deploymentStageId")]
        public Input<string>? DeploymentStageId { get; set; }

        [Input("dockerfilePath")]
        public Input<string>? DockerfilePath { get; set; }

        [Input("entrypoint")]
        public Input<string>? Entrypoint { get; set; }

        [Input("environmentVariableAliases")]
        private InputList<Inputs.GetApplicationEnvironmentVariableAliasInputArgs>? _environmentVariableAliases;
        public InputList<Inputs.GetApplicationEnvironmentVariableAliasInputArgs> EnvironmentVariableAliases
        {
            get => _environmentVariableAliases ?? (_environmentVariableAliases = new InputList<Inputs.GetApplicationEnvironmentVariableAliasInputArgs>());
            set => _environmentVariableAliases = value;
        }

        [Input("environmentVariableOverrides")]
        private InputList<Inputs.GetApplicationEnvironmentVariableOverrideInputArgs>? _environmentVariableOverrides;
        public InputList<Inputs.GetApplicationEnvironmentVariableOverrideInputArgs> EnvironmentVariableOverrides
        {
            get => _environmentVariableOverrides ?? (_environmentVariableOverrides = new InputList<Inputs.GetApplicationEnvironmentVariableOverrideInputArgs>());
            set => _environmentVariableOverrides = value;
        }

        [Input("environmentVariables")]
        private InputList<Inputs.GetApplicationEnvironmentVariableInputArgs>? _environmentVariables;
        public InputList<Inputs.GetApplicationEnvironmentVariableInputArgs> EnvironmentVariables
        {
            get => _environmentVariables ?? (_environmentVariables = new InputList<Inputs.GetApplicationEnvironmentVariableInputArgs>());
            set => _environmentVariables = value;
        }

        [Input("healthchecks")]
        public Input<Inputs.GetApplicationHealthchecksInputArgs>? Healthchecks { get; set; }

        [Input("iconUri")]
        public Input<string>? IconUri { get; set; }

        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        [Input("labelsGroupIds")]
        private InputList<string>? _labelsGroupIds;
        public InputList<string> LabelsGroupIds
        {
            get => _labelsGroupIds ?? (_labelsGroupIds = new InputList<string>());
            set => _labelsGroupIds = value;
        }

        [Input("maxRunningInstances")]
        public Input<int>? MaxRunningInstances { get; set; }

        [Input("memory")]
        public Input<int>? Memory { get; set; }

        [Input("minRunningInstances")]
        public Input<int>? MinRunningInstances { get; set; }

        [Input("secretAliases")]
        private InputList<Inputs.GetApplicationSecretAliasInputArgs>? _secretAliases;
        public InputList<Inputs.GetApplicationSecretAliasInputArgs> SecretAliases
        {
            get => _secretAliases ?? (_secretAliases = new InputList<Inputs.GetApplicationSecretAliasInputArgs>());
            set => _secretAliases = value;
        }

        [Input("secretOverrides")]
        private InputList<Inputs.GetApplicationSecretOverrideInputArgs>? _secretOverrides;
        public InputList<Inputs.GetApplicationSecretOverrideInputArgs> SecretOverrides
        {
            get => _secretOverrides ?? (_secretOverrides = new InputList<Inputs.GetApplicationSecretOverrideInputArgs>());
            set => _secretOverrides = value;
        }

        [Input("secrets")]
        private InputList<Inputs.GetApplicationSecretInputArgs>? _secrets;
        public InputList<Inputs.GetApplicationSecretInputArgs> Secrets
        {
            get => _secrets ?? (_secrets = new InputList<Inputs.GetApplicationSecretInputArgs>());
            set => _secrets = value;
        }

        [Input("storages")]
        private InputList<Inputs.GetApplicationStorageInputArgs>? _storages;
        public InputList<Inputs.GetApplicationStorageInputArgs> Storages
        {
            get => _storages ?? (_storages = new InputList<Inputs.GetApplicationStorageInputArgs>());
            set => _storages = value;
        }

        public GetApplicationInvokeArgs()
        {
        }
        public static new GetApplicationInvokeArgs Empty => new GetApplicationInvokeArgs();
    }


    [OutputType]
    public sealed class GetApplicationResult
    {
        public readonly string AdvancedSettingsJson;
        public readonly ImmutableArray<string> AnnotationsGroupIds;
        public readonly ImmutableArray<string> Arguments;
        public readonly bool AutoDeploy;
        public readonly bool AutoPreview;
        public readonly string BuildMode;
        public readonly string BuildpackLanguage;
        public readonly ImmutableArray<Outputs.GetApplicationBuiltInEnvironmentVariableResult> BuiltInEnvironmentVariables;
        public readonly int Cpu;
        public readonly ImmutableArray<Outputs.GetApplicationCustomDomainResult> CustomDomains;
        public readonly ImmutableArray<Outputs.GetApplicationDeploymentRestrictionResult> DeploymentRestrictions;
        public readonly string DeploymentStageId;
        public readonly string DockerfilePath;
        public readonly string Entrypoint;
        public readonly string EnvironmentId;
        public readonly ImmutableArray<Outputs.GetApplicationEnvironmentVariableAliasResult> EnvironmentVariableAliases;
        public readonly ImmutableArray<Outputs.GetApplicationEnvironmentVariableOverrideResult> EnvironmentVariableOverrides;
        public readonly ImmutableArray<Outputs.GetApplicationEnvironmentVariableResult> EnvironmentVariables;
        public readonly string ExternalHost;
        public readonly Outputs.GetApplicationGitRepositoryResult GitRepository;
        public readonly Outputs.GetApplicationHealthchecksResult? Healthchecks;
        public readonly string IconUri;
        public readonly string Id;
        public readonly string InternalHost;
        public readonly ImmutableArray<string> LabelsGroupIds;
        public readonly int MaxRunningInstances;
        public readonly int Memory;
        public readonly int MinRunningInstances;
        public readonly string Name;
        public readonly ImmutableArray<Outputs.GetApplicationPortResult> Ports;
        public readonly ImmutableArray<Outputs.GetApplicationSecretAliasResult> SecretAliases;
        public readonly ImmutableArray<Outputs.GetApplicationSecretOverrideResult> SecretOverrides;
        public readonly ImmutableArray<Outputs.GetApplicationSecretResult> Secrets;
        public readonly ImmutableArray<Outputs.GetApplicationStorageResult> Storages;

        [OutputConstructor]
        private GetApplicationResult(
            string advancedSettingsJson,

            ImmutableArray<string> annotationsGroupIds,

            ImmutableArray<string> arguments,

            bool autoDeploy,

            bool autoPreview,

            string buildMode,

            string buildpackLanguage,

            ImmutableArray<Outputs.GetApplicationBuiltInEnvironmentVariableResult> builtInEnvironmentVariables,

            int cpu,

            ImmutableArray<Outputs.GetApplicationCustomDomainResult> customDomains,

            ImmutableArray<Outputs.GetApplicationDeploymentRestrictionResult> deploymentRestrictions,

            string deploymentStageId,

            string dockerfilePath,

            string entrypoint,

            string environmentId,

            ImmutableArray<Outputs.GetApplicationEnvironmentVariableAliasResult> environmentVariableAliases,

            ImmutableArray<Outputs.GetApplicationEnvironmentVariableOverrideResult> environmentVariableOverrides,

            ImmutableArray<Outputs.GetApplicationEnvironmentVariableResult> environmentVariables,

            string externalHost,

            Outputs.GetApplicationGitRepositoryResult gitRepository,

            Outputs.GetApplicationHealthchecksResult? healthchecks,

            string iconUri,

            string id,

            string internalHost,

            ImmutableArray<string> labelsGroupIds,

            int maxRunningInstances,

            int memory,

            int minRunningInstances,

            string name,

            ImmutableArray<Outputs.GetApplicationPortResult> ports,

            ImmutableArray<Outputs.GetApplicationSecretAliasResult> secretAliases,

            ImmutableArray<Outputs.GetApplicationSecretOverrideResult> secretOverrides,

            ImmutableArray<Outputs.GetApplicationSecretResult> secrets,

            ImmutableArray<Outputs.GetApplicationStorageResult> storages)
        {
            AdvancedSettingsJson = advancedSettingsJson;
            AnnotationsGroupIds = annotationsGroupIds;
            Arguments = arguments;
            AutoDeploy = autoDeploy;
            AutoPreview = autoPreview;
            BuildMode = buildMode;
            BuildpackLanguage = buildpackLanguage;
            BuiltInEnvironmentVariables = builtInEnvironmentVariables;
            Cpu = cpu;
            CustomDomains = customDomains;
            DeploymentRestrictions = deploymentRestrictions;
            DeploymentStageId = deploymentStageId;
            DockerfilePath = dockerfilePath;
            Entrypoint = entrypoint;
            EnvironmentId = environmentId;
            EnvironmentVariableAliases = environmentVariableAliases;
            EnvironmentVariableOverrides = environmentVariableOverrides;
            EnvironmentVariables = environmentVariables;
            ExternalHost = externalHost;
            GitRepository = gitRepository;
            Healthchecks = healthchecks;
            IconUri = iconUri;
            Id = id;
            InternalHost = internalHost;
            LabelsGroupIds = labelsGroupIds;
            MaxRunningInstances = maxRunningInstances;
            Memory = memory;
            MinRunningInstances = minRunningInstances;
            Name = name;
            Ports = ports;
            SecretAliases = secretAliases;
            SecretOverrides = secretOverrides;
            Secrets = secrets;
            Storages = storages;
        }
    }
}
