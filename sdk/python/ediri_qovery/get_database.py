# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = [
    'GetDatabaseResult',
    'AwaitableGetDatabaseResult',
    'get_database',
    'get_database_output',
]

@pulumi.output_type
class GetDatabaseResult:
    """
    A collection of values returned by getDatabase.
    """
    def __init__(__self__, accessibility=None, cpu=None, deployment_stage_id=None, environment_id=None, external_host=None, id=None, instance_type=None, internal_host=None, login=None, memory=None, mode=None, name=None, password=None, port=None, storage=None, type=None, version=None):
        if accessibility and not isinstance(accessibility, str):
            raise TypeError("Expected argument 'accessibility' to be a str")
        pulumi.set(__self__, "accessibility", accessibility)
        if cpu and not isinstance(cpu, int):
            raise TypeError("Expected argument 'cpu' to be a int")
        pulumi.set(__self__, "cpu", cpu)
        if deployment_stage_id and not isinstance(deployment_stage_id, str):
            raise TypeError("Expected argument 'deployment_stage_id' to be a str")
        pulumi.set(__self__, "deployment_stage_id", deployment_stage_id)
        if environment_id and not isinstance(environment_id, str):
            raise TypeError("Expected argument 'environment_id' to be a str")
        pulumi.set(__self__, "environment_id", environment_id)
        if external_host and not isinstance(external_host, str):
            raise TypeError("Expected argument 'external_host' to be a str")
        pulumi.set(__self__, "external_host", external_host)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if instance_type and not isinstance(instance_type, str):
            raise TypeError("Expected argument 'instance_type' to be a str")
        pulumi.set(__self__, "instance_type", instance_type)
        if internal_host and not isinstance(internal_host, str):
            raise TypeError("Expected argument 'internal_host' to be a str")
        pulumi.set(__self__, "internal_host", internal_host)
        if login and not isinstance(login, str):
            raise TypeError("Expected argument 'login' to be a str")
        pulumi.set(__self__, "login", login)
        if memory and not isinstance(memory, int):
            raise TypeError("Expected argument 'memory' to be a int")
        pulumi.set(__self__, "memory", memory)
        if mode and not isinstance(mode, str):
            raise TypeError("Expected argument 'mode' to be a str")
        pulumi.set(__self__, "mode", mode)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if password and not isinstance(password, str):
            raise TypeError("Expected argument 'password' to be a str")
        pulumi.set(__self__, "password", password)
        if port and not isinstance(port, int):
            raise TypeError("Expected argument 'port' to be a int")
        pulumi.set(__self__, "port", port)
        if storage and not isinstance(storage, int):
            raise TypeError("Expected argument 'storage' to be a int")
        pulumi.set(__self__, "storage", storage)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if version and not isinstance(version, str):
            raise TypeError("Expected argument 'version' to be a str")
        pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter
    def accessibility(self) -> Optional[str]:
        return pulumi.get(self, "accessibility")

    @property
    @pulumi.getter
    def cpu(self) -> Optional[int]:
        return pulumi.get(self, "cpu")

    @property
    @pulumi.getter(name="deploymentStageId")
    def deployment_stage_id(self) -> str:
        return pulumi.get(self, "deployment_stage_id")

    @property
    @pulumi.getter(name="environmentId")
    def environment_id(self) -> str:
        return pulumi.get(self, "environment_id")

    @property
    @pulumi.getter(name="externalHost")
    def external_host(self) -> str:
        return pulumi.get(self, "external_host")

    @property
    @pulumi.getter
    def id(self) -> str:
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="instanceType")
    def instance_type(self) -> str:
        return pulumi.get(self, "instance_type")

    @property
    @pulumi.getter(name="internalHost")
    def internal_host(self) -> str:
        return pulumi.get(self, "internal_host")

    @property
    @pulumi.getter
    def login(self) -> str:
        return pulumi.get(self, "login")

    @property
    @pulumi.getter
    def memory(self) -> Optional[int]:
        return pulumi.get(self, "memory")

    @property
    @pulumi.getter
    def mode(self) -> str:
        return pulumi.get(self, "mode")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def password(self) -> str:
        return pulumi.get(self, "password")

    @property
    @pulumi.getter
    def port(self) -> int:
        return pulumi.get(self, "port")

    @property
    @pulumi.getter
    def storage(self) -> Optional[int]:
        return pulumi.get(self, "storage")

    @property
    @pulumi.getter
    def type(self) -> str:
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def version(self) -> str:
        return pulumi.get(self, "version")


