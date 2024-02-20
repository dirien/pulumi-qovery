// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package qovery

import (
	"context"
	"reflect"

	"github.com/dirien/pulumi-qovery/sdk/go/qovery/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// ## # Helm (Data Source)
//
// Provides a Qovery helm resource.
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/dirien/pulumi-qovery/sdk/go/qovery"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := qovery.LookupHelm(ctx, &qovery.LookupHelmArgs{
//				Id: "<helm_id>",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func LookupHelm(ctx *pulumi.Context, args *LookupHelmArgs, opts ...pulumi.InvokeOption) (*LookupHelmResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupHelmResult
	err := ctx.Invoke("qovery:index/getHelm:getHelm", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getHelm.
type LookupHelmArgs struct {
	// Advanced settings.
	AdvancedSettingsJson *string `pulumi:"advancedSettingsJson"`
	// List of deployment restrictions
	DeploymentRestrictions []GetHelmDeploymentRestriction `pulumi:"deploymentRestrictions"`
	// Id of the deployment stage.
	DeploymentStageId *string `pulumi:"deploymentStageId"`
	// List of environment variable aliases linked to this helm.
	EnvironmentVariableAliases []GetHelmEnvironmentVariableAlias `pulumi:"environmentVariableAliases"`
	// List of environment variable overrides linked to this helm.
	EnvironmentVariableOverrides []GetHelmEnvironmentVariableOverride `pulumi:"environmentVariableOverrides"`
	// List of environment variables linked to this helm.
	EnvironmentVariables []GetHelmEnvironmentVariable `pulumi:"environmentVariables"`
	// Id of the environment variable.
	Id string `pulumi:"id"`
	// List of secret aliases linked to this helm.
	SecretAliases []GetHelmSecretAlias `pulumi:"secretAliases"`
	// List of secret overrides linked to this helm.
	SecretOverrides []GetHelmSecretOverride `pulumi:"secretOverrides"`
	// List of secrets linked to this helm.
	Secrets []GetHelmSecret `pulumi:"secrets"`
}

// A collection of values returned by getHelm.
type LookupHelmResult struct {
	// Advanced settings.
	AdvancedSettingsJson string `pulumi:"advancedSettingsJson"`
	// List of built-in environment variables linked to this helm.
	BuiltInEnvironmentVariables []GetHelmBuiltInEnvironmentVariable `pulumi:"builtInEnvironmentVariables"`
	// List of deployment restrictions
	DeploymentRestrictions []GetHelmDeploymentRestriction `pulumi:"deploymentRestrictions"`
	// Id of the deployment stage.
	DeploymentStageId string `pulumi:"deploymentStageId"`
	// Id of the environment.
	EnvironmentId string `pulumi:"environmentId"`
	// List of environment variable aliases linked to this helm.
	EnvironmentVariableAliases []GetHelmEnvironmentVariableAlias `pulumi:"environmentVariableAliases"`
	// List of environment variable overrides linked to this helm.
	EnvironmentVariableOverrides []GetHelmEnvironmentVariableOverride `pulumi:"environmentVariableOverrides"`
	// List of environment variables linked to this helm.
	EnvironmentVariables []GetHelmEnvironmentVariable `pulumi:"environmentVariables"`
	// The helm external FQDN host [NOTE: only if your helm is using a publicly accessible port].
	ExternalHost string `pulumi:"externalHost"`
	// Id of the helm.
	Id string `pulumi:"id"`
	// The helm internal host.
	InternalHost string `pulumi:"internalHost"`
	// Name of the helm.
	Name string `pulumi:"name"`
	// List of secret aliases linked to this helm.
	SecretAliases []GetHelmSecretAlias `pulumi:"secretAliases"`
	// List of secret overrides linked to this helm.
	SecretOverrides []GetHelmSecretOverride `pulumi:"secretOverrides"`
	// List of secrets linked to this helm.
	Secrets []GetHelmSecret `pulumi:"secrets"`
}

func LookupHelmOutput(ctx *pulumi.Context, args LookupHelmOutputArgs, opts ...pulumi.InvokeOption) LookupHelmResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupHelmResult, error) {
			args := v.(LookupHelmArgs)
			r, err := LookupHelm(ctx, &args, opts...)
			var s LookupHelmResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupHelmResultOutput)
}

// A collection of arguments for invoking getHelm.
type LookupHelmOutputArgs struct {
	// Advanced settings.
	AdvancedSettingsJson pulumi.StringPtrInput `pulumi:"advancedSettingsJson"`
	// List of deployment restrictions
	DeploymentRestrictions GetHelmDeploymentRestrictionArrayInput `pulumi:"deploymentRestrictions"`
	// Id of the deployment stage.
	DeploymentStageId pulumi.StringPtrInput `pulumi:"deploymentStageId"`
	// List of environment variable aliases linked to this helm.
	EnvironmentVariableAliases GetHelmEnvironmentVariableAliasArrayInput `pulumi:"environmentVariableAliases"`
	// List of environment variable overrides linked to this helm.
	EnvironmentVariableOverrides GetHelmEnvironmentVariableOverrideArrayInput `pulumi:"environmentVariableOverrides"`
	// List of environment variables linked to this helm.
	EnvironmentVariables GetHelmEnvironmentVariableArrayInput `pulumi:"environmentVariables"`
	// Id of the environment variable.
	Id pulumi.StringInput `pulumi:"id"`
	// List of secret aliases linked to this helm.
	SecretAliases GetHelmSecretAliasArrayInput `pulumi:"secretAliases"`
	// List of secret overrides linked to this helm.
	SecretOverrides GetHelmSecretOverrideArrayInput `pulumi:"secretOverrides"`
	// List of secrets linked to this helm.
	Secrets GetHelmSecretArrayInput `pulumi:"secrets"`
}

