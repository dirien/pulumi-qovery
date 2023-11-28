# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['DatabaseArgs', 'Database']

@pulumi.input_type
class DatabaseArgs:
    def __init__(__self__, *,
                 environment_id: pulumi.Input[str],
                 mode: pulumi.Input[str],
                 type: pulumi.Input[str],
                 version: pulumi.Input[str],
                 accessibility: Optional[pulumi.Input[str]] = None,
                 cpu: Optional[pulumi.Input[int]] = None,
                 deployment_stage_id: Optional[pulumi.Input[str]] = None,
                 instance_type: Optional[pulumi.Input[str]] = None,
                 memory: Optional[pulumi.Input[int]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 storage: Optional[pulumi.Input[int]] = None):
        """
        The set of arguments for constructing a Database resource.
        :param pulumi.Input[str] environment_id: Id of the environment.
        :param pulumi.Input[str] mode: Mode of the database [NOTE: can't be updated after creation]. - Can be: `CONTAINER`, `MANAGED`.
        :param pulumi.Input[str] type: Type of the database [NOTE: can't be updated after creation]. - Can be: `MONGODB`, `MYSQL`, `POSTGRESQL`, `REDIS`.
        :param pulumi.Input[str] version: Version of the database
        :param pulumi.Input[str] accessibility: Accessibility of the database. - Can be: `PRIVATE`, `PUBLIC`. - Default: `PUBLIC`.
        :param pulumi.Input[int] cpu: CPU of the database in millicores (m) [1000m = 1 CPU]. - Must be: `>= 250`. - Default: `250`.
        :param pulumi.Input[str] deployment_stage_id: Id of the deployment stage.
        :param pulumi.Input[str] instance_type: Instance type of the database.
        :param pulumi.Input[int] memory: RAM of the database in MB [1024MB = 1GB]. - Must be: `>= 100`. - Default: `256`.
        :param pulumi.Input[str] name: Name of the database.
        :param pulumi.Input[int] storage: Storage of the database in GB [1024MB = 1GB] [NOTE: can't be updated after creation]. - Must be: `>= 10`. - Default:
               `10`.
        """
        pulumi.set(__self__, "environment_id", environment_id)
        pulumi.set(__self__, "mode", mode)
        pulumi.set(__self__, "type", type)
        pulumi.set(__self__, "version", version)
        if accessibility is not None:
            pulumi.set(__self__, "accessibility", accessibility)
        if cpu is not None:
            pulumi.set(__self__, "cpu", cpu)
        if deployment_stage_id is not None:
            pulumi.set(__self__, "deployment_stage_id", deployment_stage_id)
        if instance_type is not None:
            pulumi.set(__self__, "instance_type", instance_type)
        if memory is not None:
            pulumi.set(__self__, "memory", memory)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if storage is not None:
            pulumi.set(__self__, "storage", storage)

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
    def mode(self) -> pulumi.Input[str]:
        """
        Mode of the database [NOTE: can't be updated after creation]. - Can be: `CONTAINER`, `MANAGED`.
        """
        return pulumi.get(self, "mode")

    @mode.setter
    def mode(self, value: pulumi.Input[str]):
        pulumi.set(self, "mode", value)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[str]:
        """
        Type of the database [NOTE: can't be updated after creation]. - Can be: `MONGODB`, `MYSQL`, `POSTGRESQL`, `REDIS`.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[str]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter
    def version(self) -> pulumi.Input[str]:
        """
        Version of the database
        """
        return pulumi.get(self, "version")

    @version.setter
    def version(self, value: pulumi.Input[str]):
        pulumi.set(self, "version", value)

    @property
    @pulumi.getter
    def accessibility(self) -> Optional[pulumi.Input[str]]:
        """
        Accessibility of the database. - Can be: `PRIVATE`, `PUBLIC`. - Default: `PUBLIC`.
        """
        return pulumi.get(self, "accessibility")

    @accessibility.setter
    def accessibility(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "accessibility", value)

    @property
    @pulumi.getter
    def cpu(self) -> Optional[pulumi.Input[int]]:
        """
        CPU of the database in millicores (m) [1000m = 1 CPU]. - Must be: `>= 250`. - Default: `250`.
        """
        return pulumi.get(self, "cpu")

    @cpu.setter
    def cpu(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "cpu", value)

    @property
    @pulumi.getter(name="deploymentStageId")
    def deployment_stage_id(self) -> Optional[pulumi.Input[str]]:
        """
        Id of the deployment stage.
        """
        return pulumi.get(self, "deployment_stage_id")

    @deployment_stage_id.setter
    def deployment_stage_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "deployment_stage_id", value)

    @property
    @pulumi.getter(name="instanceType")
    def instance_type(self) -> Optional[pulumi.Input[str]]:
        """
        Instance type of the database.
        """
        return pulumi.get(self, "instance_type")

    @instance_type.setter
    def instance_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_type", value)

    @property
    @pulumi.getter
    def memory(self) -> Optional[pulumi.Input[int]]:
        """
        RAM of the database in MB [1024MB = 1GB]. - Must be: `>= 100`. - Default: `256`.
        """
        return pulumi.get(self, "memory")

    @memory.setter
    def memory(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "memory", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the database.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def storage(self) -> Optional[pulumi.Input[int]]:
        """
        Storage of the database in GB [1024MB = 1GB] [NOTE: can't be updated after creation]. - Must be: `>= 10`. - Default:
        `10`.
        """
        return pulumi.get(self, "storage")

    @storage.setter
    def storage(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "storage", value)


@pulumi.input_type
class _DatabaseState:
    def __init__(__self__, *,
                 accessibility: Optional[pulumi.Input[str]] = None,
                 cpu: Optional[pulumi.Input[int]] = None,
                 deployment_stage_id: Optional[pulumi.Input[str]] = None,
                 environment_id: Optional[pulumi.Input[str]] = None,
                 external_host: Optional[pulumi.Input[str]] = None,
                 instance_type: Optional[pulumi.Input[str]] = None,
                 internal_host: Optional[pulumi.Input[str]] = None,
                 login: Optional[pulumi.Input[str]] = None,
                 memory: Optional[pulumi.Input[int]] = None,
                 mode: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 password: Optional[pulumi.Input[str]] = None,
                 port: Optional[pulumi.Input[int]] = None,
                 storage: Optional[pulumi.Input[int]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 version: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering Database resources.
        :param pulumi.Input[str] accessibility: Accessibility of the database. - Can be: `PRIVATE`, `PUBLIC`. - Default: `PUBLIC`.
        :param pulumi.Input[int] cpu: CPU of the database in millicores (m) [1000m = 1 CPU]. - Must be: `>= 250`. - Default: `250`.
        :param pulumi.Input[str] deployment_stage_id: Id of the deployment stage.
        :param pulumi.Input[str] environment_id: Id of the environment.
        :param pulumi.Input[str] external_host: The database external FQDN host [NOTE: only if your container is using a publicly accessible port].
        :param pulumi.Input[str] instance_type: Instance type of the database.
        :param pulumi.Input[str] internal_host: The database internal host (Recommended for your application)
        :param pulumi.Input[str] login: The login to connect to your database
        :param pulumi.Input[int] memory: RAM of the database in MB [1024MB = 1GB]. - Must be: `>= 100`. - Default: `256`.
        :param pulumi.Input[str] mode: Mode of the database [NOTE: can't be updated after creation]. - Can be: `CONTAINER`, `MANAGED`.
        :param pulumi.Input[str] name: Name of the database.
        :param pulumi.Input[str] password: The password to connect to your database
        :param pulumi.Input[int] port: The port to connect to your database
        :param pulumi.Input[int] storage: Storage of the database in GB [1024MB = 1GB] [NOTE: can't be updated after creation]. - Must be: `>= 10`. - Default:
               `10`.
        :param pulumi.Input[str] type: Type of the database [NOTE: can't be updated after creation]. - Can be: `MONGODB`, `MYSQL`, `POSTGRESQL`, `REDIS`.
        :param pulumi.Input[str] version: Version of the database
        """
        if accessibility is not None:
            pulumi.set(__self__, "accessibility", accessibility)
        if cpu is not None:
            pulumi.set(__self__, "cpu", cpu)
        if deployment_stage_id is not None:
            pulumi.set(__self__, "deployment_stage_id", deployment_stage_id)
        if environment_id is not None:
            pulumi.set(__self__, "environment_id", environment_id)
        if external_host is not None:
            pulumi.set(__self__, "external_host", external_host)
        if instance_type is not None:
            pulumi.set(__self__, "instance_type", instance_type)
        if internal_host is not None:
            pulumi.set(__self__, "internal_host", internal_host)
        if login is not None:
            pulumi.set(__self__, "login", login)
        if memory is not None:
            pulumi.set(__self__, "memory", memory)
        if mode is not None:
            pulumi.set(__self__, "mode", mode)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if password is not None:
            pulumi.set(__self__, "password", password)
        if port is not None:
            pulumi.set(__self__, "port", port)
        if storage is not None:
            pulumi.set(__self__, "storage", storage)
        if type is not None:
            pulumi.set(__self__, "type", type)
        if version is not None:
            pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter
    def accessibility(self) -> Optional[pulumi.Input[str]]:
        """
        Accessibility of the database. - Can be: `PRIVATE`, `PUBLIC`. - Default: `PUBLIC`.
        """
        return pulumi.get(self, "accessibility")

    @accessibility.setter
    def accessibility(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "accessibility", value)

    @property
    @pulumi.getter
    def cpu(self) -> Optional[pulumi.Input[int]]:
        """
        CPU of the database in millicores (m) [1000m = 1 CPU]. - Must be: `>= 250`. - Default: `250`.
        """
        return pulumi.get(self, "cpu")

    @cpu.setter
    def cpu(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "cpu", value)

    @property
    @pulumi.getter(name="deploymentStageId")
    def deployment_stage_id(self) -> Optional[pulumi.Input[str]]:
        """
        Id of the deployment stage.
        """
        return pulumi.get(self, "deployment_stage_id")

    @deployment_stage_id.setter
    def deployment_stage_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "deployment_stage_id", value)

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
    @pulumi.getter(name="externalHost")
    def external_host(self) -> Optional[pulumi.Input[str]]:
        """
        The database external FQDN host [NOTE: only if your container is using a publicly accessible port].
        """
        return pulumi.get(self, "external_host")

    @external_host.setter
    def external_host(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "external_host", value)

    @property
    @pulumi.getter(name="instanceType")
    def instance_type(self) -> Optional[pulumi.Input[str]]:
        """
        Instance type of the database.
        """
        return pulumi.get(self, "instance_type")

    @instance_type.setter
    def instance_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_type", value)

    @property
    @pulumi.getter(name="internalHost")
    def internal_host(self) -> Optional[pulumi.Input[str]]:
        """
        The database internal host (Recommended for your application)
        """
        return pulumi.get(self, "internal_host")

    @internal_host.setter
    def internal_host(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "internal_host", value)

    @property
    @pulumi.getter
    def login(self) -> Optional[pulumi.Input[str]]:
        """
        The login to connect to your database
        """
        return pulumi.get(self, "login")

    @login.setter
    def login(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "login", value)

    @property
    @pulumi.getter
    def memory(self) -> Optional[pulumi.Input[int]]:
        """
        RAM of the database in MB [1024MB = 1GB]. - Must be: `>= 100`. - Default: `256`.
        """
        return pulumi.get(self, "memory")

    @memory.setter
    def memory(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "memory", value)

    @property
    @pulumi.getter
    def mode(self) -> Optional[pulumi.Input[str]]:
        """
        Mode of the database [NOTE: can't be updated after creation]. - Can be: `CONTAINER`, `MANAGED`.
        """
        return pulumi.get(self, "mode")

    @mode.setter
    def mode(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "mode", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the database.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def password(self) -> Optional[pulumi.Input[str]]:
        """
        The password to connect to your database
        """
        return pulumi.get(self, "password")

    @password.setter
    def password(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "password", value)

    @property
    @pulumi.getter
    def port(self) -> Optional[pulumi.Input[int]]:
        """
        The port to connect to your database
        """
        return pulumi.get(self, "port")

    @port.setter
    def port(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "port", value)

    @property
    @pulumi.getter
    def storage(self) -> Optional[pulumi.Input[int]]:
        """
        Storage of the database in GB [1024MB = 1GB] [NOTE: can't be updated after creation]. - Must be: `>= 10`. - Default:
        `10`.
        """
        return pulumi.get(self, "storage")

    @storage.setter
    def storage(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "storage", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[str]]:
        """
        Type of the database [NOTE: can't be updated after creation]. - Can be: `MONGODB`, `MYSQL`, `POSTGRESQL`, `REDIS`.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter
    def version(self) -> Optional[pulumi.Input[str]]:
        """
        Version of the database
        """
        return pulumi.get(self, "version")

    @version.setter
    def version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "version", value)


class Database(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 accessibility: Optional[pulumi.Input[str]] = None,
                 cpu: Optional[pulumi.Input[int]] = None,
                 deployment_stage_id: Optional[pulumi.Input[str]] = None,
                 environment_id: Optional[pulumi.Input[str]] = None,
                 instance_type: Optional[pulumi.Input[str]] = None,
                 memory: Optional[pulumi.Input[int]] = None,
                 mode: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 storage: Optional[pulumi.Input[int]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 version: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        ## # Database (Resource)

        Provides a Qovery database resource. This can be used to create and manage Qovery databases.

        ## Example

        ```python
        import pulumi
        import ediri_qovery as qovery

        my_container_database = qovery.Database("myContainerDatabase",
            environment_id=qovery_environment["my_environment"]["id"],
            type="POSTGRESQL",
            version="10",
            mode="CONTAINER",
            accessibility="PRIVATE",
            cpu=250,
            memory=256,
            storage=10,
            opts=pulumi.ResourceOptions(depends_on=[qovery_environment["my_environment"]]))
        my_managed_database = qovery.Database("myManagedDatabase",
            environment_id=qovery_environment["my_environment"]["id"],
            type="POSTGRESQL",
            version="10",
            mode="MANAGED",
            instance_type="db.t3.micro",
            accessibility="PRIVATE",
            storage=10,
            opts=pulumi.ResourceOptions(depends_on=[qovery_environment["my_environment"]]))
        ```

        ## Import

        ```sh
         $ pulumi import qovery:index/database:Database my_database "<database_id>"
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] accessibility: Accessibility of the database. - Can be: `PRIVATE`, `PUBLIC`. - Default: `PUBLIC`.
        :param pulumi.Input[int] cpu: CPU of the database in millicores (m) [1000m = 1 CPU]. - Must be: `>= 250`. - Default: `250`.
        :param pulumi.Input[str] deployment_stage_id: Id of the deployment stage.
        :param pulumi.Input[str] environment_id: Id of the environment.
        :param pulumi.Input[str] instance_type: Instance type of the database.
        :param pulumi.Input[int] memory: RAM of the database in MB [1024MB = 1GB]. - Must be: `>= 100`. - Default: `256`.
        :param pulumi.Input[str] mode: Mode of the database [NOTE: can't be updated after creation]. - Can be: `CONTAINER`, `MANAGED`.
        :param pulumi.Input[str] name: Name of the database.
        :param pulumi.Input[int] storage: Storage of the database in GB [1024MB = 1GB] [NOTE: can't be updated after creation]. - Must be: `>= 10`. - Default:
               `10`.
        :param pulumi.Input[str] type: Type of the database [NOTE: can't be updated after creation]. - Can be: `MONGODB`, `MYSQL`, `POSTGRESQL`, `REDIS`.
        :param pulumi.Input[str] version: Version of the database
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DatabaseArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        ## # Database (Resource)

        Provides a Qovery database resource. This can be used to create and manage Qovery databases.

        ## Example

        ```python
        import pulumi
        import ediri_qovery as qovery

        my_container_database = qovery.Database("myContainerDatabase",
            environment_id=qovery_environment["my_environment"]["id"],
            type="POSTGRESQL",
            version="10",
            mode="CONTAINER",
            accessibility="PRIVATE",
            cpu=250,
            memory=256,
            storage=10,
            opts=pulumi.ResourceOptions(depends_on=[qovery_environment["my_environment"]]))
        my_managed_database = qovery.Database("myManagedDatabase",
            environment_id=qovery_environment["my_environment"]["id"],
            type="POSTGRESQL",
            version="10",
            mode="MANAGED",
            instance_type="db.t3.micro",
            accessibility="PRIVATE",
            storage=10,
            opts=pulumi.ResourceOptions(depends_on=[qovery_environment["my_environment"]]))
        ```

        ## Import

        ```sh
         $ pulumi import qovery:index/database:Database my_database "<database_id>"
        ```

        :param str resource_name: The name of the resource.
        :param DatabaseArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DatabaseArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 accessibility: Optional[pulumi.Input[str]] = None,
                 cpu: Optional[pulumi.Input[int]] = None,
                 deployment_stage_id: Optional[pulumi.Input[str]] = None,
                 environment_id: Optional[pulumi.Input[str]] = None,
                 instance_type: Optional[pulumi.Input[str]] = None,
                 memory: Optional[pulumi.Input[int]] = None,
                 mode: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 storage: Optional[pulumi.Input[int]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 version: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = DatabaseArgs.__new__(DatabaseArgs)

            __props__.__dict__["accessibility"] = accessibility
            __props__.__dict__["cpu"] = cpu
            __props__.__dict__["deployment_stage_id"] = deployment_stage_id
            if environment_id is None and not opts.urn:
                raise TypeError("Missing required property 'environment_id'")
            __props__.__dict__["environment_id"] = environment_id
            __props__.__dict__["instance_type"] = instance_type
            __props__.__dict__["memory"] = memory
            if mode is None and not opts.urn:
                raise TypeError("Missing required property 'mode'")
            __props__.__dict__["mode"] = mode
            __props__.__dict__["name"] = name
            __props__.__dict__["storage"] = storage
            if type is None and not opts.urn:
                raise TypeError("Missing required property 'type'")
            __props__.__dict__["type"] = type
            if version is None and not opts.urn:
                raise TypeError("Missing required property 'version'")
            __props__.__dict__["version"] = version
            __props__.__dict__["external_host"] = None
            __props__.__dict__["internal_host"] = None
            __props__.__dict__["login"] = None
            __props__.__dict__["password"] = None
            __props__.__dict__["port"] = None
        super(Database, __self__).__init__(
            'qovery:index/database:Database',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            accessibility: Optional[pulumi.Input[str]] = None,
            cpu: Optional[pulumi.Input[int]] = None,
            deployment_stage_id: Optional[pulumi.Input[str]] = None,
            environment_id: Optional[pulumi.Input[str]] = None,
            external_host: Optional[pulumi.Input[str]] = None,
            instance_type: Optional[pulumi.Input[str]] = None,
            internal_host: Optional[pulumi.Input[str]] = None,
            login: Optional[pulumi.Input[str]] = None,
            memory: Optional[pulumi.Input[int]] = None,
            mode: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            password: Optional[pulumi.Input[str]] = None,
            port: Optional[pulumi.Input[int]] = None,
            storage: Optional[pulumi.Input[int]] = None,
            type: Optional[pulumi.Input[str]] = None,
            version: Optional[pulumi.Input[str]] = None) -> 'Database':
        """
        Get an existing Database resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] accessibility: Accessibility of the database. - Can be: `PRIVATE`, `PUBLIC`. - Default: `PUBLIC`.
        :param pulumi.Input[int] cpu: CPU of the database in millicores (m) [1000m = 1 CPU]. - Must be: `>= 250`. - Default: `250`.
        :param pulumi.Input[str] deployment_stage_id: Id of the deployment stage.
        :param pulumi.Input[str] environment_id: Id of the environment.
        :param pulumi.Input[str] external_host: The database external FQDN host [NOTE: only if your container is using a publicly accessible port].
        :param pulumi.Input[str] instance_type: Instance type of the database.
        :param pulumi.Input[str] internal_host: The database internal host (Recommended for your application)
        :param pulumi.Input[str] login: The login to connect to your database
        :param pulumi.Input[int] memory: RAM of the database in MB [1024MB = 1GB]. - Must be: `>= 100`. - Default: `256`.
        :param pulumi.Input[str] mode: Mode of the database [NOTE: can't be updated after creation]. - Can be: `CONTAINER`, `MANAGED`.
        :param pulumi.Input[str] name: Name of the database.
        :param pulumi.Input[str] password: The password to connect to your database
        :param pulumi.Input[int] port: The port to connect to your database
        :param pulumi.Input[int] storage: Storage of the database in GB [1024MB = 1GB] [NOTE: can't be updated after creation]. - Must be: `>= 10`. - Default:
               `10`.
        :param pulumi.Input[str] type: Type of the database [NOTE: can't be updated after creation]. - Can be: `MONGODB`, `MYSQL`, `POSTGRESQL`, `REDIS`.
        :param pulumi.Input[str] version: Version of the database
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _DatabaseState.__new__(_DatabaseState)

        __props__.__dict__["accessibility"] = accessibility
        __props__.__dict__["cpu"] = cpu
        __props__.__dict__["deployment_stage_id"] = deployment_stage_id
        __props__.__dict__["environment_id"] = environment_id
        __props__.__dict__["external_host"] = external_host
        __props__.__dict__["instance_type"] = instance_type
        __props__.__dict__["internal_host"] = internal_host
        __props__.__dict__["login"] = login
        __props__.__dict__["memory"] = memory
        __props__.__dict__["mode"] = mode
        __props__.__dict__["name"] = name
        __props__.__dict__["password"] = password
        __props__.__dict__["port"] = port
        __props__.__dict__["storage"] = storage
        __props__.__dict__["type"] = type
        __props__.__dict__["version"] = version
        return Database(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def accessibility(self) -> pulumi.Output[str]:
        """
        Accessibility of the database. - Can be: `PRIVATE`, `PUBLIC`. - Default: `PUBLIC`.
        """
        return pulumi.get(self, "accessibility")

    @property
    @pulumi.getter
    def cpu(self) -> pulumi.Output[int]:
        """
        CPU of the database in millicores (m) [1000m = 1 CPU]. - Must be: `>= 250`. - Default: `250`.
        """
        return pulumi.get(self, "cpu")

    @property
    @pulumi.getter(name="deploymentStageId")
    def deployment_stage_id(self) -> pulumi.Output[str]:
        """
        Id of the deployment stage.
        """
        return pulumi.get(self, "deployment_stage_id")

    @property
    @pulumi.getter(name="environmentId")
    def environment_id(self) -> pulumi.Output[str]:
        """
        Id of the environment.
        """
        return pulumi.get(self, "environment_id")

    @property
    @pulumi.getter(name="externalHost")
    def external_host(self) -> pulumi.Output[str]:
        """
        The database external FQDN host [NOTE: only if your container is using a publicly accessible port].
        """
        return pulumi.get(self, "external_host")

    @property
    @pulumi.getter(name="instanceType")
    def instance_type(self) -> pulumi.Output[str]:
        """
        Instance type of the database.
        """
        return pulumi.get(self, "instance_type")

    @property
    @pulumi.getter(name="internalHost")
    def internal_host(self) -> pulumi.Output[str]:
        """
        The database internal host (Recommended for your application)
        """
        return pulumi.get(self, "internal_host")

    @property
    @pulumi.getter
    def login(self) -> pulumi.Output[str]:
        """
        The login to connect to your database
        """
        return pulumi.get(self, "login")

    @property
    @pulumi.getter
    def memory(self) -> pulumi.Output[int]:
        """
        RAM of the database in MB [1024MB = 1GB]. - Must be: `>= 100`. - Default: `256`.
        """
        return pulumi.get(self, "memory")

    @property
    @pulumi.getter
    def mode(self) -> pulumi.Output[str]:
        """
        Mode of the database [NOTE: can't be updated after creation]. - Can be: `CONTAINER`, `MANAGED`.
        """
        return pulumi.get(self, "mode")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Name of the database.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def password(self) -> pulumi.Output[str]:
        """
        The password to connect to your database
        """
        return pulumi.get(self, "password")

    @property
    @pulumi.getter
    def port(self) -> pulumi.Output[int]:
        """
        The port to connect to your database
        """
        return pulumi.get(self, "port")

    @property
    @pulumi.getter
    def storage(self) -> pulumi.Output[int]:
        """
        Storage of the database in GB [1024MB = 1GB] [NOTE: can't be updated after creation]. - Must be: `>= 10`. - Default:
        `10`.
        """
        return pulumi.get(self, "storage")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Type of the database [NOTE: can't be updated after creation]. - Can be: `MONGODB`, `MYSQL`, `POSTGRESQL`, `REDIS`.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def version(self) -> pulumi.Output[str]:
        """
        Version of the database
        """
        return pulumi.get(self, "version")

