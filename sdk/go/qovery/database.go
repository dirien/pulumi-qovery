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

// ## # Database (Resource)
//
// Provides a Qovery database resource. This can be used to create and manage Qovery databases.
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
//			_, err := qovery.NewDatabase(ctx, "myContainerDatabase", &qovery.DatabaseArgs{
//				EnvironmentId: pulumi.Any(qovery_environment.My_environment.Id),
//				Type:          pulumi.String("POSTGRESQL"),
//				Version:       pulumi.String("10"),
//				Mode:          pulumi.String("CONTAINER"),
//				Accessibility: pulumi.String("PRIVATE"),
//				Cpu:           pulumi.Int(250),
//				Memory:        pulumi.Int(256),
//				Storage:       pulumi.Int(10),
//			}, pulumi.DependsOn([]pulumi.Resource{
//				qovery_environment.My_environment,
//			}))
//			if err != nil {
//				return err
//			}
//			_, err = qovery.NewDatabase(ctx, "myManagedDatabase", &qovery.DatabaseArgs{
//				EnvironmentId: pulumi.Any(qovery_environment.My_environment.Id),
//				Type:          pulumi.String("POSTGRESQL"),
//				Version:       pulumi.String("10"),
//				Mode:          pulumi.String("MANAGED"),
//				InstanceType:  pulumi.String("db.t3.micro"),
//				Accessibility: pulumi.String("PRIVATE"),
//				Storage:       pulumi.Int(10),
//			}, pulumi.DependsOn([]pulumi.Resource{
//				qovery_environment.My_environment,
//			}))
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
//
//	$ pulumi import qovery:index/database:Database my_database "<database_id>"
//
// ```
type Database struct {
	pulumi.CustomResourceState

	// Accessibility of the database. - Can be: `PRIVATE`, `PUBLIC`. - Default: `PUBLIC`.
	Accessibility pulumi.StringOutput `pulumi:"accessibility"`
	// CPU of the database in millicores (m) [1000m = 1 CPU]. - Must be: `>= 250`. - Default: `250`.
	Cpu pulumi.IntOutput `pulumi:"cpu"`
	// Id of the deployment stage.
	DeploymentStageId pulumi.StringOutput `pulumi:"deploymentStageId"`
	// Id of the environment.
	EnvironmentId pulumi.StringOutput `pulumi:"environmentId"`
	// The database external FQDN host [NOTE: only if your container is using a publicly accessible port].
	ExternalHost pulumi.StringOutput `pulumi:"externalHost"`
	// Instance type of the database.
	InstanceType pulumi.StringOutput `pulumi:"instanceType"`
	// The database internal host (Recommended for your application)
	InternalHost pulumi.StringOutput `pulumi:"internalHost"`
	// The login to connect to your database
	Login pulumi.StringOutput `pulumi:"login"`
	// RAM of the database in MB [1024MB = 1GB]. - Must be: `>= 100`. - Default: `256`.
	Memory pulumi.IntOutput `pulumi:"memory"`
	// Mode of the database [NOTE: can't be updated after creation]. - Can be: `CONTAINER`, `MANAGED`.
	Mode pulumi.StringOutput `pulumi:"mode"`
	// Name of the database.
	Name pulumi.StringOutput `pulumi:"name"`
	// The password to connect to your database
	Password pulumi.StringOutput `pulumi:"password"`
	// The port to connect to your database
	Port pulumi.IntOutput `pulumi:"port"`
	// Storage of the database in GB [1024MB = 1GB] [NOTE: can't be updated after creation]. - Must be: `>= 10`. - Default:
	// `10`.
	Storage pulumi.IntOutput `pulumi:"storage"`
	// Type of the database [NOTE: can't be updated after creation]. - Can be: `MONGODB`, `MYSQL`, `POSTGRESQL`, `REDIS`.
	Type pulumi.StringOutput `pulumi:"type"`
	// Version of the database
	Version pulumi.StringOutput `pulumi:"version"`
}

