// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * ## # qovery.Container (Resource)
 *
 * Provides a Qovery container resource. This can be used to create and manage Qovery container registry.
 *
 * ## Import
 *
 * ```sh
 *  $ pulumi import qovery:index/container:Container my_container "<container_id>"
 * ```
 */
export class Container extends pulumi.CustomResource {
    /**
     * Get an existing Container resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ContainerState, opts?: pulumi.CustomResourceOptions): Container {
        return new Container(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'qovery:index/container:Container';

    /**
     * Returns true if the given object is an instance of Container.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Container {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Container.__pulumiType;
    }

    /**
     * Advanced settings.
     */
    public readonly advancedSettingsJson!: pulumi.Output<string>;
    /**
     * List of arguments of this container.
     */
    public readonly arguments!: pulumi.Output<string[]>;
    /**
     * Specify if the container will be automatically updated after receiving a new image tag.
     */
    public readonly autoDeploy!: pulumi.Output<boolean>;
    /**
     * Specify if the environment preview option is activated or not for this container.
     */
    public readonly autoPreview!: pulumi.Output<boolean>;
    /**
     * List of built-in environment variables linked to this container.
     */
    public /*out*/ readonly builtInEnvironmentVariables!: pulumi.Output<outputs.ContainerBuiltInEnvironmentVariable[]>;
    /**
     * CPU of the container in millicores (m) [1000m = 1 CPU]. - Must be: `>= 10`. - Default: `500`.
     */
    public readonly cpu!: pulumi.Output<number>;
    /**
     * List of custom domains linked to this container.
     */
    public readonly customDomains!: pulumi.Output<outputs.ContainerCustomDomain[] | undefined>;
    /**
     * Id of the deployment stage.
     */
    public readonly deploymentStageId!: pulumi.Output<string>;
    /**
     * Entrypoint of the container.
     */
    public readonly entrypoint!: pulumi.Output<string | undefined>;
    /**
     * Id of the environment.
     */
    public readonly environmentId!: pulumi.Output<string>;
    /**
     * List of environment variable aliases linked to this container.
     */
    public readonly environmentVariableAliases!: pulumi.Output<outputs.ContainerEnvironmentVariableAlias[] | undefined>;
    /**
     * List of environment variable overrides linked to this container.
     */
    public readonly environmentVariableOverrides!: pulumi.Output<outputs.ContainerEnvironmentVariableOverride[] | undefined>;
    /**
     * List of environment variables linked to this container.
     */
    public readonly environmentVariables!: pulumi.Output<outputs.ContainerEnvironmentVariable[] | undefined>;
    /**
     * The container external FQDN host [NOTE: only if your container is using a publicly accessible port].
     */
    public /*out*/ readonly externalHost!: pulumi.Output<string>;
    /**
     * Configuration for the healthchecks that are going to be executed against your service
     */
    public readonly healthchecks!: pulumi.Output<outputs.ContainerHealthchecks>;
    /**
     * Name of the container image.
     */
    public readonly imageName!: pulumi.Output<string>;
    /**
     * The container internal host.
     */
    public /*out*/ readonly internalHost!: pulumi.Output<string>;
    /**
     * Maximum number of instances running for the container. - Must be: `>= -1`. - Default: `1`.
     */
    public readonly maxRunningInstances!: pulumi.Output<number>;
    /**
     * RAM of the container in MB [1024MB = 1GB]. - Must be: `>= 10`. - Default: `512`.
     */
    public readonly memory!: pulumi.Output<number>;
    /**
     * Minimum number of instances running for the container. - Must be: `>= 1`. - Default: `1`.
     */
    public readonly minRunningInstances!: pulumi.Output<number>;
    /**
     * Name of the container.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * List of ports linked to this container.
     */
    public readonly ports!: pulumi.Output<outputs.ContainerPort[] | undefined>;
    /**
     * Id of the registry.
     */
    public readonly registryId!: pulumi.Output<string>;
    /**
     * List of secret aliases linked to this container.
     */
    public readonly secretAliases!: pulumi.Output<outputs.ContainerSecretAlias[] | undefined>;
    /**
     * List of secret overrides linked to this container.
     */
    public readonly secretOverrides!: pulumi.Output<outputs.ContainerSecretOverride[] | undefined>;
    /**
     * List of secrets linked to this container.
     */
    public readonly secrets!: pulumi.Output<outputs.ContainerSecret[] | undefined>;
    /**
     * List of storages linked to this container.
     */
    public readonly storages!: pulumi.Output<outputs.ContainerStorage[] | undefined>;
    /**
     * Tag of the container image.
     */
    public readonly tag!: pulumi.Output<string>;

