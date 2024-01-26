/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.16.3
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
    /// CreateGroupRequest
    /// </summary>
    [DataContract(Name = "CreateGroupRequest")]
    public partial class CreateGroupRequest : IEquatable<CreateGroupRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets JoinState
        /// </summary>
        [DataMember(Name = "joinState", EmitDefaultValue = false)]
        public GroupJoinState? JoinState { get; set; }

        /// <summary>
        /// Gets or Sets Privacy
        /// </summary>
        [DataMember(Name = "privacy", EmitDefaultValue = false)]
        public GroupPrivacy? Privacy { get; set; }

        /// <summary>
        /// Gets or Sets RoleTemplate
        /// </summary>
        [DataMember(Name = "roleTemplate", IsRequired = true, EmitDefaultValue = true)]
        public GroupRoleTemplate RoleTemplate { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroupRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateGroupRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroupRequest" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="shortCode">shortCode (required).</param>
        /// <param name="description">description.</param>
        /// <param name="joinState">joinState.</param>
        /// <param name="iconId">iconId.</param>
        /// <param name="bannerId">bannerId.</param>
        /// <param name="privacy">privacy.</param>
        /// <param name="roleTemplate">roleTemplate (required).</param>
        public CreateGroupRequest(string name = default(string), string shortCode = default(string), string description = default(string), GroupJoinState? joinState = default(GroupJoinState?), string iconId = default(string), string bannerId = default(string), GroupPrivacy? privacy = default(GroupPrivacy?), GroupRoleTemplate roleTemplate = default(GroupRoleTemplate))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateGroupRequest and cannot be null");
            }
            this.Name = name;
            // to ensure "shortCode" is required (not null)
            if (shortCode == null)
            {
                throw new ArgumentNullException("shortCode is a required property for CreateGroupRequest and cannot be null");
            }
            this.ShortCode = shortCode;
            this.RoleTemplate = roleTemplate;
            this.Description = description;
            this.JoinState = joinState;
            this.IconId = iconId;
            this.BannerId = bannerId;
            this.Privacy = privacy;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ShortCode
        /// </summary>
        [DataMember(Name = "shortCode", IsRequired = true, EmitDefaultValue = true)]
        public string ShortCode { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets IconId
        /// </summary>
        [DataMember(Name = "iconId", EmitDefaultValue = true)]
        public string IconId { get; set; }

        /// <summary>
        /// Gets or Sets BannerId
        /// </summary>
        [DataMember(Name = "bannerId", EmitDefaultValue = true)]
        public string BannerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateGroupRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShortCode: ").Append(ShortCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  JoinState: ").Append(JoinState).Append("\n");
            sb.Append("  IconId: ").Append(IconId).Append("\n");
            sb.Append("  BannerId: ").Append(BannerId).Append("\n");
            sb.Append("  Privacy: ").Append(Privacy).Append("\n");
            sb.Append("  RoleTemplate: ").Append(RoleTemplate).Append("\n");
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
            return this.Equals(input as CreateGroupRequest);
        }

        /// <summary>
        /// Returns true if CreateGroupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateGroupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateGroupRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ShortCode == input.ShortCode ||
                    (this.ShortCode != null &&
                    this.ShortCode.Equals(input.ShortCode))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.JoinState == input.JoinState ||
                    this.JoinState.Equals(input.JoinState)
                ) && 
                (
                    this.IconId == input.IconId ||
                    (this.IconId != null &&
                    this.IconId.Equals(input.IconId))
                ) && 
                (
                    this.BannerId == input.BannerId ||
                    (this.BannerId != null &&
                    this.BannerId.Equals(input.BannerId))
                ) && 
                (
                    this.Privacy == input.Privacy ||
                    this.Privacy.Equals(input.Privacy)
                ) && 
                (
                    this.RoleTemplate == input.RoleTemplate ||
                    this.RoleTemplate.Equals(input.RoleTemplate)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.ShortCode != null)
                {
                    hashCode = (hashCode * 59) + this.ShortCode.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.JoinState.GetHashCode();
                if (this.IconId != null)
                {
                    hashCode = (hashCode * 59) + this.IconId.GetHashCode();
                }
                if (this.BannerId != null)
                {
                    hashCode = (hashCode * 59) + this.BannerId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Privacy.GetHashCode();
                hashCode = (hashCode * 59) + this.RoleTemplate.GetHashCode();
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 64.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 3.", new [] { "Name" });
            }

            // ShortCode (string) maxLength
            if (this.ShortCode != null && this.ShortCode.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShortCode, length must be less than 6.", new [] { "ShortCode" });
            }

            // ShortCode (string) minLength
            if (this.ShortCode != null && this.ShortCode.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShortCode, length must be greater than 3.", new [] { "ShortCode" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 250)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 250.", new [] { "Description" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 0.", new [] { "Description" });
            }

            yield break;
        }
    }

}
