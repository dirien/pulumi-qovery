// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package qovery

import (
	"context"
	"reflect"

	"github.com/dirien/pulumi-qovery/sdk/go/qovery/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// ## # Deployment (Data Source)
//
// Provides a Qovery deployment resource. This is used to trigger a service deployment at demand.
func LookupDeployment(ctx *pulumi.Context, args *LookupDeploymentArgs, opts ...pulumi.InvokeOption) (*LookupDeploymentResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupDeploymentResult
	err := ctx.Invoke("qovery:index/getDeployment:getDeployment", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getDeployment.
type LookupDeploymentArgs struct {
	Id      string  `pulumi:"id"`
	Version *string `pulumi:"version"`
}

// A collection of values returned by getDeployment.
type LookupDeploymentResult struct {
	DesiredState  string  `pulumi:"desiredState"`
	EnvironmentId string  `pulumi:"environmentId"`
	Id            string  `pulumi:"id"`
	Version       *string `pulumi:"version"`
}

func LookupDeploymentOutput(ctx *pulumi.Context, args LookupDeploymentOutputArgs, opts ...pulumi.InvokeOption) LookupDeploymentResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupDeploymentResultOutput, error) {
			args := v.(LookupDeploymentArgs)
			opts = internal.PkgInvokeDefaultOpts(opts)
			var rv LookupDeploymentResult
			secret, err := ctx.InvokePackageRaw("qovery:index/getDeployment:getDeployment", args, &rv, "", opts...)
			if err != nil {
				return LookupDeploymentResultOutput{}, err
			}

			output := pulumi.ToOutput(rv).(LookupDeploymentResultOutput)
			if secret {
				return pulumi.ToSecret(output).(LookupDeploymentResultOutput), nil
			}
			return output, nil
		}).(LookupDeploymentResultOutput)
}

// A collection of arguments for invoking getDeployment.
type LookupDeploymentOutputArgs struct {
	Id      pulumi.StringInput    `pulumi:"id"`
	Version pulumi.StringPtrInput `pulumi:"version"`
}

func (LookupDeploymentOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupDeploymentArgs)(nil)).Elem()
}

// A collection of values returned by getDeployment.
type LookupDeploymentResultOutput struct{ *pulumi.OutputState }

func (LookupDeploymentResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupDeploymentResult)(nil)).Elem()
}

func (o LookupDeploymentResultOutput) ToLookupDeploymentResultOutput() LookupDeploymentResultOutput {
	return o
}

func (o LookupDeploymentResultOutput) ToLookupDeploymentResultOutputWithContext(ctx context.Context) LookupDeploymentResultOutput {
	return o
}

func (o LookupDeploymentResultOutput) DesiredState() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDeploymentResult) string { return v.DesiredState }).(pulumi.StringOutput)
}

func (o LookupDeploymentResultOutput) EnvironmentId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDeploymentResult) string { return v.EnvironmentId }).(pulumi.StringOutput)
}

func (o LookupDeploymentResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDeploymentResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupDeploymentResultOutput) Version() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupDeploymentResult) *string { return v.Version }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupDeploymentResultOutput{})
}
