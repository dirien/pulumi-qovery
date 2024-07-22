// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * ## # qovery.AnnotationsGroup (Resource)
 *
 * Provides a Qovery annotations group resource
 *
 * ## Example
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as qovery from "@ediri/qovery";
 *
 * const annotationsGroup1 = new qovery.AnnotationsGroup("annotationsGroup1", {
 *     organizationId: qovery_organization.my_organization.id,
 *     annotations: {
 *         key1: "value1",
 *         key2: "value2",
 *     },
 *     scopes: [
 *         "PODS",
 *         "DEPLOYMENTS",
 *     ],
 * });
 * ```
 *
 * ## Import
 *
 * ```sh
 * $ pulumi import qovery:index/annotationsGroup:AnnotationsGroup my_qovery_annotations_group "<annotations_group_id>"
 * ```
 */
export class AnnotationsGroup extends pulumi.CustomResource {
    /**
     * Get an existing AnnotationsGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AnnotationsGroupState, opts?: pulumi.CustomResourceOptions): AnnotationsGroup {
        return new AnnotationsGroup(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'qovery:index/annotationsGroup:AnnotationsGroup';

    /**
     * Returns true if the given object is an instance of AnnotationsGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AnnotationsGroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AnnotationsGroup.__pulumiType;
    }

    /**
     * annotations
     */
    public readonly annotations!: pulumi.Output<{[key: string]: string}>;
    /**
     * name of the annotations group
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Id of the organization.
     */
    public readonly organizationId!: pulumi.Output<string>;
    /**
     * scopes of the annotations group
     */
    public readonly scopes!: pulumi.Output<string[]>;

    /**
     * Create a AnnotationsGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AnnotationsGroupArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AnnotationsGroupArgs | AnnotationsGroupState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as AnnotationsGroupState | undefined;
            resourceInputs["annotations"] = state ? state.annotations : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["organizationId"] = state ? state.organizationId : undefined;
            resourceInputs["scopes"] = state ? state.scopes : undefined;
        } else {
            const args = argsOrState as AnnotationsGroupArgs | undefined;
            if ((!args || args.annotations === undefined) && !opts.urn) {
                throw new Error("Missing required property 'annotations'");
            }
            if ((!args || args.organizationId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'organizationId'");
            }
            if ((!args || args.scopes === undefined) && !opts.urn) {
                throw new Error("Missing required property 'scopes'");
            }
            resourceInputs["annotations"] = args ? args.annotations : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["organizationId"] = args ? args.organizationId : undefined;
            resourceInputs["scopes"] = args ? args.scopes : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(AnnotationsGroup.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering AnnotationsGroup resources.
 */
export interface AnnotationsGroupState {
    /**
     * annotations
     */
    annotations?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * name of the annotations group
     */
    name?: pulumi.Input<string>;
    /**
     * Id of the organization.
     */
    organizationId?: pulumi.Input<string>;
    /**
     * scopes of the annotations group
     */
    scopes?: pulumi.Input<pulumi.Input<string>[]>;
}

/**
 * The set of arguments for constructing a AnnotationsGroup resource.
 */
export interface AnnotationsGroupArgs {
    /**
     * annotations
     */
    annotations: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * name of the annotations group
     */
    name?: pulumi.Input<string>;
    /**
     * Id of the organization.
     */
    organizationId: pulumi.Input<string>;
    /**
     * scopes of the annotations group
     */
    scopes: pulumi.Input<pulumi.Input<string>[]>;
}
