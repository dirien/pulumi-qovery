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
    public sealed class ClusterFeaturesKarpenter
    {
        /// <summary>
        /// The default architecture of service
        /// </summary>
        public readonly string DefaultServiceArchitecture;
        public readonly int DiskSizeInGib;
        /// <summary>
        /// Enable spot instances
        /// </summary>
        public readonly bool SpotEnabled;

        [OutputConstructor]
        private ClusterFeaturesKarpenter(
            string defaultServiceArchitecture,

            int diskSizeInGib,

            bool spotEnabled)
        {
            DefaultServiceArchitecture = defaultServiceArchitecture;
            DiskSizeInGib = diskSizeInGib;
            SpotEnabled = spotEnabled;
        }
    }
}
