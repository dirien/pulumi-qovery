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

    public sealed class GetEnvironmentSecretArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Id of the secret.
        /// </summary>
        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        /// <summary>
        /// Key of the secret.
        /// </summary>
        [Input("key", required: true)]
        public string Key { get; set; } = null!;

        [Input("value", required: true)]
        private string? _value;

        /// <summary>
        /// Value of the secret.
        /// </summary>
        public string? Value
        {
            get => _value;
            set => _value = value;
        }

        public GetEnvironmentSecretArgs()
        {
        }
        public static new GetEnvironmentSecretArgs Empty => new GetEnvironmentSecretArgs();
    }
}
