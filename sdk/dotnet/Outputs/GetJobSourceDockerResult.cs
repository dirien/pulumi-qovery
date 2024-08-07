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
    public sealed class GetJobSourceDockerResult
    {
        /// <summary>
        /// Job's docker source dockerfile path.
        /// </summary>
        public readonly string? DockerfilePath;
        /// <summary>
        /// Inline Dockerfile to inject for building the image
        /// </summary>
        public readonly string? DockerfileRaw;
        /// <summary>
        /// Job's docker source git repository.
        /// </summary>
        public readonly Outputs.GetJobSourceDockerGitRepositoryResult GitRepository;

        [OutputConstructor]
        private GetJobSourceDockerResult(
            string? dockerfilePath,

            string? dockerfileRaw,

            Outputs.GetJobSourceDockerGitRepositoryResult gitRepository)
        {
            DockerfilePath = dockerfilePath;
            DockerfileRaw = dockerfileRaw;
            GitRepository = gitRepository;
        }
    }
}
