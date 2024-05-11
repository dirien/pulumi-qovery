// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package qovery

import (
	"context"
	"reflect"

	"errors"
	"github.com/dirien/pulumi-qovery/sdk/go/qovery/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// ## # Helm (Resource)
//
// Provides a Qovery helm resource. This can be used to create and manage Qovery helm registry.
//
// ## Import
//
// ```sh
// $ pulumi import qovery:index/helm:Helm my_helm "<helm_id>"
// ```
type Helm struct {
	pulumi.CustomResourceState

	// Advanced settings.
	AdvancedSettingsJson pulumi.StringOutput `pulumi:"advancedSettingsJson"`
	// Allow this chart to deploy resources outside of this environment namespace (including CRDs or non-namespaced resources)
	AllowClusterWideResources pulumi.BoolOutput `pulumi:"allowClusterWideResources"`
	// Helm arguments
	Arguments pulumi.StringArrayOutput `pulumi:"arguments"`
	// Specify if the service will be automatically updated on every new commit on the branch.
	AutoDeploy pulumi.BoolOutput `pulumi:"autoDeploy"`
	// Specify if the environment preview option is activated or not for this helm.
	AutoPreview pulumi.BoolOutput `pulumi:"autoPreview"`
	// List of built-in environment variables linked to this helm.
	BuiltInEnvironmentVariables HelmBuiltInEnvironmentVariableArrayOutput `pulumi:"builtInEnvironmentVariables"`
	// List of deployment restrictions
	DeploymentRestrictions HelmDeploymentRestrictionArrayOutput `pulumi:"deploymentRestrictions"`
	// Id of the deployment stage.
	DeploymentStageId pulumi.StringOutput `pulumi:"deploymentStageId"`
	// Id of the environment.
	EnvironmentId pulumi.StringOutput `pulumi:"environmentId"`
	// List of environment variable aliases linked to this helm.
	EnvironmentVariableAliases HelmEnvironmentVariableAliasArrayOutput `pulumi:"environmentVariableAliases"`
	// List of environment variable overrides linked to this helm.
	EnvironmentVariableOverrides HelmEnvironmentVariableOverrideArrayOutput `pulumi:"environmentVariableOverrides"`
	// List of environment variables linked to this helm.
	EnvironmentVariables HelmEnvironmentVariableArrayOutput `pulumi:"environmentVariables"`
	// The helm external FQDN host [NOTE: only if your helm is using a publicly accessible port].
	ExternalHost pulumi.StringOutput `pulumi:"externalHost"`
	// The helm internal host.
	InternalHost pulumi.StringOutput `pulumi:"internalHost"`
	// Name of the helm.
	Name pulumi.StringOutput `pulumi:"name"`
	// List of ports linked to this helm.
	Ports HelmPortsMapOutput `pulumi:"ports"`
	// List of secret aliases linked to this helm.
	SecretAliases HelmSecretAliasArrayOutput `pulumi:"secretAliases"`
	// List of secret overrides linked to this helm.
	SecretOverrides HelmSecretOverrideArrayOutput `pulumi:"secretOverrides"`
	// List of secrets linked to this helm.
	Secrets HelmSecretArrayOutput `pulumi:"secrets"`
	// Helm chart from a Helm repository or from a git repository
	Source HelmSourceOutput `pulumi:"source"`
	// Helm timeout in second
	TimeoutSec pulumi.IntOutput `pulumi:"timeoutSec"`
	// Define your own overrides to customize the helm chart behaviour.
	ValuesOverride HelmValuesOverrideOutput `pulumi:"valuesOverride"`
}

// NewHelm registers a new resource with the given unique name, arguments, and options.
func NewHelm(ctx *pulumi.Context,
	name string, args *HelmArgs, opts ...pulumi.ResourceOption) (*Helm, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AllowClusterWideResources == nil {
		return nil, errors.New("invalid value for required argument 'AllowClusterWideResources'")
	}
	if args.EnvironmentId == nil {
		return nil, errors.New("invalid value for required argument 'EnvironmentId'")
	}
	if args.Source == nil {
		return nil, errors.New("invalid value for required argument 'Source'")
	}
	if args.ValuesOverride == nil {
		return nil, errors.New("invalid value for required argument 'ValuesOverride'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Helm
	err := ctx.RegisterResource("qovery:index/helm:Helm", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetHelm gets an existing Helm resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetHelm(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *HelmState, opts ...pulumi.ResourceOption) (*Helm, error) {
	var resource Helm
	err := ctx.ReadResource("qovery:index/helm:Helm", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Helm resources.
type helmState struct {
	// Advanced settings.
	AdvancedSettingsJson *string `pulumi:"advancedSettingsJson"`
	// Allow this chart to deploy resources outside of this environment namespace (including CRDs or non-namespaced resources)
	AllowClusterWideResources *bool `pulumi:"allowClusterWideResources"`
	// Helm arguments
	Arguments []string `pulumi:"arguments"`
	// Specify if the service will be automatically updated on every new commit on the branch.
	AutoDeploy *bool `pulumi:"autoDeploy"`
	// Specify if the environment preview option is activated or not for this helm.
	AutoPreview *bool `pulumi:"autoPreview"`
	// List of built-in environment variables linked to this helm.
	BuiltInEnvironmentVariables []HelmBuiltInEnvironmentVariable `pulumi:"builtInEnvironmentVariables"`
	// List of deployment restrictions
	DeploymentRestrictions []HelmDeploymentRestriction `pulumi:"deploymentRestrictions"`
	// Id of the deployment stage.
	DeploymentStageId *string `pulumi:"deploymentStageId"`
	// Id of the environment.
	EnvironmentId *string `pulumi:"environmentId"`
	// List of environment variable aliases linked to this helm.
	EnvironmentVariableAliases []HelmEnvironmentVariableAlias `pulumi:"environmentVariableAliases"`
	// List of environment variable overrides linked to this helm.
	EnvironmentVariableOverrides []HelmEnvironmentVariableOverride `pulumi:"environmentVariableOverrides"`
	// List of environment variables linked to this helm.
	EnvironmentVariables []HelmEnvironmentVariable `pulumi:"environmentVariables"`
	// The helm external FQDN host [NOTE: only if your helm is using a publicly accessible port].
	ExternalHost *string `pulumi:"externalHost"`
	// The helm internal host.
	InternalHost *string `pulumi:"internalHost"`
	// Name of the helm.
	Name *string `pulumi:"name"`
	// List of ports linked to this helm.
	Ports map[string]HelmPorts `pulumi:"ports"`
	// List of secret aliases linked to this helm.
	SecretAliases []HelmSecretAlias `pulumi:"secretAliases"`
	// List of secret overrides linked to this helm.
	SecretOverrides []HelmSecretOverride `pulumi:"secretOverrides"`
	// List of secrets linked to this helm.
	Secrets []HelmSecret `pulumi:"secrets"`
	// Helm chart from a Helm repository or from a git repository
	Source *HelmSource `pulumi:"source"`
	// Helm timeout in second
	TimeoutSec *int `pulumi:"timeoutSec"`
	// Define your own overrides to customize the helm chart behaviour.
	ValuesOverride *HelmValuesOverride `pulumi:"valuesOverride"`
}

type HelmState struct {
	// Advanced settings.
	AdvancedSettingsJson pulumi.StringPtrInput
	// Allow this chart to deploy resources outside of this environment namespace (including CRDs or non-namespaced resources)
	AllowClusterWideResources pulumi.BoolPtrInput
	// Helm arguments
	Arguments pulumi.StringArrayInput
	// Specify if the service will be automatically updated on every new commit on the branch.
	AutoDeploy pulumi.BoolPtrInput
	// Specify if the environment preview option is activated or not for this helm.
	AutoPreview pulumi.BoolPtrInput
	// List of built-in environment variables linked to this helm.
	BuiltInEnvironmentVariables HelmBuiltInEnvironmentVariableArrayInput
	// List of deployment restrictions
	DeploymentRestrictions HelmDeploymentRestrictionArrayInput
	// Id of the deployment stage.
	DeploymentStageId pulumi.StringPtrInput
	// Id of the environment.
	EnvironmentId pulumi.StringPtrInput
	// List of environment variable aliases linked to this helm.
	EnvironmentVariableAliases HelmEnvironmentVariableAliasArrayInput
	// List of environment variable overrides linked to this helm.
	EnvironmentVariableOverrides HelmEnvironmentVariableOverrideArrayInput
	// List of environment variables linked to this helm.
	EnvironmentVariables HelmEnvironmentVariableArrayInput
	// The helm external FQDN host [NOTE: only if your helm is using a publicly accessible port].
	ExternalHost pulumi.StringPtrInput
	// The helm internal host.
	InternalHost pulumi.StringPtrInput
	// Name of the helm.
	Name pulumi.StringPtrInput
	// List of ports linked to this helm.
	Ports HelmPortsMapInput
	// List of secret aliases linked to this helm.
	SecretAliases HelmSecretAliasArrayInput
	// List of secret overrides linked to this helm.
	SecretOverrides HelmSecretOverrideArrayInput
	// List of secrets linked to this helm.
	Secrets HelmSecretArrayInput
	// Helm chart from a Helm repository or from a git repository
	Source HelmSourcePtrInput
	// Helm timeout in second
	TimeoutSec pulumi.IntPtrInput
	// Define your own overrides to customize the helm chart behaviour.
	ValuesOverride HelmValuesOverridePtrInput
}

func (HelmState) ElementType() reflect.Type {
	return reflect.TypeOf((*helmState)(nil)).Elem()
}

type helmArgs struct {
	// Advanced settings.
	AdvancedSettingsJson *string `pulumi:"advancedSettingsJson"`
	// Allow this chart to deploy resources outside of this environment namespace (including CRDs or non-namespaced resources)
	AllowClusterWideResources bool `pulumi:"allowClusterWideResources"`
	// Helm arguments
	Arguments []string `pulumi:"arguments"`
	// Specify if the service will be automatically updated on every new commit on the branch.
	AutoDeploy *bool `pulumi:"autoDeploy"`
	// Specify if the environment preview option is activated or not for this helm.
	AutoPreview *bool `pulumi:"autoPreview"`
	// List of deployment restrictions
	DeploymentRestrictions []HelmDeploymentRestriction `pulumi:"deploymentRestrictions"`
	// Id of the deployment stage.
	DeploymentStageId *string `pulumi:"deploymentStageId"`
	// Id of the environment.
	EnvironmentId string `pulumi:"environmentId"`
	// List of environment variable aliases linked to this helm.
	EnvironmentVariableAliases []HelmEnvironmentVariableAlias `pulumi:"environmentVariableAliases"`
	// List of environment variable overrides linked to this helm.
	EnvironmentVariableOverrides []HelmEnvironmentVariableOverride `pulumi:"environmentVariableOverrides"`
	// List of environment variables linked to this helm.
	EnvironmentVariables []HelmEnvironmentVariable `pulumi:"environmentVariables"`
	// Name of the helm.
	Name *string `pulumi:"name"`
	// List of ports linked to this helm.
	Ports map[string]HelmPorts `pulumi:"ports"`
	// List of secret aliases linked to this helm.
	SecretAliases []HelmSecretAlias `pulumi:"secretAliases"`
	// List of secret overrides linked to this helm.
	SecretOverrides []HelmSecretOverride `pulumi:"secretOverrides"`
	// List of secrets linked to this helm.
	Secrets []HelmSecret `pulumi:"secrets"`
	// Helm chart from a Helm repository or from a git repository
	Source HelmSource `pulumi:"source"`
	// Helm timeout in second
	TimeoutSec *int `pulumi:"timeoutSec"`
	// Define your own overrides to customize the helm chart behaviour.
	ValuesOverride HelmValuesOverride `pulumi:"valuesOverride"`
}

// The set of arguments for constructing a Helm resource.
type HelmArgs struct {
	// Advanced settings.
	AdvancedSettingsJson pulumi.StringPtrInput
	// Allow this chart to deploy resources outside of this environment namespace (including CRDs or non-namespaced resources)
	AllowClusterWideResources pulumi.BoolInput
	// Helm arguments
	Arguments pulumi.StringArrayInput
	// Specify if the service will be automatically updated on every new commit on the branch.
	AutoDeploy pulumi.BoolPtrInput
	// Specify if the environment preview option is activated or not for this helm.
	AutoPreview pulumi.BoolPtrInput
	// List of deployment restrictions
	DeploymentRestrictions HelmDeploymentRestrictionArrayInput
	// Id of the deployment stage.
	DeploymentStageId pulumi.StringPtrInput
	// Id of the environment.
	EnvironmentId pulumi.StringInput
	// List of environment variable aliases linked to this helm.
	EnvironmentVariableAliases HelmEnvironmentVariableAliasArrayInput
	// List of environment variable overrides linked to this helm.
	EnvironmentVariableOverrides HelmEnvironmentVariableOverrideArrayInput
	// List of environment variables linked to this helm.
	EnvironmentVariables HelmEnvironmentVariableArrayInput
	// Name of the helm.
	Name pulumi.StringPtrInput
	// List of ports linked to this helm.
	Ports HelmPortsMapInput
	// List of secret aliases linked to this helm.
	SecretAliases HelmSecretAliasArrayInput
	// List of secret overrides linked to this helm.
	SecretOverrides HelmSecretOverrideArrayInput
	// List of secrets linked to this helm.
	Secrets HelmSecretArrayInput
	// Helm chart from a Helm repository or from a git repository
	Source HelmSourceInput
	// Helm timeout in second
	TimeoutSec pulumi.IntPtrInput
	// Define your own overrides to customize the helm chart behaviour.
	ValuesOverride HelmValuesOverrideInput
}

func (HelmArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*helmArgs)(nil)).Elem()
}

type HelmInput interface {
	pulumi.Input

	ToHelmOutput() HelmOutput
	ToHelmOutputWithContext(ctx context.Context) HelmOutput
}

func (*Helm) ElementType() reflect.Type {
	return reflect.TypeOf((**Helm)(nil)).Elem()
}

func (i *Helm) ToHelmOutput() HelmOutput {
	return i.ToHelmOutputWithContext(context.Background())
}

func (i *Helm) ToHelmOutputWithContext(ctx context.Context) HelmOutput {
	return pulumi.ToOutputWithContext(ctx, i).(HelmOutput)
}

// HelmArrayInput is an input type that accepts HelmArray and HelmArrayOutput values.
// You can construct a concrete instance of `HelmArrayInput` via:
//
//	HelmArray{ HelmArgs{...} }
type HelmArrayInput interface {
	pulumi.Input

	ToHelmArrayOutput() HelmArrayOutput
	ToHelmArrayOutputWithContext(context.Context) HelmArrayOutput
}

type HelmArray []HelmInput

func (HelmArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Helm)(nil)).Elem()
}

func (i HelmArray) ToHelmArrayOutput() HelmArrayOutput {
	return i.ToHelmArrayOutputWithContext(context.Background())
}

func (i HelmArray) ToHelmArrayOutputWithContext(ctx context.Context) HelmArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(HelmArrayOutput)
}

// HelmMapInput is an input type that accepts HelmMap and HelmMapOutput values.
// You can construct a concrete instance of `HelmMapInput` via:
//
//	HelmMap{ "key": HelmArgs{...} }
type HelmMapInput interface {
	pulumi.Input

	ToHelmMapOutput() HelmMapOutput
	ToHelmMapOutputWithContext(context.Context) HelmMapOutput
}

type HelmMap map[string]HelmInput

func (HelmMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Helm)(nil)).Elem()
}

