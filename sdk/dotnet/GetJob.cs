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
    public static class GetJob
    {
        /// <summary>
        /// ## # qovery.Job (Data Source)
        /// 
        /// Provides a Qovery job resource. This can be used to create and manage Qovery job registry.
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Qovery = Pulumi.Qovery;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var myJob = Qovery.GetJob.Invoke(new()
        ///     {
        ///         Id = "&lt;job_id&gt;",
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetJobResult> InvokeAsync(GetJobArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetJobResult>("qovery:index/getJob:getJob", args ?? new GetJobArgs(), options.WithDefaults());

        /// <summary>
        /// ## # qovery.Job (Data Source)
        /// 
        /// Provides a Qovery job resource. This can be used to create and manage Qovery job registry.
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Qovery = Pulumi.Qovery;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var myJob = Qovery.GetJob.Invoke(new()
        ///     {
        ///         Id = "&lt;job_id&gt;",
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetJobResult> Invoke(GetJobInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetJobResult>("qovery:index/getJob:getJob", args ?? new GetJobInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetJobArgs : global::Pulumi.InvokeArgs
    {
        [Input("advancedSettingsJson")]
        public string? AdvancedSettingsJson { get; set; }

        [Input("autoDeploy")]
        public bool? AutoDeploy { get; set; }

        [Input("autoPreview")]
        public bool? AutoPreview { get; set; }

        [Input("cpu")]
        public int? Cpu { get; set; }

        [Input("deploymentStageId")]
        public string? DeploymentStageId { get; set; }

        [Input("environmentVariableAliases")]
        private List<Inputs.GetJobEnvironmentVariableAliasArgs>? _environmentVariableAliases;
        public List<Inputs.GetJobEnvironmentVariableAliasArgs> EnvironmentVariableAliases
        {
            get => _environmentVariableAliases ?? (_environmentVariableAliases = new List<Inputs.GetJobEnvironmentVariableAliasArgs>());
            set => _environmentVariableAliases = value;
        }

        [Input("environmentVariableOverrides")]
        private List<Inputs.GetJobEnvironmentVariableOverrideArgs>? _environmentVariableOverrides;
        public List<Inputs.GetJobEnvironmentVariableOverrideArgs> EnvironmentVariableOverrides
        {
            get => _environmentVariableOverrides ?? (_environmentVariableOverrides = new List<Inputs.GetJobEnvironmentVariableOverrideArgs>());
            set => _environmentVariableOverrides = value;
        }

        [Input("environmentVariables")]
        private List<Inputs.GetJobEnvironmentVariableArgs>? _environmentVariables;
        public List<Inputs.GetJobEnvironmentVariableArgs> EnvironmentVariables
        {
            get => _environmentVariables ?? (_environmentVariables = new List<Inputs.GetJobEnvironmentVariableArgs>());
            set => _environmentVariables = value;
        }

        [Input("healthchecks")]
        public Inputs.GetJobHealthchecksArgs? Healthchecks { get; set; }

        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        [Input("maxDurationSeconds")]
        public int? MaxDurationSeconds { get; set; }

        [Input("maxNbRestart")]
        public int? MaxNbRestart { get; set; }

        [Input("memory")]
        public int? Memory { get; set; }

        [Input("port")]
        public int? Port { get; set; }

        [Input("secretAliases")]
        private List<Inputs.GetJobSecretAliasArgs>? _secretAliases;
        public List<Inputs.GetJobSecretAliasArgs> SecretAliases
        {
            get => _secretAliases ?? (_secretAliases = new List<Inputs.GetJobSecretAliasArgs>());
            set => _secretAliases = value;
        }

        [Input("secretOverrides")]
        private List<Inputs.GetJobSecretOverrideArgs>? _secretOverrides;
        public List<Inputs.GetJobSecretOverrideArgs> SecretOverrides
        {
            get => _secretOverrides ?? (_secretOverrides = new List<Inputs.GetJobSecretOverrideArgs>());
            set => _secretOverrides = value;
        }

        [Input("secrets")]
        private List<Inputs.GetJobSecretArgs>? _secrets;
        public List<Inputs.GetJobSecretArgs> Secrets
        {
            get => _secrets ?? (_secrets = new List<Inputs.GetJobSecretArgs>());
            set => _secrets = value;
        }

        [Input("source")]
        public Inputs.GetJobSourceArgs? Source { get; set; }

        public GetJobArgs()
        {
        }
        public static new GetJobArgs Empty => new GetJobArgs();
    }

    public sealed class GetJobInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("advancedSettingsJson")]
        public Input<string>? AdvancedSettingsJson { get; set; }

        [Input("autoDeploy")]
        public Input<bool>? AutoDeploy { get; set; }

        [Input("autoPreview")]
        public Input<bool>? AutoPreview { get; set; }

        [Input("cpu")]
        public Input<int>? Cpu { get; set; }

        [Input("deploymentStageId")]
        public Input<string>? DeploymentStageId { get; set; }

        [Input("environmentVariableAliases")]
        private InputList<Inputs.GetJobEnvironmentVariableAliasInputArgs>? _environmentVariableAliases;
        public InputList<Inputs.GetJobEnvironmentVariableAliasInputArgs> EnvironmentVariableAliases
        {
            get => _environmentVariableAliases ?? (_environmentVariableAliases = new InputList<Inputs.GetJobEnvironmentVariableAliasInputArgs>());
            set => _environmentVariableAliases = value;
        }

        [Input("environmentVariableOverrides")]
        private InputList<Inputs.GetJobEnvironmentVariableOverrideInputArgs>? _environmentVariableOverrides;
        public InputList<Inputs.GetJobEnvironmentVariableOverrideInputArgs> EnvironmentVariableOverrides
        {
            get => _environmentVariableOverrides ?? (_environmentVariableOverrides = new InputList<Inputs.GetJobEnvironmentVariableOverrideInputArgs>());
            set => _environmentVariableOverrides = value;
        }

        [Input("environmentVariables")]
        private InputList<Inputs.GetJobEnvironmentVariableInputArgs>? _environmentVariables;
        public InputList<Inputs.GetJobEnvironmentVariableInputArgs> EnvironmentVariables
        {
            get => _environmentVariables ?? (_environmentVariables = new InputList<Inputs.GetJobEnvironmentVariableInputArgs>());
            set => _environmentVariables = value;
        }

        [Input("healthchecks")]
        public Input<Inputs.GetJobHealthchecksInputArgs>? Healthchecks { get; set; }

        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        [Input("maxDurationSeconds")]
        public Input<int>? MaxDurationSeconds { get; set; }

        [Input("maxNbRestart")]
        public Input<int>? MaxNbRestart { get; set; }

        [Input("memory")]
        public Input<int>? Memory { get; set; }

        [Input("port")]
        public Input<int>? Port { get; set; }

        [Input("secretAliases")]
        private InputList<Inputs.GetJobSecretAliasInputArgs>? _secretAliases;
        public InputList<Inputs.GetJobSecretAliasInputArgs> SecretAliases
        {
            get => _secretAliases ?? (_secretAliases = new InputList<Inputs.GetJobSecretAliasInputArgs>());
            set => _secretAliases = value;
        }

        [Input("secretOverrides")]
        private InputList<Inputs.GetJobSecretOverrideInputArgs>? _secretOverrides;
        public InputList<Inputs.GetJobSecretOverrideInputArgs> SecretOverrides
        {
            get => _secretOverrides ?? (_secretOverrides = new InputList<Inputs.GetJobSecretOverrideInputArgs>());
            set => _secretOverrides = value;
        }

        [Input("secrets")]
        private InputList<Inputs.GetJobSecretInputArgs>? _secrets;
        public InputList<Inputs.GetJobSecretInputArgs> Secrets
        {
            get => _secrets ?? (_secrets = new InputList<Inputs.GetJobSecretInputArgs>());
            set => _secrets = value;
        }

        [Input("source")]
        public Input<Inputs.GetJobSourceInputArgs>? Source { get; set; }

        public GetJobInvokeArgs()
        {
        }
        public static new GetJobInvokeArgs Empty => new GetJobInvokeArgs();
    }


    [OutputType]
    public sealed class GetJobResult
    {
        public readonly string AdvancedSettingsJson;
        public readonly bool AutoDeploy;
        public readonly bool AutoPreview;
        public readonly ImmutableArray<Outputs.GetJobBuiltInEnvironmentVariableResult> BuiltInEnvironmentVariables;
        public readonly int? Cpu;
        public readonly string DeploymentStageId;
        public readonly string EnvironmentId;
        public readonly ImmutableArray<Outputs.GetJobEnvironmentVariableAliasResult> EnvironmentVariableAliases;
        public readonly ImmutableArray<Outputs.GetJobEnvironmentVariableOverrideResult> EnvironmentVariableOverrides;
        public readonly ImmutableArray<Outputs.GetJobEnvironmentVariableResult> EnvironmentVariables;
        public readonly string ExternalHost;
        public readonly Outputs.GetJobHealthchecksResult? Healthchecks;
        public readonly string Id;
        public readonly string InternalHost;
        public readonly int MaxDurationSeconds;
        public readonly int MaxNbRestart;
        public readonly int? Memory;
        public readonly string Name;
        public readonly int Port;
        public readonly Outputs.GetJobScheduleResult Schedule;
        public readonly ImmutableArray<Outputs.GetJobSecretAliasResult> SecretAliases;
        public readonly ImmutableArray<Outputs.GetJobSecretOverrideResult> SecretOverrides;
        public readonly ImmutableArray<Outputs.GetJobSecretResult> Secrets;
        public readonly Outputs.GetJobSourceResult Source;

        [OutputConstructor]
        private GetJobResult(
            string advancedSettingsJson,

            bool autoDeploy,

            bool autoPreview,

            ImmutableArray<Outputs.GetJobBuiltInEnvironmentVariableResult> builtInEnvironmentVariables,

            int? cpu,

            string deploymentStageId,

            string environmentId,

            ImmutableArray<Outputs.GetJobEnvironmentVariableAliasResult> environmentVariableAliases,

            ImmutableArray<Outputs.GetJobEnvironmentVariableOverrideResult> environmentVariableOverrides,

            ImmutableArray<Outputs.GetJobEnvironmentVariableResult> environmentVariables,

            string externalHost,

            Outputs.GetJobHealthchecksResult? healthchecks,

            string id,

            string internalHost,

            int maxDurationSeconds,

            int maxNbRestart,

            int? memory,

            string name,

            int port,

            Outputs.GetJobScheduleResult schedule,

            ImmutableArray<Outputs.GetJobSecretAliasResult> secretAliases,

            ImmutableArray<Outputs.GetJobSecretOverrideResult> secretOverrides,

            ImmutableArray<Outputs.GetJobSecretResult> secrets,

            Outputs.GetJobSourceResult source)
        {
            AdvancedSettingsJson = advancedSettingsJson;
            AutoDeploy = autoDeploy;
            AutoPreview = autoPreview;
            BuiltInEnvironmentVariables = builtInEnvironmentVariables;
            Cpu = cpu;
            DeploymentStageId = deploymentStageId;
            EnvironmentId = environmentId;
            EnvironmentVariableAliases = environmentVariableAliases;
            EnvironmentVariableOverrides = environmentVariableOverrides;
            EnvironmentVariables = environmentVariables;
            ExternalHost = externalHost;
            Healthchecks = healthchecks;
            Id = id;
            InternalHost = internalHost;
            MaxDurationSeconds = maxDurationSeconds;
            MaxNbRestart = maxNbRestart;
            Memory = memory;
            Name = name;
            Port = port;
            Schedule = schedule;
            SecretAliases = secretAliases;
            SecretOverrides = secretOverrides;
            Secrets = secrets;
            Source = source;
        }
    }
}
