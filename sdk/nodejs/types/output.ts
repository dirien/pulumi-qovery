// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

export interface ApplicationBuiltInEnvironmentVariable {
    id: string;
    key: string;
    value: string;
}

export interface ApplicationCustomDomain {
    domain: string;
    id: string;
    status: string;
    validationDomain: string;
}

export interface ApplicationEnvironmentVariable {
    id: string;
    key: string;
    value: string;
}

export interface ApplicationEnvironmentVariableAlias {
    id: string;
    key: string;
    value: string;
}

export interface ApplicationEnvironmentVariableOverride {
    id: string;
    key: string;
    value: string;
}

export interface ApplicationGitRepository {
    branch: string;
    gitTokenId?: string;
    rootPath: string;
    url: string;
}

export interface ApplicationHealthchecks {
    livenessProbe?: outputs.ApplicationHealthchecksLivenessProbe;
    readinessProbe?: outputs.ApplicationHealthchecksReadinessProbe;
}

export interface ApplicationHealthchecksLivenessProbe {
    failureThreshold: number;
    initialDelaySeconds: number;
    periodSeconds: number;
    successThreshold: number;
    timeoutSeconds: number;
    type: outputs.ApplicationHealthchecksLivenessProbeType;
}

export interface ApplicationHealthchecksLivenessProbeType {
    exec?: outputs.ApplicationHealthchecksLivenessProbeTypeExec;
    grpc?: outputs.ApplicationHealthchecksLivenessProbeTypeGrpc;
    http?: outputs.ApplicationHealthchecksLivenessProbeTypeHttp;
    tcp?: outputs.ApplicationHealthchecksLivenessProbeTypeTcp;
}

export interface ApplicationHealthchecksLivenessProbeTypeExec {
    commands: string[];
}

export interface ApplicationHealthchecksLivenessProbeTypeGrpc {
    port: number;
    service?: string;
}

export interface ApplicationHealthchecksLivenessProbeTypeHttp {
    path?: string;
    port: number;
    scheme?: string;
}

export interface ApplicationHealthchecksLivenessProbeTypeTcp {
    host?: string;
    port: number;
}

export interface ApplicationHealthchecksReadinessProbe {
    failureThreshold: number;
    initialDelaySeconds: number;
    periodSeconds: number;
    successThreshold: number;
    timeoutSeconds: number;
    type: outputs.ApplicationHealthchecksReadinessProbeType;
}

export interface ApplicationHealthchecksReadinessProbeType {
    exec?: outputs.ApplicationHealthchecksReadinessProbeTypeExec;
    grpc?: outputs.ApplicationHealthchecksReadinessProbeTypeGrpc;
    http?: outputs.ApplicationHealthchecksReadinessProbeTypeHttp;
    tcp?: outputs.ApplicationHealthchecksReadinessProbeTypeTcp;
}

export interface ApplicationHealthchecksReadinessProbeTypeExec {
    commands: string[];
}

export interface ApplicationHealthchecksReadinessProbeTypeGrpc {
    port: number;
    service?: string;
}

export interface ApplicationHealthchecksReadinessProbeTypeHttp {
    path?: string;
    port: number;
    scheme?: string;
}

export interface ApplicationHealthchecksReadinessProbeTypeTcp {
    host?: string;
    port: number;
}

export interface ApplicationPort {
    externalPort?: number;
    id: string;
    internalPort: number;
    isDefault: boolean;
    name: string;
    protocol: string;
    publiclyAccessible: boolean;
}

export interface ApplicationSecret {
    id: string;
    key: string;
    value: string;
}

export interface ApplicationSecretAlias {
    id: string;
    key: string;
    value: string;
}

export interface ApplicationSecretOverride {
    id: string;
    key: string;
    value: string;
}

export interface ApplicationStorage {
    id: string;
    mountPoint: string;
    size: number;
    type: string;
}

export interface ClusterFeatures {
    staticIp: boolean;
    vpcSubnet: string;
}

export interface ClusterRoutingTable {
    description: string;
    destination: string;
    target: string;
}

export interface ContainerBuiltInEnvironmentVariable {
    id: string;
    key: string;
    value: string;
}

export interface ContainerCustomDomain {
    domain: string;
    id: string;
    status: string;
    validationDomain: string;
}

export interface ContainerEnvironmentVariable {
    id: string;
    key: string;
    value: string;
}

