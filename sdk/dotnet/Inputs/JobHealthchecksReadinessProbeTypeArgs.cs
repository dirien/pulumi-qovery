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

    public sealed class JobHealthchecksReadinessProbeTypeArgs : global::Pulumi.ResourceArgs
    {
        [Input("exec")]
        public Input<Inputs.JobHealthchecksReadinessProbeTypeExecArgs>? Exec { get; set; }

        [Input("grpc")]
        public Input<Inputs.JobHealthchecksReadinessProbeTypeGrpcArgs>? Grpc { get; set; }

        [Input("http")]
        public Input<Inputs.JobHealthchecksReadinessProbeTypeHttpArgs>? Http { get; set; }

        [Input("tcp")]
        public Input<Inputs.JobHealthchecksReadinessProbeTypeTcpArgs>? Tcp { get; set; }

        public JobHealthchecksReadinessProbeTypeArgs()
        {
        }
        public static new JobHealthchecksReadinessProbeTypeArgs Empty => new JobHealthchecksReadinessProbeTypeArgs();
    }
}