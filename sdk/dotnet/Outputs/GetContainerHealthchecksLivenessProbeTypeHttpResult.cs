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
    public sealed class GetContainerHealthchecksLivenessProbeTypeHttpResult
    {
        /// <summary>
        /// The path that the HTTP GET request. By default it is `/`
        /// </summary>
        public readonly string? Path;
        /// <summary>
        /// The port number to try to connect to
        /// </summary>
        public readonly int Port;
        /// <summary>
        /// if the HTTP GET request should be done in HTTP or HTTPS.
        /// </summary>
        public readonly string Scheme;

        [OutputConstructor]
        private GetContainerHealthchecksLivenessProbeTypeHttpResult(
            string? path,

            int port,

            string scheme)
        {
            Path = path;
            Port = port;
            Scheme = scheme;
        }
    }
}
