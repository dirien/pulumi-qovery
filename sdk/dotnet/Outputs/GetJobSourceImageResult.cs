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
    public sealed class GetJobSourceImageResult
    {
        /// <summary>
        /// Job's image source name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Job's image source registry ID.
        /// </summary>
        public readonly string RegistryId;
        /// <summary>
        /// Job's image source tag.
        /// </summary>
        public readonly string Tag;

        [OutputConstructor]
        private GetJobSourceImageResult(
            string name,

            string registryId,

            string tag)
        {
            Name = name;
            RegistryId = registryId;
            Tag = tag;
        }
    }
}
