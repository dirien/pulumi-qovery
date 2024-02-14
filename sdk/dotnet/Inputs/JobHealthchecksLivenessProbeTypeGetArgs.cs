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

    public sealed class JobHealthchecksLivenessProbeTypeGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Check that the given command return an exit 0. Binary should be present in the image
        /// </summary>
        [Input("exec")]
        public Input<Inputs.JobHealthchecksLivenessProbeTypeExecGetArgs>? Exec { get; set; }

        /// <summary>
        /// Check that the given port respond to GRPC call
        /// </summary>
        [Input("grpc")]
        public Input<Inputs.JobHealthchecksLivenessProbeTypeGrpcGetArgs>? Grpc { get; set; }

        /// <summary>
        /// Check that the given port respond to HTTP call (should return a 2xx response code)
        /// </summary>
        [Input("http")]
        public Input<Inputs.JobHealthchecksLivenessProbeTypeHttpGetArgs>? Http { get; set; }

        /// <summary>
        /// Check that the given port accepting connection
        /// </summary>
        [Input("tcp")]
        public Input<Inputs.JobHealthchecksLivenessProbeTypeTcpGetArgs>? Tcp { get; set; }

        public JobHealthchecksLivenessProbeTypeGetArgs()
        {
        }
        public static new JobHealthchecksLivenessProbeTypeGetArgs Empty => new JobHealthchecksLivenessProbeTypeGetArgs();
    }
}
