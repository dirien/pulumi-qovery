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
    public sealed class ContainerHealthchecksReadinessProbeTypeGrpc
    {
        /// <summary>
        /// The port number to try to connect to
        /// </summary>
        public readonly int Port;
        /// <summary>
        /// The grpc service to connect to. It needs to implement grpc health protocol. https://kubernetes.io/blog/2018/10/01/health-checking-grpc-servers-on-kubernetes/#introducing-grpc-health-probe
        /// </summary>
        public readonly string? Service;

        [OutputConstructor]
        private ContainerHealthchecksReadinessProbeTypeGrpc(
            int port,

            string? service)
        {
            Port = port;
            Service = service;
        }
    }
}
