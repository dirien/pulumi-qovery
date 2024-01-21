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
    public static class GetHelmRepository
    {
        /// <summary>
        /// ## # qovery.HelmRepository (Data Source)
        /// 
        /// Provides a Qovery helm repository resource. This can be used to create and manage Qovery helm repository.
        /// </summary>
        public static Task<GetHelmRepositoryResult> InvokeAsync(GetHelmRepositoryArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetHelmRepositoryResult>("qovery:index/getHelmRepository:getHelmRepository", args ?? new GetHelmRepositoryArgs(), options.WithDefaults());

        /// <summary>
        /// ## # qovery.HelmRepository (Data Source)
        /// 
        /// Provides a Qovery helm repository resource. This can be used to create and manage Qovery helm repository.
        /// </summary>
        public static Output<GetHelmRepositoryResult> Invoke(GetHelmRepositoryInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetHelmRepositoryResult>("qovery:index/getHelmRepository:getHelmRepository", args ?? new GetHelmRepositoryInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetHelmRepositoryArgs : global::Pulumi.InvokeArgs
    {
        [Input("description")]
        public string? Description { get; set; }

        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        [Input("organizationId", required: true)]
        public string OrganizationId { get; set; } = null!;

        public GetHelmRepositoryArgs()
        {
        }
        public static new GetHelmRepositoryArgs Empty => new GetHelmRepositoryArgs();
    }

    public sealed class GetHelmRepositoryInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        [Input("organizationId", required: true)]
        public Input<string> OrganizationId { get; set; } = null!;

        public GetHelmRepositoryInvokeArgs()
        {
        }
        public static new GetHelmRepositoryInvokeArgs Empty => new GetHelmRepositoryInvokeArgs();
    }


    [OutputType]
    public sealed class GetHelmRepositoryResult
    {
        public readonly string Description;
        public readonly string Id;
        public readonly string Kind;
        public readonly string Name;
        public readonly string OrganizationId;
        public readonly string Url;

        [OutputConstructor]
        private GetHelmRepositoryResult(
            string description,

            string id,

            string kind,

            string name,

            string organizationId,

            string url)
        {
            Description = description;
            Id = id;
            Kind = kind;
            Name = name;
            OrganizationId = organizationId;
            Url = url;
        }
    }
}
