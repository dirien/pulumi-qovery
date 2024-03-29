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
    public sealed class JobScheduleCronjobCommand
    {
        /// <summary>
        /// List of arguments of this job.
        /// </summary>
        public readonly ImmutableArray<string> Arguments;
        /// <summary>
        /// Entrypoint of the job.
        /// </summary>
        public readonly string? Entrypoint;

        [OutputConstructor]
        private JobScheduleCronjobCommand(
            ImmutableArray<string> arguments,

            string? entrypoint)
        {
            Arguments = arguments;
            Entrypoint = entrypoint;
        }
    }
}
