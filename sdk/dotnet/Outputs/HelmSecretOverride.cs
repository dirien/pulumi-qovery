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
    public sealed class HelmSecretOverride
    {
        public readonly string? Id;
        public readonly string Key;
        public readonly string Value;

        [OutputConstructor]
        private HelmSecretOverride(
            string? id,

            string key,

            string value)
        {
            Id = id;
            Key = key;
            Value = value;
        }
    }
}
