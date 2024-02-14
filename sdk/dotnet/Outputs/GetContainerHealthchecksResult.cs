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
    public sealed class GetContainerHealthchecksResult
    {
        /// <summary>
        /// Configuration for the liveness probe, in order to know when your service is working correctly. Failing the probe means your service being killed/ask to be restarted.
        /// </summary>
        public readonly Outputs.GetContainerHealthchecksLivenessProbeResult? LivenessProbe;
        /// <summary>
        /// Configuration for the readiness probe, in order to know when your service is ready to receive traffic. Failing the probe means your service will stop receiving traffic.
        /// </summary>
        public readonly Outputs.GetContainerHealthchecksReadinessProbeResult? ReadinessProbe;

        [OutputConstructor]
        private GetContainerHealthchecksResult(
            Outputs.GetContainerHealthchecksLivenessProbeResult? livenessProbe,

            Outputs.GetContainerHealthchecksReadinessProbeResult? readinessProbe)
        {
            LivenessProbe = livenessProbe;
            ReadinessProbe = readinessProbe;
        }
    }
}
