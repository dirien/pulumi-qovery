import * as pulumi from "@pulumi/pulumi";
import * as qovery from "@ediri/qovery";

const config = new pulumi.Config();
const organizationId = config.get("organizationId") || "changeme";
const awsCredentials = new qovery.AwsCredentials("awsCredentials", {
    organizationId: organizationId,
    accessKeyId: config.requireSecret("accessKeyId"),
    secretAccessKey: config.requireSecret("secretAccessKey"),
});
const myCluster = new qovery.Cluster("myCluster", {
    organizationId: organizationId,
    name: "TS Demo Cluster",
    description: "Pulumi TS Demo Cluster",
    cloudProvider: "AWS",
    region: "eu-central-1",
    instanceType: "t3a.medium",
    minRunningNodes: 3,
    maxRunningNodes: 4,
    credentialsId: awsCredentials.id,
    state: "DEPLOYED",
});
const myProject = new qovery.Project("myProject", {
    organizationId: organizationId,
    name: "Demo Project",
    description: "Pulumi Demo Project",
});
const prodEnvironment = new qovery.Environment("prodEnvironment", {
    name: "Production",
    mode: "PRODUCTION",
    projectId: myProject.id,
    clusterId: myCluster.id,
});
const helloServerDemoApp = new qovery.Application("helloServerDemoApp", {
    name: "hello-server-demo-app",
    environmentId: prodEnvironment.id,
    gitRepository: {
        url: "https://github.com/dirien/hello-server.git",
        branch: "main",
        rootPath: "/golang",
    },
    cpu: 500,
    memory: 256,
    buildMode: "DOCKER",
    healthchecks: {
        livenessProbe: {
            type: {
                http: {
                    port: 8080,
                    path: "/",
                },
            },
            initialDelaySeconds: 30,
            periodSeconds: 10,
            timeoutSeconds: 10,
            successThreshold: 1,
            failureThreshold: 3,
        },
    },
    dockerfilePath: "Dockerfile",
    minRunningInstances: 1,
    maxRunningInstances: 1,
    ports: [{
        internalPort: 8080,
        externalPort: 443,
        protocol: "HTTP",
        publiclyAccessible: true,
        isDefault: true,
    }],
});
const helloServerDemoAppDeployment = new qovery.Deployment("helloServerDemoAppDeployment", {
    environmentId: prodEnvironment.id,
    desiredState: "RUNNING",
}, {
    dependsOn: [helloServerDemoApp],
});
