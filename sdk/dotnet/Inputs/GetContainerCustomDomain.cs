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

    public sealed class GetContainerCustomDomainArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Your custom domain.
        /// </summary>
        [Input("domain", required: true)]
        public string Domain { get; set; } = null!;

        /// <summary>
        /// Id of the custom domain.
        /// </summary>
        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        /// <summary>
        /// Status of the custom domain.
        /// </summary>
        [Input("status", required: true)]
        public string Status { get; set; } = null!;

        /// <summary>
        /// URL provided by Qovery. You must create a CNAME on your DNS provider using that URL.
        /// </summary>
        [Input("validationDomain", required: true)]
        public string ValidationDomain { get; set; } = null!;

        public GetContainerCustomDomainArgs()
        {
        }
        public static new GetContainerCustomDomainArgs Empty => new GetContainerCustomDomainArgs();
    }
}