// NewDatabase registers a new resource with the given unique name, arguments, and options.
func NewDatabase(ctx *pulumi.Context,
	name string, args *DatabaseArgs, opts ...pulumi.ResourceOption) (*Database, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.EnvironmentId == nil {
		return nil, errors.New("invalid value for required argument 'EnvironmentId'")
	}
	if args.Mode == nil {
		return nil, errors.New("invalid value for required argument 'Mode'")
	}
	if args.Type == nil {
		return nil, errors.New("invalid value for required argument 'Type'")
	}
	if args.Version == nil {
		return nil, errors.New("invalid value for required argument 'Version'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Database
	err := ctx.RegisterResource("qovery:index/database:Database", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDatabase gets an existing Database resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDatabase(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DatabaseState, opts ...pulumi.ResourceOption) (*Database, error) {
	var resource Database
	err := ctx.ReadResource("qovery:index/database:Database", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Database resources.
type databaseState struct {
	// Accessibility of the database. - Can be: `PRIVATE`, `PUBLIC`. - Default: `PUBLIC`.
	Accessibility *string `pulumi:"accessibility"`
	// CPU of the database in millicores (m) [1000m = 1 CPU]. - Must be: `>= 250`. - Default: `250`.
	Cpu *int `pulumi:"cpu"`
	// Id of the deployment stage.
	DeploymentStageId *string `pulumi:"deploymentStageId"`
	// Id of the environment.
	EnvironmentId *string `pulumi:"environmentId"`
	// The database external FQDN host [NOTE: only if your container is using a publicly accessible port].
	ExternalHost *string `pulumi:"externalHost"`
	// Instance type of the database.
	InstanceType *string `pulumi:"instanceType"`
	// The database internal host (Recommended for your application)
	InternalHost *string `pulumi:"internalHost"`
	// The login to connect to your database
	Login *string `pulumi:"login"`
	// RAM of the database in MB [1024MB = 1GB]. - Must be: `>= 100`. - Default: `256`.
	Memory *int `pulumi:"memory"`
	// Mode of the database [NOTE: can't be updated after creation]. - Can be: `CONTAINER`, `MANAGED`.
	Mode *string `pulumi:"mode"`
	// Name of the database.
	Name *string `pulumi:"name"`
	// The password to connect to your database
	Password *string `pulumi:"password"`
	// The port to connect to your database
	Port *int `pulumi:"port"`
	// Storage of the database in GB [1024MB = 1GB] [NOTE: can't be updated after creation]. - Must be: `>= 10`. - Default:
	// `10`.
	Storage *int `pulumi:"storage"`
	// Type of the database [NOTE: can't be updated after creation]. - Can be: `MONGODB`, `MYSQL`, `POSTGRESQL`, `REDIS`.
	Type *string `pulumi:"type"`
	// Version of the database
	Version *string `pulumi:"version"`
}

type DatabaseState struct {
	// Accessibility of the database. - Can be: `PRIVATE`, `PUBLIC`. - Default: `PUBLIC`.
	Accessibility pulumi.StringPtrInput
	// CPU of the database in millicores (m) [1000m = 1 CPU]. - Must be: `>= 250`. - Default: `250`.
	Cpu pulumi.IntPtrInput
	// Id of the deployment stage.
	DeploymentStageId pulumi.StringPtrInput
	// Id of the environment.
	EnvironmentId pulumi.StringPtrInput
	// The database external FQDN host [NOTE: only if your container is using a publicly accessible port].
	ExternalHost pulumi.StringPtrInput
	// Instance type of the database.
	InstanceType pulumi.StringPtrInput
	// The database internal host (Recommended for your application)
	InternalHost pulumi.StringPtrInput
	// The login to connect to your database
	Login pulumi.StringPtrInput
	// RAM of the database in MB [1024MB = 1GB]. - Must be: `>= 100`. - Default: `256`.
	Memory pulumi.IntPtrInput
	// Mode of the database [NOTE: can't be updated after creation]. - Can be: `CONTAINER`, `MANAGED`.
	Mode pulumi.StringPtrInput
	// Name of the database.
	Name pulumi.StringPtrInput
	// The password to connect to your database
	Password pulumi.StringPtrInput
	// The port to connect to your database
	Port pulumi.IntPtrInput
	// Storage of the database in GB [1024MB = 1GB] [NOTE: can't be updated after creation]. - Must be: `>= 10`. - Default:
	// `10`.
	Storage pulumi.IntPtrInput
	// Type of the database [NOTE: can't be updated after creation]. - Can be: `MONGODB`, `MYSQL`, `POSTGRESQL`, `REDIS`.
	Type pulumi.StringPtrInput
	// Version of the database
	Version pulumi.StringPtrInput
}

func (DatabaseState) ElementType() reflect.Type {
	return reflect.TypeOf((*databaseState)(nil)).Elem()
}

type databaseArgs struct {
	// Accessibility of the database. - Can be: `PRIVATE`, `PUBLIC`. - Default: `PUBLIC`.
	Accessibility *string `pulumi:"accessibility"`
	// CPU of the database in millicores (m) [1000m = 1 CPU]. - Must be: `>= 250`. - Default: `250`.
	Cpu *int `pulumi:"cpu"`
	// Id of the deployment stage.
	DeploymentStageId *string `pulumi:"deploymentStageId"`
	// Id of the environment.
	EnvironmentId string `pulumi:"environmentId"`
	// Instance type of the database.
	InstanceType *string `pulumi:"instanceType"`
	// RAM of the database in MB [1024MB = 1GB]. - Must be: `>= 100`. - Default: `256`.
	Memory *int `pulumi:"memory"`
	// Mode of the database [NOTE: can't be updated after creation]. - Can be: `CONTAINER`, `MANAGED`.
	Mode string `pulumi:"mode"`
	// Name of the database.
	Name *string `pulumi:"name"`
	// Storage of the database in GB [1024MB = 1GB] [NOTE: can't be updated after creation]. - Must be: `>= 10`. - Default:
	// `10`.
	Storage *int `pulumi:"storage"`
	// Type of the database [NOTE: can't be updated after creation]. - Can be: `MONGODB`, `MYSQL`, `POSTGRESQL`, `REDIS`.
	Type string `pulumi:"type"`
	// Version of the database
	Version string `pulumi:"version"`
}

// The set of arguments for constructing a Database resource.
type DatabaseArgs struct {
	// Accessibility of the database. - Can be: `PRIVATE`, `PUBLIC`. - Default: `PUBLIC`.
	Accessibility pulumi.StringPtrInput
	// CPU of the database in millicores (m) [1000m = 1 CPU]. - Must be: `>= 250`. - Default: `250`.
	Cpu pulumi.IntPtrInput
	// Id of the deployment stage.
	DeploymentStageId pulumi.StringPtrInput
	// Id of the environment.
	EnvironmentId pulumi.StringInput
	// Instance type of the database.
	InstanceType pulumi.StringPtrInput
	// RAM of the database in MB [1024MB = 1GB]. - Must be: `>= 100`. - Default: `256`.
	Memory pulumi.IntPtrInput
	// Mode of the database [NOTE: can't be updated after creation]. - Can be: `CONTAINER`, `MANAGED`.
	Mode pulumi.StringInput
	// Name of the database.
	Name pulumi.StringPtrInput
	// Storage of the database in GB [1024MB = 1GB] [NOTE: can't be updated after creation]. - Must be: `>= 10`. - Default:
	// `10`.
	Storage pulumi.IntPtrInput
	// Type of the database [NOTE: can't be updated after creation]. - Can be: `MONGODB`, `MYSQL`, `POSTGRESQL`, `REDIS`.
	Type pulumi.StringInput
	// Version of the database
	Version pulumi.StringInput
}

func (DatabaseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*databaseArgs)(nil)).Elem()
}

type DatabaseInput interface {
	pulumi.Input

	ToDatabaseOutput() DatabaseOutput
	ToDatabaseOutputWithContext(ctx context.Context) DatabaseOutput
}

func (*Database) ElementType() reflect.Type {
	return reflect.TypeOf((**Database)(nil)).Elem()
}

func (i *Database) ToDatabaseOutput() DatabaseOutput {
	return i.ToDatabaseOutputWithContext(context.Background())
}

func (i *Database) ToDatabaseOutputWithContext(ctx context.Context) DatabaseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DatabaseOutput)
}

// DatabaseArrayInput is an input type that accepts DatabaseArray and DatabaseArrayOutput values.
// You can construct a concrete instance of `DatabaseArrayInput` via:
//
//	DatabaseArray{ DatabaseArgs{...} }
type DatabaseArrayInput interface {
	pulumi.Input

	ToDatabaseArrayOutput() DatabaseArrayOutput
	ToDatabaseArrayOutputWithContext(context.Context) DatabaseArrayOutput
}

type DatabaseArray []DatabaseInput

func (DatabaseArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Database)(nil)).Elem()
}

