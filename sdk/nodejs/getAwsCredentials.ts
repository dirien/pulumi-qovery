// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * ## # qovery.AwsCredentials (Data Source)
 *
 * Provides a Qovery AWS credentials resource. This can be used to create and manage Qovery AWS credentials.
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as qovery from "@pulumi/qovery";
 *
 * const myAwsCreds = qovery.getAwsCredentials({
 *     id: "<credentials_id>",
 *     organizationId: "<organization_id>",
 * });
 * ```
 */
export function getAwsCredentials(args: GetAwsCredentialsArgs, opts?: pulumi.InvokeOptions): Promise<GetAwsCredentialsResult> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("qovery:index/getAwsCredentials:getAwsCredentials", {
        "id": args.id,
        "organizationId": args.organizationId,
    }, opts);
}

/**
 * A collection of arguments for invoking getAwsCredentials.
 */
export interface GetAwsCredentialsArgs {
    /**
     * Id of the AWS credentials.
     */
    id: string;
    /**
     * Id of the organization.
     */
    organizationId: string;
}

/**
 * A collection of values returned by getAwsCredentials.
 */
export interface GetAwsCredentialsResult {
    /**
     * Id of the AWS credentials.
     */
    readonly id: string;
    /**
     * Name of the aws credentials.
     */
    readonly name: string;
    /**
     * Id of the organization.
     */
    readonly organizationId: string;
}
/**
 * ## # qovery.AwsCredentials (Data Source)
 *
 * Provides a Qovery AWS credentials resource. This can be used to create and manage Qovery AWS credentials.
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as qovery from "@pulumi/qovery";
 *
 * const myAwsCreds = qovery.getAwsCredentials({
 *     id: "<credentials_id>",
 *     organizationId: "<organization_id>",
 * });
 * ```
 */
export function getAwsCredentialsOutput(args: GetAwsCredentialsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAwsCredentialsResult> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("qovery:index/getAwsCredentials:getAwsCredentials", {
        "id": args.id,
        "organizationId": args.organizationId,
    }, opts);
}

/**
 * A collection of arguments for invoking getAwsCredentials.
 */
export interface GetAwsCredentialsOutputArgs {
    /**
     * Id of the AWS credentials.
     */
    id: pulumi.Input<string>;
    /**
     * Id of the organization.
     */
    organizationId: pulumi.Input<string>;
}
