// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * ## # qovery.Deployment (Data Source)
 *
 * Provides a Qovery deployment resource. This is used to trigger a service deployment at demand.
 */
export function getDeployment(args: GetDeploymentArgs, opts?: pulumi.InvokeOptions): Promise<GetDeploymentResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("qovery:index/getDeployment:getDeployment", {
        "id": args.id,
        "version": args.version,
    }, opts);
}

/**
 * A collection of arguments for invoking getDeployment.
 */
export interface GetDeploymentArgs {
    id: string;
    version?: string;
}

/**
 * A collection of values returned by getDeployment.
 */
export interface GetDeploymentResult {
    readonly desiredState: string;
    readonly environmentId: string;
    readonly id: string;
    readonly version?: string;
}
/**
 * ## # qovery.Deployment (Data Source)
 *
 * Provides a Qovery deployment resource. This is used to trigger a service deployment at demand.
 */
export function getDeploymentOutput(args: GetDeploymentOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDeploymentResult> {
    return pulumi.output(args).apply((a: any) => getDeployment(a, opts))
}

/**
 * A collection of arguments for invoking getDeployment.
 */
export interface GetDeploymentOutputArgs {
    id: pulumi.Input<string>;
    version?: pulumi.Input<string>;
}
