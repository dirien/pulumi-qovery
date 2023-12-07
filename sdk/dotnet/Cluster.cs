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
    ///  $ pulumi import qovery:index/cluster:Cluster my_cluster "&lt;organization_id&gt;,&lt;cluster_id&gt;"
    /// ```
    /// </summary>
    [QoveryResourceType("qovery:index/cluster:Cluster")]
    public partial class Cluster : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Advanced settings of the cluster.
        /// </summary>
        [Output("advancedSettingsJson")]
        public Output<string> AdvancedSettingsJson { get; private set; } = null!;

        /// <summary>
        /// Cloud provider of the cluster. - Can be: `AWS`, `DO`, `SCW`.
        /// </summary>
        [Output("cloudProvider")]
        public Output<string> CloudProvider { get; private set; } = null!;

        /// <summary>
        /// Id of the credentials.
        /// </summary>
        [Output("credentialsId")]
        public Output<string> CredentialsId { get; private set; } = null!;

        /// <summary>
        /// Description of the cluster. - Default: ``.
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        [Output("diskSize")]
        public Output<int> DiskSize { get; private set; } = null!;

        /// <summary>
        /// Features of the cluster.
        /// </summary>
        [Output("features")]
        public Output<Outputs.ClusterFeatures> Features { get; private set; } = null!;

        /// <summary>
        /// Instance type of the cluster. I.e: For Aws `t3a.xlarge`, for Scaleway `DEV-L`
        /// </summary>
        [Output("instanceType")]
        public Output<string> InstanceType { get; private set; } = null!;

        /// <summary>
        /// Kubernetes mode of the cluster. - Can be: `K3S`, `MANAGED`. - Default: `MANAGED`.
        /// </summary>
        [Output("kubernetesMode")]
        public Output<string> KubernetesMode { get; private set; } = null!;

        /// <summary>
        /// Maximum number of nodes running for the cluster. [NOTE: have to be set to 1 in case of K3S clusters] - Must be: `&gt;= 1`.
        /// - Default: `10`.
        /// </summary>
        [Output("maxRunningNodes")]
        public Output<int> MaxRunningNodes { get; private set; } = null!;

        /// <summary>
        /// Minimum number of nodes running for the cluster. [NOTE: have to be set to 1 in case of K3S clusters]. - Must be: `&gt;= 1`.
        /// - Default: `3`.
        /// </summary>
        [Output("minRunningNodes")]
        public Output<int> MinRunningNodes { get; private set; } = null!;

        /// <summary>
        /// Name of the cluster.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Id of the organization.
        /// </summary>
        [Output("organizationId")]
        public Output<string> OrganizationId { get; private set; } = null!;

        /// <summary>
        /// Region of the cluster.
        /// </summary>
        [Output("region")]
        public Output<string> Region { get; private set; } = null!;

        /// <summary>
        /// List of routes of the cluster.
        /// </summary>
        [Output("routingTables")]
        public Output<ImmutableArray<Outputs.ClusterRoutingTable>> RoutingTables { get; private set; } = null!;

        /// <summary>
        /// State of the cluster. - Can be: `DEPLOYED`, `STOPPED`. - Default: `DEPLOYED`.
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;


        /// <summary>
        /// Create a Cluster resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Cluster(string name, ClusterArgs args, CustomResourceOptions? options = null)
            : base("qovery:index/cluster:Cluster", name, args ?? new ClusterArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Cluster(string name, Input<string> id, ClusterState? state = null, CustomResourceOptions? options = null)
            : base("qovery:index/cluster:Cluster", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Cluster resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Cluster Get(string name, Input<string> id, ClusterState? state = null, CustomResourceOptions? options = null)
        {
            return new Cluster(name, id, state, options);
        }
    }

    public sealed class ClusterArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Advanced settings of the cluster.
        /// </summary>
        [Input("advancedSettingsJson")]
        public Input<string>? AdvancedSettingsJson { get; set; }

        /// <summary>
        /// Cloud provider of the cluster. - Can be: `AWS`, `DO`, `SCW`.
        /// </summary>
        [Input("cloudProvider", required: true)]
        public Input<string> CloudProvider { get; set; } = null!;

        /// <summary>
        /// Id of the credentials.
        /// </summary>
        [Input("credentialsId", required: true)]
        public Input<string> CredentialsId { get; set; } = null!;

        /// <summary>
        /// Description of the cluster. - Default: ``.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("diskSize")]
        public Input<int>? DiskSize { get; set; }

        /// <summary>
        /// Features of the cluster.
        /// </summary>
        [Input("features")]
        public Input<Inputs.ClusterFeaturesArgs>? Features { get; set; }

        /// <summary>
        /// Instance type of the cluster. I.e: For Aws `t3a.xlarge`, for Scaleway `DEV-L`
        /// </summary>
        [Input("instanceType", required: true)]
        public Input<string> InstanceType { get; set; } = null!;

        /// <summary>
        /// Kubernetes mode of the cluster. - Can be: `K3S`, `MANAGED`. - Default: `MANAGED`.
        /// </summary>
        [Input("kubernetesMode")]
        public Input<string>? KubernetesMode { get; set; }

        /// <summary>
        /// Maximum number of nodes running for the cluster. [NOTE: have to be set to 1 in case of K3S clusters] - Must be: `&gt;= 1`.
        /// - Default: `10`.
        /// </summary>
        [Input("maxRunningNodes")]
        public Input<int>? MaxRunningNodes { get; set; }

        /// <summary>
        /// Minimum number of nodes running for the cluster. [NOTE: have to be set to 1 in case of K3S clusters]. - Must be: `&gt;= 1`.
        /// - Default: `3`.
        /// </summary>
        [Input("minRunningNodes")]
        public Input<int>? MinRunningNodes { get; set; }

        /// <summary>
        /// Name of the cluster.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Id of the organization.
        /// </summary>
        [Input("organizationId", required: true)]
        public Input<string> OrganizationId { get; set; } = null!;

        /// <summary>
        /// Region of the cluster.
        /// </summary>
        [Input("region", required: true)]
        public Input<string> Region { get; set; } = null!;

        [Input("routingTables")]
        private InputList<Inputs.ClusterRoutingTableArgs>? _routingTables;

        /// <summary>
        /// List of routes of the cluster.
        /// </summary>
        public InputList<Inputs.ClusterRoutingTableArgs> RoutingTables
        {
            get => _routingTables ?? (_routingTables = new InputList<Inputs.ClusterRoutingTableArgs>());
            set => _routingTables = value;
        }

        /// <summary>
        /// State of the cluster. - Can be: `DEPLOYED`, `STOPPED`. - Default: `DEPLOYED`.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        public ClusterArgs()
        {
        }
        public static new ClusterArgs Empty => new ClusterArgs();
    }

    public sealed class ClusterState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Advanced settings of the cluster.
        /// </summary>
        [Input("advancedSettingsJson")]
        public Input<string>? AdvancedSettingsJson { get; set; }

        /// <summary>
        /// Cloud provider of the cluster. - Can be: `AWS`, `DO`, `SCW`.
        /// </summary>
        [Input("cloudProvider")]
        public Input<string>? CloudProvider { get; set; }

        /// <summary>
        /// Id of the credentials.
        /// </summary>
        [Input("credentialsId")]
        public Input<string>? CredentialsId { get; set; }

        /// <summary>
        /// Description of the cluster. - Default: ``.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("diskSize")]
        public Input<int>? DiskSize { get; set; }

        /// <summary>
        /// Features of the cluster.
        /// </summary>
        [Input("features")]
        public Input<Inputs.ClusterFeaturesGetArgs>? Features { get; set; }

        /// <summary>
        /// Instance type of the cluster. I.e: For Aws `t3a.xlarge`, for Scaleway `DEV-L`
        /// </summary>
        [Input("instanceType")]
        public Input<string>? InstanceType { get; set; }

        /// <summary>
        /// Kubernetes mode of the cluster. - Can be: `K3S`, `MANAGED`. - Default: `MANAGED`.
        /// </summary>
        [Input("kubernetesMode")]
        public Input<string>? KubernetesMode { get; set; }

        /// <summary>
        /// Maximum number of nodes running for the cluster. [NOTE: have to be set to 1 in case of K3S clusters] - Must be: `&gt;= 1`.
        /// - Default: `10`.
        /// </summary>
        [Input("maxRunningNodes")]
        public Input<int>? MaxRunningNodes { get; set; }

        /// <summary>
        /// Minimum number of nodes running for the cluster. [NOTE: have to be set to 1 in case of K3S clusters]. - Must be: `&gt;= 1`.
        /// - Default: `3`.
        /// </summary>
        [Input("minRunningNodes")]
        public Input<int>? MinRunningNodes { get; set; }

        /// <summary>
        /// Name of the cluster.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Id of the organization.
        /// </summary>
        [Input("organizationId")]
        public Input<string>? OrganizationId { get; set; }

        /// <summary>
        /// Region of the cluster.
        /// </summary>
        [Input("region")]
        public Input<string>? Region { get; set; }

        [Input("routingTables")]
        private InputList<Inputs.ClusterRoutingTableGetArgs>? _routingTables;

        /// <summary>
        /// List of routes of the cluster.
        /// </summary>
        public InputList<Inputs.ClusterRoutingTableGetArgs> RoutingTables
        {
            get => _routingTables ?? (_routingTables = new InputList<Inputs.ClusterRoutingTableGetArgs>());
            set => _routingTables = value;
        }

        /// <summary>
        /// State of the cluster. - Can be: `DEPLOYED`, `STOPPED`. - Default: `DEPLOYED`.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        public ClusterState()
        {
        }
        public static new ClusterState Empty => new ClusterState();
    }
}
