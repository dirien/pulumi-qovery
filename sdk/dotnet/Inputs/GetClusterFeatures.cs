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

    public sealed class GetClusterFeaturesArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Network configuration if you want to install qovery on an existing VPC
        /// </summary>
        [Input("existingVpc")]
        public Inputs.GetClusterFeaturesExistingVpcArgs? ExistingVpc { get; set; }

        /// <summary>
        /// Static IP (AWS only) [NOTE: can't be updated after creation].
        /// 	- Default: `false`.
        /// </summary>
        [Input("staticIp", required: true)]
        public bool StaticIp { get; set; }

        /// <summary>
        /// Custom VPC subnet (AWS only) [NOTE: can't be updated after creation].
        /// 	- Default: `10.0.0.0/16`.
        /// </summary>
        [Input("vpcSubnet", required: true)]
        public string VpcSubnet { get; set; } = null!;

        public GetClusterFeaturesArgs()
        {
        }
        public static new GetClusterFeaturesArgs Empty => new GetClusterFeaturesArgs();
    }
}
