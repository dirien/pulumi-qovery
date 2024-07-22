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
    public static class GetLabelsGroup
    {
        /// <summary>
        /// ## # qovery.LabelsGroup (Data Source)
        /// 
        /// Provides a Qovery labels group resource
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
        ///     var myLabelsGroup = Qovery.GetLabelsGroup.Invoke(new()
        ///     {
        ///         Id = "&lt;labels_group_id&gt;",
        ///         OrganizationId = "&lt;organization_id&gt;",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetLabelsGroupResult> InvokeAsync(GetLabelsGroupArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetLabelsGroupResult>("qovery:index/getLabelsGroup:getLabelsGroup", args ?? new GetLabelsGroupArgs(), options.WithDefaults());

        /// <summary>
        /// ## # qovery.LabelsGroup (Data Source)
        /// 
        /// Provides a Qovery labels group resource
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
        ///     var myLabelsGroup = Qovery.GetLabelsGroup.Invoke(new()
        ///     {
        ///         Id = "&lt;labels_group_id&gt;",
        ///         OrganizationId = "&lt;organization_id&gt;",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetLabelsGroupResult> Invoke(GetLabelsGroupInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetLabelsGroupResult>("qovery:index/getLabelsGroup:getLabelsGroup", args ?? new GetLabelsGroupInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetLabelsGroupArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Id of the labels group
        /// </summary>
        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        [Input("labels")]
        private List<Inputs.GetLabelsGroupLabelArgs>? _labels;

        /// <summary>
        /// labels
        /// </summary>
        public List<Inputs.GetLabelsGroupLabelArgs> Labels
        {
            get => _labels ?? (_labels = new List<Inputs.GetLabelsGroupLabelArgs>());
            set => _labels = value;
        }

        /// <summary>
        /// name of the labels group
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Id of the organization.
        /// </summary>
        [Input("organizationId", required: true)]
        public string OrganizationId { get; set; } = null!;

        public GetLabelsGroupArgs()
        {
        }
        public static new GetLabelsGroupArgs Empty => new GetLabelsGroupArgs();
    }

    public sealed class GetLabelsGroupInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Id of the labels group
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        [Input("labels")]
        private InputList<Inputs.GetLabelsGroupLabelInputArgs>? _labels;

        /// <summary>
        /// labels
        /// </summary>
        public InputList<Inputs.GetLabelsGroupLabelInputArgs> Labels
        {
            get => _labels ?? (_labels = new InputList<Inputs.GetLabelsGroupLabelInputArgs>());
            set => _labels = value;
        }

        /// <summary>
        /// name of the labels group
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Id of the organization.
        /// </summary>
        [Input("organizationId", required: true)]
        public Input<string> OrganizationId { get; set; } = null!;

        public GetLabelsGroupInvokeArgs()
        {
        }
        public static new GetLabelsGroupInvokeArgs Empty => new GetLabelsGroupInvokeArgs();
    }


    [OutputType]
    public sealed class GetLabelsGroupResult
    {
        /// <summary>
        /// Id of the labels group
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// labels
        /// </summary>
        public readonly ImmutableArray<Outputs.GetLabelsGroupLabelResult> Labels;
        /// <summary>
        /// name of the labels group
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Id of the organization.
        /// </summary>
        public readonly string OrganizationId;

        [OutputConstructor]
        private GetLabelsGroupResult(
            string id,

            ImmutableArray<Outputs.GetLabelsGroupLabelResult> labels,

            string? name,

            string organizationId)
        {
            Id = id;
            Labels = labels;
            Name = name;
            OrganizationId = organizationId;
        }
    }
}
