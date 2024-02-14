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

    public sealed class GetContainerStorageInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Id of the storage.
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        /// <summary>
        /// Mount point of the storage for the container.
        /// </summary>
        [Input("mountPoint", required: true)]
        public Input<string> MountPoint { get; set; } = null!;

        /// <summary>
        /// Size of the storage for the container in GB [1024MB = 1GB].
        /// 	- Must be: `&gt;= 1`.
        /// </summary>
        [Input("size", required: true)]
        public Input<int> Size { get; set; } = null!;

        /// <summary>
        /// Type of the storage for the container.
        /// 	- Can be: `FAST_SSD`.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public GetContainerStorageInputArgs()
        {
        }
        public static new GetContainerStorageInputArgs Empty => new GetContainerStorageInputArgs();
    }
}
