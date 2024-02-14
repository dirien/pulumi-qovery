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
    public sealed class GetApplicationHealthchecksReadinessProbeResult
    {
        /// <summary>
        /// Number of time the an ok probe should fail before declaring it as failed
        /// </summary>
        public readonly int FailureThreshold;
        /// <summary>
        /// Number of seconds to wait before the first execution of the probe to be trigerred
        /// </summary>
        public readonly int InitialDelaySeconds;
        /// <summary>
        /// Number of seconds before each execution of the probe
        /// </summary>
        public readonly int PeriodSeconds;
        /// <summary>
        /// Number of time the probe should success before declaring a failed probe as ok again
        /// </summary>
        public readonly int SuccessThreshold;
        /// <summary>
        /// Number of seconds within which the check need to respond before declaring it as a failure
        /// </summary>
        public readonly int TimeoutSeconds;
        /// <summary>
        /// Kind of check to run for this probe. There can only be one configured at a time
        /// </summary>
        public readonly Outputs.GetApplicationHealthchecksReadinessProbeTypeResult Type;

        [OutputConstructor]
        private GetApplicationHealthchecksReadinessProbeResult(
            int failureThreshold,

            int initialDelaySeconds,

            int periodSeconds,

            int successThreshold,

            int timeoutSeconds,

            Outputs.GetApplicationHealthchecksReadinessProbeTypeResult type)
        {
            FailureThreshold = failureThreshold;
            InitialDelaySeconds = initialDelaySeconds;
            PeriodSeconds = periodSeconds;
            SuccessThreshold = successThreshold;
            TimeoutSeconds = timeoutSeconds;
            Type = type;
        }
    }
}