export interface ContainerEnvironmentVariableAlias {
    id: string;
    key: string;
    value: string;
}

export interface ContainerEnvironmentVariableOverride {
    id: string;
    key: string;
    value: string;
}

export interface ContainerHealthchecks {
    livenessProbe?: outputs.ContainerHealthchecksLivenessProbe;
    readinessProbe?: outputs.ContainerHealthchecksReadinessProbe;
}

export interface ContainerHealthchecksLivenessProbe {
    failureThreshold: number;
    initialDelaySeconds: number;
    periodSeconds: number;
    successThreshold: number;
    timeoutSeconds: number;
    type: outputs.ContainerHealthchecksLivenessProbeType;
}

export interface ContainerHealthchecksLivenessProbeType {
    exec?: outputs.ContainerHealthchecksLivenessProbeTypeExec;
    grpc?: outputs.ContainerHealthchecksLivenessProbeTypeGrpc;
    http?: outputs.ContainerHealthchecksLivenessProbeTypeHttp;
    tcp?: outputs.ContainerHealthchecksLivenessProbeTypeTcp;
}

export interface ContainerHealthchecksLivenessProbeTypeExec {
    commands: string[];
}

export interface ContainerHealthchecksLivenessProbeTypeGrpc {
    port: number;
    service?: string;
}

export interface ContainerHealthchecksLivenessProbeTypeHttp {
    path?: string;
    port: number;
    scheme?: string;
}

export interface ContainerHealthchecksLivenessProbeTypeTcp {
    host?: string;
    port: number;
}

export interface ContainerHealthchecksReadinessProbe {
    failureThreshold: number;
    initialDelaySeconds: number;
    periodSeconds: number;
    successThreshold: number;
    timeoutSeconds: number;
    type: outputs.ContainerHealthchecksReadinessProbeType;
}

export interface ContainerHealthchecksReadinessProbeType {
    exec?: outputs.ContainerHealthchecksReadinessProbeTypeExec;
    grpc?: outputs.ContainerHealthchecksReadinessProbeTypeGrpc;
    http?: outputs.ContainerHealthchecksReadinessProbeTypeHttp;
    tcp?: outputs.ContainerHealthchecksReadinessProbeTypeTcp;
}

export interface ContainerHealthchecksReadinessProbeTypeExec {
    commands: string[];
}

export interface ContainerHealthchecksReadinessProbeTypeGrpc {
    port: number;
    service?: string;
}

export interface ContainerHealthchecksReadinessProbeTypeHttp {
    path?: string;
    port: number;
    scheme?: string;
}

export interface ContainerHealthchecksReadinessProbeTypeTcp {
    host?: string;
    port: number;
}

export interface ContainerPort {
    externalPort?: number;
    id: string;
    internalPort: number;
    isDefault: boolean;
    name: string;
    protocol: string;
    publiclyAccessible: boolean;
}

export interface ContainerRegistryConfig {
    accessKeyId?: string;
    password?: string;
    region?: string;
    scalewayAccessKey?: string;
    scalewaySecretKey?: string;
    secretAccessKey?: string;
    username?: string;
}

export interface ContainerSecret {
    id: string;
    key: string;
    value: string;
}

export interface ContainerSecretAlias {
    id: string;
    key: string;
    value: string;
}

export interface ContainerSecretOverride {
    id: string;
    key: string;
    value: string;
}

export interface ContainerStorage {
    id: string;
    mountPoint: string;
    size: number;
    type: string;
}

export interface EnvironmentBuiltInEnvironmentVariable {
    id: string;
    key: string;
    value: string;
}

export interface EnvironmentEnvironmentVariable {
    id: string;
    key: string;
    value: string;
}

export interface EnvironmentEnvironmentVariableAlias {
    id: string;
    key: string;
    value: string;
}

export interface EnvironmentEnvironmentVariableOverride {
    id: string;
    key: string;
    value: string;
}

export interface EnvironmentSecret {
    id: string;
    key: string;
    value: string;
}

export interface EnvironmentSecretAlias {
    id: string;
    key: string;
    value: string;
}

export interface EnvironmentSecretOverride {
    id: string;
    key: string;
    value: string;
}

export interface GetApplicationBuiltInEnvironmentVariable {
    id: string;
    key: string;
    value: string;
}

export interface GetApplicationCustomDomain {
    domain: string;
    id: string;
    status: string;
    validationDomain: string;
}

