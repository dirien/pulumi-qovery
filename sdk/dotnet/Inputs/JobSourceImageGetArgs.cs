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

    public sealed class JobSourceImageGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("registryId", required: true)]
        public Input<string> RegistryId { get; set; } = null!;

        [Input("tag", required: true)]
        public Input<string> Tag { get; set; } = null!;

        public JobSourceImageGetArgs()
        {
        }
        public static new JobSourceImageGetArgs Empty => new JobSourceImageGetArgs();
    }
}