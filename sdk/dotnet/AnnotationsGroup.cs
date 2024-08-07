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
    /// ## # qovery.AnnotationsGroup (Resource)
    /// 
    /// Provides a Qovery annotations group resource
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
    ///     var annotationsGroup1 = new Qovery.AnnotationsGroup("annotationsGroup1", new()
    ///     {
    ///         OrganizationId = qovery_organization.My_organization.Id,
    ///         Annotations = 
    ///         {
    ///             { "key1", "value1" },
    ///             { "key2", "value2" },
    ///         },
    ///         Scopes = new[]
    ///         {
    ///             "PODS",
    ///             "DEPLOYMENTS",
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// ```sh
    /// $ pulumi import qovery:index/annotationsGroup:AnnotationsGroup my_qovery_annotations_group "&lt;annotations_group_id&gt;"
    /// ```
    /// </summary>
    [QoveryResourceType("qovery:index/annotationsGroup:AnnotationsGroup")]
    public partial class AnnotationsGroup : global::Pulumi.CustomResource
    {
        /// <summary>
        /// annotations
        /// </summary>
        [Output("annotations")]
        public Output<ImmutableDictionary<string, string>> Annotations { get; private set; } = null!;

        /// <summary>
        /// name of the annotations group
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Id of the organization.
        /// </summary>
        [Output("organizationId")]
        public Output<string> OrganizationId { get; private set; } = null!;

        /// <summary>
        /// scopes of the annotations group
        /// </summary>
        [Output("scopes")]
        public Output<ImmutableArray<string>> Scopes { get; private set; } = null!;


        /// <summary>
        /// Create a AnnotationsGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AnnotationsGroup(string name, AnnotationsGroupArgs args, CustomResourceOptions? options = null)
            : base("qovery:index/annotationsGroup:AnnotationsGroup", name, args ?? new AnnotationsGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AnnotationsGroup(string name, Input<string> id, AnnotationsGroupState? state = null, CustomResourceOptions? options = null)
            : base("qovery:index/annotationsGroup:AnnotationsGroup", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing AnnotationsGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AnnotationsGroup Get(string name, Input<string> id, AnnotationsGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new AnnotationsGroup(name, id, state, options);
        }
    }

    public sealed class AnnotationsGroupArgs : global::Pulumi.ResourceArgs
    {
        [Input("annotations", required: true)]
        private InputMap<string>? _annotations;

        /// <summary>
        /// annotations
        /// </summary>
        public InputMap<string> Annotations
        {
            get => _annotations ?? (_annotations = new InputMap<string>());
            set => _annotations = value;
        }

        /// <summary>
        /// name of the annotations group
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Id of the organization.
        /// </summary>
        [Input("organizationId", required: true)]
        public Input<string> OrganizationId { get; set; } = null!;

        [Input("scopes", required: true)]
        private InputList<string>? _scopes;

        /// <summary>
        /// scopes of the annotations group
        /// </summary>
        public InputList<string> Scopes
        {
            get => _scopes ?? (_scopes = new InputList<string>());
            set => _scopes = value;
        }

        public AnnotationsGroupArgs()
        {
        }
        public static new AnnotationsGroupArgs Empty => new AnnotationsGroupArgs();
    }

    public sealed class AnnotationsGroupState : global::Pulumi.ResourceArgs
    {
        [Input("annotations")]
        private InputMap<string>? _annotations;

        /// <summary>
        /// annotations
        /// </summary>
        public InputMap<string> Annotations
        {
            get => _annotations ?? (_annotations = new InputMap<string>());
            set => _annotations = value;
        }

        /// <summary>
        /// name of the annotations group
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Id of the organization.
        /// </summary>
        [Input("organizationId")]
        public Input<string>? OrganizationId { get; set; }

        [Input("scopes")]
        private InputList<string>? _scopes;

        /// <summary>
        /// scopes of the annotations group
        /// </summary>
        public InputList<string> Scopes
        {
            get => _scopes ?? (_scopes = new InputList<string>());
            set => _scopes = value;
        }

        public AnnotationsGroupState()
        {
        }
        public static new AnnotationsGroupState Empty => new AnnotationsGroupState();
    }
}
