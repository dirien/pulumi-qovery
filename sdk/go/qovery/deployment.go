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

// ## # Deployment (Resource)
//
// Provides a Qovery deployment resource. This is used to trigger a service deployment at demand.
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
//			_, err := qovery.NewDeployment(ctx, "myDeployment", &qovery.DeploymentArgs{
//				EnvironmentId: pulumi.Any(qovery_environment.My_environment.Id),
//				DesiredState:  pulumi.String("RUNNING"),
//				Version:       pulumi.String("random_uuid_to_force_retrigger_terraform_apply"),
//			}, pulumi.DependsOn([]pulumi.Resource{
//				qovery_application.My_application,
//				qovery_database.My_database,
//				qovery_container.My_container,
//			}))
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
type Deployment struct {
	pulumi.CustomResourceState

	// Desired state of the deployment. - Can be: `RESTARTED`, `RUNNING`, `STOPPED`.
	DesiredState pulumi.StringOutput `pulumi:"desiredState"`
	// Id of the environment.
	EnvironmentId pulumi.StringOutput `pulumi:"environmentId"`
	// Version to force trigger a deployment when desired_state doesn't change (e.g redeploy a deployment having the 'RUNNING'
	// state)
	Version pulumi.StringPtrOutput `pulumi:"version"`
}

// NewDeployment registers a new resource with the given unique name, arguments, and options.
func NewDeployment(ctx *pulumi.Context,
	name string, args *DeploymentArgs, opts ...pulumi.ResourceOption) (*Deployment, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DesiredState == nil {
		return nil, errors.New("invalid value for required argument 'DesiredState'")
	}
	if args.EnvironmentId == nil {
		return nil, errors.New("invalid value for required argument 'EnvironmentId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Deployment
	err := ctx.RegisterResource("qovery:index/deployment:Deployment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDeployment gets an existing Deployment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDeployment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DeploymentState, opts ...pulumi.ResourceOption) (*Deployment, error) {
	var resource Deployment
	err := ctx.ReadResource("qovery:index/deployment:Deployment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Deployment resources.
type deploymentState struct {
	// Desired state of the deployment. - Can be: `RESTARTED`, `RUNNING`, `STOPPED`.
	DesiredState *string `pulumi:"desiredState"`
	// Id of the environment.
	EnvironmentId *string `pulumi:"environmentId"`
	// Version to force trigger a deployment when desired_state doesn't change (e.g redeploy a deployment having the 'RUNNING'
	// state)
	Version *string `pulumi:"version"`
}

type DeploymentState struct {
	// Desired state of the deployment. - Can be: `RESTARTED`, `RUNNING`, `STOPPED`.
	DesiredState pulumi.StringPtrInput
	// Id of the environment.
	EnvironmentId pulumi.StringPtrInput
	// Version to force trigger a deployment when desired_state doesn't change (e.g redeploy a deployment having the 'RUNNING'
	// state)
	Version pulumi.StringPtrInput
}

func (DeploymentState) ElementType() reflect.Type {
	return reflect.TypeOf((*deploymentState)(nil)).Elem()
}

type deploymentArgs struct {
	// Desired state of the deployment. - Can be: `RESTARTED`, `RUNNING`, `STOPPED`.
	DesiredState string `pulumi:"desiredState"`
	// Id of the environment.
	EnvironmentId string `pulumi:"environmentId"`
	// Version to force trigger a deployment when desired_state doesn't change (e.g redeploy a deployment having the 'RUNNING'
	// state)
	Version *string `pulumi:"version"`
}

// The set of arguments for constructing a Deployment resource.
type DeploymentArgs struct {
	// Desired state of the deployment. - Can be: `RESTARTED`, `RUNNING`, `STOPPED`.
	DesiredState pulumi.StringInput
	// Id of the environment.
	EnvironmentId pulumi.StringInput
	// Version to force trigger a deployment when desired_state doesn't change (e.g redeploy a deployment having the 'RUNNING'
	// state)
	Version pulumi.StringPtrInput
}

func (DeploymentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*deploymentArgs)(nil)).Elem()
}

type DeploymentInput interface {
	pulumi.Input

	ToDeploymentOutput() DeploymentOutput
	ToDeploymentOutputWithContext(ctx context.Context) DeploymentOutput
}

func (*Deployment) ElementType() reflect.Type {
	return reflect.TypeOf((**Deployment)(nil)).Elem()
}

func (i *Deployment) ToDeploymentOutput() DeploymentOutput {
	return i.ToDeploymentOutputWithContext(context.Background())
}

func (i *Deployment) ToDeploymentOutputWithContext(ctx context.Context) DeploymentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DeploymentOutput)
}

// DeploymentArrayInput is an input type that accepts DeploymentArray and DeploymentArrayOutput values.
// You can construct a concrete instance of `DeploymentArrayInput` via:
//
//	DeploymentArray{ DeploymentArgs{...} }
type DeploymentArrayInput interface {
	pulumi.Input

	ToDeploymentArrayOutput() DeploymentArrayOutput
	ToDeploymentArrayOutputWithContext(context.Context) DeploymentArrayOutput
}

type DeploymentArray []DeploymentInput

func (DeploymentArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Deployment)(nil)).Elem()
}

