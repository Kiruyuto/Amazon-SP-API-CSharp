/* 
 * The Selling Partner API for FBA inbound operations.
 *
 * The Selling Partner API for Fulfillment By Amazon (FBA) Inbound. The FBA Inbound API enables building inbound workflows to create, manage, and send shipments into Amazon's fulfillment network. The API has interoperability with the Send-to-Amazon user interface.
 *
 * OpenAPI spec version: 2024-03-20
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInboundv20240320
{
    /// <summary>
    /// Representation of a location used within the inbounding experience.
    /// </summary>
    [DataContract]
    public partial class Region :  IEquatable<Region>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Region" /> class.
        /// </summary>
        /// <param name="countryCode">ISO 3166 standard alpha-2 country code..</param>
        /// <param name="state">State..</param>
        /// <param name="warehouseId">An identifier for a warehouse, such as a FC, IXD, upstream storage..</param>
        public Region(string countryCode = default(string), string state = default(string), string warehouseId = default(string))
        {
            this.CountryCode = countryCode;
            this.State = state;
            this.WarehouseId = warehouseId;
        }
        
        /// <summary>
        /// ISO 3166 standard alpha-2 country code.
        /// </summary>
        /// <value>ISO 3166 standard alpha-2 country code.</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// State.
        /// </summary>
        /// <value>State.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// An identifier for a warehouse, such as a FC, IXD, upstream storage.
        /// </summary>
        /// <value>An identifier for a warehouse, such as a FC, IXD, upstream storage.</value>
        [DataMember(Name="warehouseId", EmitDefaultValue=false)]
        public string WarehouseId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Region {\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Region);
        }

        /// <summary>
        /// Returns true if Region instances are equal
        /// </summary>
        /// <param name="input">Instance of Region to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Region input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.WarehouseId == input.WarehouseId ||
                    (this.WarehouseId != null &&
                    this.WarehouseId.Equals(input.WarehouseId))
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
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.WarehouseId != null)
                    hashCode = hashCode * 59 + this.WarehouseId.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // CountryCode (string) maxLength
            if(this.CountryCode != null && this.CountryCode.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryCode, length must be less than 1024.", new [] { "CountryCode" });
            }

            // CountryCode (string) minLength
            if(this.CountryCode != null && this.CountryCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryCode, length must be greater than 1.", new [] { "CountryCode" });
            }

            // State (string) maxLength
            if(this.State != null && this.State.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for State, length must be less than 1024.", new [] { "State" });
            }

            // State (string) minLength
            if(this.State != null && this.State.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for State, length must be greater than 1.", new [] { "State" });
            }

            // WarehouseId (string) maxLength
            if(this.WarehouseId != null && this.WarehouseId.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WarehouseId, length must be less than 1024.", new [] { "WarehouseId" });
            }

            // WarehouseId (string) minLength
            if(this.WarehouseId != null && this.WarehouseId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WarehouseId, length must be greater than 1.", new [] { "WarehouseId" });
            }

            yield break;
        }
    }

}