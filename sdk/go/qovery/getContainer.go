// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package qovery

import (
	"context"
	"reflect"

	"github.com/dirien/pulumi-qovery/sdk/go/qovery/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// ## # Container (Data Source)
//
// Provides a Qovery container resource. This can be used to create and manage Qovery container registry.
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
//			_, err := qovery.LookupContainer(ctx, &qovery.LookupContainerArgs{
//				Id: "<container_id>",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func LookupContainer(ctx *pulumi.Context, args *LookupContainerArgs, opts ...pulumi.InvokeOption) (*LookupContainerResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupContainerResult
	err := ctx.Invoke("qovery:index/getContainer:getContainer", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getContainer.
type LookupContainerArgs struct {
	AdvancedSettingsJson         *string                                   `pulumi:"advancedSettingsJson"`
	Arguments                    []string                                  `pulumi:"arguments"`
	AutoDeploy                   *bool                                     `pulumi:"autoDeploy"`
	AutoPreview                  *bool                                     `pulumi:"autoPreview"`
	Cpu                          *int                                      `pulumi:"cpu"`
	CustomDomains                []GetContainerCustomDomain                `pulumi:"customDomains"`
	DeploymentStageId            *string                                   `pulumi:"deploymentStageId"`
	Entrypoint                   *string                                   `pulumi:"entrypoint"`
	EnvironmentVariableAliases   []GetContainerEnvironmentVariableAlias    `pulumi:"environmentVariableAliases"`
	EnvironmentVariableOverrides []GetContainerEnvironmentVariableOverride `pulumi:"environmentVariableOverrides"`
	EnvironmentVariables         []GetContainerEnvironmentVariable         `pulumi:"environmentVariables"`
	Healthchecks                 *GetContainerHealthchecks                 `pulumi:"healthchecks"`
	Id                           string                                    `pulumi:"id"`
	MaxRunningInstances          *int                                      `pulumi:"maxRunningInstances"`
	Memory                       *int                                      `pulumi:"memory"`
	MinRunningInstances          *int                                      `pulumi:"minRunningInstances"`
	Ports                        []GetContainerPort                        `pulumi:"ports"`
	SecretAliases                []GetContainerSecretAlias                 `pulumi:"secretAliases"`
	SecretOverrides              []GetContainerSecretOverride              `pulumi:"secretOverrides"`
	Secrets                      []GetContainerSecret                      `pulumi:"secrets"`
	Storages                     []GetContainerStorage                     `pulumi:"storages"`
}

// A collection of values returned by getContainer.
type LookupContainerResult struct {
	AdvancedSettingsJson         string                                    `pulumi:"advancedSettingsJson"`
	Arguments                    []string                                  `pulumi:"arguments"`
	AutoDeploy                   bool                                      `pulumi:"autoDeploy"`
	AutoPreview                  bool                                      `pulumi:"autoPreview"`
	BuiltInEnvironmentVariables  []GetContainerBuiltInEnvironmentVariable  `pulumi:"builtInEnvironmentVariables"`
	Cpu                          int                                       `pulumi:"cpu"`
	CustomDomains                []GetContainerCustomDomain                `pulumi:"customDomains"`
	DeploymentStageId            string                                    `pulumi:"deploymentStageId"`
	Entrypoint                   string                                    `pulumi:"entrypoint"`
	EnvironmentId                string                                    `pulumi:"environmentId"`
	EnvironmentVariableAliases   []GetContainerEnvironmentVariableAlias    `pulumi:"environmentVariableAliases"`
	EnvironmentVariableOverrides []GetContainerEnvironmentVariableOverride `pulumi:"environmentVariableOverrides"`
	EnvironmentVariables         []GetContainerEnvironmentVariable         `pulumi:"environmentVariables"`
	ExternalHost                 string                                    `pulumi:"externalHost"`
	Healthchecks                 *GetContainerHealthchecks                 `pulumi:"healthchecks"`
	Id                           string                                    `pulumi:"id"`
	ImageName                    string                                    `pulumi:"imageName"`
	InternalHost                 string                                    `pulumi:"internalHost"`
	MaxRunningInstances          int                                       `pulumi:"maxRunningInstances"`
	Memory                       int                                       `pulumi:"memory"`
	MinRunningInstances          int                                       `pulumi:"minRunningInstances"`
	Name                         string                                    `pulumi:"name"`
	Ports                        []GetContainerPort                        `pulumi:"ports"`
	RegistryId                   string                                    `pulumi:"registryId"`
	SecretAliases                []GetContainerSecretAlias                 `pulumi:"secretAliases"`
	SecretOverrides              []GetContainerSecretOverride              `pulumi:"secretOverrides"`
	Secrets                      []GetContainerSecret                      `pulumi:"secrets"`
	Storages                     []GetContainerStorage                     `pulumi:"storages"`
	Tag                          string                                    `pulumi:"tag"`
}

func LookupContainerOutput(ctx *pulumi.Context, args LookupContainerOutputArgs, opts ...pulumi.InvokeOption) LookupContainerResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupContainerResult, error) {
			args := v.(LookupContainerArgs)
			r, err := LookupContainer(ctx, &args, opts...)
			var s LookupContainerResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupContainerResultOutput)
}