func (i HelmMap) ToHelmMapOutput() HelmMapOutput {
	return i.ToHelmMapOutputWithContext(context.Background())
}

func (i HelmMap) ToHelmMapOutputWithContext(ctx context.Context) HelmMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(HelmMapOutput)
}

type HelmOutput struct{ *pulumi.OutputState }

func (HelmOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Helm)(nil)).Elem()
}

func (o HelmOutput) ToHelmOutput() HelmOutput {
	return o
}

func (o HelmOutput) ToHelmOutputWithContext(ctx context.Context) HelmOutput {
	return o
}

// Advanced settings.
func (o HelmOutput) AdvancedSettingsJson() pulumi.StringOutput {
	return o.ApplyT(func(v *Helm) pulumi.StringOutput { return v.AdvancedSettingsJson }).(pulumi.StringOutput)
}

// Allow this chart to deploy resources outside of this environment namespace (including CRDs or non-namespaced resources)
func (o HelmOutput) AllowClusterWideResources() pulumi.BoolOutput {
	return o.ApplyT(func(v *Helm) pulumi.BoolOutput { return v.AllowClusterWideResources }).(pulumi.BoolOutput)
}

// Helm arguments
func (o HelmOutput) Arguments() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *Helm) pulumi.StringArrayOutput { return v.Arguments }).(pulumi.StringArrayOutput)
}

