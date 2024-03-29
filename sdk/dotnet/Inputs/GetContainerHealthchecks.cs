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

    public sealed class GetContainerHealthchecksArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Configuration for the liveness probe, in order to know when your service is working correctly. Failing the probe means your service being killed/ask to be restarted.
        /// </summary>
        [Input("livenessProbe")]
        public Inputs.GetContainerHealthchecksLivenessProbeArgs? LivenessProbe { get; set; }

        /// <summary>
        /// Configuration for the readiness probe, in order to know when your service is ready to receive traffic. Failing the probe means your service will stop receiving traffic.
        /// </summary>
        [Input("readinessProbe")]
        public Inputs.GetContainerHealthchecksReadinessProbeArgs? ReadinessProbe { get; set; }

        public GetContainerHealthchecksArgs()
        {
        }
        public static new GetContainerHealthchecksArgs Empty => new GetContainerHealthchecksArgs();
    }
}
