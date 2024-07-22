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

    public sealed class GetJobSourceDockerArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Job's docker source dockerfile path.
        /// </summary>
        [Input("dockerfilePath")]
        public string? DockerfilePath { get; set; }

        /// <summary>
        /// Inline Dockerfile to inject for building the image
        /// </summary>
        [Input("dockerfileRaw")]
        public string? DockerfileRaw { get; set; }

        /// <summary>
        /// Job's docker source git repository.
        /// </summary>
        [Input("gitRepository", required: true)]
        public Inputs.GetJobSourceDockerGitRepositoryArgs GitRepository { get; set; } = null!;

        public GetJobSourceDockerArgs()
        {
        }
        public static new GetJobSourceDockerArgs Empty => new GetJobSourceDockerArgs();
    }
}