// A collection of arguments for invoking getContainer.
type LookupContainerOutputArgs struct {
	AdvancedSettingsJson         pulumi.StringPtrInput                             `pulumi:"advancedSettingsJson"`
	Arguments                    pulumi.StringArrayInput                           `pulumi:"arguments"`
	AutoDeploy                   pulumi.BoolPtrInput                               `pulumi:"autoDeploy"`
	AutoPreview                  pulumi.BoolPtrInput                               `pulumi:"autoPreview"`
	Cpu                          pulumi.IntPtrInput                                `pulumi:"cpu"`
	CustomDomains                GetContainerCustomDomainArrayInput                `pulumi:"customDomains"`
	DeploymentStageId            pulumi.StringPtrInput                             `pulumi:"deploymentStageId"`
	Entrypoint                   pulumi.StringPtrInput                             `pulumi:"entrypoint"`
	EnvironmentVariableAliases   GetContainerEnvironmentVariableAliasArrayInput    `pulumi:"environmentVariableAliases"`
	EnvironmentVariableOverrides GetContainerEnvironmentVariableOverrideArrayInput `pulumi:"environmentVariableOverrides"`
	EnvironmentVariables         GetContainerEnvironmentVariableArrayInput         `pulumi:"environmentVariables"`
	Healthchecks                 GetContainerHealthchecksPtrInput                  `pulumi:"healthchecks"`
	Id                           pulumi.StringInput                                `pulumi:"id"`
	MaxRunningInstances          pulumi.IntPtrInput                                `pulumi:"maxRunningInstances"`
	Memory                       pulumi.IntPtrInput                                `pulumi:"memory"`
	MinRunningInstances          pulumi.IntPtrInput                                `pulumi:"minRunningInstances"`
	Ports                        GetContainerPortArrayInput                        `pulumi:"ports"`
	SecretAliases                GetContainerSecretAliasArrayInput                 `pulumi:"secretAliases"`
	SecretOverrides              GetContainerSecretOverrideArrayInput              `pulumi:"secretOverrides"`
	Secrets                      GetContainerSecretArrayInput                      `pulumi:"secrets"`
	Storages                     GetContainerStorageArrayInput                     `pulumi:"storages"`
}

func (LookupContainerOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupContainerArgs)(nil)).Elem()
}

// A collection of values returned by getContainer.
type LookupContainerResultOutput struct{ *pulumi.OutputState }

func (LookupContainerResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupContainerResult)(nil)).Elem()
}

func (o LookupContainerResultOutput) ToLookupContainerResultOutput() LookupContainerResultOutput {
	return o
}

func (o LookupContainerResultOutput) ToLookupContainerResultOutputWithContext(ctx context.Context) LookupContainerResultOutput {
	return o
}

func (o LookupContainerResultOutput) AdvancedSettingsJson() pulumi.StringOutput {
	return o.ApplyT(func(v LookupContainerResult) string { return v.AdvancedSettingsJson }).(pulumi.StringOutput)
}

func (o LookupContainerResultOutput) Arguments() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupContainerResult) []string { return v.Arguments }).(pulumi.StringArrayOutput)
}

func (o LookupContainerResultOutput) AutoDeploy() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupContainerResult) bool { return v.AutoDeploy }).(pulumi.BoolOutput)
}

func (o LookupContainerResultOutput) AutoPreview() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupContainerResult) bool { return v.AutoPreview }).(pulumi.BoolOutput)
}

func (o LookupContainerResultOutput) BuiltInEnvironmentVariables() GetContainerBuiltInEnvironmentVariableArrayOutput {
	return o.ApplyT(func(v LookupContainerResult) []GetContainerBuiltInEnvironmentVariable {
		return v.BuiltInEnvironmentVariables
	}).(GetContainerBuiltInEnvironmentVariableArrayOutput)
}

func (o LookupContainerResultOutput) Cpu() pulumi.IntOutput {
	return o.ApplyT(func(v LookupContainerResult) int { return v.Cpu }).(pulumi.IntOutput)
}

func (o LookupContainerResultOutput) CustomDomains() GetContainerCustomDomainArrayOutput {
	return o.ApplyT(func(v LookupContainerResult) []GetContainerCustomDomain { return v.CustomDomains }).(GetContainerCustomDomainArrayOutput)
}

