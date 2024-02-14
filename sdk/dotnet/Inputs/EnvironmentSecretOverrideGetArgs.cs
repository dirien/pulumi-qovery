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

    public sealed class EnvironmentSecretOverrideGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Id of the secret override.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Name of the secret override.
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        [Input("value", required: true)]
        private Input<string>? _value;

        /// <summary>
        /// Value of the secret override.
        /// </summary>
        public Input<string>? Value
        {
            get => _value;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _value = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public EnvironmentSecretOverrideGetArgs()
        {
        }
        public static new EnvironmentSecretOverrideGetArgs Empty => new EnvironmentSecretOverrideGetArgs();
    }
}
