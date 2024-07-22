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

    public sealed class GetClusterFeaturesKarpenterArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The default architecture of service
        /// </summary>
        [Input("defaultServiceArchitecture", required: true)]
        public string DefaultServiceArchitecture { get; set; } = null!;

        [Input("diskSizeInGib", required: true)]
        public int DiskSizeInGib { get; set; }

        /// <summary>
        /// Enable spot instances
        /// </summary>
        [Input("spotEnabled", required: true)]
        public bool SpotEnabled { get; set; }

        public GetClusterFeaturesKarpenterArgs()
        {
        }
        public static new GetClusterFeaturesKarpenterArgs Empty => new GetClusterFeaturesKarpenterArgs();
    }
}
