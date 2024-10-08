// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package qovery

import (
	"context"
	"reflect"

	"github.com/dirien/pulumi-qovery/sdk/go/qovery/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// ## # AnnotationsGroup (Data Source)
//
// Provides a Qovery annotations group resource
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
//			_, err := qovery.LookupAnnotationsGroup(ctx, &qovery.LookupAnnotationsGroupArgs{
//				Id:             "<annotations_group_id>",
//				OrganizationId: "<organization_id>",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func LookupAnnotationsGroup(ctx *pulumi.Context, args *LookupAnnotationsGroupArgs, opts ...pulumi.InvokeOption) (*LookupAnnotationsGroupResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupAnnotationsGroupResult
	err := ctx.Invoke("qovery:index/getAnnotationsGroup:getAnnotationsGroup", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getAnnotationsGroup.
type LookupAnnotationsGroupArgs struct {
	// annotations
	Annotations map[string]string `pulumi:"annotations"`
	// Id of the annotations group
	Id string `pulumi:"id"`
	// name of the annotations group
	Name *string `pulumi:"name"`
	// Id of the organization.
	OrganizationId string `pulumi:"organizationId"`
	// scopes of the annotations group
	Scopes []string `pulumi:"scopes"`
}

// A collection of values returned by getAnnotationsGroup.
type LookupAnnotationsGroupResult struct {
	// annotations
	Annotations map[string]string `pulumi:"annotations"`
	// Id of the annotations group
	Id string `pulumi:"id"`
	// name of the annotations group
	Name *string `pulumi:"name"`
	// Id of the organization.
	OrganizationId string `pulumi:"organizationId"`
	// scopes of the annotations group
	Scopes []string `pulumi:"scopes"`
}

func LookupAnnotationsGroupOutput(ctx *pulumi.Context, args LookupAnnotationsGroupOutputArgs, opts ...pulumi.InvokeOption) LookupAnnotationsGroupResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupAnnotationsGroupResultOutput, error) {
			args := v.(LookupAnnotationsGroupArgs)
			opts = internal.PkgInvokeDefaultOpts(opts)
			var rv LookupAnnotationsGroupResult
			secret, err := ctx.InvokePackageRaw("qovery:index/getAnnotationsGroup:getAnnotationsGroup", args, &rv, "", opts...)
			if err != nil {
				return LookupAnnotationsGroupResultOutput{}, err
			}

			output := pulumi.ToOutput(rv).(LookupAnnotationsGroupResultOutput)
			if secret {
				return pulumi.ToSecret(output).(LookupAnnotationsGroupResultOutput), nil
			}
			return output, nil
		}).(LookupAnnotationsGroupResultOutput)
}

// A collection of arguments for invoking getAnnotationsGroup.
type LookupAnnotationsGroupOutputArgs struct {
	// annotations
	Annotations pulumi.StringMapInput `pulumi:"annotations"`
	// Id of the annotations group
	Id pulumi.StringInput `pulumi:"id"`
	// name of the annotations group
	Name pulumi.StringPtrInput `pulumi:"name"`
	// Id of the organization.
	OrganizationId pulumi.StringInput `pulumi:"organizationId"`
	// scopes of the annotations group
	Scopes pulumi.StringArrayInput `pulumi:"scopes"`
}

func (LookupAnnotationsGroupOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupAnnotationsGroupArgs)(nil)).Elem()
}

// A collection of values returned by getAnnotationsGroup.
type LookupAnnotationsGroupResultOutput struct{ *pulumi.OutputState }

func (LookupAnnotationsGroupResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupAnnotationsGroupResult)(nil)).Elem()
}

func (o LookupAnnotationsGroupResultOutput) ToLookupAnnotationsGroupResultOutput() LookupAnnotationsGroupResultOutput {
	return o
}

func (o LookupAnnotationsGroupResultOutput) ToLookupAnnotationsGroupResultOutputWithContext(ctx context.Context) LookupAnnotationsGroupResultOutput {
	return o
}

// annotations
func (o LookupAnnotationsGroupResultOutput) Annotations() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupAnnotationsGroupResult) map[string]string { return v.Annotations }).(pulumi.StringMapOutput)
}

// Id of the annotations group
func (o LookupAnnotationsGroupResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAnnotationsGroupResult) string { return v.Id }).(pulumi.StringOutput)
}

// name of the annotations group
func (o LookupAnnotationsGroupResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupAnnotationsGroupResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

// Id of the organization.
func (o LookupAnnotationsGroupResultOutput) OrganizationId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAnnotationsGroupResult) string { return v.OrganizationId }).(pulumi.StringOutput)
}

// scopes of the annotations group
func (o LookupAnnotationsGroupResultOutput) Scopes() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupAnnotationsGroupResult) []string { return v.Scopes }).(pulumi.StringArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupAnnotationsGroupResultOutput{})
}
