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

    public sealed class JobHealthchecksReadinessProbeTypeTcpGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("host")]
        public Input<string>? Host { get; set; }

        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        public JobHealthchecksReadinessProbeTypeTcpGetArgs()
        {
        }
        public static new JobHealthchecksReadinessProbeTypeTcpGetArgs Empty => new JobHealthchecksReadinessProbeTypeTcpGetArgs();
    }
}
