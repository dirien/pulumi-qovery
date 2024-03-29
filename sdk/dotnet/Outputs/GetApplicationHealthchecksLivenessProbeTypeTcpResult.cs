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
    public sealed class GetApplicationHealthchecksLivenessProbeTypeTcpResult
    {
        /// <summary>
        /// Optional. If the host need to be different than localhost/pod ip
        /// </summary>
        public readonly string? Host;
        /// <summary>
        /// The port number to try to connect to
        /// </summary>
        public readonly int Port;

        [OutputConstructor]
        private GetApplicationHealthchecksLivenessProbeTypeTcpResult(
            string? host,

            int port)
        {
            Host = host;
            Port = port;
        }
    }
}