// Specify if the service will be automatically updated on every new commit on the branch.
func (o HelmOutput) AutoDeploy() pulumi.BoolOutput {
	return o.ApplyT(func(v *Helm) pulumi.BoolOutput { return v.AutoDeploy }).(pulumi.BoolOutput)
}

// Specify if the environment preview option is activated or not for this helm.
func (o HelmOutput) AutoPreview() pulumi.BoolOutput {
	return o.ApplyT(func(v *Helm) pulumi.BoolOutput { return v.AutoPreview }).(pulumi.BoolOutput)
}

// List of built-in environment variables linked to this helm.
func (o HelmOutput) BuiltInEnvironmentVariables() HelmBuiltInEnvironmentVariableArrayOutput {
	return o.ApplyT(func(v *Helm) HelmBuiltInEnvironmentVariableArrayOutput { return v.BuiltInEnvironmentVariables }).(HelmBuiltInEnvironmentVariableArrayOutput)
}

// List of deployment restrictions
func (o HelmOutput) DeploymentRestrictions() HelmDeploymentRestrictionArrayOutput {
	return o.ApplyT(func(v *Helm) HelmDeploymentRestrictionArrayOutput { return v.DeploymentRestrictions }).(HelmDeploymentRestrictionArrayOutput)
}

// Id of the deployment stage.
func (o HelmOutput) DeploymentStageId() pulumi.StringOutput {
	return o.ApplyT(func(v *Helm) pulumi.StringOutput { return v.DeploymentStageId }).(pulumi.StringOutput)
}

