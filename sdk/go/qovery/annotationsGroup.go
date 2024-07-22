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

// ## # AnnotationsGroup (Resource)
//
// # Provides a Qovery annotations group resource
//
// ## Example
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
//			_, err := qovery.NewAnnotationsGroup(ctx, "annotationsGroup1", &qovery.AnnotationsGroupArgs{
//				OrganizationId: pulumi.Any(qovery_organization.My_organization.Id),
//				Annotations: pulumi.StringMap{
//					"key1": pulumi.String("value1"),
//					"key2": pulumi.String("value2"),
//				},
//				Scopes: pulumi.StringArray{
//					pulumi.String("PODS"),
//					pulumi.String("DEPLOYMENTS"),
//				},
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
//
// ## Import
//
// ```sh
// $ pulumi import qovery:index/annotationsGroup:AnnotationsGroup my_qovery_annotations_group "<annotations_group_id>"
// ```
type AnnotationsGroup struct {
	pulumi.CustomResourceState

	// annotations
	Annotations pulumi.StringMapOutput `pulumi:"annotations"`
	// name of the annotations group
	Name pulumi.StringOutput `pulumi:"name"`
	// Id of the organization.
	OrganizationId pulumi.StringOutput `pulumi:"organizationId"`
	// scopes of the annotations group
	Scopes pulumi.StringArrayOutput `pulumi:"scopes"`
}

// NewAnnotationsGroup registers a new resource with the given unique name, arguments, and options.
func NewAnnotationsGroup(ctx *pulumi.Context,
	name string, args *AnnotationsGroupArgs, opts ...pulumi.ResourceOption) (*AnnotationsGroup, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Annotations == nil {
		return nil, errors.New("invalid value for required argument 'Annotations'")
	}
	if args.OrganizationId == nil {
		return nil, errors.New("invalid value for required argument 'OrganizationId'")
	}
	if args.Scopes == nil {
		return nil, errors.New("invalid value for required argument 'Scopes'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource AnnotationsGroup
	err := ctx.RegisterResource("qovery:index/annotationsGroup:AnnotationsGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAnnotationsGroup gets an existing AnnotationsGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAnnotationsGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AnnotationsGroupState, opts ...pulumi.ResourceOption) (*AnnotationsGroup, error) {
	var resource AnnotationsGroup
	err := ctx.ReadResource("qovery:index/annotationsGroup:AnnotationsGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AnnotationsGroup resources.
type annotationsGroupState struct {
	// annotations
	Annotations map[string]string `pulumi:"annotations"`
	// name of the annotations group
	Name *string `pulumi:"name"`
	// Id of the organization.
	OrganizationId *string `pulumi:"organizationId"`
	// scopes of the annotations group
	Scopes []string `pulumi:"scopes"`
}

type AnnotationsGroupState struct {
	// annotations
	Annotations pulumi.StringMapInput
	// name of the annotations group
	Name pulumi.StringPtrInput
	// Id of the organization.
	OrganizationId pulumi.StringPtrInput
	// scopes of the annotations group
	Scopes pulumi.StringArrayInput
}

func (AnnotationsGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*annotationsGroupState)(nil)).Elem()
}

type annotationsGroupArgs struct {
	// annotations
	Annotations map[string]string `pulumi:"annotations"`
	// name of the annotations group
	Name *string `pulumi:"name"`
	// Id of the organization.
	OrganizationId string `pulumi:"organizationId"`
	// scopes of the annotations group
	Scopes []string `pulumi:"scopes"`
}

// The set of arguments for constructing a AnnotationsGroup resource.
type AnnotationsGroupArgs struct {
	// annotations
	Annotations pulumi.StringMapInput
	// name of the annotations group
	Name pulumi.StringPtrInput
	// Id of the organization.
	OrganizationId pulumi.StringInput
	// scopes of the annotations group
	Scopes pulumi.StringArrayInput
}

func (AnnotationsGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*annotationsGroupArgs)(nil)).Elem()
}

type AnnotationsGroupInput interface {
	pulumi.Input

	ToAnnotationsGroupOutput() AnnotationsGroupOutput
	ToAnnotationsGroupOutputWithContext(ctx context.Context) AnnotationsGroupOutput
}

func (*AnnotationsGroup) ElementType() reflect.Type {
	return reflect.TypeOf((**AnnotationsGroup)(nil)).Elem()
}

func (i *AnnotationsGroup) ToAnnotationsGroupOutput() AnnotationsGroupOutput {
	return i.ToAnnotationsGroupOutputWithContext(context.Background())
}

func (i *AnnotationsGroup) ToAnnotationsGroupOutputWithContext(ctx context.Context) AnnotationsGroupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AnnotationsGroupOutput)
}

// AnnotationsGroupArrayInput is an input type that accepts AnnotationsGroupArray and AnnotationsGroupArrayOutput values.
// You can construct a concrete instance of `AnnotationsGroupArrayInput` via:
//
//	AnnotationsGroupArray{ AnnotationsGroupArgs{...} }
type AnnotationsGroupArrayInput interface {
	pulumi.Input

	ToAnnotationsGroupArrayOutput() AnnotationsGroupArrayOutput
	ToAnnotationsGroupArrayOutputWithContext(context.Context) AnnotationsGroupArrayOutput
}

