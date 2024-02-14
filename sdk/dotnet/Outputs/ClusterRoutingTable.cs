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
    public sealed class ClusterRoutingTable
    {
        /// <summary>
        /// Description of the route.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Destination of the route.
        /// </summary>
        public readonly string Destination;
        /// <summary>
        /// Target of the route.
        /// </summary>
        public readonly string Target;

        [OutputConstructor]
        private ClusterRoutingTable(
            string description,

            string destination,

            string target)
        {
            Description = description;
            Destination = destination;
            Target = target;
        }
    }
}
