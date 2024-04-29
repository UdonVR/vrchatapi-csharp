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
    /// NotificationDetailRequestInviteResponse
    /// </summary>
    [DataContract(Name = "NotificationDetailRequestInviteResponse")]
    public partial class NotificationDetailRequestInviteResponse : IEquatable<NotificationDetailRequestInviteResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationDetailRequestInviteResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NotificationDetailRequestInviteResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationDetailRequestInviteResponse" /> class.
        /// </summary>
        /// <param name="inResponseTo">inResponseTo (required).</param>
        /// <param name="requestMessage">Used when using InviteMessage Slot..</param>
        public NotificationDetailRequestInviteResponse(string inResponseTo = default(string), string requestMessage = default(string))
        {
            // to ensure "inResponseTo" is required (not null)
            if (inResponseTo == null)
            {
                throw new ArgumentNullException("inResponseTo is a required property for NotificationDetailRequestInviteResponse and cannot be null");
            }
            this.InResponseTo = inResponseTo;
            this.RequestMessage = requestMessage;
        }

        /// <summary>
        /// Gets or Sets InResponseTo
        /// </summary>
        [DataMember(Name = "inResponseTo", IsRequired = true, EmitDefaultValue = true)]
        public string InResponseTo { get; set; }

        /// <summary>
        /// Used when using InviteMessage Slot.
        /// </summary>
        /// <value>Used when using InviteMessage Slot.</value>
        [DataMember(Name = "requestMessage", EmitDefaultValue = false)]
        public string RequestMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NotificationDetailRequestInviteResponse {\n");
            sb.Append("  InResponseTo: ").Append(InResponseTo).Append("\n");
            sb.Append("  RequestMessage: ").Append(RequestMessage).Append("\n");
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
            return this.Equals(input as NotificationDetailRequestInviteResponse);
        }

        /// <summary>
        /// Returns true if NotificationDetailRequestInviteResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationDetailRequestInviteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationDetailRequestInviteResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InResponseTo == input.InResponseTo ||
                    (this.InResponseTo != null &&
                    this.InResponseTo.Equals(input.InResponseTo))
                ) && 
                (
                    this.RequestMessage == input.RequestMessage ||
                    (this.RequestMessage != null &&
                    this.RequestMessage.Equals(input.RequestMessage))
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
                if (this.InResponseTo != null)
                {
                    hashCode = (hashCode * 59) + this.InResponseTo.GetHashCode();
                }
                if (this.RequestMessage != null)
                {
                    hashCode = (hashCode * 59) + this.RequestMessage.GetHashCode();
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