func (i DatabaseArray) ToDatabaseArrayOutput() DatabaseArrayOutput {
	return i.ToDatabaseArrayOutputWithContext(context.Background())
}

func (i DatabaseArray) ToDatabaseArrayOutputWithContext(ctx context.Context) DatabaseArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DatabaseArrayOutput)
}

// DatabaseMapInput is an input type that accepts DatabaseMap and DatabaseMapOutput values.
// You can construct a concrete instance of `DatabaseMapInput` via:
//
//	DatabaseMap{ "key": DatabaseArgs{...} }
type DatabaseMapInput interface {
	pulumi.Input

	ToDatabaseMapOutput() DatabaseMapOutput
	ToDatabaseMapOutputWithContext(context.Context) DatabaseMapOutput
}

type DatabaseMap map[string]DatabaseInput

func (DatabaseMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Database)(nil)).Elem()
}

func (i DatabaseMap) ToDatabaseMapOutput() DatabaseMapOutput {
	return i.ToDatabaseMapOutputWithContext(context.Background())
}

func (i DatabaseMap) ToDatabaseMapOutputWithContext(ctx context.Context) DatabaseMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DatabaseMapOutput)
}

type DatabaseOutput struct{ *pulumi.OutputState }

func (DatabaseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Database)(nil)).Elem()
}

