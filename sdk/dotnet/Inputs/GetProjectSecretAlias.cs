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

    public sealed class GetProjectSecretAliasArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Id of the secret alias.
        /// </summary>
        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        /// <summary>
        /// Name of the secret alias.
        /// </summary>
        [Input("key", required: true)]
        public string Key { get; set; } = null!;

        /// <summary>
        /// Name of the secret to alias.
        /// </summary>
        [Input("value", required: true)]
        public string Value { get; set; } = null!;

        public GetProjectSecretAliasArgs()
        {
        }
        public static new GetProjectSecretAliasArgs Empty => new GetProjectSecretAliasArgs();
    }
}