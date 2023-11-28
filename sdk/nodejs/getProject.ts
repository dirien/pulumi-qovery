// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * ## # qovery.Project (Data Source)
 *
 * Provides a Qovery project resource. This can be used to create and manage Qovery projects.
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as qovery from "@pulumi/qovery";
 *
 * const myProject = qovery.getProject({
 *     id: "<project_id>",
 * });
 * ```
 */
export function getProject(args: GetProjectArgs, opts?: pulumi.InvokeOptions): Promise<GetProjectResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("qovery:index/getProject:getProject", {
        "description": args.description,
        "environmentVariableAliases": args.environmentVariableAliases,
        "environmentVariables": args.environmentVariables,
        "id": args.id,
        "secretAliases": args.secretAliases,
        "secrets": args.secrets,
    }, opts);
}

/**
 * A collection of arguments for invoking getProject.
 */
export interface GetProjectArgs {
    /**
     * Description of the project.
     */
    description?: string;
    /**
     * List of environment variable aliases linked to this project.
     */
    environmentVariableAliases?: inputs.GetProjectEnvironmentVariableAlias[];
    /**
     * List of environment variables linked to this project.
     */
    environmentVariables?: inputs.GetProjectEnvironmentVariable[];
    /**
     * Id of the environment variable.
     */
    id: string;
    /**
     * List of secret aliases linked to this project.
     */
    secretAliases?: inputs.GetProjectSecretAlias[];
    /**
     * List of secrets linked to this project.
     */
    secrets?: inputs.GetProjectSecret[];
}

/**
 * A collection of values returned by getProject.
 */
export interface GetProjectResult {
    /**
     * List of built-in environment variables linked to this project.
     */
    readonly builtInEnvironmentVariables: outputs.GetProjectBuiltInEnvironmentVariable[];
    /**
     * Description of the project.
     */
    readonly description: string;
    /**
     * List of environment variable aliases linked to this project.
     */
    readonly environmentVariableAliases: outputs.GetProjectEnvironmentVariableAlias[];
    /**
     * List of environment variables linked to this project.
     */
    readonly environmentVariables: outputs.GetProjectEnvironmentVariable[];
    /**
     * Id of the project.
     */
    readonly id: string;
    /**
     * Name of the project.
     */
    readonly name: string;
    /**
     * Id of the organization.
     */
    readonly organizationId: string;
    /**
     * List of secret aliases linked to this project.
     */
    readonly secretAliases: outputs.GetProjectSecretAlias[];
    /**
     * List of secrets linked to this project.
     */
    readonly secrets: outputs.GetProjectSecret[];
}
/**
 * ## # qovery.Project (Data Source)
 *
 * Provides a Qovery project resource. This can be used to create and manage Qovery projects.
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as qovery from "@pulumi/qovery";
 *
 * const myProject = qovery.getProject({
 *     id: "<project_id>",
 * });
 * ```
 */
export function getProjectOutput(args: GetProjectOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetProjectResult> {
    return pulumi.output(args).apply((a: any) => getProject(a, opts))
}

/**
 * A collection of arguments for invoking getProject.
 */
export interface GetProjectOutputArgs {
    /**
     * Description of the project.
     */
    description?: pulumi.Input<string>;
    /**
     * List of environment variable aliases linked to this project.
     */
    environmentVariableAliases?: pulumi.Input<pulumi.Input<inputs.GetProjectEnvironmentVariableAliasArgs>[]>;
    /**
     * List of environment variables linked to this project.
     */
    environmentVariables?: pulumi.Input<pulumi.Input<inputs.GetProjectEnvironmentVariableArgs>[]>;
    /**
     * Id of the environment variable.
     */
    id: pulumi.Input<string>;
    /**
     * List of secret aliases linked to this project.
     */
    secretAliases?: pulumi.Input<pulumi.Input<inputs.GetProjectSecretAliasArgs>[]>;
    /**
     * List of secrets linked to this project.
     */
    secrets?: pulumi.Input<pulumi.Input<inputs.GetProjectSecretArgs>[]>;
}
