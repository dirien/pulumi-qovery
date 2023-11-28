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
    public sealed class ContainerHealthchecksLivenessProbeType
    {
        public readonly Outputs.ContainerHealthchecksLivenessProbeTypeExec? Exec;
        public readonly Outputs.ContainerHealthchecksLivenessProbeTypeGrpc? Grpc;
        public readonly Outputs.ContainerHealthchecksLivenessProbeTypeHttp? Http;
        public readonly Outputs.ContainerHealthchecksLivenessProbeTypeTcp? Tcp;

        [OutputConstructor]
        private ContainerHealthchecksLivenessProbeType(
            Outputs.ContainerHealthchecksLivenessProbeTypeExec? exec,

            Outputs.ContainerHealthchecksLivenessProbeTypeGrpc? grpc,

            Outputs.ContainerHealthchecksLivenessProbeTypeHttp? http,

            Outputs.ContainerHealthchecksLivenessProbeTypeTcp? tcp)
        {
            Exec = exec;
            Grpc = grpc;
            Http = http;
            Tcp = tcp;
        }
    }
}