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

    public sealed class GetContainerHealthchecksReadinessProbeArgs : global::Pulumi.InvokeArgs
    {
        [Input("failureThreshold", required: true)]
        public int FailureThreshold { get; set; }

        [Input("initialDelaySeconds", required: true)]
        public int InitialDelaySeconds { get; set; }

        [Input("periodSeconds", required: true)]
        public int PeriodSeconds { get; set; }

        [Input("successThreshold", required: true)]
        public int SuccessThreshold { get; set; }

        [Input("timeoutSeconds", required: true)]
        public int TimeoutSeconds { get; set; }

        [Input("type", required: true)]
        public Inputs.GetContainerHealthchecksReadinessProbeTypeArgs Type { get; set; } = null!;

        public GetContainerHealthchecksReadinessProbeArgs()
        {
        }
        public static new GetContainerHealthchecksReadinessProbeArgs Empty => new GetContainerHealthchecksReadinessProbeArgs();
    }
}