// Id of the environment.
func (o HelmOutput) EnvironmentId() pulumi.StringOutput {
	return o.ApplyT(func(v *Helm) pulumi.StringOutput { return v.EnvironmentId }).(pulumi.StringOutput)
}

// List of environment variable aliases linked to this helm.
func (o HelmOutput) EnvironmentVariableAliases() HelmEnvironmentVariableAliasArrayOutput {
	return o.ApplyT(func(v *Helm) HelmEnvironmentVariableAliasArrayOutput { return v.EnvironmentVariableAliases }).(HelmEnvironmentVariableAliasArrayOutput)
}

// List of environment variable overrides linked to this helm.
func (o HelmOutput) EnvironmentVariableOverrides() HelmEnvironmentVariableOverrideArrayOutput {
	return o.ApplyT(func(v *Helm) HelmEnvironmentVariableOverrideArrayOutput { return v.EnvironmentVariableOverrides }).(HelmEnvironmentVariableOverrideArrayOutput)
}

// List of environment variables linked to this helm.
func (o HelmOutput) EnvironmentVariables() HelmEnvironmentVariableArrayOutput {
	return o.ApplyT(func(v *Helm) HelmEnvironmentVariableArrayOutput { return v.EnvironmentVariables }).(HelmEnvironmentVariableArrayOutput)
}