func (o DatabaseOutput) ToDatabaseOutput() DatabaseOutput {
	return o
}

func (o DatabaseOutput) ToDatabaseOutputWithContext(ctx context.Context) DatabaseOutput {
	return o
}

// Accessibility of the database. - Can be: `PRIVATE`, `PUBLIC`. - Default: `PUBLIC`.
func (o DatabaseOutput) Accessibility() pulumi.StringOutput {
	return o.ApplyT(func(v *Database) pulumi.StringOutput { return v.Accessibility }).(pulumi.StringOutput)
}

// CPU of the database in millicores (m) [1000m = 1 CPU]. - Must be: `>= 250`. - Default: `250`.
func (o DatabaseOutput) Cpu() pulumi.IntOutput {
	return o.ApplyT(func(v *Database) pulumi.IntOutput { return v.Cpu }).(pulumi.IntOutput)
}

// Id of the deployment stage.
func (o DatabaseOutput) DeploymentStageId() pulumi.StringOutput {
	return o.ApplyT(func(v *Database) pulumi.StringOutput { return v.DeploymentStageId }).(pulumi.StringOutput)
}

// Id of the environment.
func (o DatabaseOutput) EnvironmentId() pulumi.StringOutput {
	return o.ApplyT(func(v *Database) pulumi.StringOutput { return v.EnvironmentId }).(pulumi.StringOutput)
}

// The database external FQDN host [NOTE: only if your container is using a publicly accessible port].
func (o DatabaseOutput) ExternalHost() pulumi.StringOutput {
	return o.ApplyT(func(v *Database) pulumi.StringOutput { return v.ExternalHost }).(pulumi.StringOutput)
}

// Instance type of the database.
func (o DatabaseOutput) InstanceType() pulumi.StringOutput {
	return o.ApplyT(func(v *Database) pulumi.StringOutput { return v.InstanceType }).(pulumi.StringOutput)
}

