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

    public sealed class HelmValuesOverrideFileGitRepositoryGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("branch", required: true)]
        public Input<string> Branch { get; set; } = null!;

        [Input("gitTokenId")]
        public Input<string>? GitTokenId { get; set; }

        [Input("paths", required: true)]
        private InputList<string>? _paths;
        public InputList<string> Paths
        {
            get => _paths ?? (_paths = new InputList<string>());
            set => _paths = value;
        }

        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public HelmValuesOverrideFileGitRepositoryGetArgs()
        {
        }
        public static new HelmValuesOverrideFileGitRepositoryGetArgs Empty => new HelmValuesOverrideFileGitRepositoryGetArgs();
    }
}
