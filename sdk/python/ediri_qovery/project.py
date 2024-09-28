# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities
from . import outputs
from ._inputs import *

__all__ = ['ProjectArgs', 'Project']

@pulumi.input_type
class ProjectArgs:
    def __init__(__self__, *,
                 organization_id: pulumi.Input[str],
                 description: Optional[pulumi.Input[str]] = None,
                 environment_variable_aliases: Optional[pulumi.Input[Sequence[pulumi.Input['ProjectEnvironmentVariableAliasArgs']]]] = None,
                 environment_variables: Optional[pulumi.Input[Sequence[pulumi.Input['ProjectEnvironmentVariableArgs']]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 secret_aliases: Optional[pulumi.Input[Sequence[pulumi.Input['ProjectSecretAliasArgs']]]] = None,
                 secrets: Optional[pulumi.Input[Sequence[pulumi.Input['ProjectSecretArgs']]]] = None):
        """
        The set of arguments for constructing a Project resource.
        :param pulumi.Input[str] organization_id: Id of the organization.
        :param pulumi.Input[str] description: Description of the project.
        :param pulumi.Input[Sequence[pulumi.Input['ProjectEnvironmentVariableAliasArgs']]] environment_variable_aliases: List of environment variable aliases linked to this project.
        :param pulumi.Input[Sequence[pulumi.Input['ProjectEnvironmentVariableArgs']]] environment_variables: List of environment variables linked to this project.
        :param pulumi.Input[str] name: Name of the project.
        :param pulumi.Input[Sequence[pulumi.Input['ProjectSecretAliasArgs']]] secret_aliases: List of secret aliases linked to this project.
        :param pulumi.Input[Sequence[pulumi.Input['ProjectSecretArgs']]] secrets: List of secrets linked to this project.
        """
        pulumi.set(__self__, "organization_id", organization_id)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if environment_variable_aliases is not None:
            pulumi.set(__self__, "environment_variable_aliases", environment_variable_aliases)
        if environment_variables is not None:
            pulumi.set(__self__, "environment_variables", environment_variables)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if secret_aliases is not None:
            pulumi.set(__self__, "secret_aliases", secret_aliases)
        if secrets is not None:
            pulumi.set(__self__, "secrets", secrets)

    @property
    @pulumi.getter(name="organizationId")
    def organization_id(self) -> pulumi.Input[str]:
        """
        Id of the organization.
        """
        return pulumi.get(self, "organization_id")

    @organization_id.setter
    def organization_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "organization_id", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description of the project.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="environmentVariableAliases")
    def environment_variable_aliases(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ProjectEnvironmentVariableAliasArgs']]]]:
        """
        List of environment variable aliases linked to this project.
        """
        return pulumi.get(self, "environment_variable_aliases")

    @environment_variable_aliases.setter
    def environment_variable_aliases(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ProjectEnvironmentVariableAliasArgs']]]]):
        pulumi.set(self, "environment_variable_aliases", value)

    @property
    @pulumi.getter(name="environmentVariables")
    def environment_variables(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ProjectEnvironmentVariableArgs']]]]:
        """
        List of environment variables linked to this project.
        """
        return pulumi.get(self, "environment_variables")

    @environment_variables.setter
    def environment_variables(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ProjectEnvironmentVariableArgs']]]]):
        pulumi.set(self, "environment_variables", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the project.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="secretAliases")
    def secret_aliases(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ProjectSecretAliasArgs']]]]:
        """
        List of secret aliases linked to this project.
        """
        return pulumi.get(self, "secret_aliases")

    @secret_aliases.setter
    def secret_aliases(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ProjectSecretAliasArgs']]]]):
        pulumi.set(self, "secret_aliases", value)

    @property
    @pulumi.getter
    def secrets(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ProjectSecretArgs']]]]:
        """
        List of secrets linked to this project.
        """
        return pulumi.get(self, "secrets")

    @secrets.setter
    def secrets(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ProjectSecretArgs']]]]):
        pulumi.set(self, "secrets", value)


@pulumi.input_type
class _ProjectState:
    def __init__(__self__, *,
                 built_in_environment_variables: Optional[pulumi.Input[Sequence[pulumi.Input['ProjectBuiltInEnvironmentVariableArgs']]]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 environment_variable_aliases: Optional[pulumi.Input[Sequence[pulumi.Input['ProjectEnvironmentVariableAliasArgs']]]] = None,
                 environment_variables: Optional[pulumi.Input[Sequence[pulumi.Input['ProjectEnvironmentVariableArgs']]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 organization_id: Optional[pulumi.Input[str]] = None,
                 secret_aliases: Optional[pulumi.Input[Sequence[pulumi.Input['ProjectSecretAliasArgs']]]] = None,
                 secrets: Optional[pulumi.Input[Sequence[pulumi.Input['ProjectSecretArgs']]]] = None):
        """
        Input properties used for looking up and filtering Project resources.
        :param pulumi.Input[Sequence[pulumi.Input['ProjectBuiltInEnvironmentVariableArgs']]] built_in_environment_variables: List of built-in environment variables linked to this project.
        :param pulumi.Input[str] description: Description of the project.
        :param pulumi.Input[Sequence[pulumi.Input['ProjectEnvironmentVariableAliasArgs']]] environment_variable_aliases: List of environment variable aliases linked to this project.
        :param pulumi.Input[Sequence[pulumi.Input['ProjectEnvironmentVariableArgs']]] environment_variables: List of environment variables linked to this project.
        :param pulumi.Input[str] name: Name of the project.
        :param pulumi.Input[str] organization_id: Id of the organization.
        :param pulumi.Input[Sequence[pulumi.Input['ProjectSecretAliasArgs']]] secret_aliases: List of secret aliases linked to this project.
        :param pulumi.Input[Sequence[pulumi.Input['ProjectSecretArgs']]] secrets: List of secrets linked to this project.
        """
        if built_in_environment_variables is not None:
            pulumi.set(__self__, "built_in_environment_variables", built_in_environment_variables)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if environment_variable_aliases is not None:
            pulumi.set(__self__, "environment_variable_aliases", environment_variable_aliases)
        if environment_variables is not None:
            pulumi.set(__self__, "environment_variables", environment_variables)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if organization_id is not None:
            pulumi.set(__self__, "organization_id", organization_id)
        if secret_aliases is not None:
            pulumi.set(__self__, "secret_aliases", secret_aliases)
        if secrets is not None:
            pulumi.set(__self__, "secrets", secrets)

    @property
    @pulumi.getter(name="builtInEnvironmentVariables")
    def built_in_environment_variables(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ProjectBuiltInEnvironmentVariableArgs']]]]:
        """
        List of built-in environment variables linked to this project.
        """
        return pulumi.get(self, "built_in_environment_variables")

    @built_in_environment_variables.setter
    def built_in_environment_variables(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ProjectBuiltInEnvironmentVariableArgs']]]]):
        pulumi.set(self, "built_in_environment_variables", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description of the project.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="environmentVariableAliases")
    def environment_variable_aliases(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ProjectEnvironmentVariableAliasArgs']]]]:
        """
        List of environment variable aliases linked to this project.
        """
        return pulumi.get(self, "environment_variable_aliases")

    @environment_variable_aliases.setter
    def environment_variable_aliases(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ProjectEnvironmentVariableAliasArgs']]]]):
        pulumi.set(self, "environment_variable_aliases", value)

    @property
    @pulumi.getter(name="environmentVariables")
    def environment_variables(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ProjectEnvironmentVariableArgs']]]]:
        """
        List of environment variables linked to this project.
        """
        return pulumi.get(self, "environment_variables")

    @environment_variables.setter
    def environment_variables(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ProjectEnvironmentVariableArgs']]]]):
        pulumi.set(self, "environment_variables", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the project.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="organizationId")
    def organization_id(self) -> Optional[pulumi.Input[str]]:
        """
        Id of the organization.
        """
        return pulumi.get(self, "organization_id")

    @organization_id.setter
    def organization_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "organization_id", value)

    @property
    @pulumi.getter(name="secretAliases")
    def secret_aliases(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ProjectSecretAliasArgs']]]]:
        """
        List of secret aliases linked to this project.
        """
        return pulumi.get(self, "secret_aliases")

    @secret_aliases.setter
    def secret_aliases(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ProjectSecretAliasArgs']]]]):
        pulumi.set(self, "secret_aliases", value)

    @property
    @pulumi.getter
    def secrets(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ProjectSecretArgs']]]]:
        """
        List of secrets linked to this project.
        """
        return pulumi.get(self, "secrets")

    @secrets.setter
    def secrets(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ProjectSecretArgs']]]]):
        pulumi.set(self, "secrets", value)


class Project(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 environment_variable_aliases: Optional[pulumi.Input[Sequence[pulumi.Input[Union['ProjectEnvironmentVariableAliasArgs', 'ProjectEnvironmentVariableAliasArgsDict']]]]] = None,
                 environment_variables: Optional[pulumi.Input[Sequence[pulumi.Input[Union['ProjectEnvironmentVariableArgs', 'ProjectEnvironmentVariableArgsDict']]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 organization_id: Optional[pulumi.Input[str]] = None,
                 secret_aliases: Optional[pulumi.Input[Sequence[pulumi.Input[Union['ProjectSecretAliasArgs', 'ProjectSecretAliasArgsDict']]]]] = None,
                 secrets: Optional[pulumi.Input[Sequence[pulumi.Input[Union['ProjectSecretArgs', 'ProjectSecretArgsDict']]]]] = None,
                 __props__=None):
        """
        ## # Project (Resource)

        Provides a Qovery project resource. This can be used to create and manage Qovery projects.

        ## Example

        ```python
        import pulumi
        import ediri_qovery as qovery

        my_project = qovery.Project("myProject",
            organization_id=qovery_organization["my_organization"]["id"],
            description="My project description",
            environment_variables=[{
                "key": "ENV_VAR_KEY",
                "value": "ENV_VAR_VALUE",
            }],
            environment_variable_aliases=[{
                "key": "ENV_VAR_KEY_ALIAS",
                "value": "ENV_VAR_KEY",
            }],
            secrets=[{
                "key": "SECRET_KEY",
                "value": "SECRET_VALUE",
            }],
            secret_aliases=[{
                "key": "SECRET_KEY_ALIAS",
                "value": "SECRET_KEY",
            }],
            opts = pulumi.ResourceOptions(depends_on=[qovery_organization["my_organization"]]))
        ```

        ## Import

        ```sh
        $ pulumi import qovery:index/project:Project my_project "<project_id>"
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Description of the project.
        :param pulumi.Input[Sequence[pulumi.Input[Union['ProjectEnvironmentVariableAliasArgs', 'ProjectEnvironmentVariableAliasArgsDict']]]] environment_variable_aliases: List of environment variable aliases linked to this project.
        :param pulumi.Input[Sequence[pulumi.Input[Union['ProjectEnvironmentVariableArgs', 'ProjectEnvironmentVariableArgsDict']]]] environment_variables: List of environment variables linked to this project.
        :param pulumi.Input[str] name: Name of the project.
        :param pulumi.Input[str] organization_id: Id of the organization.
        :param pulumi.Input[Sequence[pulumi.Input[Union['ProjectSecretAliasArgs', 'ProjectSecretAliasArgsDict']]]] secret_aliases: List of secret aliases linked to this project.
        :param pulumi.Input[Sequence[pulumi.Input[Union['ProjectSecretArgs', 'ProjectSecretArgsDict']]]] secrets: List of secrets linked to this project.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ProjectArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        ## # Project (Resource)

        Provides a Qovery project resource. This can be used to create and manage Qovery projects.

        ## Example

        ```python
        import pulumi
        import ediri_qovery as qovery

        my_project = qovery.Project("myProject",
            organization_id=qovery_organization["my_organization"]["id"],
            description="My project description",
            environment_variables=[{
                "key": "ENV_VAR_KEY",
                "value": "ENV_VAR_VALUE",
            }],
            environment_variable_aliases=[{
                "key": "ENV_VAR_KEY_ALIAS",
                "value": "ENV_VAR_KEY",
            }],
            secrets=[{
                "key": "SECRET_KEY",
                "value": "SECRET_VALUE",
            }],
            secret_aliases=[{
                "key": "SECRET_KEY_ALIAS",
                "value": "SECRET_KEY",
            }],
            opts = pulumi.ResourceOptions(depends_on=[qovery_organization["my_organization"]]))
        ```

        ## Import

        ```sh
        $ pulumi import qovery:index/project:Project my_project "<project_id>"
        ```

        :param str resource_name: The name of the resource.
        :param ProjectArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ProjectArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 environment_variable_aliases: Optional[pulumi.Input[Sequence[pulumi.Input[Union['ProjectEnvironmentVariableAliasArgs', 'ProjectEnvironmentVariableAliasArgsDict']]]]] = None,
                 environment_variables: Optional[pulumi.Input[Sequence[pulumi.Input[Union['ProjectEnvironmentVariableArgs', 'ProjectEnvironmentVariableArgsDict']]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 organization_id: Optional[pulumi.Input[str]] = None,
                 secret_aliases: Optional[pulumi.Input[Sequence[pulumi.Input[Union['ProjectSecretAliasArgs', 'ProjectSecretAliasArgsDict']]]]] = None,
                 secrets: Optional[pulumi.Input[Sequence[pulumi.Input[Union['ProjectSecretArgs', 'ProjectSecretArgsDict']]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ProjectArgs.__new__(ProjectArgs)

            __props__.__dict__["description"] = description
            __props__.__dict__["environment_variable_aliases"] = environment_variable_aliases
            __props__.__dict__["environment_variables"] = environment_variables
            __props__.__dict__["name"] = name
            if organization_id is None and not opts.urn:
                raise TypeError("Missing required property 'organization_id'")
            __props__.__dict__["organization_id"] = organization_id
            __props__.__dict__["secret_aliases"] = secret_aliases
            __props__.__dict__["secrets"] = secrets
            __props__.__dict__["built_in_environment_variables"] = None
        super(Project, __self__).__init__(
            'qovery:index/project:Project',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            built_in_environment_variables: Optional[pulumi.Input[Sequence[pulumi.Input[Union['ProjectBuiltInEnvironmentVariableArgs', 'ProjectBuiltInEnvironmentVariableArgsDict']]]]] = None,
            description: Optional[pulumi.Input[str]] = None,
            environment_variable_aliases: Optional[pulumi.Input[Sequence[pulumi.Input[Union['ProjectEnvironmentVariableAliasArgs', 'ProjectEnvironmentVariableAliasArgsDict']]]]] = None,
            environment_variables: Optional[pulumi.Input[Sequence[pulumi.Input[Union['ProjectEnvironmentVariableArgs', 'ProjectEnvironmentVariableArgsDict']]]]] = None,
            name: Optional[pulumi.Input[str]] = None,
            organization_id: Optional[pulumi.Input[str]] = None,
            secret_aliases: Optional[pulumi.Input[Sequence[pulumi.Input[Union['ProjectSecretAliasArgs', 'ProjectSecretAliasArgsDict']]]]] = None,
            secrets: Optional[pulumi.Input[Sequence[pulumi.Input[Union['ProjectSecretArgs', 'ProjectSecretArgsDict']]]]] = None) -> 'Project':
        """
        Get an existing Project resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[Union['ProjectBuiltInEnvironmentVariableArgs', 'ProjectBuiltInEnvironmentVariableArgsDict']]]] built_in_environment_variables: List of built-in environment variables linked to this project.
        :param pulumi.Input[str] description: Description of the project.
        :param pulumi.Input[Sequence[pulumi.Input[Union['ProjectEnvironmentVariableAliasArgs', 'ProjectEnvironmentVariableAliasArgsDict']]]] environment_variable_aliases: List of environment variable aliases linked to this project.
        :param pulumi.Input[Sequence[pulumi.Input[Union['ProjectEnvironmentVariableArgs', 'ProjectEnvironmentVariableArgsDict']]]] environment_variables: List of environment variables linked to this project.
        :param pulumi.Input[str] name: Name of the project.
        :param pulumi.Input[str] organization_id: Id of the organization.
        :param pulumi.Input[Sequence[pulumi.Input[Union['ProjectSecretAliasArgs', 'ProjectSecretAliasArgsDict']]]] secret_aliases: List of secret aliases linked to this project.
        :param pulumi.Input[Sequence[pulumi.Input[Union['ProjectSecretArgs', 'ProjectSecretArgsDict']]]] secrets: List of secrets linked to this project.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ProjectState.__new__(_ProjectState)

        __props__.__dict__["built_in_environment_variables"] = built_in_environment_variables
        __props__.__dict__["description"] = description
        __props__.__dict__["environment_variable_aliases"] = environment_variable_aliases
        __props__.__dict__["environment_variables"] = environment_variables
        __props__.__dict__["name"] = name
        __props__.__dict__["organization_id"] = organization_id
        __props__.__dict__["secret_aliases"] = secret_aliases
        __props__.__dict__["secrets"] = secrets
        return Project(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="builtInEnvironmentVariables")
    def built_in_environment_variables(self) -> pulumi.Output[Sequence['outputs.ProjectBuiltInEnvironmentVariable']]:
        """
        List of built-in environment variables linked to this project.
        """
        return pulumi.get(self, "built_in_environment_variables")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[str]:
        """
        Description of the project.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="environmentVariableAliases")
    def environment_variable_aliases(self) -> pulumi.Output[Optional[Sequence['outputs.ProjectEnvironmentVariableAlias']]]:
        """
        List of environment variable aliases linked to this project.
        """
        return pulumi.get(self, "environment_variable_aliases")

    @property
    @pulumi.getter(name="environmentVariables")
    def environment_variables(self) -> pulumi.Output[Optional[Sequence['outputs.ProjectEnvironmentVariable']]]:
        """
        List of environment variables linked to this project.
        """
        return pulumi.get(self, "environment_variables")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Name of the project.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="organizationId")
    def organization_id(self) -> pulumi.Output[str]:
        """
        Id of the organization.
        """
        return pulumi.get(self, "organization_id")

    @property
    @pulumi.getter(name="secretAliases")
    def secret_aliases(self) -> pulumi.Output[Optional[Sequence['outputs.ProjectSecretAlias']]]:
        """
        List of secret aliases linked to this project.
        """
        return pulumi.get(self, "secret_aliases")

    @property
    @pulumi.getter
    def secrets(self) -> pulumi.Output[Optional[Sequence['outputs.ProjectSecret']]]:
        """
        List of secrets linked to this project.
        """
        return pulumi.get(self, "secrets")

