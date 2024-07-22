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
    public sealed class GetClusterFeaturesResult
    {
        /// <summary>
        /// Network configuration if you want to install qovery on an existing VPC
        /// </summary>
        public readonly Outputs.GetClusterFeaturesExistingVpcResult? ExistingVpc;
        /// <summary>
        /// Karpenter parameters if you want to use Karpenter on an EKS cluster
        /// </summary>
        public readonly Outputs.GetClusterFeaturesKarpenterResult? Karpenter;
        /// <summary>
        /// Static IP (AWS only) [NOTE: can't be updated after creation].
        /// 	- Default: `false`.
        /// </summary>
        public readonly bool StaticIp;
        /// <summary>
        /// Custom VPC subnet (AWS only) [NOTE: can't be updated after creation].
        /// 	- Default: `10.0.0.0/16`.
        /// </summary>
        public readonly string VpcSubnet;

        [OutputConstructor]
        private GetClusterFeaturesResult(
            Outputs.GetClusterFeaturesExistingVpcResult? existingVpc,

            Outputs.GetClusterFeaturesKarpenterResult? karpenter,

            bool staticIp,

            string vpcSubnet)
        {
            ExistingVpc = existingVpc;
            Karpenter = karpenter;
            StaticIp = staticIp;
            VpcSubnet = vpcSubnet;
        }
    }
}
