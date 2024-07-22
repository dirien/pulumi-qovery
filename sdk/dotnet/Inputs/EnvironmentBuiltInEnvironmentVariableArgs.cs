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

    public sealed class EnvironmentBuiltInEnvironmentVariableArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description of the environment variable.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Id of the environment variable.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Key of the environment variable.
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        /// <summary>
        /// Value of the environment variable.
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public EnvironmentBuiltInEnvironmentVariableArgs()
        {
        }
        public static new EnvironmentBuiltInEnvironmentVariableArgs Empty => new EnvironmentBuiltInEnvironmentVariableArgs();
    }
}