export interface GetApplicationEnvironmentVariable {
    id: string;
    key: string;
    value: string;
}

export interface GetApplicationEnvironmentVariableAlias {
    id: string;
    key: string;
    value: string;
}

export interface GetApplicationEnvironmentVariableOverride {
    id: string;
    key: string;
    value: string;
}

export interface GetApplicationGitRepository {
    branch: string;
    gitTokenId: string;
    rootPath: string;
    url: string;
}

export interface GetApplicationHealthchecks {
    livenessProbe?: outputs.GetApplicationHealthchecksLivenessProbe;
    readinessProbe?: outputs.GetApplicationHealthchecksReadinessProbe;
}

export interface GetApplicationHealthchecksLivenessProbe {
    failureThreshold: number;
    initialDelaySeconds: number;
    periodSeconds: number;
    successThreshold: number;
    timeoutSeconds: number;
    type: outputs.GetApplicationHealthchecksLivenessProbeType;
}

export interface GetApplicationHealthchecksLivenessProbeType {
    exec?: outputs.GetApplicationHealthchecksLivenessProbeTypeExec;
    grpc?: outputs.GetApplicationHealthchecksLivenessProbeTypeGrpc;
    http?: outputs.GetApplicationHealthchecksLivenessProbeTypeHttp;
    tcp?: outputs.GetApplicationHealthchecksLivenessProbeTypeTcp;
}

export interface GetApplicationHealthchecksLivenessProbeTypeExec {
    commands: string[];
}

export interface GetApplicationHealthchecksLivenessProbeTypeGrpc {
    port: number;
    service?: string;
}

export interface GetApplicationHealthchecksLivenessProbeTypeHttp {
    path?: string;
    port: number;
    scheme?: string;
}

export interface GetApplicationHealthchecksLivenessProbeTypeTcp {
    host?: string;
    port: number;
}

export interface GetApplicationHealthchecksReadinessProbe {
    failureThreshold: number;
    initialDelaySeconds: number;
    periodSeconds: number;
    successThreshold: number;
    timeoutSeconds: number;
    type: outputs.GetApplicationHealthchecksReadinessProbeType;
}

export interface GetApplicationHealthchecksReadinessProbeType {
    exec?: outputs.GetApplicationHealthchecksReadinessProbeTypeExec;
    grpc?: outputs.GetApplicationHealthchecksReadinessProbeTypeGrpc;
    http?: outputs.GetApplicationHealthchecksReadinessProbeTypeHttp;
    tcp?: outputs.GetApplicationHealthchecksReadinessProbeTypeTcp;
}

export interface GetApplicationHealthchecksReadinessProbeTypeExec {
    commands: string[];
}

export interface GetApplicationHealthchecksReadinessProbeTypeGrpc {
    port: number;
    service?: string;
}

export interface GetApplicationHealthchecksReadinessProbeTypeHttp {
    path?: string;
    port: number;
    scheme?: string;
}

export interface GetApplicationHealthchecksReadinessProbeTypeTcp {
    host?: string;
    port: number;
}

export interface GetApplicationPort {
    externalPort: number;
    id: string;
    internalPort: number;
    isDefault: boolean;
    name: string;
    protocol: string;
    publiclyAccessible: boolean;
}

export interface GetApplicationSecret {
    id: string;
    key: string;
    value: string;
}

export interface GetApplicationSecretAlias {
    id: string;
    key: string;
    value: string;
}

export interface GetApplicationSecretOverride {
    id: string;
    key: string;
    value: string;
}

export interface GetApplicationStorage {
    id: string;
    mountPoint: string;
    size: number;
    type: string;
}

export interface GetClusterFeatures {
    staticIp: boolean;
    vpcSubnet: string;
}

export interface GetClusterRoutingTable {
    description: string;
    destination: string;
    target: string;
}

export interface GetContainerBuiltInEnvironmentVariable {
    id: string;
    key: string;
    value: string;
}

export interface GetContainerCustomDomain {
    domain: string;
    id: string;
    status: string;
    validationDomain: string;
}

export interface GetContainerEnvironmentVariable {
    id: string;
    key: string;
    value: string;
}

export interface GetContainerEnvironmentVariableAlias {
    id: string;
    key: string;
    value: string;
}

export interface GetContainerEnvironmentVariableOverride {
    id: string;
    key: string;
    value: string;
}

