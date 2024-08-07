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
    public sealed class GetHelmValuesOverrideFileResult
    {
        /// <summary>
        /// YAML file from a git repository
        /// </summary>
        public readonly Outputs.GetHelmValuesOverrideFileGitRepositoryResult? GitRepository;
        /// <summary>
        /// Raw YAML files
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.GetHelmValuesOverrideFileRawResult>? Raw;

        [OutputConstructor]
        private GetHelmValuesOverrideFileResult(
            Outputs.GetHelmValuesOverrideFileGitRepositoryResult? gitRepository,

            ImmutableDictionary<string, Outputs.GetHelmValuesOverrideFileRawResult>? raw)
        {
            GitRepository = gitRepository;
            Raw = raw;
        }
    }
}
