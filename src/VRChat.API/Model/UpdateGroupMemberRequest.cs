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
    /// UpdateGroupMemberRequest
    /// </summary>
    [DataContract(Name = "UpdateGroupMemberRequest")]
    public partial class UpdateGroupMemberRequest : IEquatable<UpdateGroupMemberRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Visibility
        /// </summary>
        [DataMember(Name = "visibility", EmitDefaultValue = false)]
        public GroupUserVisibility? Visibility { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGroupMemberRequest" /> class.
        /// </summary>
        /// <param name="visibility">visibility.</param>
        /// <param name="isSubscribedToAnnouncements">isSubscribedToAnnouncements.</param>
        /// <param name="managerNotes">managerNotes.</param>
        public UpdateGroupMemberRequest(GroupUserVisibility? visibility = default(GroupUserVisibility?), bool isSubscribedToAnnouncements = default(bool), string managerNotes = default(string))
        {
            this.Visibility = visibility;
            this.IsSubscribedToAnnouncements = isSubscribedToAnnouncements;
            this.ManagerNotes = managerNotes;
        }

        /// <summary>
        /// Gets or Sets IsSubscribedToAnnouncements
        /// </summary>
        [DataMember(Name = "isSubscribedToAnnouncements", EmitDefaultValue = true)]
        public bool IsSubscribedToAnnouncements { get; set; }

        /// <summary>
        /// Gets or Sets ManagerNotes
        /// </summary>
        [DataMember(Name = "managerNotes", EmitDefaultValue = false)]
        public string ManagerNotes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateGroupMemberRequest {\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
            sb.Append("  IsSubscribedToAnnouncements: ").Append(IsSubscribedToAnnouncements).Append("\n");
            sb.Append("  ManagerNotes: ").Append(ManagerNotes).Append("\n");
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
            return this.Equals(input as UpdateGroupMemberRequest);
        }

        /// <summary>
        /// Returns true if UpdateGroupMemberRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateGroupMemberRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateGroupMemberRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Visibility == input.Visibility ||
                    this.Visibility.Equals(input.Visibility)
                ) && 
                (
                    this.IsSubscribedToAnnouncements == input.IsSubscribedToAnnouncements ||
                    this.IsSubscribedToAnnouncements.Equals(input.IsSubscribedToAnnouncements)
                ) && 
                (
                    this.ManagerNotes == input.ManagerNotes ||
                    (this.ManagerNotes != null &&
                    this.ManagerNotes.Equals(input.ManagerNotes))
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
                hashCode = (hashCode * 59) + this.Visibility.GetHashCode();
                hashCode = (hashCode * 59) + this.IsSubscribedToAnnouncements.GetHashCode();
                if (this.ManagerNotes != null)
                {
                    hashCode = (hashCode * 59) + this.ManagerNotes.GetHashCode();
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
            yield break;
        }
    }

}