export interface GetContainerHealthchecks {
    livenessProbe?: outputs.GetContainerHealthchecksLivenessProbe;
    readinessProbe?: outputs.GetContainerHealthchecksReadinessProbe;
}

export interface GetContainerHealthchecksLivenessProbe {
    failureThreshold: number;
    initialDelaySeconds: number;
    periodSeconds: number;
    successThreshold: number;
    timeoutSeconds: number;
    type: outputs.GetContainerHealthchecksLivenessProbeType;
}

export interface GetContainerHealthchecksLivenessProbeType {
    exec?: outputs.GetContainerHealthchecksLivenessProbeTypeExec;
    grpc?: outputs.GetContainerHealthchecksLivenessProbeTypeGrpc;
    http?: outputs.GetContainerHealthchecksLivenessProbeTypeHttp;
    tcp?: outputs.GetContainerHealthchecksLivenessProbeTypeTcp;
}

export interface GetContainerHealthchecksLivenessProbeTypeExec {
    commands: string[];
}

export interface GetContainerHealthchecksLivenessProbeTypeGrpc {
    port: number;
    service?: string;
}

export interface GetContainerHealthchecksLivenessProbeTypeHttp {
    path?: string;
    port: number;
    scheme?: string;
}

export interface GetContainerHealthchecksLivenessProbeTypeTcp {
    host?: string;
    port: number;
}

export interface GetContainerHealthchecksReadinessProbe {
    failureThreshold: number;
    initialDelaySeconds: number;
    periodSeconds: number;
    successThreshold: number;
    timeoutSeconds: number;
    type: outputs.GetContainerHealthchecksReadinessProbeType;
}

export interface GetContainerHealthchecksReadinessProbeType {
    exec?: outputs.GetContainerHealthchecksReadinessProbeTypeExec;
    grpc?: outputs.GetContainerHealthchecksReadinessProbeTypeGrpc;
    http?: outputs.GetContainerHealthchecksReadinessProbeTypeHttp;
    tcp?: outputs.GetContainerHealthchecksReadinessProbeTypeTcp;
}

export interface GetContainerHealthchecksReadinessProbeTypeExec {
    commands: string[];
}

export interface GetContainerHealthchecksReadinessProbeTypeGrpc {
    port: number;
    service?: string;
}

export interface GetContainerHealthchecksReadinessProbeTypeHttp {
    path?: string;
    port: number;
    scheme?: string;
}

export interface GetContainerHealthchecksReadinessProbeTypeTcp {
    host?: string;
    port: number;
}

export interface GetContainerPort {
    externalPort: number;
    id: string;
    internalPort: number;
    isDefault: boolean;
    name: string;
    protocol: string;
    publiclyAccessible: boolean;
}

export interface GetContainerSecret {
    id: string;
    key: string;
    value: string;
}

export interface GetContainerSecretAlias {
    id: string;
    key: string;
    value: string;
}

export interface GetContainerSecretOverride {
    id: string;
    key: string;
    value: string;
}

export interface GetContainerStorage {
    id: string;
    mountPoint: string;
    size: number;
    type: string;
}

export interface GetEnvironmentBuiltInEnvironmentVariable {
    id: string;
    key: string;
    value: string;
}

export interface GetEnvironmentEnvironmentVariable {
    id: string;
    key: string;
    value: string;
}

export interface GetEnvironmentEnvironmentVariableAlias {
    id: string;
    key: string;
    value: string;
}

export interface GetEnvironmentEnvironmentVariableOverride {
    id: string;
    key: string;
    value: string;
}

export interface GetEnvironmentSecret {
    id: string;
    key: string;
    value: string;
}

export interface GetEnvironmentSecretAlias {
    id: string;
    key: string;
    value: string;
}

export interface GetEnvironmentSecretOverride {
    id: string;
    key: string;
    value: string;
}

export interface GetHelmBuiltInEnvironmentVariable {
    id: string;
    key: string;
    value: string;
}

export interface GetHelmEnvironmentVariable {
    id: string;
    key: string;
    value: string;
}

export interface GetHelmEnvironmentVariableAlias {
    id: string;
    key: string;
    value: string;
}

export interface GetHelmEnvironmentVariableOverride {
    id: string;
    key: string;
    value: string;
}

export interface GetHelmSecret {
    id: string;
    key: string;
    value: string;
}

export interface GetHelmSecretAlias {
    id: string;
    key: string;
    value: string;
}

