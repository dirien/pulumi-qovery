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

    public sealed class ApplicationPortGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// External port of the application.
        /// 	- Required if: `ports.publicly_accessible=true`.
        /// 	- Must be: `&gt;= 1` and `&lt;= 65535`.
        /// </summary>
        [Input("externalPort")]
        public Input<int>? ExternalPort { get; set; }

        /// <summary>
        /// Id of the port.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Internal port of the application.
        /// 	- Must be: `&gt;= 1` and `&lt;= 65535`.
        /// </summary>
        [Input("internalPort", required: true)]
        public Input<int> InternalPort { get; set; } = null!;

        /// <summary>
        /// If this port will be used for the root domain
        /// </summary>
        [Input("isDefault", required: true)]
        public Input<bool> IsDefault { get; set; } = null!;

        /// <summary>
        /// Name of the port.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Protocol used for the port of the application.
        /// 	- Can be: `GRPC`, `HTTP`, `TCP`, `UDP`.
        /// 	- Default: `HTTP`.
        /// </summary>
        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        /// <summary>
        /// Specify if the port is exposed to the world or not for this application.
        /// </summary>
        [Input("publiclyAccessible", required: true)]
        public Input<bool> PubliclyAccessible { get; set; } = null!;

        public ApplicationPortGetArgs()
        {
        }
        public static new ApplicationPortGetArgs Empty => new ApplicationPortGetArgs();
    }
}
