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
    public sealed class ClusterFeatures
    {
        /// <summary>
        /// Static IP (AWS only) [NOTE: can't be updated after creation].
        /// 	- Default: `false`.
        /// </summary>
        public readonly bool? StaticIp;
        /// <summary>
        /// Custom VPC subnet (AWS only) [NOTE: can't be updated after creation].
        /// 	- Default: `10.0.0.0/16`.
        /// </summary>
        public readonly string? VpcSubnet;

        [OutputConstructor]
        private ClusterFeatures(
            bool? staticIp,

            string? vpcSubnet)
        {
            StaticIp = staticIp;
            VpcSubnet = vpcSubnet;
        }
    }
}
