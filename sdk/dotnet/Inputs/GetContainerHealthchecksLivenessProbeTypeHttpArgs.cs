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

    public sealed class GetContainerHealthchecksLivenessProbeTypeHttpInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("path", required: true)]
        public Input<string> Path { get; set; } = null!;

        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        [Input("scheme", required: true)]
        public Input<string> Scheme { get; set; } = null!;

        public GetContainerHealthchecksLivenessProbeTypeHttpInputArgs()
        {
        }
        public static new GetContainerHealthchecksLivenessProbeTypeHttpInputArgs Empty => new GetContainerHealthchecksLivenessProbeTypeHttpInputArgs();
    }
}
