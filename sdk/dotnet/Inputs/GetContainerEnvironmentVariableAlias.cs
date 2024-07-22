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

    public sealed class GetContainerEnvironmentVariableAliasArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Description of the environment variable alias.
        /// </summary>
        [Input("description", required: true)]
        public string Description { get; set; } = null!;

        /// <summary>
        /// Id of the environment variable alias.
        /// </summary>
        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        /// <summary>
        /// Name of the environment variable alias.
        /// </summary>
        [Input("key", required: true)]
        public string Key { get; set; } = null!;

        /// <summary>
        /// Name of the variable to alias.
        /// </summary>
        [Input("value", required: true)]
        public string Value { get; set; } = null!;

        public GetContainerEnvironmentVariableAliasArgs()
        {
        }
        public static new GetContainerEnvironmentVariableAliasArgs Empty => new GetContainerEnvironmentVariableAliasArgs();
    }
}