    /**
     * Create a Container resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ContainerArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ContainerArgs | ContainerState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ContainerState | undefined;
            resourceInputs["advancedSettingsJson"] = state ? state.advancedSettingsJson : undefined;
            resourceInputs["arguments"] = state ? state.arguments : undefined;
            resourceInputs["autoDeploy"] = state ? state.autoDeploy : undefined;
            resourceInputs["autoPreview"] = state ? state.autoPreview : undefined;
            resourceInputs["builtInEnvironmentVariables"] = state ? state.builtInEnvironmentVariables : undefined;
            resourceInputs["cpu"] = state ? state.cpu : undefined;
            resourceInputs["customDomains"] = state ? state.customDomains : undefined;
            resourceInputs["deploymentStageId"] = state ? state.deploymentStageId : undefined;
            resourceInputs["entrypoint"] = state ? state.entrypoint : undefined;
            resourceInputs["environmentId"] = state ? state.environmentId : undefined;
            resourceInputs["environmentVariableAliases"] = state ? state.environmentVariableAliases : undefined;
            resourceInputs["environmentVariableOverrides"] = state ? state.environmentVariableOverrides : undefined;
            resourceInputs["environmentVariables"] = state ? state.environmentVariables : undefined;
            resourceInputs["externalHost"] = state ? state.externalHost : undefined;
            resourceInputs["healthchecks"] = state ? state.healthchecks : undefined;
            resourceInputs["imageName"] = state ? state.imageName : undefined;
            resourceInputs["internalHost"] = state ? state.internalHost : undefined;
            resourceInputs["maxRunningInstances"] = state ? state.maxRunningInstances : undefined;
            resourceInputs["memory"] = state ? state.memory : undefined;
            resourceInputs["minRunningInstances"] = state ? state.minRunningInstances : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["ports"] = state ? state.ports : undefined;
            resourceInputs["registryId"] = state ? state.registryId : undefined;
            resourceInputs["secretAliases"] = state ? state.secretAliases : undefined;
            resourceInputs["secretOverrides"] = state ? state.secretOverrides : undefined;
            resourceInputs["secrets"] = state ? state.secrets : undefined;
            resourceInputs["storages"] = state ? state.storages : undefined;
            resourceInputs["tag"] = state ? state.tag : undefined;
        } else {
            const args = argsOrState as ContainerArgs | undefined;
            if ((!args || args.environmentId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'environmentId'");
            }
            if ((!args || args.healthchecks === undefined) && !opts.urn) {
                throw new Error("Missing required property 'healthchecks'");
            }
            if ((!args || args.imageName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'imageName'");
            }
            if ((!args || args.registryId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'registryId'");
            }
            if ((!args || args.tag === undefined) && !opts.urn) {
                throw new Error("Missing required property 'tag'");
            }
            resourceInputs["advancedSettingsJson"] = args ? args.advancedSettingsJson : undefined;
            resourceInputs["arguments"] = args ? args.arguments : undefined;
            resourceInputs["autoDeploy"] = args ? args.autoDeploy : undefined;
            resourceInputs["autoPreview"] = args ? args.autoPreview : undefined;
            resourceInputs["cpu"] = args ? args.cpu : undefined;
            resourceInputs["customDomains"] = args ? args.customDomains : undefined;
            resourceInputs["deploymentStageId"] = args ? args.deploymentStageId : undefined;
            resourceInputs["entrypoint"] = args ? args.entrypoint : undefined;
            resourceInputs["environmentId"] = args ? args.environmentId : undefined;
            resourceInputs["environmentVariableAliases"] = args ? args.environmentVariableAliases : undefined;
            resourceInputs["environmentVariableOverrides"] = args ? args.environmentVariableOverrides : undefined;
            resourceInputs["environmentVariables"] = args ? args.environmentVariables : undefined;
            resourceInputs["healthchecks"] = args ? args.healthchecks : undefined;
            resourceInputs["imageName"] = args ? args.imageName : undefined;
            resourceInputs["maxRunningInstances"] = args ? args.maxRunningInstances : undefined;
            resourceInputs["memory"] = args ? args.memory : undefined;
            resourceInputs["minRunningInstances"] = args ? args.minRunningInstances : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["ports"] = args ? args.ports : undefined;
            resourceInputs["registryId"] = args ? args.registryId : undefined;
            resourceInputs["secretAliases"] = args ? args.secretAliases : undefined;
            resourceInputs["secretOverrides"] = args ? args.secretOverrides : undefined;
            resourceInputs["secrets"] = args ? args.secrets : undefined;
            resourceInputs["storages"] = args ? args.storages : undefined;
            resourceInputs["tag"] = args ? args.tag : undefined;
            resourceInputs["builtInEnvironmentVariables"] = undefined /*out*/;
            resourceInputs["externalHost"] = undefined /*out*/;
            resourceInputs["internalHost"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Container.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Container resources.
 */
export interface ContainerState {
    /**
     * Advanced settings.
     */
    advancedSettingsJson?: pulumi.Input<string>;
    /**
     * List of arguments of this container.
     */
    arguments?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Specify if the container will be automatically updated after receiving a new image tag.
     */
    autoDeploy?: pulumi.Input<boolean>;
    /**
     * Specify if the environment preview option is activated or not for this container.
     */
    autoPreview?: pulumi.Input<boolean>;
    /**
     * List of built-in environment variables linked to this container.
     */
    builtInEnvironmentVariables?: pulumi.Input<pulumi.Input<inputs.ContainerBuiltInEnvironmentVariable>[]>;
    /**
     * CPU of the container in millicores (m) [1000m = 1 CPU]. - Must be: `>= 10`. - Default: `500`.
     */
    cpu?: pulumi.Input<number>;
    /**
     * List of custom domains linked to this container.
     */
    customDomains?: pulumi.Input<pulumi.Input<inputs.ContainerCustomDomain>[]>;
    /**
     * Id of the deployment stage.
     */
    deploymentStageId?: pulumi.Input<string>;
    /**
     * Entrypoint of the container.
     */
    entrypoint?: pulumi.Input<string>;
    /**
     * Id of the environment.
     */
    environmentId?: pulumi.Input<string>;
    /**
     * List of environment variable aliases linked to this container.
     */
    environmentVariableAliases?: pulumi.Input<pulumi.Input<inputs.ContainerEnvironmentVariableAlias>[]>;
    /**
     * List of environment variable overrides linked to this container.
     */
    environmentVariableOverrides?: pulumi.Input<pulumi.Input<inputs.ContainerEnvironmentVariableOverride>[]>;
    /**
     * List of environment variables linked to this container.
     */
    environmentVariables?: pulumi.Input<pulumi.Input<inputs.ContainerEnvironmentVariable>[]>;
    /**
     * The container external FQDN host [NOTE: only if your container is using a publicly accessible port].
     */
    externalHost?: pulumi.Input<string>;
    /**
     * Configuration for the healthchecks that are going to be executed against your service
     */
    healthchecks?: pulumi.Input<inputs.ContainerHealthchecks>;
    /**
     * Name of the container image.
     */
    imageName?: pulumi.Input<string>;
    /**
     * The container internal host.
     */
    internalHost?: pulumi.Input<string>;
    /**
     * Maximum number of instances running for the container. - Must be: `>= -1`. - Default: `1`.
     */
    maxRunningInstances?: pulumi.Input<number>;
    /**
     * RAM of the container in MB [1024MB = 1GB]. - Must be: `>= 10`. - Default: `512`.
     */
    memory?: pulumi.Input<number>;
    /**
     * Minimum number of instances running for the container. - Must be: `>= 1`. - Default: `1`.
     */
    minRunningInstances?: pulumi.Input<number>;
    /**
     * Name of the container.
     */
    name?: pulumi.Input<string>;
    /**
     * List of ports linked to this container.
     */
    ports?: pulumi.Input<pulumi.Input<inputs.ContainerPort>[]>;
    /**
     * Id of the registry.
     */
    registryId?: pulumi.Input<string>;
    /**
     * List of secret aliases linked to this container.
     */
    secretAliases?: pulumi.Input<pulumi.Input<inputs.ContainerSecretAlias>[]>;
    /**
     * List of secret overrides linked to this container.
     */
    secretOverrides?: pulumi.Input<pulumi.Input<inputs.ContainerSecretOverride>[]>;
    /**
     * List of secrets linked to this container.
     */
    secrets?: pulumi.Input<pulumi.Input<inputs.ContainerSecret>[]>;
    /**
     * List of storages linked to this container.
     */
    storages?: pulumi.Input<pulumi.Input<inputs.ContainerStorage>[]>;
    /**
     * Tag of the container image.
     */
    tag?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Container resource.
 */
export interface ContainerArgs {
    /**
     * Advanced settings.
     */
    advancedSettingsJson?: pulumi.Input<string>;
    /**
     * List of arguments of this container.
     */
    arguments?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Specify if the container will be automatically updated after receiving a new image tag.
     */
    autoDeploy?: pulumi.Input<boolean>;
    /**
     * Specify if the environment preview option is activated or not for this container.
     */
    autoPreview?: pulumi.Input<boolean>;
    /**
     * CPU of the container in millicores (m) [1000m = 1 CPU]. - Must be: `>= 10`. - Default: `500`.
     */
    cpu?: pulumi.Input<number>;
    /**
     * List of custom domains linked to this container.
     */
    customDomains?: pulumi.Input<pulumi.Input<inputs.ContainerCustomDomain>[]>;
    /**
     * Id of the deployment stage.
     */
    deploymentStageId?: pulumi.Input<string>;
    /**
     * Entrypoint of the container.
     */
    entrypoint?: pulumi.Input<string>;
    /**
     * Id of the environment.
     */
    environmentId: pulumi.Input<string>;
    /**
     * List of environment variable aliases linked to this container.
     */
    environmentVariableAliases?: pulumi.Input<pulumi.Input<inputs.ContainerEnvironmentVariableAlias>[]>;
    /**
     * List of environment variable overrides linked to this container.
     */
    environmentVariableOverrides?: pulumi.Input<pulumi.Input<inputs.ContainerEnvironmentVariableOverride>[]>;
    /**
     * List of environment variables linked to this container.
     */
    environmentVariables?: pulumi.Input<pulumi.Input<inputs.ContainerEnvironmentVariable>[]>;
    /**
     * Configuration for the healthchecks that are going to be executed against your service
     */
    healthchecks: pulumi.Input<inputs.ContainerHealthchecks>;
    /**
     * Name of the container image.
     */
    imageName: pulumi.Input<string>;
    /**
     * Maximum number of instances running for the container. - Must be: `>= -1`. - Default: `1`.
     */
    maxRunningInstances?: pulumi.Input<number>;
    /**
     * RAM of the container in MB [1024MB = 1GB]. - Must be: `>= 10`. - Default: `512`.
     */
    memory?: pulumi.Input<number>;
    /**
     * Minimum number of instances running for the container. - Must be: `>= 1`. - Default: `1`.
     */
    minRunningInstances?: pulumi.Input<number>;
    /**
     * Name of the container.
     */
    name?: pulumi.Input<string>;
    /**
     * List of ports linked to this container.
     */
    ports?: pulumi.Input<pulumi.Input<inputs.ContainerPort>[]>;
    /**
     * Id of the registry.
     */
    registryId: pulumi.Input<string>;
    /**
     * List of secret aliases linked to this container.
     */
    secretAliases?: pulumi.Input<pulumi.Input<inputs.ContainerSecretAlias>[]>;
    /**
     * List of secret overrides linked to this container.
     */
    secretOverrides?: pulumi.Input<pulumi.Input<inputs.ContainerSecretOverride>[]>;
    /**
     * List of secrets linked to this container.
     */
    secrets?: pulumi.Input<pulumi.Input<inputs.ContainerSecret>[]>;
    /**
     * List of storages linked to this container.
     */
    storages?: pulumi.Input<pulumi.Input<inputs.ContainerStorage>[]>;
    /**
     * Tag of the container image.
     */
    tag: pulumi.Input<string>;
}
