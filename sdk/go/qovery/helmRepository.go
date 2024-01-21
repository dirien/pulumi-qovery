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

// ## # HelmRepository (Resource)
//
// Provides a Qovery helm repository resource. This can be used to create and manage Qovery helm repository.
//
// ## Import
//
// ```sh
//
//	$ pulumi import qovery:index/helmRepository:HelmRepository my_helm_repository "<organization_id>,<helm_repository_id>"
//
// ```
type HelmRepository struct {
	pulumi.CustomResourceState

	// Configuration needed to authenticate the helm repository.
	Config HelmRepositoryConfigPtrOutput `pulumi:"config"`
	// Description of the helm repository.
	Description pulumi.StringOutput `pulumi:"description"`
	// Kind of the helm repository. - Can be: `HTTPS`, `OCI_DOCKER_HUB`, `OCI_DOCR`, `OCI_ECR`, `OCI_GENERIC_CR`,
	// `OCI_GITHUB_CR`, `OCI_GITLAB_CR`, `OCI_PUBLIC_ECR`, `OCI_SCALEWAY_CR`.
	Kind pulumi.StringOutput `pulumi:"kind"`
	// Name of the helm repository.
	Name pulumi.StringOutput `pulumi:"name"`
	// Id of the organization.
	OrganizationId pulumi.StringOutput `pulumi:"organizationId"`
	// Bypass tls certificate verification when connecting to repository
	SkipTlsVerification pulumi.BoolOutput `pulumi:"skipTlsVerification"`
	// URL of the helm repository.
	Url pulumi.StringOutput `pulumi:"url"`
}

