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
    /// ## # qovery.Database (Resource)
    /// 
    /// Provides a Qovery database resource. This can be used to create and manage Qovery databases.
    /// 
    /// ## Example
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Qovery = ediri.Qovery;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var myContainerDatabase = new Qovery.Database("myContainerDatabase", new()
    ///     {
    ///         EnvironmentId = qovery_environment.My_environment.Id,
    ///         Type = "POSTGRESQL",
    ///         Version = "10",
    ///         Mode = "CONTAINER",
    ///         Accessibility = "PRIVATE",
    ///         Cpu = 250,
    ///         Memory = 256,
    ///         Storage = 10,
    ///     }, new CustomResourceOptions
    ///     {
    ///         DependsOn =
    ///         {
    ///             qovery_environment.My_environment,
    ///         },
    ///     });
    /// 
    ///     var myManagedDatabase = new Qovery.Database("myManagedDatabase", new()
    ///     {
    ///         EnvironmentId = qovery_environment.My_environment.Id,
    ///         Type = "POSTGRESQL",
    ///         Version = "10",
    ///         Mode = "MANAGED",
    ///         InstanceType = "db.t3.micro",
    ///         Accessibility = "PRIVATE",
    ///         Storage = 10,
    ///     }, new CustomResourceOptions
    ///     {
    ///         DependsOn =
    ///         {
    ///             qovery_environment.My_environment,
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// ```sh
    /// $ pulumi import qovery:index/database:Database my_database "&lt;database_id&gt;"
    /// ```
    /// </summary>
    [QoveryResourceType("qovery:index/database:Database")]
    public partial class Database : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Accessibility of the database. - Can be: `PRIVATE`, `PUBLIC`. - Default: `PUBLIC`.
        /// </summary>
        [Output("accessibility")]
        public Output<string> Accessibility { get; private set; } = null!;

        /// <summary>
        /// List of annotations group ids
        /// </summary>
        [Output("annotationsGroupIds")]
        public Output<ImmutableArray<string>> AnnotationsGroupIds { get; private set; } = null!;

        /// <summary>
        /// CPU of the database in millicores (m) [1000m = 1 CPU]. - Must be: `&gt;= 250`. - Default: `250`.
        /// </summary>
        [Output("cpu")]
        public Output<int> Cpu { get; private set; } = null!;

        /// <summary>
        /// Id of the deployment stage.
        /// </summary>
        [Output("deploymentStageId")]
        public Output<string> DeploymentStageId { get; private set; } = null!;

        /// <summary>
        /// Id of the environment.
        /// </summary>
        [Output("environmentId")]
        public Output<string> EnvironmentId { get; private set; } = null!;

        /// <summary>
        /// The database external FQDN host [NOTE: only if your container is using a publicly accessible port].
        /// </summary>
        [Output("externalHost")]
        public Output<string> ExternalHost { get; private set; } = null!;

        /// <summary>
        /// Icon URI representing the database.
        /// </summary>
        [Output("iconUri")]
        public Output<string> IconUri { get; private set; } = null!;

        /// <summary>
        /// Instance type of the database.
        /// </summary>
        [Output("instanceType")]
        public Output<string> InstanceType { get; private set; } = null!;

        /// <summary>
        /// The database internal host (Recommended for your application)
        /// </summary>
        [Output("internalHost")]
        public Output<string> InternalHost { get; private set; } = null!;

        /// <summary>
        /// List of labels group ids
        /// </summary>
        [Output("labelsGroupIds")]
        public Output<ImmutableArray<string>> LabelsGroupIds { get; private set; } = null!;

        /// <summary>
        /// The login to connect to your database
        /// </summary>
        [Output("login")]
        public Output<string> Login { get; private set; } = null!;

        /// <summary>
        /// RAM of the database in MB [1024MB = 1GB]. - Must be: `&gt;= 100`. - Default: `256`.
        /// </summary>
        [Output("memory")]
        public Output<int> Memory { get; private set; } = null!;

        /// <summary>
        /// Mode of the database [NOTE: can't be updated after creation]. - Can be: `CONTAINER`, `MANAGED`.
        /// </summary>
        [Output("mode")]
        public Output<string> Mode { get; private set; } = null!;

        /// <summary>
        /// Name of the database.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The password to connect to your database
        /// </summary>
        [Output("password")]
        public Output<string> Password { get; private set; } = null!;

        /// <summary>
        /// The port to connect to your database
        /// </summary>
        [Output("port")]
        public Output<int> Port { get; private set; } = null!;

        /// <summary>
        /// Storage of the database in GB [1024MB = 1GB] [NOTE: can't be updated after creation]. - Must be: `&gt;= 10`. - Default:
        /// `10`.
        /// </summary>
        [Output("storage")]
        public Output<int> Storage { get; private set; } = null!;

        /// <summary>
        /// Type of the database [NOTE: can't be updated after creation]. - Can be: `MONGODB`, `MYSQL`, `POSTGRESQL`, `REDIS`.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// Version of the database
        /// </summary>
        [Output("version")]
        public Output<string> Version { get; private set; } = null!;


        /// <summary>
        /// Create a Database resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Database(string name, DatabaseArgs args, CustomResourceOptions? options = null)
            : base("qovery:index/database:Database", name, args ?? new DatabaseArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Database(string name, Input<string> id, DatabaseState? state = null, CustomResourceOptions? options = null)
            : base("qovery:index/database:Database", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Database resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Database Get(string name, Input<string> id, DatabaseState? state = null, CustomResourceOptions? options = null)
        {
            return new Database(name, id, state, options);
        }
    }

    public sealed class DatabaseArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Accessibility of the database. - Can be: `PRIVATE`, `PUBLIC`. - Default: `PUBLIC`.
        /// </summary>
        [Input("accessibility")]
        public Input<string>? Accessibility { get; set; }

        [Input("annotationsGroupIds")]
        private InputList<string>? _annotationsGroupIds;

        /// <summary>
        /// List of annotations group ids
        /// </summary>
        public InputList<string> AnnotationsGroupIds
        {
            get => _annotationsGroupIds ?? (_annotationsGroupIds = new InputList<string>());
            set => _annotationsGroupIds = value;
        }

        /// <summary>
        /// CPU of the database in millicores (m) [1000m = 1 CPU]. - Must be: `&gt;= 250`. - Default: `250`.
        /// </summary>
        [Input("cpu")]
        public Input<int>? Cpu { get; set; }

        /// <summary>
        /// Id of the deployment stage.
        /// </summary>
        [Input("deploymentStageId")]
        public Input<string>? DeploymentStageId { get; set; }

        /// <summary>
        /// Id of the environment.
        /// </summary>
        [Input("environmentId", required: true)]
        public Input<string> EnvironmentId { get; set; } = null!;

        /// <summary>
        /// Icon URI representing the database.
        /// </summary>
        [Input("iconUri")]
        public Input<string>? IconUri { get; set; }

        /// <summary>
        /// Instance type of the database.
        /// </summary>
        [Input("instanceType")]
        public Input<string>? InstanceType { get; set; }

        [Input("labelsGroupIds")]
        private InputList<string>? _labelsGroupIds;

        /// <summary>
        /// List of labels group ids
        /// </summary>
        public InputList<string> LabelsGroupIds
        {
            get => _labelsGroupIds ?? (_labelsGroupIds = new InputList<string>());
            set => _labelsGroupIds = value;
        }

        /// <summary>
        /// RAM of the database in MB [1024MB = 1GB]. - Must be: `&gt;= 100`. - Default: `256`.
        /// </summary>
        [Input("memory")]
        public Input<int>? Memory { get; set; }

        /// <summary>
        /// Mode of the database [NOTE: can't be updated after creation]. - Can be: `CONTAINER`, `MANAGED`.
        /// </summary>
        [Input("mode", required: true)]
        public Input<string> Mode { get; set; } = null!;

        /// <summary>
        /// Name of the database.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Storage of the database in GB [1024MB = 1GB] [NOTE: can't be updated after creation]. - Must be: `&gt;= 10`. - Default:
        /// `10`.
        /// </summary>
        [Input("storage")]
        public Input<int>? Storage { get; set; }

        /// <summary>
        /// Type of the database [NOTE: can't be updated after creation]. - Can be: `MONGODB`, `MYSQL`, `POSTGRESQL`, `REDIS`.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// Version of the database
        /// </summary>
        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        public DatabaseArgs()
        {
        }
        public static new DatabaseArgs Empty => new DatabaseArgs();
    }

    public sealed class DatabaseState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Accessibility of the database. - Can be: `PRIVATE`, `PUBLIC`. - Default: `PUBLIC`.
        /// </summary>
        [Input("accessibility")]
        public Input<string>? Accessibility { get; set; }

        [Input("annotationsGroupIds")]
        private InputList<string>? _annotationsGroupIds;

        /// <summary>
        /// List of annotations group ids
        /// </summary>
        public InputList<string> AnnotationsGroupIds
        {
            get => _annotationsGroupIds ?? (_annotationsGroupIds = new InputList<string>());
            set => _annotationsGroupIds = value;
        }

        /// <summary>
        /// CPU of the database in millicores (m) [1000m = 1 CPU]. - Must be: `&gt;= 250`. - Default: `250`.
        /// </summary>
        [Input("cpu")]
        public Input<int>? Cpu { get; set; }

        /// <summary>
        /// Id of the deployment stage.
        /// </summary>
        [Input("deploymentStageId")]
        public Input<string>? DeploymentStageId { get; set; }

        /// <summary>
        /// Id of the environment.
        /// </summary>
        [Input("environmentId")]
        public Input<string>? EnvironmentId { get; set; }

        /// <summary>
        /// The database external FQDN host [NOTE: only if your container is using a publicly accessible port].
        /// </summary>
        [Input("externalHost")]
        public Input<string>? ExternalHost { get; set; }

        /// <summary>
        /// Icon URI representing the database.
        /// </summary>
        [Input("iconUri")]
        public Input<string>? IconUri { get; set; }

        /// <summary>
        /// Instance type of the database.
        /// </summary>
        [Input("instanceType")]
        public Input<string>? InstanceType { get; set; }

        /// <summary>
        /// The database internal host (Recommended for your application)
        /// </summary>
        [Input("internalHost")]
        public Input<string>? InternalHost { get; set; }

        [Input("labelsGroupIds")]
        private InputList<string>? _labelsGroupIds;

        /// <summary>
        /// List of labels group ids
        /// </summary>
        public InputList<string> LabelsGroupIds
        {
            get => _labelsGroupIds ?? (_labelsGroupIds = new InputList<string>());
            set => _labelsGroupIds = value;
        }

        /// <summary>
        /// The login to connect to your database
        /// </summary>
        [Input("login")]
        public Input<string>? Login { get; set; }

        /// <summary>
        /// RAM of the database in MB [1024MB = 1GB]. - Must be: `&gt;= 100`. - Default: `256`.
        /// </summary>
        [Input("memory")]
        public Input<int>? Memory { get; set; }

        /// <summary>
        /// Mode of the database [NOTE: can't be updated after creation]. - Can be: `CONTAINER`, `MANAGED`.
        /// </summary>
        [Input("mode")]
        public Input<string>? Mode { get; set; }

        /// <summary>
        /// Name of the database.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The password to connect to your database
        /// </summary>
        [Input("password")]
        public Input<string>? Password { get; set; }

        /// <summary>
        /// The port to connect to your database
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        /// <summary>
        /// Storage of the database in GB [1024MB = 1GB] [NOTE: can't be updated after creation]. - Must be: `&gt;= 10`. - Default:
        /// `10`.
        /// </summary>
        [Input("storage")]
        public Input<int>? Storage { get; set; }

        /// <summary>
        /// Type of the database [NOTE: can't be updated after creation]. - Can be: `MONGODB`, `MYSQL`, `POSTGRESQL`, `REDIS`.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// Version of the database
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public DatabaseState()
        {
        }
        public static new DatabaseState Empty => new DatabaseState();
    }
}
