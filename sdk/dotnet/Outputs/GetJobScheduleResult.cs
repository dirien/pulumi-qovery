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
    public sealed class GetJobScheduleResult
    {
        public readonly Outputs.GetJobScheduleCronjobResult Cronjob;
        public readonly Outputs.GetJobScheduleOnDeleteResult OnDelete;
        public readonly Outputs.GetJobScheduleOnStartResult OnStart;
        public readonly Outputs.GetJobScheduleOnStopResult OnStop;

        [OutputConstructor]
        private GetJobScheduleResult(
            Outputs.GetJobScheduleCronjobResult cronjob,

            Outputs.GetJobScheduleOnDeleteResult onDelete,

            Outputs.GetJobScheduleOnStartResult onStart,

            Outputs.GetJobScheduleOnStopResult onStop)
        {
            Cronjob = cronjob;
            OnDelete = onDelete;
            OnStart = onStart;
            OnStop = onStop;
        }
    }
}