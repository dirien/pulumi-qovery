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
        /// <summary>
        /// Configuration for the liveness probe, in order to know when your service is working correctly. Failing the probe means your service being killed/ask to be restarted.
        /// </summary>
        [Input("livenessProbe")]
        public Input<Inputs.ContainerHealthchecksLivenessProbeArgs>? LivenessProbe { get; set; }

        /// <summary>
        /// Configuration for the readiness probe, in order to know when your service is ready to receive traffic. Failing the probe means your service will stop receiving traffic.
        /// </summary>
        [Input("readinessProbe")]
        public Input<Inputs.ContainerHealthchecksReadinessProbeArgs>? ReadinessProbe { get; set; }

        public ContainerHealthchecksArgs()
        {
        }
        public static new ContainerHealthchecksArgs Empty => new ContainerHealthchecksArgs();
    }
}
