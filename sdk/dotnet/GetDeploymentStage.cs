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
    public static class GetDeploymentStage
    {
        /// <summary>
        /// ## # qovery.DeploymentStage (Data Source)
        /// 
        /// Provides a Qovery deployment stage resource. This can be used to create and manage Qovery deployment stages.
        /// </summary>
        public static Task<GetDeploymentStageResult> InvokeAsync(GetDeploymentStageArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDeploymentStageResult>("qovery:index/getDeploymentStage:getDeploymentStage", args ?? new GetDeploymentStageArgs(), options.WithDefaults());

        /// <summary>
        /// ## # qovery.DeploymentStage (Data Source)
        /// 
        /// Provides a Qovery deployment stage resource. This can be used to create and manage Qovery deployment stages.
        /// </summary>
        public static Output<GetDeploymentStageResult> Invoke(GetDeploymentStageInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDeploymentStageResult>("qovery:index/getDeploymentStage:getDeploymentStage", args ?? new GetDeploymentStageInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDeploymentStageArgs : global::Pulumi.InvokeArgs
    {
        [Input("description")]
        public string? Description { get; set; }

        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        [Input("isAfter")]
        public string? IsAfter { get; set; }

        [Input("isBefore")]
        public string? IsBefore { get; set; }

        public GetDeploymentStageArgs()
        {
        }
        public static new GetDeploymentStageArgs Empty => new GetDeploymentStageArgs();
    }

    public sealed class GetDeploymentStageInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        [Input("isAfter")]
        public Input<string>? IsAfter { get; set; }

        [Input("isBefore")]
        public Input<string>? IsBefore { get; set; }

        public GetDeploymentStageInvokeArgs()
        {
        }
        public static new GetDeploymentStageInvokeArgs Empty => new GetDeploymentStageInvokeArgs();
    }


    [OutputType]
    public sealed class GetDeploymentStageResult
    {
        public readonly string Description;
        public readonly string EnvironmentId;
        public readonly string Id;
        public readonly string IsAfter;
        public readonly string IsBefore;
        public readonly string Name;

        [OutputConstructor]
        private GetDeploymentStageResult(
            string description,

            string environmentId,

            string id,

            string isAfter,

            string isBefore,

            string name)
        {
            Description = description;
            EnvironmentId = environmentId;
            Id = id;
            IsAfter = isAfter;
            IsBefore = isBefore;
            Name = name;
        }
    }
}