// The database internal host (Recommended for your application)
func (o DatabaseOutput) InternalHost() pulumi.StringOutput {
	return o.ApplyT(func(v *Database) pulumi.StringOutput { return v.InternalHost }).(pulumi.StringOutput)
}

// The login to connect to your database
func (o DatabaseOutput) Login() pulumi.StringOutput {
	return o.ApplyT(func(v *Database) pulumi.StringOutput { return v.Login }).(pulumi.StringOutput)
}

// RAM of the database in MB [1024MB = 1GB]. - Must be: `>= 100`. - Default: `256`.
func (o DatabaseOutput) Memory() pulumi.IntOutput {
	return o.ApplyT(func(v *Database) pulumi.IntOutput { return v.Memory }).(pulumi.IntOutput)
}

// Mode of the database [NOTE: can't be updated after creation]. - Can be: `CONTAINER`, `MANAGED`.
func (o DatabaseOutput) Mode() pulumi.StringOutput {
	return o.ApplyT(func(v *Database) pulumi.StringOutput { return v.Mode }).(pulumi.StringOutput)
}

// Name of the database.
func (o DatabaseOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *Database) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// The password to connect to your database
func (o DatabaseOutput) Password() pulumi.StringOutput {
	return o.ApplyT(func(v *Database) pulumi.StringOutput { return v.Password }).(pulumi.StringOutput)
}

// The port to connect to your database
func (o DatabaseOutput) Port() pulumi.IntOutput {
	return o.ApplyT(func(v *Database) pulumi.IntOutput { return v.Port }).(pulumi.IntOutput)
}

// Storage of the database in GB [1024MB = 1GB] [NOTE: can't be updated after creation]. - Must be: `>= 10`. - Default:
// `10`.
func (o DatabaseOutput) Storage() pulumi.IntOutput {
	return o.ApplyT(func(v *Database) pulumi.IntOutput { return v.Storage }).(pulumi.IntOutput)
}

// Type of the database [NOTE: can't be updated after creation]. - Can be: `MONGODB`, `MYSQL`, `POSTGRESQL`, `REDIS`.
func (o DatabaseOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v *Database) pulumi.StringOutput { return v.Type }).(pulumi.StringOutput)
}

// Version of the database
func (o DatabaseOutput) Version() pulumi.StringOutput {
	return o.ApplyT(func(v *Database) pulumi.StringOutput { return v.Version }).(pulumi.StringOutput)
}

type DatabaseArrayOutput struct{ *pulumi.OutputState }

func (DatabaseArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Database)(nil)).Elem()
}

func (o DatabaseArrayOutput) ToDatabaseArrayOutput() DatabaseArrayOutput {
	return o
}

func (o DatabaseArrayOutput) ToDatabaseArrayOutputWithContext(ctx context.Context) DatabaseArrayOutput {
	return o
}

func (o DatabaseArrayOutput) Index(i pulumi.IntInput) DatabaseOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Database {
		return vs[0].([]*Database)[vs[1].(int)]
	}).(DatabaseOutput)
}

type DatabaseMapOutput struct{ *pulumi.OutputState }

func (DatabaseMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Database)(nil)).Elem()
}

func (o DatabaseMapOutput) ToDatabaseMapOutput() DatabaseMapOutput {
	return o
}

func (o DatabaseMapOutput) ToDatabaseMapOutputWithContext(ctx context.Context) DatabaseMapOutput {
	return o
}

func (o DatabaseMapOutput) MapIndex(k pulumi.StringInput) DatabaseOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Database {
		return vs[0].(map[string]*Database)[vs[1].(string)]
	}).(DatabaseOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DatabaseInput)(nil)).Elem(), &Database{})
	pulumi.RegisterInputType(reflect.TypeOf((*DatabaseArrayInput)(nil)).Elem(), DatabaseArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*DatabaseMapInput)(nil)).Elem(), DatabaseMap{})
	pulumi.RegisterOutputType(DatabaseOutput{})
	pulumi.RegisterOutputType(DatabaseArrayOutput{})
	pulumi.RegisterOutputType(DatabaseMapOutput{})
}