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

    public sealed class GetJobSourceImageArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Job's image source name.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Job's image source registry ID.
        /// </summary>
        [Input("registryId", required: true)]
        public string RegistryId { get; set; } = null!;

        /// <summary>
        /// Job's image source tag.
        /// </summary>
        [Input("tag", required: true)]
        public string Tag { get; set; } = null!;

        public GetJobSourceImageArgs()
        {
        }
        public static new GetJobSourceImageArgs Empty => new GetJobSourceImageArgs();
    }
}
