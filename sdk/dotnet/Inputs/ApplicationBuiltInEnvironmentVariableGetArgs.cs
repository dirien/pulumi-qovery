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

    public sealed class ApplicationBuiltInEnvironmentVariableGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("key")]
        public Input<string>? Key { get; set; }

        [Input("value")]
        public Input<string>? Value { get; set; }

        public ApplicationBuiltInEnvironmentVariableGetArgs()
        {
        }
        public static new ApplicationBuiltInEnvironmentVariableGetArgs Empty => new ApplicationBuiltInEnvironmentVariableGetArgs();
    }
}
