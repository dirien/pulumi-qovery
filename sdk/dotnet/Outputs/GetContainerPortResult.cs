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
    public sealed class GetContainerPortResult
    {
        /// <summary>
        /// External port of the container.
        /// 	- Required if: `ports.publicly_accessible=true`.
        /// 	- Must be: `&gt;= 1` and `&lt;= 65535`.
        /// </summary>
        public readonly int ExternalPort;
        /// <summary>
        /// Id of the port.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Internal port of the container.
        /// 	- Must be: `&gt;= 1` and `&lt;= 65535`.
        /// </summary>
        public readonly int InternalPort;
        /// <summary>
        /// If this port will be used for the root domain
        /// </summary>
        public readonly bool IsDefault;
        /// <summary>
        /// Name of the port.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Protocol used for the port of the container.
        /// 	- Can be: `GRPC`, `HTTP`, `TCP`, `UDP`.
        /// 	- Default: `HTTP`.
        /// </summary>
        public readonly string Protocol;
        /// <summary>
        /// Specify if the port is exposed to the world or not for this container.
        /// </summary>
        public readonly bool PubliclyAccessible;

        [OutputConstructor]
        private GetContainerPortResult(
            int externalPort,

            string id,

            int internalPort,

            bool isDefault,

            string name,

            string protocol,

            bool publiclyAccessible)
        {
            ExternalPort = externalPort;
            Id = id;
            InternalPort = internalPort;
            IsDefault = isDefault;
            Name = name;
            Protocol = protocol;
            PubliclyAccessible = publiclyAccessible;
        }
    }
}
