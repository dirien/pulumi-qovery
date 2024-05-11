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
    /// ## # qovery.Organization (Resource)
    /// 
    /// Provides a Qovery organization resource. This can be used to create and manage Qovery organizations.
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
    ///     var myOrganization = new Qovery.Organization("myOrganization", new()
    ///     {
    ///         Description = "My organization description",
    ///         Plan = "FREE",
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// ```sh
    /// $ pulumi import qovery:index/organization:Organization my_organization "&lt;organization_id&gt;"
    /// ```
    /// </summary>
    [QoveryResourceType("qovery:index/organization:Organization")]
    public partial class Organization : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Description of the organization.
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// Name of the organization.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Plan of the organization. - Can be: `BUSINESS`, `ENTERPRISE`, `ENTERPRISE_YEARLY`, `FREE`, `PROFESSIONAL`, `TEAM`,
        /// `TEAM_YEARLY`.
        /// </summary>
        [Output("plan")]
        public Output<string> Plan { get; private set; } = null!;


        /// <summary>
        /// Create a Organization resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Organization(string name, OrganizationArgs args, CustomResourceOptions? options = null)
            : base("qovery:index/organization:Organization", name, args ?? new OrganizationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Organization(string name, Input<string> id, OrganizationState? state = null, CustomResourceOptions? options = null)
            : base("qovery:index/organization:Organization", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Organization resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Organization Get(string name, Input<string> id, OrganizationState? state = null, CustomResourceOptions? options = null)
        {
            return new Organization(name, id, state, options);
        }
    }

    public sealed class OrganizationArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description of the organization.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Name of the organization.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Plan of the organization. - Can be: `BUSINESS`, `ENTERPRISE`, `ENTERPRISE_YEARLY`, `FREE`, `PROFESSIONAL`, `TEAM`,
        /// `TEAM_YEARLY`.
        /// </summary>
        [Input("plan", required: true)]
        public Input<string> Plan { get; set; } = null!;

        public OrganizationArgs()
        {
        }
        public static new OrganizationArgs Empty => new OrganizationArgs();
    }

    public sealed class OrganizationState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description of the organization.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Name of the organization.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Plan of the organization. - Can be: `BUSINESS`, `ENTERPRISE`, `ENTERPRISE_YEARLY`, `FREE`, `PROFESSIONAL`, `TEAM`,
        /// `TEAM_YEARLY`.
        /// </summary>
        [Input("plan")]
        public Input<string>? Plan { get; set; }

        public OrganizationState()
        {
        }
        public static new OrganizationState Empty => new OrganizationState();
    }
}
