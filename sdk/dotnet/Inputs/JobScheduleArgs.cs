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

    public sealed class JobScheduleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Job's cron.
        /// </summary>
        [Input("cronjob")]
        public Input<Inputs.JobScheduleCronjobArgs>? Cronjob { get; set; }

        /// <summary>
        /// Type of the lifecycle job.
        /// 	- Can be: `CLOUDFORMATION`, `GENERIC`, `TERRAFORM`.
        /// </summary>
        [Input("lifecycleType")]
        public Input<string>? LifecycleType { get; set; }

        /// <summary>
        /// Job's schedule on delete.
        /// </summary>
        [Input("onDelete")]
        public Input<Inputs.JobScheduleOnDeleteArgs>? OnDelete { get; set; }

        /// <summary>
        /// Job's schedule on start.
        /// </summary>
        [Input("onStart")]
        public Input<Inputs.JobScheduleOnStartArgs>? OnStart { get; set; }

        /// <summary>
        /// Job's schedule on stop.
        /// </summary>
        [Input("onStop")]
        public Input<Inputs.JobScheduleOnStopArgs>? OnStop { get; set; }

        public JobScheduleArgs()
        {
        }
        public static new JobScheduleArgs Empty => new JobScheduleArgs();
    }
}
