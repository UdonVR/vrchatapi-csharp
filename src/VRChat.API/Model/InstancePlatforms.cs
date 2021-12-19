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
    /// InstancePlatforms
    /// </summary>
    [DataContract(Name = "InstancePlatforms")]
    public partial class InstancePlatforms : IEquatable<InstancePlatforms>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstancePlatforms" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InstancePlatforms() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InstancePlatforms" /> class.
        /// </summary>
        /// <param name="android">android (required).</param>
        /// <param name="standalonewindows">standalonewindows (required).</param>
        public InstancePlatforms(int android = default(int), int standalonewindows = default(int))
        {
            this.Android = android;
            this.Standalonewindows = standalonewindows;
        }

        /// <summary>
        /// Gets or Sets Android
        /// </summary>
        [DataMember(Name = "android", IsRequired = true, EmitDefaultValue = false)]
        public int Android { get; set; }

        /// <summary>
        /// Gets or Sets Standalonewindows
        /// </summary>
        [DataMember(Name = "standalonewindows", IsRequired = true, EmitDefaultValue = false)]
        public int Standalonewindows { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstancePlatforms {\n");
            sb.Append("  Android: ").Append(Android).Append("\n");
            sb.Append("  Standalonewindows: ").Append(Standalonewindows).Append("\n");
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
            return this.Equals(input as InstancePlatforms);
        }

        /// <summary>
        /// Returns true if InstancePlatforms instances are equal
        /// </summary>
        /// <param name="input">Instance of InstancePlatforms to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstancePlatforms input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Android == input.Android ||
                    this.Android.Equals(input.Android)
                ) && 
                (
                    this.Standalonewindows == input.Standalonewindows ||
                    this.Standalonewindows.Equals(input.Standalonewindows)
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
                hashCode = hashCode * 59 + this.Android.GetHashCode();
                hashCode = hashCode * 59 + this.Standalonewindows.GetHashCode();
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
            // Android (int) minimum
            if(this.Android < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Android, must be a value greater than or equal to 0.", new [] { "Android" });
            }

            // Standalonewindows (int) minimum
            if(this.Standalonewindows < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Standalonewindows, must be a value greater than or equal to 0.", new [] { "Standalonewindows" });
            }

            yield break;
        }
    }

}
