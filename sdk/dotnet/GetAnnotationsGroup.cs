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
    public static class GetAnnotationsGroup
    {
        /// <summary>
        /// ## # qovery.AnnotationsGroup (Data Source)
        /// 
        /// Provides a Qovery annotations group resource
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
        ///     var myAnnotationsGroup = Qovery.GetAnnotationsGroup.Invoke(new()
        ///     {
        ///         Id = "&lt;annotations_group_id&gt;",
        ///         OrganizationId = "&lt;organization_id&gt;",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetAnnotationsGroupResult> InvokeAsync(GetAnnotationsGroupArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetAnnotationsGroupResult>("qovery:index/getAnnotationsGroup:getAnnotationsGroup", args ?? new GetAnnotationsGroupArgs(), options.WithDefaults());

        /// <summary>
        /// ## # qovery.AnnotationsGroup (Data Source)
        /// 
        /// Provides a Qovery annotations group resource
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
        ///     var myAnnotationsGroup = Qovery.GetAnnotationsGroup.Invoke(new()
        ///     {
        ///         Id = "&lt;annotations_group_id&gt;",
        ///         OrganizationId = "&lt;organization_id&gt;",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetAnnotationsGroupResult> Invoke(GetAnnotationsGroupInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetAnnotationsGroupResult>("qovery:index/getAnnotationsGroup:getAnnotationsGroup", args ?? new GetAnnotationsGroupInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetAnnotationsGroupArgs : global::Pulumi.InvokeArgs
    {
        [Input("annotations")]
        private Dictionary<string, string>? _annotations;

        /// <summary>
        /// annotations
        /// </summary>
        public Dictionary<string, string> Annotations
        {
            get => _annotations ?? (_annotations = new Dictionary<string, string>());
            set => _annotations = value;
        }

        /// <summary>
        /// Id of the annotations group
        /// </summary>
        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        /// <summary>
        /// name of the annotations group
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Id of the organization.
        /// </summary>
        [Input("organizationId", required: true)]
        public string OrganizationId { get; set; } = null!;

        [Input("scopes")]
        private List<string>? _scopes;

        /// <summary>
        /// scopes of the annotations group
        /// </summary>
        public List<string> Scopes
        {
            get => _scopes ?? (_scopes = new List<string>());
            set => _scopes = value;
        }

        public GetAnnotationsGroupArgs()
        {
        }
        public static new GetAnnotationsGroupArgs Empty => new GetAnnotationsGroupArgs();
    }

    public sealed class GetAnnotationsGroupInvokeArgs : global::Pulumi.InvokeArgs
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
        /// Id of the annotations group
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

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

        public GetAnnotationsGroupInvokeArgs()
        {
        }
        public static new GetAnnotationsGroupInvokeArgs Empty => new GetAnnotationsGroupInvokeArgs();
    }


    [OutputType]
    public sealed class GetAnnotationsGroupResult
    {
        /// <summary>
        /// annotations
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Annotations;
        /// <summary>
        /// Id of the annotations group
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// name of the annotations group
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Id of the organization.
        /// </summary>
        public readonly string OrganizationId;
        /// <summary>
        /// scopes of the annotations group
        /// </summary>
        public readonly ImmutableArray<string> Scopes;

        [OutputConstructor]
        private GetAnnotationsGroupResult(
            ImmutableDictionary<string, string>? annotations,

            string id,

            string? name,

            string organizationId,

            ImmutableArray<string> scopes)
        {
            Annotations = annotations;
            Id = id;
            Name = name;
            OrganizationId = organizationId;
            Scopes = scopes;
        }
    }
}