// The helm external FQDN host [NOTE: only if your helm is using a publicly accessible port].
func (o HelmOutput) ExternalHost() pulumi.StringOutput {
	return o.ApplyT(func(v *Helm) pulumi.StringOutput { return v.ExternalHost }).(pulumi.StringOutput)
}

// The helm internal host.
func (o HelmOutput) InternalHost() pulumi.StringOutput {
	return o.ApplyT(func(v *Helm) pulumi.StringOutput { return v.InternalHost }).(pulumi.StringOutput)
}

// Name of the helm.
func (o HelmOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *Helm) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// List of ports linked to this helm.
func (o HelmOutput) Ports() HelmPortsMapOutput {
	return o.ApplyT(func(v *Helm) HelmPortsMapOutput { return v.Ports }).(HelmPortsMapOutput)
}

// List of secret aliases linked to this helm.
func (o HelmOutput) SecretAliases() HelmSecretAliasArrayOutput {
	return o.ApplyT(func(v *Helm) HelmSecretAliasArrayOutput { return v.SecretAliases }).(HelmSecretAliasArrayOutput)
}

// List of secret overrides linked to this helm.
func (o HelmOutput) SecretOverrides() HelmSecretOverrideArrayOutput {
	return o.ApplyT(func(v *Helm) HelmSecretOverrideArrayOutput { return v.SecretOverrides }).(HelmSecretOverrideArrayOutput)
}

