// Copyright 2016-2018, Pulumi Corporation.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

package qovery

import (
	_ "embed"
	"fmt"
	"github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfbridge"
	"github.com/qovery/terraform-provider-qovery/qovery"
	"path/filepath"
	"unicode"

	"github.com/dirien/pulumi-qovery/provider/pkg/version"
	pf "github.com/pulumi/pulumi-terraform-bridge/pf/tfbridge"
	tfbridgetokens "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfbridge/tokens"
	"github.com/pulumi/pulumi/sdk/v3/go/common/tokens"
)

// all of the token components used below.
const (
	// This variable controls the default name of the package in the package
	// registries for nodejs and python:
	mainPkg = "qovery"
	// modules:
	mainMod = "index" // the qovery module
)

// qoveryMember manufactures a type token for the random package and the given module and type.
func qoveryMember(mod string, mem string) tokens.ModuleMember {
	return tokens.ModuleMember(mainPkg + ":" + mod + ":" + mem)
}

// qoveryType manufactures a type token for the random package and the given module and type.
func qoveryType(mod string, typ string) tokens.Type {
	return tokens.Type(qoveryMember(mod, typ))
}

// qoveryResource manufactures a standard resource token given a module and resource name.  It automatically uses the
// qovery package and names the file by simply lower casing the resource's first character.
func qoveryResource(mod string, res string) tokens.Type {
	fn := string(unicode.ToLower(rune(res[0]))) + res[1:]
	return qoveryType(mod+"/"+fn, res)
}

// qoveryDataSource manufactures a standard resource token given a module and resource name.  It automatically uses the
// qovery package and names the file by simply lower casing the resource's first character.
func qoveryDataSource(mod string, res string) tokens.ModuleMember {
	fn := string(unicode.ToLower(rune(res[0]))) + res[1:]
	return qoveryMember(mod+"/"+fn, res)
}

//go:embed cmd/pulumi-resource-qovery/bridge-metadata.json
var metadata []byte

