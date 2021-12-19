/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.6.5
 * Contact: me@ruby.js.org
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
    /// WorldMetadata
    /// </summary>
    [DataContract(Name = "WorldMetadata")]
    public partial class WorldMetadata : IEquatable<WorldMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorldMetadata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorldMetadata() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorldMetadata" /> class.
        /// </summary>
        /// <param name="id">WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user. (required).</param>
        /// <param name="metadata">metadata (required).</param>
        public WorldMetadata(string id = default(string), Object metadata = default(Object))
        {
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for WorldMetadata and cannot be null");
            }
            this.Id = id;
            // to ensure "metadata" is required (not null)
            if (metadata == null) {
                throw new ArgumentNullException("metadata is a required property for WorldMetadata and cannot be null");
            }
            this.Metadata = metadata;
        }

        /// <summary>
        /// WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.
        /// </summary>
        /// <value>WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", IsRequired = true, EmitDefaultValue = false)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorldMetadata {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as WorldMetadata);
        }

        /// <summary>
        /// Returns true if WorldMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of WorldMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorldMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
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
            // Id (string) pattern
            Regex regexId = new Regex(@"(^$|offline|(wrld|wld)_[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12})", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            yield break;
        }
    }

}
