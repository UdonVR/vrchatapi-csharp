/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.18.4
 * Contact: vrchatapi.lpv0t@aries.fyi
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = VRChat.API.Client.OpenAPIDateConverter;

namespace VRChat.API.Model
{
    /// <summary>
    /// Group access type when the instance type is \&quot;group\&quot;
    /// </summary>
    /// <value>Group access type when the instance type is \&quot;group\&quot;</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GroupAccessType
    {
        /// <summary>
        /// Enum Public for value: public
        /// </summary>
        [EnumMember(Value = "public")]
        Public = 1,

        /// <summary>
        /// Enum Plus for value: plus
        /// </summary>
        [EnumMember(Value = "plus")]
        Plus = 2,

        /// <summary>
        /// Enum Members for value: members
        /// </summary>
        [EnumMember(Value = "members")]
        Members = 3

    }

}