// Provider returns additional overlaid schema and metadata associated with the provider..
func Provider() tfbridge.ProviderInfo {
	// Instantiate the Terraform provider
	// Create a Pulumi provider mapping
	p := qovery.New(version.Version)
	prov := tfbridge.ProviderInfo{
		P:       pf.ShimProvider(p()),
		Name:    "qovery",
		Version: version.Version,
		// DisplayName is a way to be able to change the casing of the provider
		// name when being displayed on the Pulumi registry
		DisplayName: "Qovery",
		// The default publisher for all packages is Pulumi.
		// Change this to your personal name (or a company name) that you
		// would like to be shown in the Pulumi Registry if this package is published
		// there.
		Publisher: "dirien",
		// LogoURL is optional but useful to help identify your package in the Pulumi Registry
		// if this package is published there.
		//
		// You may host a logo on a domain you control or add an SVG logo for your package
		// in your repository and use the raw content URL for that file as your logo URL.
		LogoURL: "",
		// PluginDownloadURL is an optional URL used to download the Provider
		// for use in Pulumi programs
		// e.g https://github.com/org/pulumi-provider-name/releases/
		PluginDownloadURL: "github://api.github.com/dirien/pulumi-qovery",
		Description:       "A Pulumi package for creating and managing qovery cloud resources.",
		// category/cloud tag helps with categorizing the package in the Pulumi Registry.
		// For all available categories, see `Keywords` in
		// https://www.pulumi.com/docs/guides/pulumi-packages/schema/#package.
		Keywords:     []string{"pulumi", "qovery", "category/cloud"},
		License:      "Apache-2.0",
		Homepage:     "https://www.pulumi.com",
		Repository:   "https://github.com/dirien/pulumi-qovery",
		MetadataInfo: tfbridge.NewProviderMetadata(metadata),
		// The GitHub Org for the provider - defaults to `terraform-providers`. Note that this
		// should match the TF provider module's require directive, not any replace directives.
		GitHubOrg: "qovery",
		Config: map[string]*tfbridge.SchemaInfo{
			// Add any required configuration here, or remove the example below if
			// no additional points are required.
			// "region": {
			// 	Type: tfbridge.MakeType("region", "Region"),
			// 	Default: &tfbridge.DefaultInfo{
			// 		EnvVars: []string{"AWS_REGION", "AWS_DEFAULT_REGION"},
			// 	},
			// },
			"token": {
				Default: &tfbridge.DefaultInfo{
					EnvVars: []string{"QOVERY_API_TOKEN"},
				},
				Secret: tfbridge.BoolRef(true),
			},
		},
		Resources: map[string]*tfbridge.ResourceInfo{
			// Map each resource in the Terraform provider to a Pulumi type. Two examples
			// are below - the single line form is the common case. The multi-line form is
			// needed only if you wish to override types or other default options.
			//
			// "aws_iam_role": {Tok: tfbridge.MakeResource(mainPkg, mainMod, "IamRole")}
			//
			// "aws_acm_certificate": {
			// 	Tok: tfbridge.MakeResource(mainPkg, mainMod, "Certificate"),
			// 	Fields: map[string]*tfbridge.SchemaInfo{
			// 		"tags": {Type: tfbridge.MakeType(mainPkg, "Tags")},
			// 	},
			// },
			"qovery_application":          {Tok: qoveryResource(mainMod, "Application")},
			"qovery_aws_credentials":      {Tok: qoveryResource(mainMod, "AwsCredentials")},
			"qovery_cluster":              {Tok: qoveryResource(mainMod, "Cluster")},
			"qovery_container":            {Tok: qoveryResource(mainMod, "Container")},
			"qovery_container_registry":   {Tok: qoveryResource(mainMod, "ContainerRegistry")},
			"qovery_database":             {Tok: qoveryResource(mainMod, "Database")},
			"qovery_deployment":           {Tok: qoveryResource(mainMod, "Deployment")},
			"qovery_deployment_stage":     {Tok: qoveryResource(mainMod, "DeploymentStage")},
			"qovery_environment":          {Tok: qoveryResource(mainMod, "Environment")},
			"qovery_git_token":            {Tok: qoveryResource(mainMod, "GitToken")},
			"qovery_job":                  {Tok: qoveryResource(mainMod, "Job")},
			"qovery_organization":         {Tok: qoveryResource(mainMod, "Organization")},
			"qovery_project":              {Tok: qoveryResource(mainMod, "Project")},
			"qovery_scaleway_credentials": {Tok: qoveryResource(mainMod, "ScalewayCredentials")},
		},
		DataSources: map[string]*tfbridge.DataSourceInfo{
			// Map each resource in the Terraform provider to a Pulumi function. An example
			// is below.
			// "aws_ami": {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getAmi")},
			"qovery_application":          {Tok: qoveryDataSource(mainMod, "getApplication")},
			"qovery_aws_credentials":      {Tok: qoveryDataSource(mainMod, "getAwsCredentials")},
			"qovery_cluster":              {Tok: qoveryDataSource(mainMod, "getCluster")},
			"qovery_container":            {Tok: qoveryDataSource(mainMod, "getContainer")},
			"qovery_container_registry":   {Tok: qoveryDataSource(mainMod, "getContainerRegistry")},
			"qovery_database":             {Tok: qoveryDataSource(mainMod, "getDatabase")},
			"qovery_deployment":           {Tok: qoveryDataSource(mainMod, "getDeployment")},
			"qovery_deployment_stage":     {Tok: qoveryDataSource(mainMod, "getDeploymentStage")},
			"qovery_environment":          {Tok: qoveryDataSource(mainMod, "getEnvironment")},
			"qovery_git_token":            {Tok: qoveryDataSource(mainMod, "getGitToken")},
			"qovery_job":                  {Tok: qoveryDataSource(mainMod, "getJob")},
			"qovery_organization":         {Tok: qoveryDataSource(mainMod, "getOrganization")},
			"qovery_project":              {Tok: qoveryDataSource(mainMod, "getProject")},
			"qovery_scaleway_credentials": {Tok: qoveryDataSource(mainMod, "getScalewayCredentials")},
		},
		JavaScript: &tfbridge.JavaScriptInfo{
			PackageName: "@ediri/qovery",
			// List any npm dependencies and their versions
			Dependencies: map[string]string{
				"@pulumi/pulumi": "^3.0.0",
			},
			DevDependencies: map[string]string{
				"@types/node": "^10.0.0", // so we can access strongly typed node definitions.
				"@types/mime": "^2.0.0",
			},
			// See the documentation for tfbridge.OverlayInfo for how to lay out this
			// section, or refer to the AWS provider. Delete this section if there are
			// no overlay files.
			//Overlay: &tfbridge.OverlayInfo{},
		},
		Python: &tfbridge.PythonInfo{
			PackageName: "ediri_qovery",
			// List any Python dependencies and their version ranges
			Requires: map[string]string{
				"pulumi": ">=3.0.0,<4.0.0",
			},
		},
		Golang: &tfbridge.GolangInfo{
			ImportBasePath: filepath.Join(
				fmt.Sprintf("github.com/dirien/pulumi-%[1]s/sdk/", mainPkg),
				tfbridge.GetModuleMajorVersion(version.Version),
				"go",
				mainPkg,
			),
			GenerateResourceContainerTypes: true,
		},
		CSharp: &tfbridge.CSharpInfo{
			RootNamespace: "ediri",
			PackageReferences: map[string]string{
				"Pulumi": "3.*",
			},
		},
		Java: &tfbridge.JavaInfo{
			BasePackage: "io.dirien",
		},
	}

	prov.MustComputeTokens(tfbridgetokens.SingleModule("qovery_", mainMod,
		tfbridgetokens.MakeStandard(mainPkg)))

	prov.MustApplyAutoAliases()

	prov.SetAutonaming(255, "-")

	return prov
}
