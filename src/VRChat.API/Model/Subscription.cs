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
    /// Subscription
    /// </summary>
    [DataContract(Name = "Subscription")]
    public partial class Subscription : IEquatable<Subscription>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name = "period", IsRequired = true, EmitDefaultValue = true)]
        public SubscriptionPeriod Period { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Subscription() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="steamItemId">steamItemId (required).</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="period">period (required).</param>
        /// <param name="tier">tier (required).</param>
        public Subscription(string id = default(string), string steamItemId = default(string), decimal amount = default(decimal), string description = default(string), SubscriptionPeriod period = default(SubscriptionPeriod), decimal tier = default(decimal))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Subscription and cannot be null");
            }
            this.Id = id;
            // to ensure "steamItemId" is required (not null)
            if (steamItemId == null)
            {
                throw new ArgumentNullException("steamItemId is a required property for Subscription and cannot be null");
            }
            this.SteamItemId = steamItemId;
            this.Amount = amount;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for Subscription and cannot be null");
            }
            this.Description = description;
            this.Period = period;
            this.Tier = tier;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets SteamItemId
        /// </summary>
        [DataMember(Name = "steamItemId", IsRequired = true, EmitDefaultValue = true)]
        public string SteamItemId { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Tier
        /// </summary>
        [DataMember(Name = "tier", IsRequired = true, EmitDefaultValue = true)]
        public decimal Tier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Subscription {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SteamItemId: ").Append(SteamItemId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Tier: ").Append(Tier).Append("\n");
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
            return this.Equals(input as Subscription);
        }

        /// <summary>
        /// Returns true if Subscription instances are equal
        /// </summary>
        /// <param name="input">Instance of Subscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Subscription input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.SteamItemId == input.SteamItemId ||
                    (this.SteamItemId != null &&
                    this.SteamItemId.Equals(input.SteamItemId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Period == input.Period ||
                    this.Period.Equals(input.Period)
                ) && 
                (
                    this.Tier == input.Tier ||
                    this.Tier.Equals(input.Tier)
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
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.SteamItemId != null)
                {
                    hashCode = (hashCode * 59) + this.SteamItemId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Period.GetHashCode();
                hashCode = (hashCode * 59) + this.Tier.GetHashCode();
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

            // SteamItemId (string) minLength
            if (this.SteamItemId != null && this.SteamItemId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SteamItemId, length must be greater than 1.", new [] { "SteamItemId" });
            }

            yield break;
        }
    }

}
