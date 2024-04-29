/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.17.3
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
    /// Defines GroupMemberStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GroupMemberStatus
    {
        /// <summary>
        /// Enum Inactive for value: inactive
        /// </summary>
        [EnumMember(Value = "inactive")]
        Inactive = 1,

        /// <summary>
        /// Enum Member for value: member
        /// </summary>
        [EnumMember(Value = "member")]
        Member = 2,

        /// <summary>
        /// Enum Requested for value: requested
        /// </summary>
        [EnumMember(Value = "requested")]
        Requested = 3,

        /// <summary>
        /// Enum Invited for value: invited
        /// </summary>
        [EnumMember(Value = "invited")]
        Invited = 4,

        /// <summary>
        /// Enum Banned for value: banned
        /// </summary>
        [EnumMember(Value = "banned")]
        Banned = 5

    }

}
