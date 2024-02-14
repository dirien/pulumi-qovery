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
    public sealed class HelmValuesOverrideFile
    {
        /// <summary>
        /// YAML file from a git repository
        /// </summary>
        public readonly Outputs.HelmValuesOverrideFileGitRepository? GitRepository;
        /// <summary>
        /// Raw YAML files
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.HelmValuesOverrideFileRaw>? Raw;

        [OutputConstructor]
        private HelmValuesOverrideFile(
            Outputs.HelmValuesOverrideFileGitRepository? gitRepository,

            ImmutableDictionary<string, Outputs.HelmValuesOverrideFileRaw>? raw)
        {
            GitRepository = gitRepository;
            Raw = raw;
        }
    }
}
