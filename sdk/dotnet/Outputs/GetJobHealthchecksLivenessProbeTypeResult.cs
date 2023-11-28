// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace ediri.Qovery.Outputs
{

    [OutputType]
    public sealed class GetJobHealthchecksLivenessProbeTypeResult
    {
        public readonly Outputs.GetJobHealthchecksLivenessProbeTypeExecResult? Exec;
        public readonly Outputs.GetJobHealthchecksLivenessProbeTypeGrpcResult? Grpc;
        public readonly Outputs.GetJobHealthchecksLivenessProbeTypeHttpResult? Http;
        public readonly Outputs.GetJobHealthchecksLivenessProbeTypeTcpResult? Tcp;

        [OutputConstructor]
        private GetJobHealthchecksLivenessProbeTypeResult(
            Outputs.GetJobHealthchecksLivenessProbeTypeExecResult? exec,

            Outputs.GetJobHealthchecksLivenessProbeTypeGrpcResult? grpc,

            Outputs.GetJobHealthchecksLivenessProbeTypeHttpResult? http,

            Outputs.GetJobHealthchecksLivenessProbeTypeTcpResult? tcp)
        {
            Exec = exec;
            Grpc = grpc;
            Http = http;
            Tcp = tcp;
        }
    }
}