export interface GetHelmSecretOverride {
    id: string;
    key: string;
    value: string;
}

export interface GetJobBuiltInEnvironmentVariable {
    id: string;
    key: string;
    value: string;
}

export interface GetJobEnvironmentVariable {
    id: string;
    key: string;
    value: string;
}

export interface GetJobEnvironmentVariableAlias {
    id: string;
    key: string;
    value: string;
}

export interface GetJobEnvironmentVariableOverride {
    id: string;
    key: string;
    value: string;
}

export interface GetJobHealthchecks {
    livenessProbe?: outputs.GetJobHealthchecksLivenessProbe;
    readinessProbe?: outputs.GetJobHealthchecksReadinessProbe;
}

export interface GetJobHealthchecksLivenessProbe {
    failureThreshold: number;
    initialDelaySeconds: number;
    periodSeconds: number;
    successThreshold: number;
    timeoutSeconds: number;
    type: outputs.GetJobHealthchecksLivenessProbeType;
}

export interface GetJobHealthchecksLivenessProbeType {
    exec?: outputs.GetJobHealthchecksLivenessProbeTypeExec;
    grpc?: outputs.GetJobHealthchecksLivenessProbeTypeGrpc;
    http?: outputs.GetJobHealthchecksLivenessProbeTypeHttp;
    tcp?: outputs.GetJobHealthchecksLivenessProbeTypeTcp;
}

export interface GetJobHealthchecksLivenessProbeTypeExec {
    commands: string[];
}

export interface GetJobHealthchecksLivenessProbeTypeGrpc {
    port: number;
    service?: string;
}

export interface GetJobHealthchecksLivenessProbeTypeHttp {
    path?: string;
    port: number;
    scheme?: string;
}

export interface GetJobHealthchecksLivenessProbeTypeTcp {
    host?: string;
    port: number;
}

export interface GetJobHealthchecksReadinessProbe {
    failureThreshold: number;
    initialDelaySeconds: number;
    periodSeconds: number;
    successThreshold: number;
    timeoutSeconds: number;
    type: outputs.GetJobHealthchecksReadinessProbeType;
}

export interface GetJobHealthchecksReadinessProbeType {
    exec?: outputs.GetJobHealthchecksReadinessProbeTypeExec;
    grpc?: outputs.GetJobHealthchecksReadinessProbeTypeGrpc;
    http?: outputs.GetJobHealthchecksReadinessProbeTypeHttp;
    tcp?: outputs.GetJobHealthchecksReadinessProbeTypeTcp;
}

export interface GetJobHealthchecksReadinessProbeTypeExec {
    commands: string[];
}

export interface GetJobHealthchecksReadinessProbeTypeGrpc {
    port: number;
    service?: string;
}

export interface GetJobHealthchecksReadinessProbeTypeHttp {
    path?: string;
    port: number;
    scheme?: string;
}

export interface GetJobHealthchecksReadinessProbeTypeTcp {
    host?: string;
    port: number;
}

export interface GetJobSchedule {
    cronjob: outputs.GetJobScheduleCronjob;
    onDelete: outputs.GetJobScheduleOnDelete;
    onStart: outputs.GetJobScheduleOnStart;
    onStop: outputs.GetJobScheduleOnStop;
}

export interface GetJobScheduleCronjob {
    command: outputs.GetJobScheduleCronjobCommand;
    schedule: string;
}

export interface GetJobScheduleCronjobCommand {
    arguments: string[];
    entrypoint: string;
}

export interface GetJobScheduleOnDelete {
    arguments: string[];
    entrypoint: string;
}

export interface GetJobScheduleOnStart {
    arguments?: string[];
    entrypoint: string;
}

export interface GetJobScheduleOnStop {
    arguments?: string[];
    entrypoint: string;
}

export interface GetJobSecret {
    id: string;
    key: string;
    value: string;
}

export interface GetJobSecretAlias {
    id: string;
    key: string;
    value: string;
}

export interface GetJobSecretOverride {
    id: string;
    key: string;
    value: string;
}

export interface GetJobSource {
    docker: outputs.GetJobSourceDocker;
    image: outputs.GetJobSourceImage;
}

export interface GetJobSourceDocker {
    dockerfilePath?: string;
    gitRepository: outputs.GetJobSourceDockerGitRepository;
}

export interface GetJobSourceDockerGitRepository {
    branch: string;
    gitTokenId?: string;
    rootPath: string;
    url: string;
}

