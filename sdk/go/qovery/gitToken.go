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

// ## # GitToken (Resource)
//
// Provides a Qovery git token resource. This can be used to create and manage Qovery git token.
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
//			_, err := qovery.NewGitToken(ctx, "myGitToken", &qovery.GitTokenArgs{
//				OrganizationId:     pulumi.Any(qovery_organization.My_organization.Id),
//				Type:               pulumi.String("GITHUB"),
//				Token:              pulumi.String("my-git-provider-token"),
//				Description:        pulumi.String("Github token"),
//				BitbucketWorkspace: pulumi.String("workspace-bitbucket"),
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
// $ pulumi import qovery:index/gitToken:GitToken my_git_token "<organization_id>,<git_token_id>"
// ```
type GitToken struct {
	pulumi.CustomResourceState

	// (Mandatory only for Bitbucket git token) Workspace where the token has permissions .
	BitbucketWorkspace pulumi.StringOutput `pulumi:"bitbucketWorkspace"`
	// Description of the git token.
	Description pulumi.StringOutput `pulumi:"description"`
	// Name of the git token.
	Name pulumi.StringOutput `pulumi:"name"`
	// Id of the organization.
	OrganizationId pulumi.StringOutput `pulumi:"organizationId"`
	// Value of the git token.
	Token pulumi.StringOutput `pulumi:"token"`
	// Type of the git token. - Can be: `BITBUCKET`, `GITHUB`, `GITLAB`.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewGitToken registers a new resource with the given unique name, arguments, and options.
func NewGitToken(ctx *pulumi.Context,
	name string, args *GitTokenArgs, opts ...pulumi.ResourceOption) (*GitToken, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.OrganizationId == nil {
		return nil, errors.New("invalid value for required argument 'OrganizationId'")
	}
	if args.Token == nil {
		return nil, errors.New("invalid value for required argument 'Token'")
	}
	if args.Type == nil {
		return nil, errors.New("invalid value for required argument 'Type'")
	}
	if args.Token != nil {
		args.Token = pulumi.ToSecret(args.Token).(pulumi.StringInput)
	}
	secrets := pulumi.AdditionalSecretOutputs([]string{
		"token",
	})
	opts = append(opts, secrets)
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource GitToken
	err := ctx.RegisterResource("qovery:index/gitToken:GitToken", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetGitToken gets an existing GitToken resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGitToken(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *GitTokenState, opts ...pulumi.ResourceOption) (*GitToken, error) {
	var resource GitToken
	err := ctx.ReadResource("qovery:index/gitToken:GitToken", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering GitToken resources.
type gitTokenState struct {
	// (Mandatory only for Bitbucket git token) Workspace where the token has permissions .
	BitbucketWorkspace *string `pulumi:"bitbucketWorkspace"`
	// Description of the git token.
	Description *string `pulumi:"description"`
	// Name of the git token.
	Name *string `pulumi:"name"`
	// Id of the organization.
	OrganizationId *string `pulumi:"organizationId"`
	// Value of the git token.
	Token *string `pulumi:"token"`
	// Type of the git token. - Can be: `BITBUCKET`, `GITHUB`, `GITLAB`.
	Type *string `pulumi:"type"`
}

type GitTokenState struct {
	// (Mandatory only for Bitbucket git token) Workspace where the token has permissions .
	BitbucketWorkspace pulumi.StringPtrInput
	// Description of the git token.
	Description pulumi.StringPtrInput
	// Name of the git token.
	Name pulumi.StringPtrInput
	// Id of the organization.
	OrganizationId pulumi.StringPtrInput
	// Value of the git token.
	Token pulumi.StringPtrInput
	// Type of the git token. - Can be: `BITBUCKET`, `GITHUB`, `GITLAB`.
	Type pulumi.StringPtrInput
}

func (GitTokenState) ElementType() reflect.Type {
	return reflect.TypeOf((*gitTokenState)(nil)).Elem()
}

type gitTokenArgs struct {
	// (Mandatory only for Bitbucket git token) Workspace where the token has permissions .
	BitbucketWorkspace *string `pulumi:"bitbucketWorkspace"`
	// Description of the git token.
	Description *string `pulumi:"description"`
	// Name of the git token.
	Name *string `pulumi:"name"`
	// Id of the organization.
	OrganizationId string `pulumi:"organizationId"`
	// Value of the git token.
	Token string `pulumi:"token"`
	// Type of the git token. - Can be: `BITBUCKET`, `GITHUB`, `GITLAB`.
	Type string `pulumi:"type"`
}

// The set of arguments for constructing a GitToken resource.
type GitTokenArgs struct {
	// (Mandatory only for Bitbucket git token) Workspace where the token has permissions .
	BitbucketWorkspace pulumi.StringPtrInput
	// Description of the git token.
	Description pulumi.StringPtrInput
	// Name of the git token.
	Name pulumi.StringPtrInput
	// Id of the organization.
	OrganizationId pulumi.StringInput
	// Value of the git token.
	Token pulumi.StringInput
	// Type of the git token. - Can be: `BITBUCKET`, `GITHUB`, `GITLAB`.
	Type pulumi.StringInput
}

func (GitTokenArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*gitTokenArgs)(nil)).Elem()
}

type GitTokenInput interface {
	pulumi.Input

	ToGitTokenOutput() GitTokenOutput
	ToGitTokenOutputWithContext(ctx context.Context) GitTokenOutput
}

func (*GitToken) ElementType() reflect.Type {
	return reflect.TypeOf((**GitToken)(nil)).Elem()
}

func (i *GitToken) ToGitTokenOutput() GitTokenOutput {
	return i.ToGitTokenOutputWithContext(context.Background())
}

func (i *GitToken) ToGitTokenOutputWithContext(ctx context.Context) GitTokenOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GitTokenOutput)
}

// GitTokenArrayInput is an input type that accepts GitTokenArray and GitTokenArrayOutput values.
// You can construct a concrete instance of `GitTokenArrayInput` via:
//
//	GitTokenArray{ GitTokenArgs{...} }
type GitTokenArrayInput interface {
	pulumi.Input

	ToGitTokenArrayOutput() GitTokenArrayOutput
	ToGitTokenArrayOutputWithContext(context.Context) GitTokenArrayOutput
}

type GitTokenArray []GitTokenInput

func (GitTokenArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*GitToken)(nil)).Elem()
}

