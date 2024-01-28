// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * ## # qovery.HelmRepository (Data Source)
 *
 * Provides a Qovery helm repository resource. This can be used to create and manage Qovery helm repository.
 */
export function getHelmRepository(args: GetHelmRepositoryArgs, opts?: pulumi.InvokeOptions): Promise<GetHelmRepositoryResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("qovery:index/getHelmRepository:getHelmRepository", {
        "description": args.description,
        "id": args.id,
        "organizationId": args.organizationId,
    }, opts);
}

/**
 * A collection of arguments for invoking getHelmRepository.
 */
export interface GetHelmRepositoryArgs {
    description?: string;
    id: string;
    organizationId: string;
}

/**
 * A collection of values returned by getHelmRepository.
 */
export interface GetHelmRepositoryResult {
    readonly description: string;
    readonly id: string;
    readonly kind: string;
    readonly name: string;
    readonly organizationId: string;
    readonly url: string;
}
/**
 * ## # qovery.HelmRepository (Data Source)
 *
 * Provides a Qovery helm repository resource. This can be used to create and manage Qovery helm repository.
 */
export function getHelmRepositoryOutput(args: GetHelmRepositoryOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetHelmRepositoryResult> {
    return pulumi.output(args).apply((a: any) => getHelmRepository(a, opts))
}

/**
 * A collection of arguments for invoking getHelmRepository.
 */
export interface GetHelmRepositoryOutputArgs {
    description?: pulumi.Input<string>;
    id: pulumi.Input<string>;
    organizationId: pulumi.Input<string>;
}