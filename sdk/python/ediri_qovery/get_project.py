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

__all__ = [
    'GetProjectResult',
    'AwaitableGetProjectResult',
    'get_project',
    'get_project_output',
]

@pulumi.output_type
class GetProjectResult:
    """
    A collection of values returned by getProject.
    """
    def __init__(__self__, built_in_environment_variables=None, description=None, environment_variable_aliases=None, environment_variables=None, id=None, name=None, organization_id=None, secret_aliases=None, secrets=None):
        if built_in_environment_variables and not isinstance(built_in_environment_variables, list):
            raise TypeError("Expected argument 'built_in_environment_variables' to be a list")
        pulumi.set(__self__, "built_in_environment_variables", built_in_environment_variables)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if environment_variable_aliases and not isinstance(environment_variable_aliases, list):
            raise TypeError("Expected argument 'environment_variable_aliases' to be a list")
        pulumi.set(__self__, "environment_variable_aliases", environment_variable_aliases)
        if environment_variables and not isinstance(environment_variables, list):
            raise TypeError("Expected argument 'environment_variables' to be a list")
        pulumi.set(__self__, "environment_variables", environment_variables)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if organization_id and not isinstance(organization_id, str):
            raise TypeError("Expected argument 'organization_id' to be a str")
        pulumi.set(__self__, "organization_id", organization_id)
        if secret_aliases and not isinstance(secret_aliases, list):
            raise TypeError("Expected argument 'secret_aliases' to be a list")
        pulumi.set(__self__, "secret_aliases", secret_aliases)
        if secrets and not isinstance(secrets, list):
            raise TypeError("Expected argument 'secrets' to be a list")
        pulumi.set(__self__, "secrets", secrets)

    @property
    @pulumi.getter(name="builtInEnvironmentVariables")
    def built_in_environment_variables(self) -> Sequence['outputs.GetProjectBuiltInEnvironmentVariableResult']:
        """
        List of built-in environment variables linked to this project.
        """
        return pulumi.get(self, "built_in_environment_variables")

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        Description of the project.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="environmentVariableAliases")
    def environment_variable_aliases(self) -> Sequence['outputs.GetProjectEnvironmentVariableAliasResult']:
        """
        List of environment variable aliases linked to this project.
        """
        return pulumi.get(self, "environment_variable_aliases")

    @property
    @pulumi.getter(name="environmentVariables")
    def environment_variables(self) -> Sequence['outputs.GetProjectEnvironmentVariableResult']:
        """
        List of environment variables linked to this project.
        """
        return pulumi.get(self, "environment_variables")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        Id of the project.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Name of the project.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="organizationId")
    def organization_id(self) -> str:
        """
        Id of the organization.
        """
        return pulumi.get(self, "organization_id")

    @property
    @pulumi.getter(name="secretAliases")
    def secret_aliases(self) -> Sequence['outputs.GetProjectSecretAliasResult']:
        """
        List of secret aliases linked to this project.
        """
        return pulumi.get(self, "secret_aliases")

    @property
    @pulumi.getter
    def secrets(self) -> Sequence['outputs.GetProjectSecretResult']:
        """
        List of secrets linked to this project.
        """
        return pulumi.get(self, "secrets")


