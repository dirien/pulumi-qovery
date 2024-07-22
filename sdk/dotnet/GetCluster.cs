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
    public static class GetCluster
    {
        /// <summary>
        /// ## # qovery.Cluster (Data Source)
        /// 
        /// Provides a Qovery cluster resource. This can be used to create and manage Qovery cluster.
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
        ///     var myCluster = Qovery.GetCluster.Invoke(new()
        ///     {
        ///         Id = "&lt;cluster_id&gt;",
        ///         OrganizationId = "&lt;organization_id&gt;",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetClusterResult> InvokeAsync(GetClusterArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetClusterResult>("qovery:index/getCluster:getCluster", args ?? new GetClusterArgs(), options.WithDefaults());

        /// <summary>
        /// ## # qovery.Cluster (Data Source)
        /// 
        /// Provides a Qovery cluster resource. This can be used to create and manage Qovery cluster.
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
        ///     var myCluster = Qovery.GetCluster.Invoke(new()
        ///     {
        ///         Id = "&lt;cluster_id&gt;",
        ///         OrganizationId = "&lt;organization_id&gt;",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetClusterResult> Invoke(GetClusterInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetClusterResult>("qovery:index/getCluster:getCluster", args ?? new GetClusterInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetClusterArgs : global::Pulumi.InvokeArgs
    {
        [Input("advancedSettingsJson")]
        public string? AdvancedSettingsJson { get; set; }

        [Input("description")]
        public string? Description { get; set; }

        [Input("diskSize")]
        public int? DiskSize { get; set; }

        [Input("features")]
        public Inputs.GetClusterFeaturesArgs? Features { get; set; }

        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        [Input("instanceType")]
        public string? InstanceType { get; set; }

        [Input("kubernetesMode")]
        public string? KubernetesMode { get; set; }

        [Input("maxRunningNodes")]
        public int? MaxRunningNodes { get; set; }

        [Input("minRunningNodes")]
        public int? MinRunningNodes { get; set; }

        [Input("organizationId", required: true)]
        public string OrganizationId { get; set; } = null!;

        [Input("routingTables")]
        private List<Inputs.GetClusterRoutingTableArgs>? _routingTables;
        public List<Inputs.GetClusterRoutingTableArgs> RoutingTables
        {
            get => _routingTables ?? (_routingTables = new List<Inputs.GetClusterRoutingTableArgs>());
            set => _routingTables = value;
        }

        [Input("state")]
        public string? State { get; set; }

        public GetClusterArgs()
        {
        }
        public static new GetClusterArgs Empty => new GetClusterArgs();
    }

    public sealed class GetClusterInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("advancedSettingsJson")]
        public Input<string>? AdvancedSettingsJson { get; set; }

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("diskSize")]
        public Input<int>? DiskSize { get; set; }

        [Input("features")]
        public Input<Inputs.GetClusterFeaturesInputArgs>? Features { get; set; }

        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        [Input("instanceType")]
        public Input<string>? InstanceType { get; set; }

        [Input("kubernetesMode")]
        public Input<string>? KubernetesMode { get; set; }

        [Input("maxRunningNodes")]
        public Input<int>? MaxRunningNodes { get; set; }

        [Input("minRunningNodes")]
        public Input<int>? MinRunningNodes { get; set; }

        [Input("organizationId", required: true)]
        public Input<string> OrganizationId { get; set; } = null!;

        [Input("routingTables")]
        private InputList<Inputs.GetClusterRoutingTableInputArgs>? _routingTables;
        public InputList<Inputs.GetClusterRoutingTableInputArgs> RoutingTables
        {
            get => _routingTables ?? (_routingTables = new InputList<Inputs.GetClusterRoutingTableInputArgs>());
            set => _routingTables = value;
        }

        [Input("state")]
        public Input<string>? State { get; set; }

        public GetClusterInvokeArgs()
        {
        }
        public static new GetClusterInvokeArgs Empty => new GetClusterInvokeArgs();
    }


    [OutputType]
    public sealed class GetClusterResult
    {
        public readonly string AdvancedSettingsJson;
        public readonly string CloudProvider;
        public readonly string CredentialsId;
        public readonly string Description;
        public readonly int DiskSize;
        public readonly Outputs.GetClusterFeaturesResult Features;
        public readonly string Id;
        public readonly string InstanceType;
        public readonly string KubernetesMode;
        public readonly int MaxRunningNodes;
        public readonly int MinRunningNodes;
        public readonly string Name;
        public readonly string OrganizationId;
        public readonly string Region;
        public readonly ImmutableArray<Outputs.GetClusterRoutingTableResult> RoutingTables;
        public readonly string State;

        [OutputConstructor]
        private GetClusterResult(
            string advancedSettingsJson,

            string cloudProvider,

            string credentialsId,

            string description,

            int diskSize,

            Outputs.GetClusterFeaturesResult features,

            string id,

            string instanceType,

            string kubernetesMode,

            int maxRunningNodes,

            int minRunningNodes,

            string name,

            string organizationId,

            string region,

            ImmutableArray<Outputs.GetClusterRoutingTableResult> routingTables,

            string state)
        {
            AdvancedSettingsJson = advancedSettingsJson;
            CloudProvider = cloudProvider;
            CredentialsId = credentialsId;
            Description = description;
            DiskSize = diskSize;
            Features = features;
            Id = id;
            InstanceType = instanceType;
            KubernetesMode = kubernetesMode;
            MaxRunningNodes = maxRunningNodes;
            MinRunningNodes = minRunningNodes;
            Name = name;
            OrganizationId = organizationId;
            Region = region;
            RoutingTables = routingTables;
            State = state;
        }
    }
}
