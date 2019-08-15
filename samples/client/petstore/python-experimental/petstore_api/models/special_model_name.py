# coding: utf-8

"""
    OpenAPI Petstore

    This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\  # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six


class SpecialModelName(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'special_property_name': 'int',
    }

    attribute_map = {
        'special_property_name': '$special[property.name]',  # noqa: E501
    }

    def __init__(self, special_property_name=None):  # noqa: E501
        """SpecialModelName - a model defined in OpenAPI



        Keyword Args:
            special_property_name (int): [optional]  # noqa: E501
        """

        self._special_property_name = None
        self.discriminator = None

        if special_property_name is not None:
            self.special_property_name = special_property_name  # noqa: E501

    @property
    def special_property_name(self):
        """Gets the special_property_name of this SpecialModelName.  # noqa: E501


        :return: The special_property_name of this SpecialModelName.  # noqa: E501
        :rtype: int
        """
        return self._special_property_name

    @special_property_name.setter
    def special_property_name(
            self,
            special_property_name):
        """Sets the special_property_name of this SpecialModelName.


        :param special_property_name: The special_property_name of this SpecialModelName.  # noqa: E501
        :type: int
        """

        self._special_property_name = (
            special_property_name)

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.openapi_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, SpecialModelName):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
