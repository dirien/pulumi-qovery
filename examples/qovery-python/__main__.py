import pulumi
import ediri_qovery as qovery

config = pulumi.Config()
organization_id = config.get("organizationId")
access_key_id = config.require("accessKeyId")
secret_access_key= config.require("secretAccessKey")
if organization_id is None:
    organization_id = "e53e1c45-7449-4f44-8c59-ee0b2d3305de"
aws_credentials = qovery.AwsCredentials("awsCredentials",
    organization_id=organization_id,
    access_key_id=access_key_id,
    secret_access_key=secret_access_key)
my_cluster = qovery.Cluster("myCluster",
    organization_id=organization_id,
    name="Python Demo Cluster",
    description="Pulumi Python Demo Cluster",
    cloud_provider="AWS",
    region="eu-central-1",
    instance_type="t3a.medium",
    min_running_nodes=3,
    max_running_nodes=4,
    credentials_id=aws_credentials.id,
    state="DEPLOYED")
my_project = qovery.Project("myProject",
    organization_id=organization_id,
    name="Demo Project",
    description="Pulumi Demo Project")
prod_environment = qovery.Environment("prodEnvironment",
    name="Production",
    mode="PRODUCTION",
    project_id=my_project.id,
    cluster_id=my_cluster.id)
hello_server_demo_app = qovery.Application("helloServerDemoApp",
    name="hello-server-demo-app",
    environment_id=prod_environment.id,
    git_repository=qovery.ApplicationGitRepositoryArgs(
        url="https://github.com/dirien/hello-server.git",
        branch="main",
        root_path="/golang",
    ),
    cpu=500,
    memory=256,
    build_mode="DOCKER",
    healthchecks=qovery.ApplicationHealthchecksArgs(
        liveness_probe=qovery.ApplicationHealthchecksLivenessProbeArgs(
            type=qovery.ApplicationHealthchecksLivenessProbeTypeArgs(
                http=qovery.ApplicationHealthchecksLivenessProbeTypeHttpArgs(
                    port=8080,
                    path="/",
                ),
            ),
            initial_delay_seconds=30,
            period_seconds=10,
            timeout_seconds=10,
            success_threshold=1,
            failure_threshold=3,
        ),
    ),
    dockerfile_path="Dockerfile",
    min_running_instances=1,
    max_running_instances=1,
    ports=[qovery.ApplicationPortArgs(
        internal_port=8080,
        external_port=443,
        protocol="HTTP",
        publicly_accessible=True,
        is_default=True,
    )])
hello_server_demo_app_deployment = qovery.Deployment("helloServerDemoAppDeployment",
    environment_id=prod_environment.id,
    desired_state="RUNNING",
    opts=pulumi.ResourceOptions(depends_on=[hello_server_demo_app]))
