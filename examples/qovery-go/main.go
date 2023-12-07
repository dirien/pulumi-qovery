package main

import (
	"github.com/dirien/pulumi-qovery/sdk/go/qovery"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi/config"
)

func main() {
	pulumi.Run(func(ctx *pulumi.Context) error {
		cfg := config.New(ctx, "")
		organizationId := "fff"
		if param := cfg.Get("organizationId"); param != "" {
			organizationId = param
		}
		awsCredentials, err := qovery.NewAwsCredentials(ctx, "awsCredentials", &qovery.AwsCredentialsArgs{
			OrganizationId:  pulumi.String(organizationId),
			AccessKeyId:     cfg.GetSecret("accessKeyId"),
			SecretAccessKey: cfg.GetSecret("secretAccessKey"),
		})
		if err != nil {
			return err
		}
		myCluster, err := qovery.NewCluster(ctx, "myCluster", &qovery.ClusterArgs{
			OrganizationId:  pulumi.String(organizationId),
			Name:            pulumi.String("Go Demo Cluster"),
			Description:     pulumi.String("Pulumi Go Demo Cluster"),
			CloudProvider:   pulumi.String("AWS"),
			Region:          pulumi.String("eu-central-1"),
			InstanceType:    pulumi.String("t3a.medium"),
			MinRunningNodes: pulumi.Int(3),
			MaxRunningNodes: pulumi.Int(4),
			CredentialsId:   awsCredentials.ID(),
			State:           pulumi.String("DEPLOYED"),
		})
		if err != nil {
			return err
		}
		myProject, err := qovery.NewProject(ctx, "myProject", &qovery.ProjectArgs{
			OrganizationId: pulumi.String(organizationId),
			Name:           pulumi.String("Demo Project"),
			Description:    pulumi.String("Pulumi Demo Project"),
		})
		if err != nil {
			return err
		}
		prodEnvironment, err := qovery.NewEnvironment(ctx, "prodEnvironment", &qovery.EnvironmentArgs{
			Name:      pulumi.String("Production"),
			Mode:      pulumi.String("PRODUCTION"),
			ProjectId: myProject.ID(),
			ClusterId: myCluster.ID(),
		})
		if err != nil {
			return err
		}
		helloServerDemoApp, err := qovery.NewApplication(ctx, "helloServerDemoApp", &qovery.ApplicationArgs{
			Name:          pulumi.String("hello-server-demo-app"),
			EnvironmentId: prodEnvironment.ID(),
			GitRepository: &qovery.ApplicationGitRepositoryArgs{
				Url:      pulumi.String("https://github.com/dirien/hello-server.git"),
				Branch:   pulumi.String("main"),
				RootPath: pulumi.String("/golang"),
			},
			Cpu:       pulumi.Int(500),
			Memory:    pulumi.Int(256),
			BuildMode: pulumi.String("DOCKER"),
			Healthchecks: &qovery.ApplicationHealthchecksArgs{
				LivenessProbe: &qovery.ApplicationHealthchecksLivenessProbeArgs{
					Type: &qovery.ApplicationHealthchecksLivenessProbeTypeArgs{
						Http: &qovery.ApplicationHealthchecksLivenessProbeTypeHttpArgs{
							Port: pulumi.Int(8080),
							Path: pulumi.String("/"),
						},
					},
					InitialDelaySeconds: pulumi.Int(30),
					PeriodSeconds:       pulumi.Int(10),
					TimeoutSeconds:      pulumi.Int(10),
					SuccessThreshold:    pulumi.Int(1),
					FailureThreshold:    pulumi.Int(3),
				},
			},
			DockerfilePath:      pulumi.String("Dockerfile"),
			MinRunningInstances: pulumi.Int(1),
			MaxRunningInstances: pulumi.Int(1),
			Ports: qovery.ApplicationPortArray{
				&qovery.ApplicationPortArgs{
					InternalPort:       pulumi.Int(8080),
					ExternalPort:       pulumi.Int(443),
					Protocol:           pulumi.String("HTTP"),
					PubliclyAccessible: pulumi.Bool(true),
					IsDefault:          pulumi.Bool(true),
				},
			},
		})
		if err != nil {
			return err
		}
		_, err = qovery.NewDeployment(ctx, "helloServerDemoAppDeployment", &qovery.DeploymentArgs{
			EnvironmentId: prodEnvironment.ID(),
			DesiredState:  pulumi.String("RUNNING"),
		}, pulumi.DependsOn([]pulumi.Resource{
			helloServerDemoApp,
		}))
		if err != nil {
			return err
		}
		return nil
	})
}
