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
    public static class GetEnvironment
    {
        /// <summary>
        /// ## # qovery.Environment (Data Source)
        /// 
        /// Provides a Qovery environment resource. This can be used to create and manage Qovery environments.
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
        ///     var myEnvironment = Qovery.GetEnvironment.Invoke(new()
        ///     {
        ///         Id = "&lt;environment_id&gt;",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetEnvironmentResult> InvokeAsync(GetEnvironmentArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetEnvironmentResult>("qovery:index/getEnvironment:getEnvironment", args ?? new GetEnvironmentArgs(), options.WithDefaults());

        /// <summary>
        /// ## # qovery.Environment (Data Source)
        /// 
        /// Provides a Qovery environment resource. This can be used to create and manage Qovery environments.
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
        ///     var myEnvironment = Qovery.GetEnvironment.Invoke(new()
        ///     {
        ///         Id = "&lt;environment_id&gt;",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetEnvironmentResult> Invoke(GetEnvironmentInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetEnvironmentResult>("qovery:index/getEnvironment:getEnvironment", args ?? new GetEnvironmentInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetEnvironmentArgs : global::Pulumi.InvokeArgs
    {
        [Input("environmentVariableAliases")]
        private List<Inputs.GetEnvironmentEnvironmentVariableAliasArgs>? _environmentVariableAliases;
        public List<Inputs.GetEnvironmentEnvironmentVariableAliasArgs> EnvironmentVariableAliases
        {
            get => _environmentVariableAliases ?? (_environmentVariableAliases = new List<Inputs.GetEnvironmentEnvironmentVariableAliasArgs>());
            set => _environmentVariableAliases = value;
        }

        [Input("environmentVariableOverrides")]
        private List<Inputs.GetEnvironmentEnvironmentVariableOverrideArgs>? _environmentVariableOverrides;
        public List<Inputs.GetEnvironmentEnvironmentVariableOverrideArgs> EnvironmentVariableOverrides
        {
            get => _environmentVariableOverrides ?? (_environmentVariableOverrides = new List<Inputs.GetEnvironmentEnvironmentVariableOverrideArgs>());
            set => _environmentVariableOverrides = value;
        }

        [Input("environmentVariables")]
        private List<Inputs.GetEnvironmentEnvironmentVariableArgs>? _environmentVariables;
        public List<Inputs.GetEnvironmentEnvironmentVariableArgs> EnvironmentVariables
        {
            get => _environmentVariables ?? (_environmentVariables = new List<Inputs.GetEnvironmentEnvironmentVariableArgs>());
            set => _environmentVariables = value;
        }

        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        [Input("mode")]
        public string? Mode { get; set; }

        [Input("secretAliases")]
        private List<Inputs.GetEnvironmentSecretAliasArgs>? _secretAliases;
        public List<Inputs.GetEnvironmentSecretAliasArgs> SecretAliases
        {
            get => _secretAliases ?? (_secretAliases = new List<Inputs.GetEnvironmentSecretAliasArgs>());
            set => _secretAliases = value;
        }

        [Input("secretOverrides")]
        private List<Inputs.GetEnvironmentSecretOverrideArgs>? _secretOverrides;
        public List<Inputs.GetEnvironmentSecretOverrideArgs> SecretOverrides
        {
            get => _secretOverrides ?? (_secretOverrides = new List<Inputs.GetEnvironmentSecretOverrideArgs>());
            set => _secretOverrides = value;
        }

        [Input("secrets")]
        private List<Inputs.GetEnvironmentSecretArgs>? _secrets;
        public List<Inputs.GetEnvironmentSecretArgs> Secrets
        {
            get => _secrets ?? (_secrets = new List<Inputs.GetEnvironmentSecretArgs>());
            set => _secrets = value;
        }

        public GetEnvironmentArgs()
        {
        }
        public static new GetEnvironmentArgs Empty => new GetEnvironmentArgs();
    }

    public sealed class GetEnvironmentInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("environmentVariableAliases")]
        private InputList<Inputs.GetEnvironmentEnvironmentVariableAliasInputArgs>? _environmentVariableAliases;
        public InputList<Inputs.GetEnvironmentEnvironmentVariableAliasInputArgs> EnvironmentVariableAliases
        {
            get => _environmentVariableAliases ?? (_environmentVariableAliases = new InputList<Inputs.GetEnvironmentEnvironmentVariableAliasInputArgs>());
            set => _environmentVariableAliases = value;
        }

        [Input("environmentVariableOverrides")]
        private InputList<Inputs.GetEnvironmentEnvironmentVariableOverrideInputArgs>? _environmentVariableOverrides;
        public InputList<Inputs.GetEnvironmentEnvironmentVariableOverrideInputArgs> EnvironmentVariableOverrides
        {
            get => _environmentVariableOverrides ?? (_environmentVariableOverrides = new InputList<Inputs.GetEnvironmentEnvironmentVariableOverrideInputArgs>());
            set => _environmentVariableOverrides = value;
        }

        [Input("environmentVariables")]
        private InputList<Inputs.GetEnvironmentEnvironmentVariableInputArgs>? _environmentVariables;
        public InputList<Inputs.GetEnvironmentEnvironmentVariableInputArgs> EnvironmentVariables
        {
            get => _environmentVariables ?? (_environmentVariables = new InputList<Inputs.GetEnvironmentEnvironmentVariableInputArgs>());
            set => _environmentVariables = value;
        }

        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        [Input("mode")]
        public Input<string>? Mode { get; set; }

        [Input("secretAliases")]
        private InputList<Inputs.GetEnvironmentSecretAliasInputArgs>? _secretAliases;
        public InputList<Inputs.GetEnvironmentSecretAliasInputArgs> SecretAliases
        {
            get => _secretAliases ?? (_secretAliases = new InputList<Inputs.GetEnvironmentSecretAliasInputArgs>());
            set => _secretAliases = value;
        }

        [Input("secretOverrides")]
        private InputList<Inputs.GetEnvironmentSecretOverrideInputArgs>? _secretOverrides;
        public InputList<Inputs.GetEnvironmentSecretOverrideInputArgs> SecretOverrides
        {
            get => _secretOverrides ?? (_secretOverrides = new InputList<Inputs.GetEnvironmentSecretOverrideInputArgs>());
            set => _secretOverrides = value;
        }

        [Input("secrets")]
        private InputList<Inputs.GetEnvironmentSecretInputArgs>? _secrets;
        public InputList<Inputs.GetEnvironmentSecretInputArgs> Secrets
        {
            get => _secrets ?? (_secrets = new InputList<Inputs.GetEnvironmentSecretInputArgs>());
            set => _secrets = value;
        }

        public GetEnvironmentInvokeArgs()
        {
        }
        public static new GetEnvironmentInvokeArgs Empty => new GetEnvironmentInvokeArgs();
    }


    [OutputType]
    public sealed class GetEnvironmentResult
    {
        public readonly ImmutableArray<Outputs.GetEnvironmentBuiltInEnvironmentVariableResult> BuiltInEnvironmentVariables;
        public readonly string ClusterId;
        public readonly ImmutableArray<Outputs.GetEnvironmentEnvironmentVariableAliasResult> EnvironmentVariableAliases;
        public readonly ImmutableArray<Outputs.GetEnvironmentEnvironmentVariableOverrideResult> EnvironmentVariableOverrides;
        public readonly ImmutableArray<Outputs.GetEnvironmentEnvironmentVariableResult> EnvironmentVariables;
        public readonly string Id;
        public readonly string Mode;
        public readonly string Name;
        public readonly string ProjectId;
        public readonly ImmutableArray<Outputs.GetEnvironmentSecretAliasResult> SecretAliases;
        public readonly ImmutableArray<Outputs.GetEnvironmentSecretOverrideResult> SecretOverrides;
        public readonly ImmutableArray<Outputs.GetEnvironmentSecretResult> Secrets;

        [OutputConstructor]
        private GetEnvironmentResult(
            ImmutableArray<Outputs.GetEnvironmentBuiltInEnvironmentVariableResult> builtInEnvironmentVariables,

            string clusterId,

            ImmutableArray<Outputs.GetEnvironmentEnvironmentVariableAliasResult> environmentVariableAliases,

            ImmutableArray<Outputs.GetEnvironmentEnvironmentVariableOverrideResult> environmentVariableOverrides,

            ImmutableArray<Outputs.GetEnvironmentEnvironmentVariableResult> environmentVariables,

            string id,

            string mode,

            string name,

            string projectId,

            ImmutableArray<Outputs.GetEnvironmentSecretAliasResult> secretAliases,

            ImmutableArray<Outputs.GetEnvironmentSecretOverrideResult> secretOverrides,

            ImmutableArray<Outputs.GetEnvironmentSecretResult> secrets)
        {
            BuiltInEnvironmentVariables = builtInEnvironmentVariables;
            ClusterId = clusterId;
            EnvironmentVariableAliases = environmentVariableAliases;
            EnvironmentVariableOverrides = environmentVariableOverrides;
            EnvironmentVariables = environmentVariables;
            Id = id;
            Mode = mode;
            Name = name;
            ProjectId = projectId;
            SecretAliases = secretAliases;
            SecretOverrides = secretOverrides;
            Secrets = secrets;
        }
    }
}
