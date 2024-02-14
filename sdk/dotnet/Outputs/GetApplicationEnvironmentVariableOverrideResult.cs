// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace ediri.Qovery.Outputs
{

    [OutputType]
    public sealed class GetApplicationEnvironmentVariableOverrideResult
    {
        /// <summary>
        /// Id of the environment variable override.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Name of the environment variable override.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// Value of the environment variable override.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private GetApplicationEnvironmentVariableOverrideResult(
            string id,

            string key,

            string value)
        {
            Id = id;
            Key = key;
            Value = value;
        }
    }
}
