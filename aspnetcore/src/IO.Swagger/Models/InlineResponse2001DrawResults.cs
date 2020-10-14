/*
 * S2S RNG API
 *
 * Szrek2Solutions Random Number Generator API
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class InlineResponse2001DrawResults : IEquatable<InlineResponse2001DrawResults>
    { 
        /// <summary>
        /// Client&#x27;s unique identifier for this draw request
        /// </summary>
        /// <value>Client&#x27;s unique identifier for this draw request</value>
        [DataMember(Name="clientRequestId")]
        public string ClientRequestId { get; set; }

        /// <summary>
        /// Gets or Sets DrawStatus
        /// </summary>
        [Required]
        [DataMember(Name="drawStatus")]
        public Status DrawStatus { get; set; }

        /// <summary>
        /// Identifier of the product definition drawn
        /// </summary>
        /// <value>Identifier of the product definition drawn</value>
        [DataMember(Name="productId")]
        public int? ProductId { get; set; }

        /// <summary>
        /// Timestamp of the draw
        /// </summary>
        /// <value>Timestamp of the draw</value>
        [DataMember(Name="drawTime")]
        public DateTime? DrawTime { get; set; }

        /// <summary>
        /// Unique record identifier for the draw
        /// </summary>
        /// <value>Unique record identifier for the draw</value>
        [DataMember(Name="recordId")]
        public string RecordId { get; set; }

        /// <summary>
        /// Numbers drawn
        /// </summary>
        /// <value>Numbers drawn</value>
        [DataMember(Name="sets")]
        public List<List<int?>> Sets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2001DrawResults {\n");
            sb.Append("  ClientRequestId: ").Append(ClientRequestId).Append("\n");
            sb.Append("  DrawStatus: ").Append(DrawStatus).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  DrawTime: ").Append(DrawTime).Append("\n");
            sb.Append("  RecordId: ").Append(RecordId).Append("\n");
            sb.Append("  Sets: ").Append(Sets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((InlineResponse2001DrawResults)obj);
        }

        /// <summary>
        /// Returns true if InlineResponse2001DrawResults instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2001DrawResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2001DrawResults other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ClientRequestId == other.ClientRequestId ||
                    ClientRequestId != null &&
                    ClientRequestId.Equals(other.ClientRequestId)
                ) && 
                (
                    DrawStatus == other.DrawStatus ||
                    DrawStatus != null &&
                    DrawStatus.Equals(other.DrawStatus)
                ) && 
                (
                    ProductId == other.ProductId ||
                    ProductId != null &&
                    ProductId.Equals(other.ProductId)
                ) && 
                (
                    DrawTime == other.DrawTime ||
                    DrawTime != null &&
                    DrawTime.Equals(other.DrawTime)
                ) && 
                (
                    RecordId == other.RecordId ||
                    RecordId != null &&
                    RecordId.Equals(other.RecordId)
                ) && 
                (
                    Sets == other.Sets ||
                    Sets != null &&
                    Sets.SequenceEqual(other.Sets)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (ClientRequestId != null)
                    hashCode = hashCode * 59 + ClientRequestId.GetHashCode();
                    if (DrawStatus != null)
                    hashCode = hashCode * 59 + DrawStatus.GetHashCode();
                    if (ProductId != null)
                    hashCode = hashCode * 59 + ProductId.GetHashCode();
                    if (DrawTime != null)
                    hashCode = hashCode * 59 + DrawTime.GetHashCode();
                    if (RecordId != null)
                    hashCode = hashCode * 59 + RecordId.GetHashCode();
                    if (Sets != null)
                    hashCode = hashCode * 59 + Sets.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InlineResponse2001DrawResults left, InlineResponse2001DrawResults right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponse2001DrawResults left, InlineResponse2001DrawResults right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
