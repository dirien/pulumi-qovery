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

    public sealed class GetContainerHealthchecksLivenessProbeTypeHttpArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The path that the HTTP GET request. By default it is `/`
        /// </summary>
        [Input("path")]
        public string? Path { get; set; }

        /// <summary>
        /// The port number to try to connect to
        /// </summary>
        [Input("port", required: true)]
        public int Port { get; set; }

        /// <summary>
        /// if the HTTP GET request should be done in HTTP or HTTPS.
        /// </summary>
        [Input("scheme", required: true)]
        public string Scheme { get; set; } = null!;

        public GetContainerHealthchecksLivenessProbeTypeHttpArgs()
        {
        }
        public static new GetContainerHealthchecksLivenessProbeTypeHttpArgs Empty => new GetContainerHealthchecksLivenessProbeTypeHttpArgs();
    }
}
