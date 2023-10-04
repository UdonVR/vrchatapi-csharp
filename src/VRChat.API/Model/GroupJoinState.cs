/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.15.0
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
    /// Defines GroupJoinState
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GroupJoinState
    {
        /// <summary>
        /// Enum Closed for value: closed
        /// </summary>
        [EnumMember(Value = "closed")]
        Closed = 1,

        /// <summary>
        /// Enum Invite for value: invite
        /// </summary>
        [EnumMember(Value = "invite")]
        Invite = 2,

        /// <summary>
        /// Enum Request for value: request
        /// </summary>
        [EnumMember(Value = "request")]
        Request = 3,

        /// <summary>
        /// Enum Open for value: open
        /// </summary>
        [EnumMember(Value = "open")]
        Open = 4

    }

}