func (LookupHelmOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupHelmArgs)(nil)).Elem()
}

// A collection of values returned by getHelm.
type LookupHelmResultOutput struct{ *pulumi.OutputState }

func (LookupHelmResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupHelmResult)(nil)).Elem()
}

func (o LookupHelmResultOutput) ToLookupHelmResultOutput() LookupHelmResultOutput {
	return o
}

func (o LookupHelmResultOutput) ToLookupHelmResultOutputWithContext(ctx context.Context) LookupHelmResultOutput {
	return o
}

// Advanced settings.
func (o LookupHelmResultOutput) AdvancedSettingsJson() pulumi.StringOutput {
	return o.ApplyT(func(v LookupHelmResult) string { return v.AdvancedSettingsJson }).(pulumi.StringOutput)
}

// List of built-in environment variables linked to this helm.
func (o LookupHelmResultOutput) BuiltInEnvironmentVariables() GetHelmBuiltInEnvironmentVariableArrayOutput {
	return o.ApplyT(func(v LookupHelmResult) []GetHelmBuiltInEnvironmentVariable { return v.BuiltInEnvironmentVariables }).(GetHelmBuiltInEnvironmentVariableArrayOutput)
}

// List of deployment restrictions
func (o LookupHelmResultOutput) DeploymentRestrictions() GetHelmDeploymentRestrictionArrayOutput {
	return o.ApplyT(func(v LookupHelmResult) []GetHelmDeploymentRestriction { return v.DeploymentRestrictions }).(GetHelmDeploymentRestrictionArrayOutput)
}

// Id of the deployment stage.
func (o LookupHelmResultOutput) DeploymentStageId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupHelmResult) string { return v.DeploymentStageId }).(pulumi.StringOutput)
}

// Id of the environment.
func (o LookupHelmResultOutput) EnvironmentId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupHelmResult) string { return v.EnvironmentId }).(pulumi.StringOutput)
}

// List of environment variable aliases linked to this helm.
func (o LookupHelmResultOutput) EnvironmentVariableAliases() GetHelmEnvironmentVariableAliasArrayOutput {
	return o.ApplyT(func(v LookupHelmResult) []GetHelmEnvironmentVariableAlias { return v.EnvironmentVariableAliases }).(GetHelmEnvironmentVariableAliasArrayOutput)
}

// List of environment variable overrides linked to this helm.
func (o LookupHelmResultOutput) EnvironmentVariableOverrides() GetHelmEnvironmentVariableOverrideArrayOutput {
	return o.ApplyT(func(v LookupHelmResult) []GetHelmEnvironmentVariableOverride { return v.EnvironmentVariableOverrides }).(GetHelmEnvironmentVariableOverrideArrayOutput)
}

// List of environment variables linked to this helm.
func (o LookupHelmResultOutput) EnvironmentVariables() GetHelmEnvironmentVariableArrayOutput {
	return o.ApplyT(func(v LookupHelmResult) []GetHelmEnvironmentVariable { return v.EnvironmentVariables }).(GetHelmEnvironmentVariableArrayOutput)
}

// The helm external FQDN host [NOTE: only if your helm is using a publicly accessible port].
func (o LookupHelmResultOutput) ExternalHost() pulumi.StringOutput {
	return o.ApplyT(func(v LookupHelmResult) string { return v.ExternalHost }).(pulumi.StringOutput)
}

// Id of the helm.
func (o LookupHelmResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupHelmResult) string { return v.Id }).(pulumi.StringOutput)
}

// The helm internal host.
func (o LookupHelmResultOutput) InternalHost() pulumi.StringOutput {
	return o.ApplyT(func(v LookupHelmResult) string { return v.InternalHost }).(pulumi.StringOutput)
}

// Name of the helm.
func (o LookupHelmResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupHelmResult) string { return v.Name }).(pulumi.StringOutput)
}

// List of secret aliases linked to this helm.
func (o LookupHelmResultOutput) SecretAliases() GetHelmSecretAliasArrayOutput {
	return o.ApplyT(func(v LookupHelmResult) []GetHelmSecretAlias { return v.SecretAliases }).(GetHelmSecretAliasArrayOutput)
}

// List of secret overrides linked to this helm.
func (o LookupHelmResultOutput) SecretOverrides() GetHelmSecretOverrideArrayOutput {
	return o.ApplyT(func(v LookupHelmResult) []GetHelmSecretOverride { return v.SecretOverrides }).(GetHelmSecretOverrideArrayOutput)
}

// List of secrets linked to this helm.
func (o LookupHelmResultOutput) Secrets() GetHelmSecretArrayOutput {
	return o.ApplyT(func(v LookupHelmResult) []GetHelmSecret { return v.Secrets }).(GetHelmSecretArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupHelmResultOutput{})
}
