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
    public static class GetGitToken
    {
        /// <summary>
        /// ## # qovery.GitToken (Data Source)
        /// 
        /// Provides a Qovery git token resource. This can be used to create and manage Qovery git token.
        /// </summary>
        public static Task<GetGitTokenResult> InvokeAsync(GetGitTokenArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetGitTokenResult>("qovery:index/getGitToken:getGitToken", args ?? new GetGitTokenArgs(), options.WithDefaults());

        /// <summary>
        /// ## # qovery.GitToken (Data Source)
        /// 
        /// Provides a Qovery git token resource. This can be used to create and manage Qovery git token.
        /// </summary>
        public static Output<GetGitTokenResult> Invoke(GetGitTokenInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetGitTokenResult>("qovery:index/getGitToken:getGitToken", args ?? new GetGitTokenInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetGitTokenArgs : global::Pulumi.InvokeArgs
    {
        [Input("bitbucketWorkspace")]
        public string? BitbucketWorkspace { get; set; }

        [Input("description")]
        public string? Description { get; set; }

        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        public GetGitTokenArgs()
        {
        }
        public static new GetGitTokenArgs Empty => new GetGitTokenArgs();
    }

    public sealed class GetGitTokenInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("bitbucketWorkspace")]
        public Input<string>? BitbucketWorkspace { get; set; }

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        public GetGitTokenInvokeArgs()
        {
        }
        public static new GetGitTokenInvokeArgs Empty => new GetGitTokenInvokeArgs();
    }


    [OutputType]
    public sealed class GetGitTokenResult
    {
        public readonly string BitbucketWorkspace;
        public readonly string Description;
        public readonly string Id;
        public readonly string Name;
        public readonly string OrganizationId;
        public readonly string Token;
        public readonly string Type;

        [OutputConstructor]
        private GetGitTokenResult(
            string bitbucketWorkspace,

            string description,

            string id,

            string name,

            string organizationId,

            string token,

            string type)
        {
            BitbucketWorkspace = bitbucketWorkspace;
            Description = description;
            Id = id;
            Name = name;
            OrganizationId = organizationId;
            Token = token;
            Type = type;
        }
    }
}