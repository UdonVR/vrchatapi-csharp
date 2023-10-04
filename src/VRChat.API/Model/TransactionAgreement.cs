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
    /// TransactionAgreement
    /// </summary>
    [DataContract(Name = "TransactionAgreement")]
    public partial class TransactionAgreement : IEquatable<TransactionAgreement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionAgreement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionAgreement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionAgreement" /> class.
        /// </summary>
        /// <param name="agreementId">agreementId (required).</param>
        /// <param name="itemId">itemId (required).</param>
        /// <param name="status">This is NOT TransactionStatus, but whatever Steam return. (required).</param>
        /// <param name="period">period (required).</param>
        /// <param name="frequency">frequency (required).</param>
        /// <param name="billingType">billingType (required).</param>
        /// <param name="startDate">startDate (required).</param>
        /// <param name="endDate">endDate (required).</param>
        /// <param name="recurringAmt">recurringAmt (required).</param>
        /// <param name="currency">currency (required).</param>
        /// <param name="timeCreated">timeCreated (required).</param>
        /// <param name="nextPayment">nextPayment (required).</param>
        /// <param name="lastPayment">lastPayment (required).</param>
        /// <param name="lastAmount">lastAmount (required).</param>
        /// <param name="lastAmountVat">lastAmountVat (required).</param>
        /// <param name="outstanding">outstanding (required).</param>
        /// <param name="failedAttempts">failedAttempts (required).</param>
        public TransactionAgreement(string agreementId = default(string), decimal itemId = default(decimal), string status = default(string), string period = default(string), decimal frequency = default(decimal), string billingType = default(string), string startDate = default(string), string endDate = default(string), decimal recurringAmt = default(decimal), string currency = default(string), string timeCreated = default(string), string nextPayment = default(string), string lastPayment = default(string), decimal lastAmount = default(decimal), decimal lastAmountVat = default(decimal), decimal outstanding = default(decimal), decimal failedAttempts = default(decimal))
        {
            // to ensure "agreementId" is required (not null)
            if (agreementId == null)
            {
                throw new ArgumentNullException("agreementId is a required property for TransactionAgreement and cannot be null");
            }
            this.AgreementId = agreementId;
            this.ItemId = itemId;
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for TransactionAgreement and cannot be null");
            }
            this.Status = status;
            // to ensure "period" is required (not null)
            if (period == null)
            {
                throw new ArgumentNullException("period is a required property for TransactionAgreement and cannot be null");
            }
            this.Period = period;
            this.Frequency = frequency;
            // to ensure "billingType" is required (not null)
            if (billingType == null)
            {
                throw new ArgumentNullException("billingType is a required property for TransactionAgreement and cannot be null");
            }
            this.BillingType = billingType;
            // to ensure "startDate" is required (not null)
            if (startDate == null)
            {
                throw new ArgumentNullException("startDate is a required property for TransactionAgreement and cannot be null");
            }
            this.StartDate = startDate;
            // to ensure "endDate" is required (not null)
            if (endDate == null)
            {
                throw new ArgumentNullException("endDate is a required property for TransactionAgreement and cannot be null");
            }
            this.EndDate = endDate;
            this.RecurringAmt = recurringAmt;
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for TransactionAgreement and cannot be null");
            }
            this.Currency = currency;
            // to ensure "timeCreated" is required (not null)
            if (timeCreated == null)
            {
                throw new ArgumentNullException("timeCreated is a required property for TransactionAgreement and cannot be null");
            }
            this.TimeCreated = timeCreated;
            // to ensure "nextPayment" is required (not null)
            if (nextPayment == null)
            {
                throw new ArgumentNullException("nextPayment is a required property for TransactionAgreement and cannot be null");
            }
            this.NextPayment = nextPayment;
            // to ensure "lastPayment" is required (not null)
            if (lastPayment == null)
            {
                throw new ArgumentNullException("lastPayment is a required property for TransactionAgreement and cannot be null");
            }
            this.LastPayment = lastPayment;
            this.LastAmount = lastAmount;
            this.LastAmountVat = lastAmountVat;
            this.Outstanding = outstanding;
            this.FailedAttempts = failedAttempts;
        }

        /// <summary>
        /// Gets or Sets AgreementId
        /// </summary>
        [DataMember(Name = "agreementId", IsRequired = true, EmitDefaultValue = true)]
        public string AgreementId { get; set; }

        /// <summary>
        /// Gets or Sets ItemId
        /// </summary>
        [DataMember(Name = "itemId", IsRequired = true, EmitDefaultValue = true)]
        public decimal ItemId { get; set; }

        /// <summary>
        /// This is NOT TransactionStatus, but whatever Steam return.
        /// </summary>
        /// <value>This is NOT TransactionStatus, but whatever Steam return.</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name = "period", IsRequired = true, EmitDefaultValue = true)]
        public string Period { get; set; }

        /// <summary>
        /// Gets or Sets Frequency
        /// </summary>
        [DataMember(Name = "frequency", IsRequired = true, EmitDefaultValue = true)]
        public decimal Frequency { get; set; }

        /// <summary>
        /// Gets or Sets BillingType
        /// </summary>
        [DataMember(Name = "billingType", IsRequired = true, EmitDefaultValue = true)]
        public string BillingType { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", IsRequired = true, EmitDefaultValue = true)]
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "endDate", IsRequired = true, EmitDefaultValue = true)]
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or Sets RecurringAmt
        /// </summary>
        [DataMember(Name = "recurringAmt", IsRequired = true, EmitDefaultValue = true)]
        public decimal RecurringAmt { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets TimeCreated
        /// </summary>
        [DataMember(Name = "timeCreated", IsRequired = true, EmitDefaultValue = true)]
        public string TimeCreated { get; set; }

        /// <summary>
        /// Gets or Sets NextPayment
        /// </summary>
        [DataMember(Name = "nextPayment", IsRequired = true, EmitDefaultValue = true)]
        public string NextPayment { get; set; }

        /// <summary>
        /// Gets or Sets LastPayment
        /// </summary>
        [DataMember(Name = "lastPayment", IsRequired = true, EmitDefaultValue = true)]
        public string LastPayment { get; set; }

        /// <summary>
        /// Gets or Sets LastAmount
        /// </summary>
        [DataMember(Name = "lastAmount", IsRequired = true, EmitDefaultValue = true)]
        public decimal LastAmount { get; set; }

        /// <summary>
        /// Gets or Sets LastAmountVat
        /// </summary>
        [DataMember(Name = "lastAmountVat", IsRequired = true, EmitDefaultValue = true)]
        public decimal LastAmountVat { get; set; }

        /// <summary>
        /// Gets or Sets Outstanding
        /// </summary>
        [DataMember(Name = "outstanding", IsRequired = true, EmitDefaultValue = true)]
        public decimal Outstanding { get; set; }

        /// <summary>
        /// Gets or Sets FailedAttempts
        /// </summary>
        [DataMember(Name = "failedAttempts", IsRequired = true, EmitDefaultValue = true)]
        public decimal FailedAttempts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionAgreement {\n");
            sb.Append("  AgreementId: ").Append(AgreementId).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  BillingType: ").Append(BillingType).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  RecurringAmt: ").Append(RecurringAmt).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  TimeCreated: ").Append(TimeCreated).Append("\n");
            sb.Append("  NextPayment: ").Append(NextPayment).Append("\n");
            sb.Append("  LastPayment: ").Append(LastPayment).Append("\n");
            sb.Append("  LastAmount: ").Append(LastAmount).Append("\n");
            sb.Append("  LastAmountVat: ").Append(LastAmountVat).Append("\n");
            sb.Append("  Outstanding: ").Append(Outstanding).Append("\n");
            sb.Append("  FailedAttempts: ").Append(FailedAttempts).Append("\n");
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
            return this.Equals(input as TransactionAgreement);
        }

        /// <summary>
        /// Returns true if TransactionAgreement instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionAgreement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionAgreement input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreementId == input.AgreementId ||
                    (this.AgreementId != null &&
                    this.AgreementId.Equals(input.AgreementId))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    this.ItemId.Equals(input.ItemId)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    this.Frequency.Equals(input.Frequency)
                ) && 
                (
                    this.BillingType == input.BillingType ||
                    (this.BillingType != null &&
                    this.BillingType.Equals(input.BillingType))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.RecurringAmt == input.RecurringAmt ||
                    this.RecurringAmt.Equals(input.RecurringAmt)
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.TimeCreated == input.TimeCreated ||
                    (this.TimeCreated != null &&
                    this.TimeCreated.Equals(input.TimeCreated))
                ) && 
                (
                    this.NextPayment == input.NextPayment ||
                    (this.NextPayment != null &&
                    this.NextPayment.Equals(input.NextPayment))
                ) && 
                (
                    this.LastPayment == input.LastPayment ||
                    (this.LastPayment != null &&
                    this.LastPayment.Equals(input.LastPayment))
                ) && 
                (
                    this.LastAmount == input.LastAmount ||
                    this.LastAmount.Equals(input.LastAmount)
                ) && 
                (
                    this.LastAmountVat == input.LastAmountVat ||
                    this.LastAmountVat.Equals(input.LastAmountVat)
                ) && 
                (
                    this.Outstanding == input.Outstanding ||
                    this.Outstanding.Equals(input.Outstanding)
                ) && 
                (
                    this.FailedAttempts == input.FailedAttempts ||
                    this.FailedAttempts.Equals(input.FailedAttempts)
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
                if (this.AgreementId != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ItemId.GetHashCode();
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Period != null)
                {
                    hashCode = (hashCode * 59) + this.Period.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Frequency.GetHashCode();
                if (this.BillingType != null)
                {
                    hashCode = (hashCode * 59) + this.BillingType.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RecurringAmt.GetHashCode();
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.TimeCreated != null)
                {
                    hashCode = (hashCode * 59) + this.TimeCreated.GetHashCode();
                }
                if (this.NextPayment != null)
                {
                    hashCode = (hashCode * 59) + this.NextPayment.GetHashCode();
                }
                if (this.LastPayment != null)
                {
                    hashCode = (hashCode * 59) + this.LastPayment.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LastAmount.GetHashCode();
                hashCode = (hashCode * 59) + this.LastAmountVat.GetHashCode();
                hashCode = (hashCode * 59) + this.Outstanding.GetHashCode();
                hashCode = (hashCode * 59) + this.FailedAttempts.GetHashCode();
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
            // AgreementId (string) minLength
            if (this.AgreementId != null && this.AgreementId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AgreementId, length must be greater than 1.", new [] { "AgreementId" });
            }

            // Status (string) minLength
            if (this.Status != null && this.Status.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Status, length must be greater than 1.", new [] { "Status" });
            }

            // Period (string) minLength
            if (this.Period != null && this.Period.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Period, length must be greater than 1.", new [] { "Period" });
            }

            // BillingType (string) minLength
            if (this.BillingType != null && this.BillingType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BillingType, length must be greater than 1.", new [] { "BillingType" });
            }

            // StartDate (string) minLength
            if (this.StartDate != null && this.StartDate.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StartDate, length must be greater than 1.", new [] { "StartDate" });
            }

            // EndDate (string) minLength
            if (this.EndDate != null && this.EndDate.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EndDate, length must be greater than 1.", new [] { "EndDate" });
            }

            // Currency (string) minLength
            if (this.Currency != null && this.Currency.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, length must be greater than 1.", new [] { "Currency" });
            }

            // TimeCreated (string) minLength
            if (this.TimeCreated != null && this.TimeCreated.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TimeCreated, length must be greater than 1.", new [] { "TimeCreated" });
            }

            // NextPayment (string) minLength
            if (this.NextPayment != null && this.NextPayment.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NextPayment, length must be greater than 1.", new [] { "NextPayment" });
            }

            // LastPayment (string) minLength
            if (this.LastPayment != null && this.LastPayment.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastPayment, length must be greater than 1.", new [] { "LastPayment" });
            }

            yield break;
        }
    }

}
