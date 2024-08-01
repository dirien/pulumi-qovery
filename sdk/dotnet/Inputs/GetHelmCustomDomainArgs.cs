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

    public sealed class GetHelmCustomDomainInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Your custom domain.
        /// </summary>
        [Input("domain", required: true)]
        public Input<string> Domain { get; set; } = null!;

        /// <summary>
        /// Qovery will generate and manage the certificate for this domain.
        /// </summary>
        [Input("generateCertificate")]
        public Input<bool>? GenerateCertificate { get; set; }

        /// <summary>
        /// Id of the custom domain.
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        /// <summary>
        /// Status of the custom domain.
        /// </summary>
        [Input("status", required: true)]
        public Input<string> Status { get; set; } = null!;

        /// <summary>
        /// Indicates if the custom domain is behind a CDN (i.e Cloudflare).
        /// This will condition the way we are checking CNAME before &amp; during a deployment:
        ///  * If `true` then we only check the domain points to an IP
        ///  * If `false` then we check that the domain resolves to the correct service Load Balancer
        /// </summary>
        [Input("useCdn")]
        public Input<bool>? UseCdn { get; set; }

        /// <summary>
        /// URL provided by Qovery. You must create a CNAME on your DNS provider using that URL.
        /// </summary>
        [Input("validationDomain", required: true)]
        public Input<string> ValidationDomain { get; set; } = null!;

        public GetHelmCustomDomainInputArgs()
        {
        }
        public static new GetHelmCustomDomainInputArgs Empty => new GetHelmCustomDomainInputArgs();
    }
}
