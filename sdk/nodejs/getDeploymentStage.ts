// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * ## # qovery.DeploymentStage (Data Source)
 *
 * Provides a Qovery deployment stage resource. This can be used to create and manage Qovery deployment stages.
 */
export function getDeploymentStage(args: GetDeploymentStageArgs, opts?: pulumi.InvokeOptions): Promise<GetDeploymentStageResult> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("qovery:index/getDeploymentStage:getDeploymentStage", {
        "description": args.description,
        "id": args.id,
        "isAfter": args.isAfter,
        "isBefore": args.isBefore,
    }, opts);
}

/**
 * A collection of arguments for invoking getDeploymentStage.
 */
export interface GetDeploymentStageArgs {
    description?: string;
    id: string;
    isAfter?: string;
    isBefore?: string;
}

/**
 * A collection of values returned by getDeploymentStage.
 */
export interface GetDeploymentStageResult {
    readonly description: string;
    readonly environmentId: string;
    readonly id: string;
    readonly isAfter: string;
    readonly isBefore: string;
    readonly name: string;
}
/**
 * ## # qovery.DeploymentStage (Data Source)
 *
 * Provides a Qovery deployment stage resource. This can be used to create and manage Qovery deployment stages.
 */
export function getDeploymentStageOutput(args: GetDeploymentStageOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDeploymentStageResult> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("qovery:index/getDeploymentStage:getDeploymentStage", {
        "description": args.description,
        "id": args.id,
        "isAfter": args.isAfter,
        "isBefore": args.isBefore,
    }, opts);
}

/**
 * A collection of arguments for invoking getDeploymentStage.
 */
export interface GetDeploymentStageOutputArgs {
    description?: pulumi.Input<string>;
    id: pulumi.Input<string>;
    isAfter?: pulumi.Input<string>;
    isBefore?: pulumi.Input<string>;
}
