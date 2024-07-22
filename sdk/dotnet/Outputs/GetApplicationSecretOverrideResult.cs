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
    public sealed class GetApplicationSecretOverrideResult
    {
        /// <summary>
        /// Description of the secret override.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Id of the secret override.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Name of the secret override.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// Value of the secret override.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private GetApplicationSecretOverrideResult(
            string description,

            string id,

            string key,

            string value)
        {
            Description = description;
            Id = id;
            Key = key;
            Value = value;
        }
    }
}