func (i GitTokenArray) ToGitTokenArrayOutput() GitTokenArrayOutput {
	return i.ToGitTokenArrayOutputWithContext(context.Background())
}

func (i GitTokenArray) ToGitTokenArrayOutputWithContext(ctx context.Context) GitTokenArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GitTokenArrayOutput)
}

// GitTokenMapInput is an input type that accepts GitTokenMap and GitTokenMapOutput values.
// You can construct a concrete instance of `GitTokenMapInput` via:
//
//	GitTokenMap{ "key": GitTokenArgs{...} }
type GitTokenMapInput interface {
	pulumi.Input

	ToGitTokenMapOutput() GitTokenMapOutput
	ToGitTokenMapOutputWithContext(context.Context) GitTokenMapOutput
}

type GitTokenMap map[string]GitTokenInput

func (GitTokenMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*GitToken)(nil)).Elem()
}

func (i GitTokenMap) ToGitTokenMapOutput() GitTokenMapOutput {
	return i.ToGitTokenMapOutputWithContext(context.Background())
}

func (i GitTokenMap) ToGitTokenMapOutputWithContext(ctx context.Context) GitTokenMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GitTokenMapOutput)
}

type GitTokenOutput struct{ *pulumi.OutputState }

func (GitTokenOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**GitToken)(nil)).Elem()
}

func (o GitTokenOutput) ToGitTokenOutput() GitTokenOutput {
	return o
}

func (o GitTokenOutput) ToGitTokenOutputWithContext(ctx context.Context) GitTokenOutput {
	return o
}

// (Mandatory only for Bitbucket git token) Workspace where the token has permissions .
func (o GitTokenOutput) BitbucketWorkspace() pulumi.StringOutput {
	return o.ApplyT(func(v *GitToken) pulumi.StringOutput { return v.BitbucketWorkspace }).(pulumi.StringOutput)
}

// Description of the git token.
func (o GitTokenOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v *GitToken) pulumi.StringOutput { return v.Description }).(pulumi.StringOutput)
}

// Name of the git token.
func (o GitTokenOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *GitToken) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Id of the organization.
func (o GitTokenOutput) OrganizationId() pulumi.StringOutput {
	return o.ApplyT(func(v *GitToken) pulumi.StringOutput { return v.OrganizationId }).(pulumi.StringOutput)
}

// Value of the git token.
func (o GitTokenOutput) Token() pulumi.StringOutput {
	return o.ApplyT(func(v *GitToken) pulumi.StringOutput { return v.Token }).(pulumi.StringOutput)
}

// Type of the git token. - Can be: `BITBUCKET`, `GITHUB`, `GITLAB`.
func (o GitTokenOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v *GitToken) pulumi.StringOutput { return v.Type }).(pulumi.StringOutput)
}

type GitTokenArrayOutput struct{ *pulumi.OutputState }

func (GitTokenArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*GitToken)(nil)).Elem()
}

func (o GitTokenArrayOutput) ToGitTokenArrayOutput() GitTokenArrayOutput {
	return o
}

func (o GitTokenArrayOutput) ToGitTokenArrayOutputWithContext(ctx context.Context) GitTokenArrayOutput {
	return o
}

func (o GitTokenArrayOutput) Index(i pulumi.IntInput) GitTokenOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *GitToken {
		return vs[0].([]*GitToken)[vs[1].(int)]
	}).(GitTokenOutput)
}

type GitTokenMapOutput struct{ *pulumi.OutputState }

func (GitTokenMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*GitToken)(nil)).Elem()
}

func (o GitTokenMapOutput) ToGitTokenMapOutput() GitTokenMapOutput {
	return o
}

func (o GitTokenMapOutput) ToGitTokenMapOutputWithContext(ctx context.Context) GitTokenMapOutput {
	return o
}

func (o GitTokenMapOutput) MapIndex(k pulumi.StringInput) GitTokenOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *GitToken {
		return vs[0].(map[string]*GitToken)[vs[1].(string)]
	}).(GitTokenOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*GitTokenInput)(nil)).Elem(), &GitToken{})
	pulumi.RegisterInputType(reflect.TypeOf((*GitTokenArrayInput)(nil)).Elem(), GitTokenArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*GitTokenMapInput)(nil)).Elem(), GitTokenMap{})
	pulumi.RegisterOutputType(GitTokenOutput{})
	pulumi.RegisterOutputType(GitTokenArrayOutput{})
	pulumi.RegisterOutputType(GitTokenMapOutput{})
}
