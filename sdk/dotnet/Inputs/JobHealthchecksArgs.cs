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

    public sealed class JobHealthchecksArgs : global::Pulumi.ResourceArgs
    {
        [Input("livenessProbe")]
        public Input<Inputs.JobHealthchecksLivenessProbeArgs>? LivenessProbe { get; set; }

        [Input("readinessProbe")]
        public Input<Inputs.JobHealthchecksReadinessProbeArgs>? ReadinessProbe { get; set; }

        public JobHealthchecksArgs()
        {
        }
        public static new JobHealthchecksArgs Empty => new JobHealthchecksArgs();
    }
}