class AwaitableGetDatabaseResult(GetDatabaseResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetDatabaseResult(
            accessibility=self.accessibility,
            cpu=self.cpu,
            deployment_stage_id=self.deployment_stage_id,
            environment_id=self.environment_id,
            external_host=self.external_host,
            id=self.id,
            instance_type=self.instance_type,
            internal_host=self.internal_host,
            login=self.login,
            memory=self.memory,
            mode=self.mode,
            name=self.name,
            password=self.password,
            port=self.port,
            storage=self.storage,
            type=self.type,
            version=self.version)


def get_database(accessibility: Optional[str] = None,
                 cpu: Optional[int] = None,
                 deployment_stage_id: Optional[str] = None,
                 id: Optional[str] = None,
                 instance_type: Optional[str] = None,
                 memory: Optional[int] = None,
                 storage: Optional[int] = None,
                 opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetDatabaseResult:
    """
    ## # Database (Data Source)

    Provides a Qovery database resource. This can be used to create and manage Qovery databases.
    ## Example Usage

    ```python
    import pulumi
    import pulumi_qovery as qovery

    my_database = qovery.get_database(id="<database_id>")
    ```
    """
    __args__ = dict()
    __args__['accessibility'] = accessibility
    __args__['cpu'] = cpu
    __args__['deploymentStageId'] = deployment_stage_id
    __args__['id'] = id
    __args__['instanceType'] = instance_type
    __args__['memory'] = memory
    __args__['storage'] = storage
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('qovery:index/getDatabase:getDatabase', __args__, opts=opts, typ=GetDatabaseResult).value

    return AwaitableGetDatabaseResult(
        accessibility=pulumi.get(__ret__, 'accessibility'),
        cpu=pulumi.get(__ret__, 'cpu'),
        deployment_stage_id=pulumi.get(__ret__, 'deployment_stage_id'),
        environment_id=pulumi.get(__ret__, 'environment_id'),
        external_host=pulumi.get(__ret__, 'external_host'),
        id=pulumi.get(__ret__, 'id'),
        instance_type=pulumi.get(__ret__, 'instance_type'),
        internal_host=pulumi.get(__ret__, 'internal_host'),
        login=pulumi.get(__ret__, 'login'),
        memory=pulumi.get(__ret__, 'memory'),
        mode=pulumi.get(__ret__, 'mode'),
        name=pulumi.get(__ret__, 'name'),
        password=pulumi.get(__ret__, 'password'),
        port=pulumi.get(__ret__, 'port'),
        storage=pulumi.get(__ret__, 'storage'),
        type=pulumi.get(__ret__, 'type'),
        version=pulumi.get(__ret__, 'version'))


@_utilities.lift_output_func(get_database)
def get_database_output(accessibility: Optional[pulumi.Input[Optional[str]]] = None,
                        cpu: Optional[pulumi.Input[Optional[int]]] = None,
                        deployment_stage_id: Optional[pulumi.Input[Optional[str]]] = None,
                        id: Optional[pulumi.Input[str]] = None,
                        instance_type: Optional[pulumi.Input[Optional[str]]] = None,
                        memory: Optional[pulumi.Input[Optional[int]]] = None,
                        storage: Optional[pulumi.Input[Optional[int]]] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetDatabaseResult]:
    """
    ## # Database (Data Source)

    Provides a Qovery database resource. This can be used to create and manage Qovery databases.
    ## Example Usage

    ```python
    import pulumi
    import pulumi_qovery as qovery

    my_database = qovery.get_database(id="<database_id>")
    ```
    """
    ...