// NewHelmRepository registers a new resource with the given unique name, arguments, and options.
func NewHelmRepository(ctx *pulumi.Context,
	name string, args *HelmRepositoryArgs, opts ...pulumi.ResourceOption) (*HelmRepository, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Kind == nil {
		return nil, errors.New("invalid value for required argument 'Kind'")
	}
	if args.OrganizationId == nil {
		return nil, errors.New("invalid value for required argument 'OrganizationId'")
	}
	if args.SkipTlsVerification == nil {
		return nil, errors.New("invalid value for required argument 'SkipTlsVerification'")
	}
	if args.Url == nil {
		return nil, errors.New("invalid value for required argument 'Url'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource HelmRepository
	err := ctx.RegisterResource("qovery:index/helmRepository:HelmRepository", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetHelmRepository gets an existing HelmRepository resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetHelmRepository(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *HelmRepositoryState, opts ...pulumi.ResourceOption) (*HelmRepository, error) {
	var resource HelmRepository
	err := ctx.ReadResource("qovery:index/helmRepository:HelmRepository", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering HelmRepository resources.
type helmRepositoryState struct {
	// Configuration needed to authenticate the helm repository.
	Config *HelmRepositoryConfig `pulumi:"config"`
	// Description of the helm repository.
	Description *string `pulumi:"description"`
	// Kind of the helm repository. - Can be: `HTTPS`, `OCI_DOCKER_HUB`, `OCI_DOCR`, `OCI_ECR`, `OCI_GENERIC_CR`,
	// `OCI_GITHUB_CR`, `OCI_GITLAB_CR`, `OCI_PUBLIC_ECR`, `OCI_SCALEWAY_CR`.
	Kind *string `pulumi:"kind"`
	// Name of the helm repository.
	Name *string `pulumi:"name"`
	// Id of the organization.
	OrganizationId *string `pulumi:"organizationId"`
	// Bypass tls certificate verification when connecting to repository
	SkipTlsVerification *bool `pulumi:"skipTlsVerification"`
	// URL of the helm repository.
	Url *string `pulumi:"url"`
}

type HelmRepositoryState struct {
	// Configuration needed to authenticate the helm repository.
	Config HelmRepositoryConfigPtrInput
	// Description of the helm repository.
	Description pulumi.StringPtrInput
	// Kind of the helm repository. - Can be: `HTTPS`, `OCI_DOCKER_HUB`, `OCI_DOCR`, `OCI_ECR`, `OCI_GENERIC_CR`,
	// `OCI_GITHUB_CR`, `OCI_GITLAB_CR`, `OCI_PUBLIC_ECR`, `OCI_SCALEWAY_CR`.
	Kind pulumi.StringPtrInput
	// Name of the helm repository.
	Name pulumi.StringPtrInput
	// Id of the organization.
	OrganizationId pulumi.StringPtrInput
	// Bypass tls certificate verification when connecting to repository
	SkipTlsVerification pulumi.BoolPtrInput
	// URL of the helm repository.
	Url pulumi.StringPtrInput
}

func (HelmRepositoryState) ElementType() reflect.Type {
	return reflect.TypeOf((*helmRepositoryState)(nil)).Elem()
}

type helmRepositoryArgs struct {
	// Configuration needed to authenticate the helm repository.
	Config *HelmRepositoryConfig `pulumi:"config"`
	// Description of the helm repository.
	Description *string `pulumi:"description"`
	// Kind of the helm repository. - Can be: `HTTPS`, `OCI_DOCKER_HUB`, `OCI_DOCR`, `OCI_ECR`, `OCI_GENERIC_CR`,
	// `OCI_GITHUB_CR`, `OCI_GITLAB_CR`, `OCI_PUBLIC_ECR`, `OCI_SCALEWAY_CR`.
	Kind string `pulumi:"kind"`
	// Name of the helm repository.
	Name *string `pulumi:"name"`
	// Id of the organization.
	OrganizationId string `pulumi:"organizationId"`
	// Bypass tls certificate verification when connecting to repository
	SkipTlsVerification bool `pulumi:"skipTlsVerification"`
	// URL of the helm repository.
	Url string `pulumi:"url"`
}

// The set of arguments for constructing a HelmRepository resource.
type HelmRepositoryArgs struct {
	// Configuration needed to authenticate the helm repository.
	Config HelmRepositoryConfigPtrInput
	// Description of the helm repository.
	Description pulumi.StringPtrInput
	// Kind of the helm repository. - Can be: `HTTPS`, `OCI_DOCKER_HUB`, `OCI_DOCR`, `OCI_ECR`, `OCI_GENERIC_CR`,
	// `OCI_GITHUB_CR`, `OCI_GITLAB_CR`, `OCI_PUBLIC_ECR`, `OCI_SCALEWAY_CR`.
	Kind pulumi.StringInput
	// Name of the helm repository.
	Name pulumi.StringPtrInput
	// Id of the organization.
	OrganizationId pulumi.StringInput
	// Bypass tls certificate verification when connecting to repository
	SkipTlsVerification pulumi.BoolInput
	// URL of the helm repository.
	Url pulumi.StringInput
}

func (HelmRepositoryArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*helmRepositoryArgs)(nil)).Elem()
}

type HelmRepositoryInput interface {
	pulumi.Input

	ToHelmRepositoryOutput() HelmRepositoryOutput
	ToHelmRepositoryOutputWithContext(ctx context.Context) HelmRepositoryOutput
}

func (*HelmRepository) ElementType() reflect.Type {
	return reflect.TypeOf((**HelmRepository)(nil)).Elem()
}

func (i *HelmRepository) ToHelmRepositoryOutput() HelmRepositoryOutput {
	return i.ToHelmRepositoryOutputWithContext(context.Background())
}

func (i *HelmRepository) ToHelmRepositoryOutputWithContext(ctx context.Context) HelmRepositoryOutput {
	return pulumi.ToOutputWithContext(ctx, i).(HelmRepositoryOutput)
}

// HelmRepositoryArrayInput is an input type that accepts HelmRepositoryArray and HelmRepositoryArrayOutput values.
// You can construct a concrete instance of `HelmRepositoryArrayInput` via:
//
//	HelmRepositoryArray{ HelmRepositoryArgs{...} }
type HelmRepositoryArrayInput interface {
	pulumi.Input

	ToHelmRepositoryArrayOutput() HelmRepositoryArrayOutput
	ToHelmRepositoryArrayOutputWithContext(context.Context) HelmRepositoryArrayOutput
}

type HelmRepositoryArray []HelmRepositoryInput

func (HelmRepositoryArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*HelmRepository)(nil)).Elem()
}

func (i HelmRepositoryArray) ToHelmRepositoryArrayOutput() HelmRepositoryArrayOutput {
	return i.ToHelmRepositoryArrayOutputWithContext(context.Background())
}

func (i HelmRepositoryArray) ToHelmRepositoryArrayOutputWithContext(ctx context.Context) HelmRepositoryArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(HelmRepositoryArrayOutput)
}

// HelmRepositoryMapInput is an input type that accepts HelmRepositoryMap and HelmRepositoryMapOutput values.
// You can construct a concrete instance of `HelmRepositoryMapInput` via:
//
//	HelmRepositoryMap{ "key": HelmRepositoryArgs{...} }
type HelmRepositoryMapInput interface {
	pulumi.Input

	ToHelmRepositoryMapOutput() HelmRepositoryMapOutput
	ToHelmRepositoryMapOutputWithContext(context.Context) HelmRepositoryMapOutput
}

type HelmRepositoryMap map[string]HelmRepositoryInput

func (HelmRepositoryMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*HelmRepository)(nil)).Elem()
}

