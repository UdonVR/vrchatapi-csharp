/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.18.1
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
    /// Error
    /// </summary>
    [DataContract(Name = "Error")]
    public partial class Error : IEquatable<Error>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        public Error(Response error = default(Response))
        {
            this._Error = error;
        }

        /// <summary>
        /// Gets or Sets _Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public Response _Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Error {\n");
            sb.Append("  _Error: ").Append(_Error).Append("\n");
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
            return this.Equals(input as Error);
        }

        /// <summary>
        /// Returns true if Error instances are equal
        /// </summary>
        /// <param name="input">Instance of Error to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Error input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._Error == input._Error ||
                    (this._Error != null &&
                    this._Error.Equals(input._Error))
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
                if (this._Error != null)
                {
                    hashCode = (hashCode * 59) + this._Error.GetHashCode();
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
