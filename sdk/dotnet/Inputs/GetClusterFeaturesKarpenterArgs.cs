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

    public sealed class GetClusterFeaturesKarpenterInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The default architecture of service
        /// </summary>
        [Input("defaultServiceArchitecture", required: true)]
        public Input<string> DefaultServiceArchitecture { get; set; } = null!;

        [Input("diskSizeInGib", required: true)]
        public Input<int> DiskSizeInGib { get; set; } = null!;

        /// <summary>
        /// Enable spot instances
        /// </summary>
        [Input("spotEnabled", required: true)]
        public Input<bool> SpotEnabled { get; set; } = null!;

        public GetClusterFeaturesKarpenterInputArgs()
        {
        }
        public static new GetClusterFeaturesKarpenterInputArgs Empty => new GetClusterFeaturesKarpenterInputArgs();
    }
}