func (o LookupContainerResultOutput) DeploymentStageId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupContainerResult) string { return v.DeploymentStageId }).(pulumi.StringOutput)
}

func (o LookupContainerResultOutput) Entrypoint() pulumi.StringOutput {
	return o.ApplyT(func(v LookupContainerResult) string { return v.Entrypoint }).(pulumi.StringOutput)
}

func (o LookupContainerResultOutput) EnvironmentId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupContainerResult) string { return v.EnvironmentId }).(pulumi.StringOutput)
}

func (o LookupContainerResultOutput) EnvironmentVariableAliases() GetContainerEnvironmentVariableAliasArrayOutput {
	return o.ApplyT(func(v LookupContainerResult) []GetContainerEnvironmentVariableAlias {
		return v.EnvironmentVariableAliases
	}).(GetContainerEnvironmentVariableAliasArrayOutput)
}

func (o LookupContainerResultOutput) EnvironmentVariableOverrides() GetContainerEnvironmentVariableOverrideArrayOutput {
	return o.ApplyT(func(v LookupContainerResult) []GetContainerEnvironmentVariableOverride {
		return v.EnvironmentVariableOverrides
	}).(GetContainerEnvironmentVariableOverrideArrayOutput)
}

func (o LookupContainerResultOutput) EnvironmentVariables() GetContainerEnvironmentVariableArrayOutput {
	return o.ApplyT(func(v LookupContainerResult) []GetContainerEnvironmentVariable { return v.EnvironmentVariables }).(GetContainerEnvironmentVariableArrayOutput)
}

func (o LookupContainerResultOutput) ExternalHost() pulumi.StringOutput {
	return o.ApplyT(func(v LookupContainerResult) string { return v.ExternalHost }).(pulumi.StringOutput)
}

func (o LookupContainerResultOutput) Healthchecks() GetContainerHealthchecksPtrOutput {
	return o.ApplyT(func(v LookupContainerResult) *GetContainerHealthchecks { return v.Healthchecks }).(GetContainerHealthchecksPtrOutput)
}

func (o LookupContainerResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupContainerResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupContainerResultOutput) ImageName() pulumi.StringOutput {
	return o.ApplyT(func(v LookupContainerResult) string { return v.ImageName }).(pulumi.StringOutput)
}

func (o LookupContainerResultOutput) InternalHost() pulumi.StringOutput {
	return o.ApplyT(func(v LookupContainerResult) string { return v.InternalHost }).(pulumi.StringOutput)
}

func (o LookupContainerResultOutput) MaxRunningInstances() pulumi.IntOutput {
	return o.ApplyT(func(v LookupContainerResult) int { return v.MaxRunningInstances }).(pulumi.IntOutput)
}

func (o LookupContainerResultOutput) Memory() pulumi.IntOutput {
	return o.ApplyT(func(v LookupContainerResult) int { return v.Memory }).(pulumi.IntOutput)
}

func (o LookupContainerResultOutput) MinRunningInstances() pulumi.IntOutput {
	return o.ApplyT(func(v LookupContainerResult) int { return v.MinRunningInstances }).(pulumi.IntOutput)
}

func (o LookupContainerResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupContainerResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupContainerResultOutput) Ports() GetContainerPortArrayOutput {
	return o.ApplyT(func(v LookupContainerResult) []GetContainerPort { return v.Ports }).(GetContainerPortArrayOutput)
}

func (o LookupContainerResultOutput) RegistryId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupContainerResult) string { return v.RegistryId }).(pulumi.StringOutput)
}

func (o LookupContainerResultOutput) SecretAliases() GetContainerSecretAliasArrayOutput {
	return o.ApplyT(func(v LookupContainerResult) []GetContainerSecretAlias { return v.SecretAliases }).(GetContainerSecretAliasArrayOutput)
}

func (o LookupContainerResultOutput) SecretOverrides() GetContainerSecretOverrideArrayOutput {
	return o.ApplyT(func(v LookupContainerResult) []GetContainerSecretOverride { return v.SecretOverrides }).(GetContainerSecretOverrideArrayOutput)
}

func (o LookupContainerResultOutput) Secrets() GetContainerSecretArrayOutput {
	return o.ApplyT(func(v LookupContainerResult) []GetContainerSecret { return v.Secrets }).(GetContainerSecretArrayOutput)
}

func (o LookupContainerResultOutput) Storages() GetContainerStorageArrayOutput {
	return o.ApplyT(func(v LookupContainerResult) []GetContainerStorage { return v.Storages }).(GetContainerStorageArrayOutput)
}

func (o LookupContainerResultOutput) Tag() pulumi.StringOutput {
	return o.ApplyT(func(v LookupContainerResult) string { return v.Tag }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupContainerResultOutput{})
}
