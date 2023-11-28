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

    public sealed class ContainerHealthchecksArgs : global::Pulumi.ResourceArgs
    {
        [Input("livenessProbe")]
        public Input<Inputs.ContainerHealthchecksLivenessProbeArgs>? LivenessProbe { get; set; }

        [Input("readinessProbe")]
        public Input<Inputs.ContainerHealthchecksReadinessProbeArgs>? ReadinessProbe { get; set; }

        public ContainerHealthchecksArgs()
        {
        }
        public static new ContainerHealthchecksArgs Empty => new ContainerHealthchecksArgs();
    }
}