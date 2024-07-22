# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['DeploymentArgs', 'Deployment']

@pulumi.input_type
class DeploymentArgs:
    def __init__(__self__, *,
                 desired_state: pulumi.Input[str],
                 environment_id: pulumi.Input[str],
                 version: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a Deployment resource.
        :param pulumi.Input[str] desired_state: Desired state of the deployment. - Can be: `RESTARTED`, `RUNNING`, `STOPPED`.
        :param pulumi.Input[str] environment_id: Id of the environment.
        :param pulumi.Input[str] version: Version to force trigger a deployment when desired_state doesn't change (e.g redeploy a deployment having the 'RUNNING'
               state)
        """
        pulumi.set(__self__, "desired_state", desired_state)
        pulumi.set(__self__, "environment_id", environment_id)
        if version is not None:
            pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter(name="desiredState")
    def desired_state(self) -> pulumi.Input[str]:
        """
        Desired state of the deployment. - Can be: `RESTARTED`, `RUNNING`, `STOPPED`.
        """
        return pulumi.get(self, "desired_state")

    @desired_state.setter
    def desired_state(self, value: pulumi.Input[str]):
        pulumi.set(self, "desired_state", value)

    @property
    @pulumi.getter(name="environmentId")
    def environment_id(self) -> pulumi.Input[str]:
        """
        Id of the environment.
        """
        return pulumi.get(self, "environment_id")

    @environment_id.setter
    def environment_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "environment_id", value)

    @property
    @pulumi.getter
    def version(self) -> Optional[pulumi.Input[str]]:
        """
        Version to force trigger a deployment when desired_state doesn't change (e.g redeploy a deployment having the 'RUNNING'
        state)
        """
        return pulumi.get(self, "version")

    @version.setter
    def version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "version", value)


@pulumi.input_type
class _DeploymentState:
    def __init__(__self__, *,
                 desired_state: Optional[pulumi.Input[str]] = None,
                 environment_id: Optional[pulumi.Input[str]] = None,
                 version: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering Deployment resources.
        :param pulumi.Input[str] desired_state: Desired state of the deployment. - Can be: `RESTARTED`, `RUNNING`, `STOPPED`.
        :param pulumi.Input[str] environment_id: Id of the environment.
        :param pulumi.Input[str] version: Version to force trigger a deployment when desired_state doesn't change (e.g redeploy a deployment having the 'RUNNING'
               state)
        """
        if desired_state is not None:
            pulumi.set(__self__, "desired_state", desired_state)
        if environment_id is not None:
            pulumi.set(__self__, "environment_id", environment_id)
        if version is not None:
            pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter(name="desiredState")
    def desired_state(self) -> Optional[pulumi.Input[str]]:
        """
        Desired state of the deployment. - Can be: `RESTARTED`, `RUNNING`, `STOPPED`.
        """
        return pulumi.get(self, "desired_state")

    @desired_state.setter
    def desired_state(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "desired_state", value)

    @property
    @pulumi.getter(name="environmentId")
    def environment_id(self) -> Optional[pulumi.Input[str]]:
        """
        Id of the environment.
        """
        return pulumi.get(self, "environment_id")

    @environment_id.setter
    def environment_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "environment_id", value)

    @property
    @pulumi.getter
    def version(self) -> Optional[pulumi.Input[str]]:
        """
        Version to force trigger a deployment when desired_state doesn't change (e.g redeploy a deployment having the 'RUNNING'
        state)
        """
        return pulumi.get(self, "version")

    @version.setter
    def version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "version", value)


class Deployment(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 desired_state: Optional[pulumi.Input[str]] = None,
                 environment_id: Optional[pulumi.Input[str]] = None,
                 version: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        ## # Deployment (Resource)

        Provides a Qovery deployment resource. This is used to trigger a service deployment at demand.

        ## Example

        ```python
        import pulumi
        import ediri_qovery as qovery

        my_deployment = qovery.Deployment("myDeployment",
            environment_id=qovery_environment["my_environment"]["id"],
            desired_state="RUNNING",
            version="random_uuid_to_force_retrigger_terraform_apply",
            opts = pulumi.ResourceOptions(depends_on=[
                    qovery_application["my_application"],
                    qovery_database["my_database"],
                    qovery_container["my_container"],
                ]))
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] desired_state: Desired state of the deployment. - Can be: `RESTARTED`, `RUNNING`, `STOPPED`.
        :param pulumi.Input[str] environment_id: Id of the environment.
        :param pulumi.Input[str] version: Version to force trigger a deployment when desired_state doesn't change (e.g redeploy a deployment having the 'RUNNING'
               state)
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DeploymentArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        ## # Deployment (Resource)

        Provides a Qovery deployment resource. This is used to trigger a service deployment at demand.

        ## Example

        ```python
        import pulumi
        import ediri_qovery as qovery

        my_deployment = qovery.Deployment("myDeployment",
            environment_id=qovery_environment["my_environment"]["id"],
            desired_state="RUNNING",
            version="random_uuid_to_force_retrigger_terraform_apply",
            opts = pulumi.ResourceOptions(depends_on=[
                    qovery_application["my_application"],
                    qovery_database["my_database"],
                    qovery_container["my_container"],
                ]))
        ```

        :param str resource_name: The name of the resource.
        :param DeploymentArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DeploymentArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 desired_state: Optional[pulumi.Input[str]] = None,
                 environment_id: Optional[pulumi.Input[str]] = None,
                 version: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = DeploymentArgs.__new__(DeploymentArgs)

            if desired_state is None and not opts.urn:
                raise TypeError("Missing required property 'desired_state'")
            __props__.__dict__["desired_state"] = desired_state
            if environment_id is None and not opts.urn:
                raise TypeError("Missing required property 'environment_id'")
            __props__.__dict__["environment_id"] = environment_id
            __props__.__dict__["version"] = version
        super(Deployment, __self__).__init__(
            'qovery:index/deployment:Deployment',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            desired_state: Optional[pulumi.Input[str]] = None,
            environment_id: Optional[pulumi.Input[str]] = None,
            version: Optional[pulumi.Input[str]] = None) -> 'Deployment':
        """
        Get an existing Deployment resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] desired_state: Desired state of the deployment. - Can be: `RESTARTED`, `RUNNING`, `STOPPED`.
        :param pulumi.Input[str] environment_id: Id of the environment.
        :param pulumi.Input[str] version: Version to force trigger a deployment when desired_state doesn't change (e.g redeploy a deployment having the 'RUNNING'
               state)
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _DeploymentState.__new__(_DeploymentState)

        __props__.__dict__["desired_state"] = desired_state
        __props__.__dict__["environment_id"] = environment_id
        __props__.__dict__["version"] = version
        return Deployment(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="desiredState")
    def desired_state(self) -> pulumi.Output[str]:
        """
        Desired state of the deployment. - Can be: `RESTARTED`, `RUNNING`, `STOPPED`.
        """
        return pulumi.get(self, "desired_state")

    @property
    @pulumi.getter(name="environmentId")
    def environment_id(self) -> pulumi.Output[str]:
        """
        Id of the environment.
        """
        return pulumi.get(self, "environment_id")

    @property
    @pulumi.getter
    def version(self) -> pulumi.Output[Optional[str]]:
        """
        Version to force trigger a deployment when desired_state doesn't change (e.g redeploy a deployment having the 'RUNNING'
        state)
        """
        return pulumi.get(self, "version")