func (i HelmRepositoryMap) ToHelmRepositoryMapOutput() HelmRepositoryMapOutput {
	return i.ToHelmRepositoryMapOutputWithContext(context.Background())
}

func (i HelmRepositoryMap) ToHelmRepositoryMapOutputWithContext(ctx context.Context) HelmRepositoryMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(HelmRepositoryMapOutput)
}

type HelmRepositoryOutput struct{ *pulumi.OutputState }

func (HelmRepositoryOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**HelmRepository)(nil)).Elem()
}

func (o HelmRepositoryOutput) ToHelmRepositoryOutput() HelmRepositoryOutput {
	return o
}

func (o HelmRepositoryOutput) ToHelmRepositoryOutputWithContext(ctx context.Context) HelmRepositoryOutput {
	return o
}

// Configuration needed to authenticate the helm repository.
func (o HelmRepositoryOutput) Config() HelmRepositoryConfigPtrOutput {
	return o.ApplyT(func(v *HelmRepository) HelmRepositoryConfigPtrOutput { return v.Config }).(HelmRepositoryConfigPtrOutput)
}

// Description of the helm repository.
func (o HelmRepositoryOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v *HelmRepository) pulumi.StringOutput { return v.Description }).(pulumi.StringOutput)
}

// Kind of the helm repository. - Can be: `HTTPS`, `OCI_DOCKER_HUB`, `OCI_DOCR`, `OCI_ECR`, `OCI_GENERIC_CR`,
// `OCI_GITHUB_CR`, `OCI_GITLAB_CR`, `OCI_PUBLIC_ECR`, `OCI_SCALEWAY_CR`.
func (o HelmRepositoryOutput) Kind() pulumi.StringOutput {
	return o.ApplyT(func(v *HelmRepository) pulumi.StringOutput { return v.Kind }).(pulumi.StringOutput)
}

// Name of the helm repository.
func (o HelmRepositoryOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *HelmRepository) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Id of the organization.
func (o HelmRepositoryOutput) OrganizationId() pulumi.StringOutput {
	return o.ApplyT(func(v *HelmRepository) pulumi.StringOutput { return v.OrganizationId }).(pulumi.StringOutput)
}

// Bypass tls certificate verification when connecting to repository
func (o HelmRepositoryOutput) SkipTlsVerification() pulumi.BoolOutput {
	return o.ApplyT(func(v *HelmRepository) pulumi.BoolOutput { return v.SkipTlsVerification }).(pulumi.BoolOutput)
}

// URL of the helm repository.
func (o HelmRepositoryOutput) Url() pulumi.StringOutput {
	return o.ApplyT(func(v *HelmRepository) pulumi.StringOutput { return v.Url }).(pulumi.StringOutput)
}

type HelmRepositoryArrayOutput struct{ *pulumi.OutputState }

func (HelmRepositoryArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*HelmRepository)(nil)).Elem()
}

func (o HelmRepositoryArrayOutput) ToHelmRepositoryArrayOutput() HelmRepositoryArrayOutput {
	return o
}

func (o HelmRepositoryArrayOutput) ToHelmRepositoryArrayOutputWithContext(ctx context.Context) HelmRepositoryArrayOutput {
	return o
}

func (o HelmRepositoryArrayOutput) Index(i pulumi.IntInput) HelmRepositoryOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *HelmRepository {
		return vs[0].([]*HelmRepository)[vs[1].(int)]
	}).(HelmRepositoryOutput)
}

type HelmRepositoryMapOutput struct{ *pulumi.OutputState }

func (HelmRepositoryMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*HelmRepository)(nil)).Elem()
}

func (o HelmRepositoryMapOutput) ToHelmRepositoryMapOutput() HelmRepositoryMapOutput {
	return o
}

func (o HelmRepositoryMapOutput) ToHelmRepositoryMapOutputWithContext(ctx context.Context) HelmRepositoryMapOutput {
	return o
}

func (o HelmRepositoryMapOutput) MapIndex(k pulumi.StringInput) HelmRepositoryOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *HelmRepository {
		return vs[0].(map[string]*HelmRepository)[vs[1].(string)]
	}).(HelmRepositoryOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*HelmRepositoryInput)(nil)).Elem(), &HelmRepository{})
	pulumi.RegisterInputType(reflect.TypeOf((*HelmRepositoryArrayInput)(nil)).Elem(), HelmRepositoryArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*HelmRepositoryMapInput)(nil)).Elem(), HelmRepositoryMap{})
	pulumi.RegisterOutputType(HelmRepositoryOutput{})
	pulumi.RegisterOutputType(HelmRepositoryArrayOutput{})
	pulumi.RegisterOutputType(HelmRepositoryMapOutput{})
}