class AwaitableGetProjectResult(GetProjectResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetProjectResult(
            built_in_environment_variables=self.built_in_environment_variables,
            description=self.description,
            environment_variable_aliases=self.environment_variable_aliases,
            environment_variables=self.environment_variables,
            id=self.id,
            name=self.name,
            organization_id=self.organization_id,
            secret_aliases=self.secret_aliases,
            secrets=self.secrets)


def get_project(description: Optional[str] = None,
                environment_variable_aliases: Optional[Sequence[Union['GetProjectEnvironmentVariableAliasArgs', 'GetProjectEnvironmentVariableAliasArgsDict']]] = None,
                environment_variables: Optional[Sequence[Union['GetProjectEnvironmentVariableArgs', 'GetProjectEnvironmentVariableArgsDict']]] = None,
                id: Optional[str] = None,
                secret_aliases: Optional[Sequence[Union['GetProjectSecretAliasArgs', 'GetProjectSecretAliasArgsDict']]] = None,
                secrets: Optional[Sequence[Union['GetProjectSecretArgs', 'GetProjectSecretArgsDict']]] = None,
                opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetProjectResult:
    """
    ## # Project (Data Source)

    Provides a Qovery project resource. This can be used to create and manage Qovery projects.
    ## Example Usage

    ```python
    import pulumi
    import pulumi_qovery as qovery

    my_project = qovery.get_project(id="<project_id>")
    ```


    :param str description: Description of the project.
    :param Sequence[Union['GetProjectEnvironmentVariableAliasArgs', 'GetProjectEnvironmentVariableAliasArgsDict']] environment_variable_aliases: List of environment variable aliases linked to this project.
    :param Sequence[Union['GetProjectEnvironmentVariableArgs', 'GetProjectEnvironmentVariableArgsDict']] environment_variables: List of environment variables linked to this project.
    :param str id: Id of the project.
    :param Sequence[Union['GetProjectSecretAliasArgs', 'GetProjectSecretAliasArgsDict']] secret_aliases: List of secret aliases linked to this project.
    :param Sequence[Union['GetProjectSecretArgs', 'GetProjectSecretArgsDict']] secrets: List of secrets linked to this project.
    """
    __args__ = dict()
    __args__['description'] = description
    __args__['environmentVariableAliases'] = environment_variable_aliases
    __args__['environmentVariables'] = environment_variables
    __args__['id'] = id
    __args__['secretAliases'] = secret_aliases
    __args__['secrets'] = secrets
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('qovery:index/getProject:getProject', __args__, opts=opts, typ=GetProjectResult).value

    return AwaitableGetProjectResult(
        built_in_environment_variables=pulumi.get(__ret__, 'built_in_environment_variables'),
        description=pulumi.get(__ret__, 'description'),
        environment_variable_aliases=pulumi.get(__ret__, 'environment_variable_aliases'),
        environment_variables=pulumi.get(__ret__, 'environment_variables'),
        id=pulumi.get(__ret__, 'id'),
        name=pulumi.get(__ret__, 'name'),
        organization_id=pulumi.get(__ret__, 'organization_id'),
        secret_aliases=pulumi.get(__ret__, 'secret_aliases'),
        secrets=pulumi.get(__ret__, 'secrets'))


@_utilities.lift_output_func(get_project)
def get_project_output(description: Optional[pulumi.Input[Optional[str]]] = None,
                       environment_variable_aliases: Optional[pulumi.Input[Optional[Sequence[Union['GetProjectEnvironmentVariableAliasArgs', 'GetProjectEnvironmentVariableAliasArgsDict']]]]] = None,
                       environment_variables: Optional[pulumi.Input[Optional[Sequence[Union['GetProjectEnvironmentVariableArgs', 'GetProjectEnvironmentVariableArgsDict']]]]] = None,
                       id: Optional[pulumi.Input[str]] = None,
                       secret_aliases: Optional[pulumi.Input[Optional[Sequence[Union['GetProjectSecretAliasArgs', 'GetProjectSecretAliasArgsDict']]]]] = None,
                       secrets: Optional[pulumi.Input[Optional[Sequence[Union['GetProjectSecretArgs', 'GetProjectSecretArgsDict']]]]] = None,
                       opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetProjectResult]:
    """
    ## # Project (Data Source)

    Provides a Qovery project resource. This can be used to create and manage Qovery projects.
    ## Example Usage

    ```python
    import pulumi
    import pulumi_qovery as qovery

    my_project = qovery.get_project(id="<project_id>")
    ```


    :param str description: Description of the project.
    :param Sequence[Union['GetProjectEnvironmentVariableAliasArgs', 'GetProjectEnvironmentVariableAliasArgsDict']] environment_variable_aliases: List of environment variable aliases linked to this project.
    :param Sequence[Union['GetProjectEnvironmentVariableArgs', 'GetProjectEnvironmentVariableArgsDict']] environment_variables: List of environment variables linked to this project.
    :param str id: Id of the project.
    :param Sequence[Union['GetProjectSecretAliasArgs', 'GetProjectSecretAliasArgsDict']] secret_aliases: List of secret aliases linked to this project.
    :param Sequence[Union['GetProjectSecretArgs', 'GetProjectSecretArgsDict']] secrets: List of secrets linked to this project.
    """
    ...
