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

    public sealed class ContainerHealthchecksLivenessProbeTypeTcpArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Optional. If the host need to be different than localhost/pod ip
        /// </summary>
        [Input("host")]
        public Input<string>? Host { get; set; }

        /// <summary>
        /// The port number to try to connect to
        /// </summary>
        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        public ContainerHealthchecksLivenessProbeTypeTcpArgs()
        {
        }
        public static new ContainerHealthchecksLivenessProbeTypeTcpArgs Empty => new ContainerHealthchecksLivenessProbeTypeTcpArgs();
    }
}
