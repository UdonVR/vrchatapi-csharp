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
    /// APIHealth
    /// </summary>
    [DataContract(Name = "APIHealth")]
    public partial class APIHealth : IEquatable<APIHealth>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIHealth" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected APIHealth() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="APIHealth" /> class.
        /// </summary>
        /// <param name="ok">ok (required).</param>
        /// <param name="serverName">serverName (required).</param>
        /// <param name="buildVersionTag">buildVersionTag (required).</param>
        public APIHealth(bool ok = default(bool), string serverName = default(string), string buildVersionTag = default(string))
        {
            this.Ok = ok;
            // to ensure "serverName" is required (not null)
            if (serverName == null)
            {
                throw new ArgumentNullException("serverName is a required property for APIHealth and cannot be null");
            }
            this.ServerName = serverName;
            // to ensure "buildVersionTag" is required (not null)
            if (buildVersionTag == null)
            {
                throw new ArgumentNullException("buildVersionTag is a required property for APIHealth and cannot be null");
            }
            this.BuildVersionTag = buildVersionTag;
        }

        /// <summary>
        /// Gets or Sets Ok
        /// </summary>
        [DataMember(Name = "ok", IsRequired = true, EmitDefaultValue = true)]
        public bool Ok { get; set; }

        /// <summary>
        /// Gets or Sets ServerName
        /// </summary>
        [DataMember(Name = "serverName", IsRequired = true, EmitDefaultValue = true)]
        public string ServerName { get; set; }

        /// <summary>
        /// Gets or Sets BuildVersionTag
        /// </summary>
        [DataMember(Name = "buildVersionTag", IsRequired = true, EmitDefaultValue = true)]
        public string BuildVersionTag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class APIHealth {\n");
            sb.Append("  Ok: ").Append(Ok).Append("\n");
            sb.Append("  ServerName: ").Append(ServerName).Append("\n");
            sb.Append("  BuildVersionTag: ").Append(BuildVersionTag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as APIHealth);
        }

        /// <summary>
        /// Returns true if APIHealth instances are equal
        /// </summary>
        /// <param name="input">Instance of APIHealth to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIHealth input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Ok == input.Ok ||
                    this.Ok.Equals(input.Ok)
                ) && 
                (
                    this.ServerName == input.ServerName ||
                    (this.ServerName != null &&
                    this.ServerName.Equals(input.ServerName))
                ) && 
                (
                    this.BuildVersionTag == input.BuildVersionTag ||
                    (this.BuildVersionTag != null &&
                    this.BuildVersionTag.Equals(input.BuildVersionTag))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Ok.GetHashCode();
                if (this.ServerName != null)
                {
                    hashCode = (hashCode * 59) + this.ServerName.GetHashCode();
                }
                if (this.BuildVersionTag != null)
                {
                    hashCode = (hashCode * 59) + this.BuildVersionTag.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // ServerName (string) minLength
            if (this.ServerName != null && this.ServerName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ServerName, length must be greater than 1.", new [] { "ServerName" });
            }

            // BuildVersionTag (string) minLength
            if (this.BuildVersionTag != null && this.BuildVersionTag.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BuildVersionTag, length must be greater than 1.", new [] { "BuildVersionTag" });
            }

            yield break;
        }
    }

}
