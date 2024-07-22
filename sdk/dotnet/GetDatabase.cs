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
    public static class GetDatabase
    {
        /// <summary>
        /// ## # qovery.Database (Data Source)
        /// 
        /// Provides a Qovery database resource. This can be used to create and manage Qovery databases.
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
        ///     var myDatabase = Qovery.GetDatabase.Invoke(new()
        ///     {
        ///         Id = "&lt;database_id&gt;",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetDatabaseResult> InvokeAsync(GetDatabaseArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDatabaseResult>("qovery:index/getDatabase:getDatabase", args ?? new GetDatabaseArgs(), options.WithDefaults());

        /// <summary>
        /// ## # qovery.Database (Data Source)
        /// 
        /// Provides a Qovery database resource. This can be used to create and manage Qovery databases.
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
        ///     var myDatabase = Qovery.GetDatabase.Invoke(new()
        ///     {
        ///         Id = "&lt;database_id&gt;",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetDatabaseResult> Invoke(GetDatabaseInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDatabaseResult>("qovery:index/getDatabase:getDatabase", args ?? new GetDatabaseInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDatabaseArgs : global::Pulumi.InvokeArgs
    {
        [Input("accessibility")]
        public string? Accessibility { get; set; }

        [Input("annotationsGroupIds")]
        private List<string>? _annotationsGroupIds;
        public List<string> AnnotationsGroupIds
        {
            get => _annotationsGroupIds ?? (_annotationsGroupIds = new List<string>());
            set => _annotationsGroupIds = value;
        }

        [Input("cpu")]
        public int? Cpu { get; set; }

        [Input("deploymentStageId")]
        public string? DeploymentStageId { get; set; }

        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        [Input("instanceType")]
        public string? InstanceType { get; set; }

        [Input("labelsGroupIds")]
        private List<string>? _labelsGroupIds;
        public List<string> LabelsGroupIds
        {
            get => _labelsGroupIds ?? (_labelsGroupIds = new List<string>());
            set => _labelsGroupIds = value;
        }

        [Input("memory")]
        public int? Memory { get; set; }

        [Input("storage")]
        public int? Storage { get; set; }

        public GetDatabaseArgs()
        {
        }
        public static new GetDatabaseArgs Empty => new GetDatabaseArgs();
    }

    public sealed class GetDatabaseInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("accessibility")]
        public Input<string>? Accessibility { get; set; }

        [Input("annotationsGroupIds")]
        private InputList<string>? _annotationsGroupIds;
        public InputList<string> AnnotationsGroupIds
        {
            get => _annotationsGroupIds ?? (_annotationsGroupIds = new InputList<string>());
            set => _annotationsGroupIds = value;
        }

        [Input("cpu")]
        public Input<int>? Cpu { get; set; }

        [Input("deploymentStageId")]
        public Input<string>? DeploymentStageId { get; set; }

        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        [Input("instanceType")]
        public Input<string>? InstanceType { get; set; }

        [Input("labelsGroupIds")]
        private InputList<string>? _labelsGroupIds;
        public InputList<string> LabelsGroupIds
        {
            get => _labelsGroupIds ?? (_labelsGroupIds = new InputList<string>());
            set => _labelsGroupIds = value;
        }

        [Input("memory")]
        public Input<int>? Memory { get; set; }

        [Input("storage")]
        public Input<int>? Storage { get; set; }

        public GetDatabaseInvokeArgs()
        {
        }
        public static new GetDatabaseInvokeArgs Empty => new GetDatabaseInvokeArgs();
    }


    [OutputType]
    public sealed class GetDatabaseResult
    {
        public readonly string? Accessibility;
        public readonly ImmutableArray<string> AnnotationsGroupIds;
        public readonly int? Cpu;
        public readonly string DeploymentStageId;
        public readonly string EnvironmentId;
        public readonly string ExternalHost;
        public readonly string Id;
        public readonly string InstanceType;
        public readonly string InternalHost;
        public readonly ImmutableArray<string> LabelsGroupIds;
        public readonly string Login;
        public readonly int? Memory;
        public readonly string Mode;
        public readonly string Name;
        public readonly string Password;
        public readonly int Port;
        public readonly int? Storage;
        public readonly string Type;
        public readonly string Version;

        [OutputConstructor]
        private GetDatabaseResult(
            string? accessibility,

            ImmutableArray<string> annotationsGroupIds,

            int? cpu,

            string deploymentStageId,

            string environmentId,

            string externalHost,

            string id,

            string instanceType,

            string internalHost,

            ImmutableArray<string> labelsGroupIds,

            string login,

            int? memory,

            string mode,

            string name,

            string password,

            int port,

            int? storage,

            string type,

            string version)
        {
            Accessibility = accessibility;
            AnnotationsGroupIds = annotationsGroupIds;
            Cpu = cpu;
            DeploymentStageId = deploymentStageId;
            EnvironmentId = environmentId;
            ExternalHost = externalHost;
            Id = id;
            InstanceType = instanceType;
            InternalHost = internalHost;
            LabelsGroupIds = labelsGroupIds;
            Login = login;
            Memory = memory;
            Mode = mode;
            Name = name;
            Password = password;
            Port = port;
            Storage = storage;
            Type = type;
            Version = version;
        }
    }
}
