# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['OrganizationArgs', 'Organization']

@pulumi.input_type
class OrganizationArgs:
    def __init__(__self__, *,
                 plan: pulumi.Input[str],
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a Organization resource.
        :param pulumi.Input[str] plan: Plan of the organization. - Can be: `BUSINESS`, `ENTERPRISE`, `ENTERPRISE_YEARLY`, `FREE`, `PROFESSIONAL`, `TEAM`,
               `TEAM_YEARLY`.
        :param pulumi.Input[str] description: Description of the organization.
        :param pulumi.Input[str] name: Name of the organization.
        """
        pulumi.set(__self__, "plan", plan)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def plan(self) -> pulumi.Input[str]:
        """
        Plan of the organization. - Can be: `BUSINESS`, `ENTERPRISE`, `ENTERPRISE_YEARLY`, `FREE`, `PROFESSIONAL`, `TEAM`,
        `TEAM_YEARLY`.
        """
        return pulumi.get(self, "plan")

    @plan.setter
    def plan(self, value: pulumi.Input[str]):
        pulumi.set(self, "plan", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description of the organization.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the organization.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


@pulumi.input_type
class _OrganizationState:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 plan: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering Organization resources.
        :param pulumi.Input[str] description: Description of the organization.
        :param pulumi.Input[str] name: Name of the organization.
        :param pulumi.Input[str] plan: Plan of the organization. - Can be: `BUSINESS`, `ENTERPRISE`, `ENTERPRISE_YEARLY`, `FREE`, `PROFESSIONAL`, `TEAM`,
               `TEAM_YEARLY`.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if plan is not None:
            pulumi.set(__self__, "plan", plan)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description of the organization.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the organization.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def plan(self) -> Optional[pulumi.Input[str]]:
        """
        Plan of the organization. - Can be: `BUSINESS`, `ENTERPRISE`, `ENTERPRISE_YEARLY`, `FREE`, `PROFESSIONAL`, `TEAM`,
        `TEAM_YEARLY`.
        """
        return pulumi.get(self, "plan")

    @plan.setter
    def plan(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "plan", value)


class Organization(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 plan: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        ## # Organization (Resource)

        Provides a Qovery organization resource. This can be used to create and manage Qovery organizations.

        ## Example

        ```python
        import pulumi
        import ediri_qovery as qovery

        my_organization = qovery.Organization("myOrganization",
            description="My organization description",
            plan="FREE")
        ```

        ## Import

        ```sh
        $ pulumi import qovery:index/organization:Organization my_organization "<organization_id>"
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Description of the organization.
        :param pulumi.Input[str] name: Name of the organization.
        :param pulumi.Input[str] plan: Plan of the organization. - Can be: `BUSINESS`, `ENTERPRISE`, `ENTERPRISE_YEARLY`, `FREE`, `PROFESSIONAL`, `TEAM`,
               `TEAM_YEARLY`.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: OrganizationArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        ## # Organization (Resource)

        Provides a Qovery organization resource. This can be used to create and manage Qovery organizations.

        ## Example

        ```python
        import pulumi
        import ediri_qovery as qovery

        my_organization = qovery.Organization("myOrganization",
            description="My organization description",
            plan="FREE")
        ```

        ## Import

        ```sh
        $ pulumi import qovery:index/organization:Organization my_organization "<organization_id>"
        ```

        :param str resource_name: The name of the resource.
        :param OrganizationArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(OrganizationArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 plan: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = OrganizationArgs.__new__(OrganizationArgs)

            __props__.__dict__["description"] = description
            __props__.__dict__["name"] = name
            if plan is None and not opts.urn:
                raise TypeError("Missing required property 'plan'")
            __props__.__dict__["plan"] = plan
        super(Organization, __self__).__init__(
            'qovery:index/organization:Organization',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            plan: Optional[pulumi.Input[str]] = None) -> 'Organization':
        """
        Get an existing Organization resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Description of the organization.
        :param pulumi.Input[str] name: Name of the organization.
        :param pulumi.Input[str] plan: Plan of the organization. - Can be: `BUSINESS`, `ENTERPRISE`, `ENTERPRISE_YEARLY`, `FREE`, `PROFESSIONAL`, `TEAM`,
               `TEAM_YEARLY`.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _OrganizationState.__new__(_OrganizationState)

        __props__.__dict__["description"] = description
        __props__.__dict__["name"] = name
        __props__.__dict__["plan"] = plan
        return Organization(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[str]:
        """
        Description of the organization.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Name of the organization.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def plan(self) -> pulumi.Output[str]:
        """
        Plan of the organization. - Can be: `BUSINESS`, `ENTERPRISE`, `ENTERPRISE_YEARLY`, `FREE`, `PROFESSIONAL`, `TEAM`,
        `TEAM_YEARLY`.
        """
        return pulumi.get(self, "plan")

