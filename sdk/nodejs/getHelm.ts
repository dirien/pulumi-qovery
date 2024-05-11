// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * ## # qovery.Helm (Data Source)
 *
 * Provides a Qovery helm resource.
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as qovery from "@pulumi/qovery";
 *
 * const myHelm = qovery.getHelm({
 *     id: "<helm_id>",
 * });
 * ```
 */
export function getHelm(args: GetHelmArgs, opts?: pulumi.InvokeOptions): Promise<GetHelmResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("qovery:index/getHelm:getHelm", {
        "advancedSettingsJson": args.advancedSettingsJson,
        "deploymentRestrictions": args.deploymentRestrictions,
        "deploymentStageId": args.deploymentStageId,
        "environmentVariableAliases": args.environmentVariableAliases,
        "environmentVariableOverrides": args.environmentVariableOverrides,
        "environmentVariables": args.environmentVariables,
        "id": args.id,
        "secretAliases": args.secretAliases,
        "secretOverrides": args.secretOverrides,
        "secrets": args.secrets,
    }, opts);
}

/**
 * A collection of arguments for invoking getHelm.
 */
export interface GetHelmArgs {
    /**
     * Advanced settings.
     */
    advancedSettingsJson?: string;
    /**
     * List of deployment restrictions
     */
    deploymentRestrictions?: inputs.GetHelmDeploymentRestriction[];
    /**
     * Id of the deployment stage.
     */
    deploymentStageId?: string;
    /**
     * List of environment variable aliases linked to this helm.
     */
    environmentVariableAliases?: inputs.GetHelmEnvironmentVariableAlias[];
    /**
     * List of environment variable overrides linked to this helm.
     */
    environmentVariableOverrides?: inputs.GetHelmEnvironmentVariableOverride[];
    /**
     * List of environment variables linked to this helm.
     */
    environmentVariables?: inputs.GetHelmEnvironmentVariable[];
    /**
     * Id of the helm.
     */
    id: string;
    /**
     * List of secret aliases linked to this helm.
     */
    secretAliases?: inputs.GetHelmSecretAlias[];
    /**
     * List of secret overrides linked to this helm.
     */
    secretOverrides?: inputs.GetHelmSecretOverride[];
    /**
     * List of secrets linked to this helm.
     */
    secrets?: inputs.GetHelmSecret[];
}

/**
 * A collection of values returned by getHelm.
 */
export interface GetHelmResult {
    /**
     * Advanced settings.
     */
    readonly advancedSettingsJson: string;
    /**
     * List of built-in environment variables linked to this helm.
     */
    readonly builtInEnvironmentVariables: outputs.GetHelmBuiltInEnvironmentVariable[];
    /**
     * List of deployment restrictions
     */
    readonly deploymentRestrictions?: outputs.GetHelmDeploymentRestriction[];
    /**
     * Id of the deployment stage.
     */
    readonly deploymentStageId: string;
    /**
     * Id of the environment.
     */
    readonly environmentId: string;
    /**
     * List of environment variable aliases linked to this helm.
     */
    readonly environmentVariableAliases: outputs.GetHelmEnvironmentVariableAlias[];
    /**
     * List of environment variable overrides linked to this helm.
     */
    readonly environmentVariableOverrides?: outputs.GetHelmEnvironmentVariableOverride[];
    /**
     * List of environment variables linked to this helm.
     */
    readonly environmentVariables?: outputs.GetHelmEnvironmentVariable[];
    /**
     * The helm external FQDN host [NOTE: only if your helm is using a publicly accessible port].
     */
    readonly externalHost: string;
    /**
     * Id of the helm.
     */
    readonly id: string;
    /**
     * The helm internal host.
     */
    readonly internalHost: string;
    /**
     * Name of the helm.
     */
    readonly name: string;
    /**
     * List of secret aliases linked to this helm.
     */
    readonly secretAliases?: outputs.GetHelmSecretAlias[];
    /**
     * List of secret overrides linked to this helm.
     */
    readonly secretOverrides?: outputs.GetHelmSecretOverride[];
    /**
     * List of secrets linked to this helm.
     */
    readonly secrets?: outputs.GetHelmSecret[];
}
/**
 * ## # qovery.Helm (Data Source)
 *
 * Provides a Qovery helm resource.
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as qovery from "@pulumi/qovery";
 *
 * const myHelm = qovery.getHelm({
 *     id: "<helm_id>",
 * });
 * ```
 */
export function getHelmOutput(args: GetHelmOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetHelmResult> {
    return pulumi.output(args).apply((a: any) => getHelm(a, opts))
}

/**
 * A collection of arguments for invoking getHelm.
 */
export interface GetHelmOutputArgs {
    /**
     * Advanced settings.
     */
    advancedSettingsJson?: pulumi.Input<string>;
    /**
     * List of deployment restrictions
     */
    deploymentRestrictions?: pulumi.Input<pulumi.Input<inputs.GetHelmDeploymentRestrictionArgs>[]>;
    /**
     * Id of the deployment stage.
     */
    deploymentStageId?: pulumi.Input<string>;
    /**
     * List of environment variable aliases linked to this helm.
     */
    environmentVariableAliases?: pulumi.Input<pulumi.Input<inputs.GetHelmEnvironmentVariableAliasArgs>[]>;
    /**
     * List of environment variable overrides linked to this helm.
     */
    environmentVariableOverrides?: pulumi.Input<pulumi.Input<inputs.GetHelmEnvironmentVariableOverrideArgs>[]>;
    /**
     * List of environment variables linked to this helm.
     */
    environmentVariables?: pulumi.Input<pulumi.Input<inputs.GetHelmEnvironmentVariableArgs>[]>;
    /**
     * Id of the helm.
     */
    id: pulumi.Input<string>;
    /**
     * List of secret aliases linked to this helm.
     */
    secretAliases?: pulumi.Input<pulumi.Input<inputs.GetHelmSecretAliasArgs>[]>;
    /**
     * List of secret overrides linked to this helm.
     */
    secretOverrides?: pulumi.Input<pulumi.Input<inputs.GetHelmSecretOverrideArgs>[]>;
    /**
     * List of secrets linked to this helm.
     */
    secrets?: pulumi.Input<pulumi.Input<inputs.GetHelmSecretArgs>[]>;
}
