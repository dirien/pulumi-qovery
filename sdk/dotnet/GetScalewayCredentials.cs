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
    public static class GetScalewayCredentials
    {
        /// <summary>
        /// ## # qovery.ScalewayCredentials (Data Source)
        /// 
        /// Use this data source to retrieve information about an existing Scaleway credentials.
        /// </summary>
        public static Task<GetScalewayCredentialsResult> InvokeAsync(GetScalewayCredentialsArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetScalewayCredentialsResult>("qovery:index/getScalewayCredentials:getScalewayCredentials", args ?? new GetScalewayCredentialsArgs(), options.WithDefaults());

        /// <summary>
        /// ## # qovery.ScalewayCredentials (Data Source)
        /// 
        /// Use this data source to retrieve information about an existing Scaleway credentials.
        /// </summary>
        public static Output<GetScalewayCredentialsResult> Invoke(GetScalewayCredentialsInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetScalewayCredentialsResult>("qovery:index/getScalewayCredentials:getScalewayCredentials", args ?? new GetScalewayCredentialsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetScalewayCredentialsArgs : global::Pulumi.InvokeArgs
    {
        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        [Input("organizationId", required: true)]
        public string OrganizationId { get; set; } = null!;

        public GetScalewayCredentialsArgs()
        {
        }
        public static new GetScalewayCredentialsArgs Empty => new GetScalewayCredentialsArgs();
    }

    public sealed class GetScalewayCredentialsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        [Input("organizationId", required: true)]
        public Input<string> OrganizationId { get; set; } = null!;

        public GetScalewayCredentialsInvokeArgs()
        {
        }
        public static new GetScalewayCredentialsInvokeArgs Empty => new GetScalewayCredentialsInvokeArgs();
    }


    [OutputType]
    public sealed class GetScalewayCredentialsResult
    {
        public readonly string Id;
        public readonly string Name;
        public readonly string OrganizationId;

        [OutputConstructor]
        private GetScalewayCredentialsResult(
            string id,

            string name,

            string organizationId)
        {
            Id = id;
            Name = name;
            OrganizationId = organizationId;
        }
    }
}