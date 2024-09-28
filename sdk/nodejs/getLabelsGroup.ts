// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * ## # qovery.LabelsGroup (Data Source)
 *
 * Provides a Qovery labels group resource
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as qovery from "@pulumi/qovery";
 *
 * const myLabelsGroup = qovery.getLabelsGroup({
 *     id: "<labels_group_id>",
 *     organizationId: "<organization_id>",
 * });
 * ```
 */
export function getLabelsGroup(args: GetLabelsGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetLabelsGroupResult> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("qovery:index/getLabelsGroup:getLabelsGroup", {
        "id": args.id,
        "labels": args.labels,
        "name": args.name,
        "organizationId": args.organizationId,
    }, opts);
}

/**
 * A collection of arguments for invoking getLabelsGroup.
 */
export interface GetLabelsGroupArgs {
    /**
     * Id of the labels group
     */
    id: string;
    /**
     * labels
     */
    labels?: inputs.GetLabelsGroupLabel[];
    /**
     * name of the labels group
     */
    name?: string;
    /**
     * Id of the organization.
     */
    organizationId: string;
}

/**
 * A collection of values returned by getLabelsGroup.
 */
export interface GetLabelsGroupResult {
    /**
     * Id of the labels group
     */
    readonly id: string;
    /**
     * labels
     */
    readonly labels?: outputs.GetLabelsGroupLabel[];
    /**
     * name of the labels group
     */
    readonly name?: string;
    /**
     * Id of the organization.
     */
    readonly organizationId: string;
}
/**
 * ## # qovery.LabelsGroup (Data Source)
 *
 * Provides a Qovery labels group resource
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as qovery from "@pulumi/qovery";
 *
 * const myLabelsGroup = qovery.getLabelsGroup({
 *     id: "<labels_group_id>",
 *     organizationId: "<organization_id>",
 * });
 * ```
 */
export function getLabelsGroupOutput(args: GetLabelsGroupOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetLabelsGroupResult> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("qovery:index/getLabelsGroup:getLabelsGroup", {
        "id": args.id,
        "labels": args.labels,
        "name": args.name,
        "organizationId": args.organizationId,
    }, opts);
}

/**
 * A collection of arguments for invoking getLabelsGroup.
 */
export interface GetLabelsGroupOutputArgs {
    /**
     * Id of the labels group
     */
    id: pulumi.Input<string>;
    /**
     * labels
     */
    labels?: pulumi.Input<pulumi.Input<inputs.GetLabelsGroupLabelArgs>[]>;
    /**
     * name of the labels group
     */
    name?: pulumi.Input<string>;
    /**
     * Id of the organization.
     */
    organizationId: pulumi.Input<string>;
}
