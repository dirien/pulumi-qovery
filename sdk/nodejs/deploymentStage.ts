// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * ## Import
 *
 * ```sh
 *  $ pulumi import qovery:index/deploymentStage:DeploymentStage my_deployment_stage "<deployment_stage_id>"
 * ```
 */
export class DeploymentStage extends pulumi.CustomResource {
    /**
     * Get an existing DeploymentStage resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DeploymentStageState, opts?: pulumi.CustomResourceOptions): DeploymentStage {
        return new DeploymentStage(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'qovery:index/deploymentStage:DeploymentStage';

    /**
     * Returns true if the given object is an instance of DeploymentStage.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DeploymentStage {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DeploymentStage.__pulumiType;
    }

    /**
     * Description of the deployment stage.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Id of the environment.
     */
    public readonly environmentId!: pulumi.Output<string>;
    /**
     * Move the current deployment stage after the target deployment stage
     */
    public readonly isAfter!: pulumi.Output<string | undefined>;
    /**
     * Move the current deployment stage before the target deployment stage
     */
    public readonly isBefore!: pulumi.Output<string | undefined>;
    /**
     * Name of the deployment stage.
     */
    public readonly name!: pulumi.Output<string>;

    /**
     * Create a DeploymentStage resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DeploymentStageArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DeploymentStageArgs | DeploymentStageState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as DeploymentStageState | undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["environmentId"] = state ? state.environmentId : undefined;
            resourceInputs["isAfter"] = state ? state.isAfter : undefined;
            resourceInputs["isBefore"] = state ? state.isBefore : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
        } else {
            const args = argsOrState as DeploymentStageArgs | undefined;
            if ((!args || args.environmentId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'environmentId'");
            }
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["environmentId"] = args ? args.environmentId : undefined;
            resourceInputs["isAfter"] = args ? args.isAfter : undefined;
            resourceInputs["isBefore"] = args ? args.isBefore : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(DeploymentStage.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DeploymentStage resources.
 */
export interface DeploymentStageState {
    /**
     * Description of the deployment stage.
     */
    description?: pulumi.Input<string>;
    /**
     * Id of the environment.
     */
    environmentId?: pulumi.Input<string>;
    /**
     * Move the current deployment stage after the target deployment stage
     */
    isAfter?: pulumi.Input<string>;
    /**
     * Move the current deployment stage before the target deployment stage
     */
    isBefore?: pulumi.Input<string>;
    /**
     * Name of the deployment stage.
     */
    name?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a DeploymentStage resource.
 */
export interface DeploymentStageArgs {
    /**
     * Description of the deployment stage.
     */
    description?: pulumi.Input<string>;
    /**
     * Id of the environment.
     */
    environmentId: pulumi.Input<string>;
    /**
     * Move the current deployment stage after the target deployment stage
     */
    isAfter?: pulumi.Input<string>;
    /**
     * Move the current deployment stage before the target deployment stage
     */
    isBefore?: pulumi.Input<string>;
    /**
     * Name of the deployment stage.
     */
    name?: pulumi.Input<string>;
}