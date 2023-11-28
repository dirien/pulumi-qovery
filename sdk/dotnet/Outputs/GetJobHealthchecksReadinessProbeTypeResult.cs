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
    public sealed class GetJobHealthchecksReadinessProbeTypeResult
    {
        public readonly Outputs.GetJobHealthchecksReadinessProbeTypeExecResult? Exec;
        public readonly Outputs.GetJobHealthchecksReadinessProbeTypeGrpcResult? Grpc;
        public readonly Outputs.GetJobHealthchecksReadinessProbeTypeHttpResult? Http;
        public readonly Outputs.GetJobHealthchecksReadinessProbeTypeTcpResult? Tcp;

        [OutputConstructor]
        private GetJobHealthchecksReadinessProbeTypeResult(
            Outputs.GetJobHealthchecksReadinessProbeTypeExecResult? exec,

            Outputs.GetJobHealthchecksReadinessProbeTypeGrpcResult? grpc,

            Outputs.GetJobHealthchecksReadinessProbeTypeHttpResult? http,

            Outputs.GetJobHealthchecksReadinessProbeTypeTcpResult? tcp)
        {
            Exec = exec;
            Grpc = grpc;
            Http = http;
            Tcp = tcp;
        }
    }
}
