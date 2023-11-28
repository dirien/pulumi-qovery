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

    public sealed class ContainerPortArgs : global::Pulumi.ResourceArgs
    {
        [Input("externalPort")]
        public Input<int>? ExternalPort { get; set; }

        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("internalPort", required: true)]
        public Input<int> InternalPort { get; set; } = null!;

        [Input("isDefault", required: true)]
        public Input<bool> IsDefault { get; set; } = null!;

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        [Input("publiclyAccessible", required: true)]
        public Input<bool> PubliclyAccessible { get; set; } = null!;

        public ContainerPortArgs()
        {
        }
        public static new ContainerPortArgs Empty => new ContainerPortArgs();
    }
}