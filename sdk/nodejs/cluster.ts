// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * ## # qovery.Cluster (Resource)
 *
 * Provides a Qovery cluster resource. This can be used to create and manage Qovery cluster.
 *
 * ## Import
 *
 * ```sh
 * $ pulumi import qovery:index/cluster:Cluster my_cluster "<organization_id>,<cluster_id>"
 * ```
 */
export class Cluster extends pulumi.CustomResource {
    /**
     * Get an existing Cluster resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ClusterState, opts?: pulumi.CustomResourceOptions): Cluster {
        return new Cluster(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'qovery:index/cluster:Cluster';

    /**
     * Returns true if the given object is an instance of Cluster.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Cluster {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Cluster.__pulumiType;
    }

    /**
     * Advanced settings of the cluster.
     */
    public readonly advancedSettingsJson!: pulumi.Output<string>;
    /**
     * Cloud provider of the cluster. - Can be: `AWS`, `GCP`, `ON_PREMISE`, `SCW`.
     */
    public readonly cloudProvider!: pulumi.Output<string>;
    /**
     * Id of the credentials.
     */
    public readonly credentialsId!: pulumi.Output<string>;
    /**
     * Description of the cluster. - Default: ``.
     */
    public readonly description!: pulumi.Output<string>;
    public readonly diskSize!: pulumi.Output<number>;
    /**
     * Features of the cluster.
     */
    public readonly features!: pulumi.Output<outputs.ClusterFeatures>;
    /**
     * Instance type of the cluster. I.e: For Aws `t3a.xlarge`, for Scaleway `DEV-L`, and not set for Karpenter-enabled
     * clusters
     */
    public readonly instanceType!: pulumi.Output<string>;
    /**
     * Kubernetes mode of the cluster. - Can be: `K3S`, `MANAGED`. - Default: `MANAGED`.
     */
    public readonly kubernetesMode!: pulumi.Output<string>;
    /**
     * Maximum number of nodes running for the cluster. [NOTE: have to be set to 1 in case of K3S clusters; and not set for
     * Karpenter-enabled clusters] - Must be: `>= 1`. - Default: `10`.
     */
    public readonly maxRunningNodes!: pulumi.Output<number>;
    /**
     * Minimum number of nodes running for the cluster. [NOTE: have to be set to 1 in case of K3S clusters, and not set for
     * Karpenter-enabled clusters]. - Must be: `>= 1`. - Default: `3`.
     */
    public readonly minRunningNodes!: pulumi.Output<number>;
    /**
     * Name of the cluster.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Id of the organization.
     */
    public readonly organizationId!: pulumi.Output<string>;
    /**
     * Specific flag to indicate that this cluster is a production one.
     */
    public readonly production!: pulumi.Output<boolean>;
    /**
     * Region of the cluster.
     */
    public readonly region!: pulumi.Output<string>;
    /**
     * List of routes of the cluster.
     */
    public readonly routingTables!: pulumi.Output<outputs.ClusterRoutingTable[]>;
    /**
     * State of the cluster. - Can be: `DEPLOYED`, `STOPPED`. - Default: `DEPLOYED`.
     */
    public readonly state!: pulumi.Output<string>;