export interface GetJobSourceImage {
    name: string;
    registryId: string;
    tag: string;
}

export interface GetProjectBuiltInEnvironmentVariable {
    /**
     * Id of the environment variable.
     */
    id: string;
    /**
     * Key of the environment variable.
     */
    key: string;
    /**
     * Value of the environment variable.
     */
    value: string;
}

export interface GetProjectEnvironmentVariable {
    /**
     * Id of the environment variable.
     */
    id: string;
    /**
     * Key of the environment variable.
     */
    key: string;
    /**
     * Value of the environment variable.
     */
    value: string;
}

export interface GetProjectEnvironmentVariableAlias {
    /**
     * Id of the environment variable alias.
     */
    id: string;
    /**
     * Name of the environment variable alias.
     */
    key: string;
    /**
     * Name of the variable to alias.
     */
    value: string;
}

export interface GetProjectSecret {
    /**
     * Id of the secret.
     */
    id: string;
    /**
     * Key of the secret.
     */
    key: string;
    /**
     * Value of the secret.
     */
    value: string;
}

export interface GetProjectSecretAlias {
    /**
     * Id of the secret alias.
     */
    id: string;
    /**
     * Name of the secret alias.
     */
    key: string;
    /**
     * Name of the secret to alias.
     */
    value: string;
}

export interface HelmBuiltInEnvironmentVariable {
    id: string;
    key: string;
    value: string;
}

export interface HelmEnvironmentVariable {
    id: string;
    key: string;
    value: string;
}

export interface HelmEnvironmentVariableAlias {
    id: string;
    key: string;
    value: string;
}

export interface HelmEnvironmentVariableOverride {
    id: string;
    key: string;
    value: string;
}

export interface HelmPorts {
    externalPort: number;
    internalPort: number;
    isDefault: boolean;
    namespace?: string;
    protocol: string;
    serviceName: string;
}

export interface HelmRepositoryConfig {
    accessKeyId?: string;
    password?: string;
    region?: string;
    scalewayAccessKey?: string;
    scalewaySecretKey?: string;
    secretAccessKey?: string;
    username?: string;
}

export interface HelmSecret {
    id: string;
    key: string;
    value: string;
}

export interface HelmSecretAlias {
    id: string;
    key: string;
    value: string;
}

export interface HelmSecretOverride {
    id: string;
    key: string;
    value: string;
}

export interface HelmSource {
    gitRepository?: outputs.HelmSourceGitRepository;
    helmRepository?: outputs.HelmSourceHelmRepository;
}

export interface HelmSourceGitRepository {
    branch: string;
    gitTokenId: string;
    rootPath: string;
    url: string;
}

export interface HelmSourceHelmRepository {
    chartName: string;
    chartVersion: string;
    helmRepositoryId: string;
}

export interface HelmValuesOverride {
    file?: outputs.HelmValuesOverrideFile;
    set: {[key: string]: string};
    setJson: {[key: string]: string};
    setString: {[key: string]: string};
}

export interface HelmValuesOverrideFile {
    gitRepository?: outputs.HelmValuesOverrideFileGitRepository;
    raw?: {[key: string]: outputs.HelmValuesOverrideFileRaw};
}

export interface HelmValuesOverrideFileGitRepository {
    branch: string;
    gitTokenId: string;
    paths: string[];
    url: string;
}

export interface HelmValuesOverrideFileRaw {
    content: string;
}

export interface JobBuiltInEnvironmentVariable {
    id: string;
    key: string;
    value: string;
}

export interface JobEnvironmentVariable {
    id: string;
    key: string;
    value: string;
}

export interface JobEnvironmentVariableAlias {
    id: string;
    key: string;
    value: string;
}

export interface JobEnvironmentVariableOverride {
    id: string;
    key: string;
    value: string;
}

export interface JobHealthchecks {
    livenessProbe?: outputs.JobHealthchecksLivenessProbe;
    readinessProbe?: outputs.JobHealthchecksReadinessProbe;
}

export interface JobHealthchecksLivenessProbe {
    failureThreshold: number;
    initialDelaySeconds: number;
    periodSeconds: number;
    successThreshold: number;
    timeoutSeconds: number;
    type: outputs.JobHealthchecksLivenessProbeType;
}

