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
    public sealed class ApplicationStorage
    {
        /// <summary>
        /// Id of the storage.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Mount point of the storage for the application.
        /// </summary>
        public readonly string MountPoint;
        /// <summary>
        /// Size of the storage for the application in GB [1024MB = 1GB].
        /// 	- Must be: `&gt;= 1`.
        /// </summary>
        public readonly int Size;
        /// <summary>
        /// Type of the storage for the application.
        /// 	- Can be: `FAST_SSD`.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ApplicationStorage(
            string? id,

            string mountPoint,

            int size,

            string type)
        {
            Id = id;
            MountPoint = mountPoint;
            Size = size;
            Type = type;
        }
    }
}
