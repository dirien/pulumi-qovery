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

    public sealed class JobScheduleOnDeleteArgs : global::Pulumi.ResourceArgs
    {
        [Input("arguments")]
        private InputList<string>? _arguments;

        /// <summary>
        /// List of arguments of this job.
        /// </summary>
        public InputList<string> Arguments
        {
            get => _arguments ?? (_arguments = new InputList<string>());
            set => _arguments = value;
        }

        /// <summary>
        /// Entrypoint of the job.
        /// </summary>
        [Input("entrypoint")]
        public Input<string>? Entrypoint { get; set; }

        public JobScheduleOnDeleteArgs()
        {
        }
        public static new JobScheduleOnDeleteArgs Empty => new JobScheduleOnDeleteArgs();
    }
}