export interface JobHealthchecksLivenessProbeType {
    exec?: outputs.JobHealthchecksLivenessProbeTypeExec;
    grpc?: outputs.JobHealthchecksLivenessProbeTypeGrpc;
    http?: outputs.JobHealthchecksLivenessProbeTypeHttp;
    tcp?: outputs.JobHealthchecksLivenessProbeTypeTcp;
}

export interface JobHealthchecksLivenessProbeTypeExec {
    commands: string[];
}

export interface JobHealthchecksLivenessProbeTypeGrpc {
    port: number;
    service?: string;
}

export interface JobHealthchecksLivenessProbeTypeHttp {
    path?: string;
    port: number;
    scheme?: string;
}

export interface JobHealthchecksLivenessProbeTypeTcp {
    host?: string;
    port: number;
}

export interface JobHealthchecksReadinessProbe {
    failureThreshold: number;
    initialDelaySeconds: number;
    periodSeconds: number;
    successThreshold: number;
    timeoutSeconds: number;
    type: outputs.JobHealthchecksReadinessProbeType;
}

export interface JobHealthchecksReadinessProbeType {
    exec?: outputs.JobHealthchecksReadinessProbeTypeExec;
    grpc?: outputs.JobHealthchecksReadinessProbeTypeGrpc;
    http?: outputs.JobHealthchecksReadinessProbeTypeHttp;
    tcp?: outputs.JobHealthchecksReadinessProbeTypeTcp;
}

export interface JobHealthchecksReadinessProbeTypeExec {
    commands: string[];
}

export interface JobHealthchecksReadinessProbeTypeGrpc {
    port: number;
    service?: string;
}

export interface JobHealthchecksReadinessProbeTypeHttp {
    path?: string;
    port: number;
    scheme?: string;
}

export interface JobHealthchecksReadinessProbeTypeTcp {
    host?: string;
    port: number;
}

export interface JobSchedule {
    cronjob?: outputs.JobScheduleCronjob;
    onDelete?: outputs.JobScheduleOnDelete;
    onStart?: outputs.JobScheduleOnStart;
    onStop?: outputs.JobScheduleOnStop;
}

export interface JobScheduleCronjob {
    command: outputs.JobScheduleCronjobCommand;
    schedule: string;
}

export interface JobScheduleCronjobCommand {
    arguments: string[];
    entrypoint: string;
}

export interface JobScheduleOnDelete {
    arguments: string[];
    entrypoint: string;
}

export interface JobScheduleOnStart {
    arguments: string[];
    entrypoint: string;
}

export interface JobScheduleOnStop {
    arguments: string[];
    entrypoint: string;
}

export interface JobSecret {
    id: string;
    key: string;
    value: string;
}

export interface JobSecretAlias {
    id: string;
    key: string;
    value: string;
}

export interface JobSecretOverride {
    id: string;
    key: string;
    value: string;
}

export interface JobSource {
    docker?: outputs.JobSourceDocker;
    image?: outputs.JobSourceImage;
}

export interface JobSourceDocker {
    dockerfilePath?: string;
    gitRepository: outputs.JobSourceDockerGitRepository;
}

export interface JobSourceDockerGitRepository {
    branch: string;
    gitTokenId?: string;
    rootPath: string;
    url: string;
}

export interface JobSourceImage {
    name: string;
    registryId: string;
    tag: string;
}

export interface ProjectBuiltInEnvironmentVariable {
    /**
     * Id of the environment variable.
     */
    id: string;
    /**
     * Key of the environment variable.
     */
    key: string;
    /**
     * Value of the environment variable.
     */
    value: string;
}

export interface ProjectEnvironmentVariable {
    /**
     * Id of the environment variable.
     */
    id: string;
    /**
     * Key of the environment variable.
     */
    key: string;
    /**
     * Value of the environment variable.
     */
    value: string;
}

export interface ProjectEnvironmentVariableAlias {
    /**
     * Id of the environment variable alias.
     */
    id: string;
    /**
     * Name of the environment variable alias.
     */
    key: string;
    /**
     * Name of the variable to alias.
     */
    value: string;
}

export interface ProjectSecret {
    /**
     * Id of the secret.
     */
    id: string;
    /**
     * Key of the secret.
     */
    key: string;
    /**
     * Value of the secret.
     */
    value: string;
}

export interface ProjectSecretAlias {
    /**
     * Id of the secret alias.
     */
    id: string;
    /**
     * Name of the secret alias.
     */
    key: string;
    /**
     * Name of the secret to alias.
     */
    value: string;
}

