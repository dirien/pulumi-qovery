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

    public sealed class ContainerCustomDomainGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Your custom domain.
        /// </summary>
        [Input("domain", required: true)]
        public Input<string> Domain { get; set; } = null!;

        /// <summary>
        /// Id of the custom domain.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Status of the custom domain.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// URL provided by Qovery. You must create a CNAME on your DNS provider using that URL.
        /// </summary>
        [Input("validationDomain")]
        public Input<string>? ValidationDomain { get; set; }

        public ContainerCustomDomainGetArgs()
        {
        }
        public static new ContainerCustomDomainGetArgs Empty => new ContainerCustomDomainGetArgs();
    }
}
