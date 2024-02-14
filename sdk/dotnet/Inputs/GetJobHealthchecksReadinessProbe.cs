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

    public sealed class GetJobHealthchecksReadinessProbeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Number of time the an ok probe should fail before declaring it as failed
        /// </summary>
        [Input("failureThreshold", required: true)]
        public int FailureThreshold { get; set; }

        /// <summary>
        /// Number of seconds to wait before the first execution of the probe to be trigerred
        /// </summary>
        [Input("initialDelaySeconds", required: true)]
        public int InitialDelaySeconds { get; set; }

        /// <summary>
        /// Number of seconds before each execution of the probe
        /// </summary>
        [Input("periodSeconds", required: true)]
        public int PeriodSeconds { get; set; }

        /// <summary>
        /// Number of time the probe should success before declaring a failed probe as ok again
        /// </summary>
        [Input("successThreshold", required: true)]
        public int SuccessThreshold { get; set; }

        /// <summary>
        /// Number of seconds within which the check need to respond before declaring it as a failure
        /// </summary>
        [Input("timeoutSeconds", required: true)]
        public int TimeoutSeconds { get; set; }

        /// <summary>
        /// Kind of check to run for this probe. There can only be one configured at a time
        /// </summary>
        [Input("type", required: true)]
        public Inputs.GetJobHealthchecksReadinessProbeTypeArgs Type { get; set; } = null!;

        public GetJobHealthchecksReadinessProbeArgs()
        {
        }
        public static new GetJobHealthchecksReadinessProbeArgs Empty => new GetJobHealthchecksReadinessProbeArgs();
    }
}