func (i DeploymentArray) ToDeploymentArrayOutput() DeploymentArrayOutput {
	return i.ToDeploymentArrayOutputWithContext(context.Background())
}

func (i DeploymentArray) ToDeploymentArrayOutputWithContext(ctx context.Context) DeploymentArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DeploymentArrayOutput)
}

// DeploymentMapInput is an input type that accepts DeploymentMap and DeploymentMapOutput values.
// You can construct a concrete instance of `DeploymentMapInput` via:
//
//	DeploymentMap{ "key": DeploymentArgs{...} }
type DeploymentMapInput interface {
	pulumi.Input

	ToDeploymentMapOutput() DeploymentMapOutput
	ToDeploymentMapOutputWithContext(context.Context) DeploymentMapOutput
}

type DeploymentMap map[string]DeploymentInput

func (DeploymentMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Deployment)(nil)).Elem()
}

func (i DeploymentMap) ToDeploymentMapOutput() DeploymentMapOutput {
	return i.ToDeploymentMapOutputWithContext(context.Background())
}

func (i DeploymentMap) ToDeploymentMapOutputWithContext(ctx context.Context) DeploymentMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DeploymentMapOutput)
}

type DeploymentOutput struct{ *pulumi.OutputState }

func (DeploymentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Deployment)(nil)).Elem()
}

func (o DeploymentOutput) ToDeploymentOutput() DeploymentOutput {
	return o
}

func (o DeploymentOutput) ToDeploymentOutputWithContext(ctx context.Context) DeploymentOutput {
	return o
}

// Desired state of the deployment. - Can be: `RESTARTED`, `RUNNING`, `STOPPED`.
func (o DeploymentOutput) DesiredState() pulumi.StringOutput {
	return o.ApplyT(func(v *Deployment) pulumi.StringOutput { return v.DesiredState }).(pulumi.StringOutput)
}

// Id of the environment.
func (o DeploymentOutput) EnvironmentId() pulumi.StringOutput {
	return o.ApplyT(func(v *Deployment) pulumi.StringOutput { return v.EnvironmentId }).(pulumi.StringOutput)
}

// Version to force trigger a deployment when desired_state doesn't change (e.g redeploy a deployment having the 'RUNNING'
// state)
func (o DeploymentOutput) Version() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Deployment) pulumi.StringPtrOutput { return v.Version }).(pulumi.StringPtrOutput)
}

type DeploymentArrayOutput struct{ *pulumi.OutputState }

func (DeploymentArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Deployment)(nil)).Elem()
}

func (o DeploymentArrayOutput) ToDeploymentArrayOutput() DeploymentArrayOutput {
	return o
}

func (o DeploymentArrayOutput) ToDeploymentArrayOutputWithContext(ctx context.Context) DeploymentArrayOutput {
	return o
}

func (o DeploymentArrayOutput) Index(i pulumi.IntInput) DeploymentOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Deployment {
		return vs[0].([]*Deployment)[vs[1].(int)]
	}).(DeploymentOutput)
}

type DeploymentMapOutput struct{ *pulumi.OutputState }

func (DeploymentMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Deployment)(nil)).Elem()
}

func (o DeploymentMapOutput) ToDeploymentMapOutput() DeploymentMapOutput {
	return o
}

func (o DeploymentMapOutput) ToDeploymentMapOutputWithContext(ctx context.Context) DeploymentMapOutput {
	return o
}

func (o DeploymentMapOutput) MapIndex(k pulumi.StringInput) DeploymentOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Deployment {
		return vs[0].(map[string]*Deployment)[vs[1].(string)]
	}).(DeploymentOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DeploymentInput)(nil)).Elem(), &Deployment{})
	pulumi.RegisterInputType(reflect.TypeOf((*DeploymentArrayInput)(nil)).Elem(), DeploymentArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*DeploymentMapInput)(nil)).Elem(), DeploymentMap{})
	pulumi.RegisterOutputType(DeploymentOutput{})
	pulumi.RegisterOutputType(DeploymentArrayOutput{})
	pulumi.RegisterOutputType(DeploymentMapOutput{})
}
