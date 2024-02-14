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

    public sealed class ApplicationHealthchecksReadinessProbeTypeGrpcGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The port number to try to connect to
        /// </summary>
        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        /// <summary>
        /// The grpc service to connect to. It needs to implement grpc health protocol. https://kubernetes.io/blog/2018/10/01/health-checking-grpc-servers-on-kubernetes/#introducing-grpc-health-probe
        /// </summary>
        [Input("service")]
        public Input<string>? Service { get; set; }

        public ApplicationHealthchecksReadinessProbeTypeGrpcGetArgs()
        {
        }
        public static new ApplicationHealthchecksReadinessProbeTypeGrpcGetArgs Empty => new ApplicationHealthchecksReadinessProbeTypeGrpcGetArgs();
    }
}