    /**
     * Create a Cluster resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ClusterArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ClusterArgs | ClusterState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ClusterState | undefined;
            resourceInputs["advancedSettingsJson"] = state ? state.advancedSettingsJson : undefined;
            resourceInputs["cloudProvider"] = state ? state.cloudProvider : undefined;
            resourceInputs["credentialsId"] = state ? state.credentialsId : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["diskSize"] = state ? state.diskSize : undefined;
            resourceInputs["features"] = state ? state.features : undefined;
            resourceInputs["instanceType"] = state ? state.instanceType : undefined;
            resourceInputs["kubernetesMode"] = state ? state.kubernetesMode : undefined;
            resourceInputs["maxRunningNodes"] = state ? state.maxRunningNodes : undefined;
            resourceInputs["minRunningNodes"] = state ? state.minRunningNodes : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["organizationId"] = state ? state.organizationId : undefined;
            resourceInputs["production"] = state ? state.production : undefined;
            resourceInputs["region"] = state ? state.region : undefined;
            resourceInputs["routingTables"] = state ? state.routingTables : undefined;
            resourceInputs["state"] = state ? state.state : undefined;
        } else {
            const args = argsOrState as ClusterArgs | undefined;
            if ((!args || args.cloudProvider === undefined) && !opts.urn) {
                throw new Error("Missing required property 'cloudProvider'");
            }
            if ((!args || args.credentialsId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'credentialsId'");
            }
            if ((!args || args.organizationId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'organizationId'");
            }
            if ((!args || args.region === undefined) && !opts.urn) {
                throw new Error("Missing required property 'region'");
            }
            resourceInputs["advancedSettingsJson"] = args ? args.advancedSettingsJson : undefined;
            resourceInputs["cloudProvider"] = args ? args.cloudProvider : undefined;
            resourceInputs["credentialsId"] = args ? args.credentialsId : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["diskSize"] = args ? args.diskSize : undefined;
            resourceInputs["features"] = args ? args.features : undefined;
            resourceInputs["instanceType"] = args ? args.instanceType : undefined;
            resourceInputs["kubernetesMode"] = args ? args.kubernetesMode : undefined;
            resourceInputs["maxRunningNodes"] = args ? args.maxRunningNodes : undefined;
            resourceInputs["minRunningNodes"] = args ? args.minRunningNodes : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["organizationId"] = args ? args.organizationId : undefined;
            resourceInputs["production"] = args ? args.production : undefined;
            resourceInputs["region"] = args ? args.region : undefined;
            resourceInputs["routingTables"] = args ? args.routingTables : undefined;
            resourceInputs["state"] = args ? args.state : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Cluster.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Cluster resources.
 */
export interface ClusterState {
    /**
     * Advanced settings of the cluster.
     */
    advancedSettingsJson?: pulumi.Input<string>;
    /**
     * Cloud provider of the cluster. - Can be: `AWS`, `GCP`, `ON_PREMISE`, `SCW`.
     */
    cloudProvider?: pulumi.Input<string>;
    /**
     * Id of the credentials.
     */
    credentialsId?: pulumi.Input<string>;
    /**
     * Description of the cluster. - Default: ``.
     */
    description?: pulumi.Input<string>;
    diskSize?: pulumi.Input<number>;
    /**
     * Features of the cluster.
     */
    features?: pulumi.Input<inputs.ClusterFeatures>;
    /**
     * Instance type of the cluster. I.e: For Aws `t3a.xlarge`, for Scaleway `DEV-L`, and not set for Karpenter-enabled
     * clusters
     */
    instanceType?: pulumi.Input<string>;
    /**
     * Kubernetes mode of the cluster. - Can be: `K3S`, `MANAGED`. - Default: `MANAGED`.
     */
    kubernetesMode?: pulumi.Input<string>;
    /**
     * Maximum number of nodes running for the cluster. [NOTE: have to be set to 1 in case of K3S clusters; and not set for
     * Karpenter-enabled clusters] - Must be: `>= 1`. - Default: `10`.
     */
    maxRunningNodes?: pulumi.Input<number>;
    /**
     * Minimum number of nodes running for the cluster. [NOTE: have to be set to 1 in case of K3S clusters, and not set for
     * Karpenter-enabled clusters]. - Must be: `>= 1`. - Default: `3`.
     */
    minRunningNodes?: pulumi.Input<number>;
    /**
     * Name of the cluster.
     */
    name?: pulumi.Input<string>;
    /**
     * Id of the organization.
     */
    organizationId?: pulumi.Input<string>;
    /**
     * Specific flag to indicate that this cluster is a production one.
     */
    production?: pulumi.Input<boolean>;
    /**
     * Region of the cluster.
     */
    region?: pulumi.Input<string>;
    /**
     * List of routes of the cluster.
     */
    routingTables?: pulumi.Input<pulumi.Input<inputs.ClusterRoutingTable>[]>;
    /**
     * State of the cluster. - Can be: `DEPLOYED`, `STOPPED`. - Default: `DEPLOYED`.
     */
    state?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Cluster resource.
 */
export interface ClusterArgs {
    /**
     * Advanced settings of the cluster.
     */
    advancedSettingsJson?: pulumi.Input<string>;
    /**
     * Cloud provider of the cluster. - Can be: `AWS`, `GCP`, `ON_PREMISE`, `SCW`.
     */
    cloudProvider: pulumi.Input<string>;
    /**
     * Id of the credentials.
     */
    credentialsId: pulumi.Input<string>;
    /**
     * Description of the cluster. - Default: ``.
     */
    description?: pulumi.Input<string>;
    diskSize?: pulumi.Input<number>;
    /**
     * Features of the cluster.
     */
    features?: pulumi.Input<inputs.ClusterFeatures>;
    /**
     * Instance type of the cluster. I.e: For Aws `t3a.xlarge`, for Scaleway `DEV-L`, and not set for Karpenter-enabled
     * clusters
     */
    instanceType?: pulumi.Input<string>;
    /**
     * Kubernetes mode of the cluster. - Can be: `K3S`, `MANAGED`. - Default: `MANAGED`.
     */
    kubernetesMode?: pulumi.Input<string>;
    /**
     * Maximum number of nodes running for the cluster. [NOTE: have to be set to 1 in case of K3S clusters; and not set for
     * Karpenter-enabled clusters] - Must be: `>= 1`. - Default: `10`.
     */
    maxRunningNodes?: pulumi.Input<number>;
    /**
     * Minimum number of nodes running for the cluster. [NOTE: have to be set to 1 in case of K3S clusters, and not set for
     * Karpenter-enabled clusters]. - Must be: `>= 1`. - Default: `3`.
     */
    minRunningNodes?: pulumi.Input<number>;
    /**
     * Name of the cluster.
     */
    name?: pulumi.Input<string>;
    /**
     * Id of the organization.
     */
    organizationId: pulumi.Input<string>;
    /**
     * Specific flag to indicate that this cluster is a production one.
     */
    production?: pulumi.Input<boolean>;
    /**
     * Region of the cluster.
     */
    region: pulumi.Input<string>;
    /**
     * List of routes of the cluster.
     */
    routingTables?: pulumi.Input<pulumi.Input<inputs.ClusterRoutingTable>[]>;
    /**
     * State of the cluster. - Can be: `DEPLOYED`, `STOPPED`. - Default: `DEPLOYED`.
     */
    state?: pulumi.Input<string>;
}
