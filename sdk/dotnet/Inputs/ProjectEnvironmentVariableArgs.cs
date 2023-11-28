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

    public sealed class ProjectEnvironmentVariableArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Id of the environment variable.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Key of the environment variable.
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// Value of the environment variable.
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public ProjectEnvironmentVariableArgs()
        {
        }
        public static new ProjectEnvironmentVariableArgs Empty => new ProjectEnvironmentVariableArgs();
    }
}