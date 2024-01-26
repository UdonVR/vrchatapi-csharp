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
    /// FriendStatus
    /// </summary>
    [DataContract(Name = "FriendStatus")]
    public partial class FriendStatus : IEquatable<FriendStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FriendStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FriendStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FriendStatus" /> class.
        /// </summary>
        /// <param name="incomingRequest">incomingRequest (required) (default to false).</param>
        /// <param name="isFriend">isFriend (required) (default to false).</param>
        /// <param name="outgoingRequest">outgoingRequest (required) (default to false).</param>
        public FriendStatus(bool incomingRequest = false, bool isFriend = false, bool outgoingRequest = false)
        {
            this.IncomingRequest = incomingRequest;
            this.IsFriend = isFriend;
            this.OutgoingRequest = outgoingRequest;
        }

        /// <summary>
        /// Gets or Sets IncomingRequest
        /// </summary>
        [DataMember(Name = "incomingRequest", IsRequired = true, EmitDefaultValue = true)]
        public bool IncomingRequest { get; set; }

        /// <summary>
        /// Gets or Sets IsFriend
        /// </summary>
        [DataMember(Name = "isFriend", IsRequired = true, EmitDefaultValue = true)]
        public bool IsFriend { get; set; }

        /// <summary>
        /// Gets or Sets OutgoingRequest
        /// </summary>
        [DataMember(Name = "outgoingRequest", IsRequired = true, EmitDefaultValue = true)]
        public bool OutgoingRequest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FriendStatus {\n");
            sb.Append("  IncomingRequest: ").Append(IncomingRequest).Append("\n");
            sb.Append("  IsFriend: ").Append(IsFriend).Append("\n");
            sb.Append("  OutgoingRequest: ").Append(OutgoingRequest).Append("\n");
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
            return this.Equals(input as FriendStatus);
        }

        /// <summary>
        /// Returns true if FriendStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of FriendStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FriendStatus input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IncomingRequest == input.IncomingRequest ||
                    this.IncomingRequest.Equals(input.IncomingRequest)
                ) && 
                (
                    this.IsFriend == input.IsFriend ||
                    this.IsFriend.Equals(input.IsFriend)
                ) && 
                (
                    this.OutgoingRequest == input.OutgoingRequest ||
                    this.OutgoingRequest.Equals(input.OutgoingRequest)
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
                hashCode = (hashCode * 59) + this.IncomingRequest.GetHashCode();
                hashCode = (hashCode * 59) + this.IsFriend.GetHashCode();
                hashCode = (hashCode * 59) + this.OutgoingRequest.GetHashCode();
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