type AnnotationsGroupArray []AnnotationsGroupInput

func (AnnotationsGroupArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AnnotationsGroup)(nil)).Elem()
}

func (i AnnotationsGroupArray) ToAnnotationsGroupArrayOutput() AnnotationsGroupArrayOutput {
	return i.ToAnnotationsGroupArrayOutputWithContext(context.Background())
}

func (i AnnotationsGroupArray) ToAnnotationsGroupArrayOutputWithContext(ctx context.Context) AnnotationsGroupArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AnnotationsGroupArrayOutput)
}

// AnnotationsGroupMapInput is an input type that accepts AnnotationsGroupMap and AnnotationsGroupMapOutput values.
// You can construct a concrete instance of `AnnotationsGroupMapInput` via:
//
//	AnnotationsGroupMap{ "key": AnnotationsGroupArgs{...} }
type AnnotationsGroupMapInput interface {
	pulumi.Input

	ToAnnotationsGroupMapOutput() AnnotationsGroupMapOutput
	ToAnnotationsGroupMapOutputWithContext(context.Context) AnnotationsGroupMapOutput
}

type AnnotationsGroupMap map[string]AnnotationsGroupInput

func (AnnotationsGroupMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AnnotationsGroup)(nil)).Elem()
}

func (i AnnotationsGroupMap) ToAnnotationsGroupMapOutput() AnnotationsGroupMapOutput {
	return i.ToAnnotationsGroupMapOutputWithContext(context.Background())
}

func (i AnnotationsGroupMap) ToAnnotationsGroupMapOutputWithContext(ctx context.Context) AnnotationsGroupMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AnnotationsGroupMapOutput)
}

type AnnotationsGroupOutput struct{ *pulumi.OutputState }

func (AnnotationsGroupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AnnotationsGroup)(nil)).Elem()
}

func (o AnnotationsGroupOutput) ToAnnotationsGroupOutput() AnnotationsGroupOutput {
	return o
}

func (o AnnotationsGroupOutput) ToAnnotationsGroupOutputWithContext(ctx context.Context) AnnotationsGroupOutput {
	return o
}

// annotations
func (o AnnotationsGroupOutput) Annotations() pulumi.StringMapOutput {
	return o.ApplyT(func(v *AnnotationsGroup) pulumi.StringMapOutput { return v.Annotations }).(pulumi.StringMapOutput)
}

// name of the annotations group
func (o AnnotationsGroupOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *AnnotationsGroup) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Id of the organization.
func (o AnnotationsGroupOutput) OrganizationId() pulumi.StringOutput {
	return o.ApplyT(func(v *AnnotationsGroup) pulumi.StringOutput { return v.OrganizationId }).(pulumi.StringOutput)
}

// scopes of the annotations group
func (o AnnotationsGroupOutput) Scopes() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *AnnotationsGroup) pulumi.StringArrayOutput { return v.Scopes }).(pulumi.StringArrayOutput)
}

type AnnotationsGroupArrayOutput struct{ *pulumi.OutputState }

func (AnnotationsGroupArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AnnotationsGroup)(nil)).Elem()
}

func (o AnnotationsGroupArrayOutput) ToAnnotationsGroupArrayOutput() AnnotationsGroupArrayOutput {
	return o
}

func (o AnnotationsGroupArrayOutput) ToAnnotationsGroupArrayOutputWithContext(ctx context.Context) AnnotationsGroupArrayOutput {
	return o
}

func (o AnnotationsGroupArrayOutput) Index(i pulumi.IntInput) AnnotationsGroupOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *AnnotationsGroup {
		return vs[0].([]*AnnotationsGroup)[vs[1].(int)]
	}).(AnnotationsGroupOutput)
}

type AnnotationsGroupMapOutput struct{ *pulumi.OutputState }

func (AnnotationsGroupMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AnnotationsGroup)(nil)).Elem()
}

func (o AnnotationsGroupMapOutput) ToAnnotationsGroupMapOutput() AnnotationsGroupMapOutput {
	return o
}

func (o AnnotationsGroupMapOutput) ToAnnotationsGroupMapOutputWithContext(ctx context.Context) AnnotationsGroupMapOutput {
	return o
}

func (o AnnotationsGroupMapOutput) MapIndex(k pulumi.StringInput) AnnotationsGroupOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *AnnotationsGroup {
		return vs[0].(map[string]*AnnotationsGroup)[vs[1].(string)]
	}).(AnnotationsGroupOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AnnotationsGroupInput)(nil)).Elem(), &AnnotationsGroup{})
	pulumi.RegisterInputType(reflect.TypeOf((*AnnotationsGroupArrayInput)(nil)).Elem(), AnnotationsGroupArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*AnnotationsGroupMapInput)(nil)).Elem(), AnnotationsGroupMap{})
	pulumi.RegisterOutputType(AnnotationsGroupOutput{})
	pulumi.RegisterOutputType(AnnotationsGroupArrayOutput{})
	pulumi.RegisterOutputType(AnnotationsGroupMapOutput{})
}
