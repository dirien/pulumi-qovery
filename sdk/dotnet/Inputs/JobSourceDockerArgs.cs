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

    public sealed class JobSourceDockerArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Job's docker source dockerfile path.
        /// </summary>
        [Input("dockerfilePath")]
        public Input<string>? DockerfilePath { get; set; }

        /// <summary>
        /// Inline Dockerfile to inject for building the image
        /// </summary>
        [Input("dockerfileRaw")]
        public Input<string>? DockerfileRaw { get; set; }

        /// <summary>
        /// Job's docker source git repository.
        /// </summary>
        [Input("gitRepository", required: true)]
        public Input<Inputs.JobSourceDockerGitRepositoryArgs> GitRepository { get; set; } = null!;

        public JobSourceDockerArgs()
        {
        }
        public static new JobSourceDockerArgs Empty => new JobSourceDockerArgs();
    }
}