// List of secrets linked to this helm.
func (o HelmOutput) Secrets() HelmSecretArrayOutput {
	return o.ApplyT(func(v *Helm) HelmSecretArrayOutput { return v.Secrets }).(HelmSecretArrayOutput)
}

// Helm chart from a Helm repository or from a git repository
func (o HelmOutput) Source() HelmSourceOutput {
	return o.ApplyT(func(v *Helm) HelmSourceOutput { return v.Source }).(HelmSourceOutput)
}

// Helm timeout in second
func (o HelmOutput) TimeoutSec() pulumi.IntOutput {
	return o.ApplyT(func(v *Helm) pulumi.IntOutput { return v.TimeoutSec }).(pulumi.IntOutput)
}

// Define your own overrides to customize the helm chart behaviour.
func (o HelmOutput) ValuesOverride() HelmValuesOverrideOutput {
	return o.ApplyT(func(v *Helm) HelmValuesOverrideOutput { return v.ValuesOverride }).(HelmValuesOverrideOutput)
}

type HelmArrayOutput struct{ *pulumi.OutputState }

func (HelmArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Helm)(nil)).Elem()
}

func (o HelmArrayOutput) ToHelmArrayOutput() HelmArrayOutput {
	return o
}

func (o HelmArrayOutput) ToHelmArrayOutputWithContext(ctx context.Context) HelmArrayOutput {
	return o
}

func (o HelmArrayOutput) Index(i pulumi.IntInput) HelmOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Helm {
		return vs[0].([]*Helm)[vs[1].(int)]
	}).(HelmOutput)
}

type HelmMapOutput struct{ *pulumi.OutputState }

func (HelmMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Helm)(nil)).Elem()
}

func (o HelmMapOutput) ToHelmMapOutput() HelmMapOutput {
	return o
}

func (o HelmMapOutput) ToHelmMapOutputWithContext(ctx context.Context) HelmMapOutput {
	return o
}

func (o HelmMapOutput) MapIndex(k pulumi.StringInput) HelmOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Helm {
		return vs[0].(map[string]*Helm)[vs[1].(string)]
	}).(HelmOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*HelmInput)(nil)).Elem(), &Helm{})
	pulumi.RegisterInputType(reflect.TypeOf((*HelmArrayInput)(nil)).Elem(), HelmArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*HelmMapInput)(nil)).Elem(), HelmMap{})
	pulumi.RegisterOutputType(HelmOutput{})
	pulumi.RegisterOutputType(HelmArrayOutput{})
	pulumi.RegisterOutputType(HelmMapOutput{})
}
