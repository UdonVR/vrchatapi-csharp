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
    /// Notification
    /// </summary>
    [DataContract(Name = "Notification")]
    public partial class Notification : IEquatable<Notification>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public NotificationType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Notification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class.
        /// </summary>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="details">**NOTICE:** This is not a JSON object when received from the REST API, but it is when received from the Websocket API. When received from the REST API, this is a json **encoded** object, meaning you have to json-de-encode to get the NotificationDetail object depending on the NotificationType. (required) (default to &quot;{}&quot;).</param>
        /// <param name="id">id (required).</param>
        /// <param name="message">message (required).</param>
        /// <param name="seen">Not included in notification objects received from the Websocket API (default to false).</param>
        /// <param name="receiverUserId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed..</param>
        /// <param name="senderUserId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. (required).</param>
        /// <param name="senderUsername">-| **DEPRECATED:** VRChat API no longer return usernames of other users. [See issue by Tupper for more information](https://github.com/pypy-vrc/VRCX/issues/429)..</param>
        /// <param name="type">type (required).</param>
        public Notification(DateTime createdAt = default(DateTime), string details = "{}", string id = default(string), string message = default(string), bool seen = false, string receiverUserId = default(string), string senderUserId = default(string), string senderUsername = default(string), NotificationType type = default(NotificationType))
        {
            this.CreatedAt = createdAt;
            // to ensure "details" is required (not null)
            if (details == null)
            {
                throw new ArgumentNullException("details is a required property for Notification and cannot be null");
            }
            this.Details = details;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Notification and cannot be null");
            }
            this.Id = id;
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for Notification and cannot be null");
            }
            this.Message = message;
            // to ensure "senderUserId" is required (not null)
            if (senderUserId == null)
            {
                throw new ArgumentNullException("senderUserId is a required property for Notification and cannot be null");
            }
            this.SenderUserId = senderUserId;
            this.Type = type;
            this.Seen = seen;
            this.ReceiverUserId = receiverUserId;
            this.SenderUsername = senderUsername;
        }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// **NOTICE:** This is not a JSON object when received from the REST API, but it is when received from the Websocket API. When received from the REST API, this is a json **encoded** object, meaning you have to json-de-encode to get the NotificationDetail object depending on the NotificationType.
        /// </summary>
        /// <value>**NOTICE:** This is not a JSON object when received from the REST API, but it is when received from the Websocket API. When received from the REST API, this is a json **encoded** object, meaning you have to json-de-encode to get the NotificationDetail object depending on the NotificationType.</value>
        [DataMember(Name = "details", IsRequired = true, EmitDefaultValue = true)]
        public string Details { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Not included in notification objects received from the Websocket API
        /// </summary>
        /// <value>Not included in notification objects received from the Websocket API</value>
        [DataMember(Name = "seen", EmitDefaultValue = true)]
        public bool Seen { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "receiverUserId", EmitDefaultValue = false)]
        public string ReceiverUserId { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "senderUserId", IsRequired = true, EmitDefaultValue = true)]
        public string SenderUserId { get; set; }

        /// <summary>
        /// -| **DEPRECATED:** VRChat API no longer return usernames of other users. [See issue by Tupper for more information](https://github.com/pypy-vrc/VRCX/issues/429).
        /// </summary>
        /// <value>-| **DEPRECATED:** VRChat API no longer return usernames of other users. [See issue by Tupper for more information](https://github.com/pypy-vrc/VRCX/issues/429).</value>
        [DataMember(Name = "senderUsername", EmitDefaultValue = false)]
        [Obsolete]
        public string SenderUsername { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Notification {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Seen: ").Append(Seen).Append("\n");
            sb.Append("  ReceiverUserId: ").Append(ReceiverUserId).Append("\n");
            sb.Append("  SenderUserId: ").Append(SenderUserId).Append("\n");
            sb.Append("  SenderUsername: ").Append(SenderUsername).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as Notification);
        }

        /// <summary>
        /// Returns true if Notification instances are equal
        /// </summary>
        /// <param name="input">Instance of Notification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Notification input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Seen == input.Seen ||
                    this.Seen.Equals(input.Seen)
                ) && 
                (
                    this.ReceiverUserId == input.ReceiverUserId ||
                    (this.ReceiverUserId != null &&
                    this.ReceiverUserId.Equals(input.ReceiverUserId))
                ) && 
                (
                    this.SenderUserId == input.SenderUserId ||
                    (this.SenderUserId != null &&
                    this.SenderUserId.Equals(input.SenderUserId))
                ) && 
                (
                    this.SenderUsername == input.SenderUsername ||
                    (this.SenderUsername != null &&
                    this.SenderUsername.Equals(input.SenderUsername))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Details != null)
                {
                    hashCode = (hashCode * 59) + this.Details.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Seen.GetHashCode();
                if (this.ReceiverUserId != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiverUserId.GetHashCode();
                }
                if (this.SenderUserId != null)
                {
                    hashCode = (hashCode * 59) + this.SenderUserId.GetHashCode();
                }
                if (this.SenderUsername != null)
                {
                    hashCode = (hashCode * 59) + this.SenderUsername.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
            // Id (string) minLength
            if (this.Id != null && this.Id.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be greater than 1.", new [] { "Id" });
            }

            // SenderUsername (string) minLength
            if (this.SenderUsername != null && this.SenderUsername.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SenderUsername, length must be greater than 1.", new [] { "SenderUsername" });
            }

            yield break;
        }
    }

}
