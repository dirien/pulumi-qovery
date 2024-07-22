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

    public sealed class GetJobEnvironmentVariableAliasInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description of the environment variable.
        /// </summary>
        [Input("description", required: true)]
        public Input<string> Description { get; set; } = null!;

        /// <summary>
        /// Id of the environment variable alias.
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        /// <summary>
        /// Name of the environment variable alias.
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// Name of the variable to alias.
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public GetJobEnvironmentVariableAliasInputArgs()
        {
        }
        public static new GetJobEnvironmentVariableAliasInputArgs Empty => new GetJobEnvironmentVariableAliasInputArgs();
    }
}
