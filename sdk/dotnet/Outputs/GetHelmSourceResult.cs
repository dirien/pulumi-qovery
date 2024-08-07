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
    public sealed class GetHelmSourceResult
    {
        /// <summary>
        /// Git repository
        /// </summary>
        public readonly Outputs.GetHelmSourceGitRepositoryResult? GitRepository;
        /// <summary>
        /// Helm repositories can be private or public
        /// </summary>
        public readonly Outputs.GetHelmSourceHelmRepositoryResult? HelmRepository;

        [OutputConstructor]
        private GetHelmSourceResult(
            Outputs.GetHelmSourceGitRepositoryResult? gitRepository,

            Outputs.GetHelmSourceHelmRepositoryResult? helmRepository)
        {
            GitRepository = gitRepository;
            HelmRepository = helmRepository;
        }
    }
}
