// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace ediri.Qovery.Inputs
{

    public sealed class GetContainerHealthchecksReadinessProbeTypeGrpcArgs : global::Pulumi.InvokeArgs
    {
        [Input("port", required: true)]
        public int Port { get; set; }

        [Input("service")]
        public string? Service { get; set; }

        public GetContainerHealthchecksReadinessProbeTypeGrpcArgs()
        {
        }
        public static new GetContainerHealthchecksReadinessProbeTypeGrpcArgs Empty => new GetContainerHealthchecksReadinessProbeTypeGrpcArgs();
    }
}
