/* 
 * s4s-full
 *
 * description
 *
 * OpenAPI spec version: stable
 * Contact: rui.p.oliveira@impactinglabs.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Model description
    /// </summary>
    [DataContract]
    public partial class CustomerBill :  IEquatable<CustomerBill>
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum S3Forgiven for "S3Forgiven"
            /// </summary>
            [EnumMember(Value = "S3Forgiven")]
            S3Forgiven,
            
            /// <summary>
            /// Enum S4Paid for "S4Paid"
            /// </summary>
            [EnumMember(Value = "S4Paid")]
            S4Paid,
            
            /// <summary>
            /// Enum S1WaitingPayment for "S1WaitingPayment"
            /// </summary>
            [EnumMember(Value = "S1WaitingPayment")]
            S1WaitingPayment,
            
            /// <summary>
            /// Enum S2WaitingPlanExpiration for "S2WaitingPlanExpiration"
            /// </summary>
            [EnumMember(Value = "S2WaitingPlanExpiration")]
            S2WaitingPlanExpiration
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerBill" /> class.
        /// </summary>
        /// <param name="CustomerPlanId">CustomerPlanId.</param>
        /// <param name="CreationTimespan">CreationTimespan.</param>
        /// <param name="LasUpdateTimespan">LasUpdateTimespan.</param>
        /// <param name="CustomerId">CustomerId.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Status">Status.</param>
        /// <param name="TotalInPayment">TotalInPayment.</param>
        /// <param name="PlanId">PlanId.</param>
        public CustomerBill(string CustomerPlanId = null, long? CreationTimespan = null, long? LasUpdateTimespan = null, string CustomerId = null, string Id = null, StatusEnum? Status = null, Dictionary<string, long?> TotalInPayment = null, string PlanId = null)
        {
            this.CustomerPlanId = CustomerPlanId;
            this.CreationTimespan = CreationTimespan;
            this.LasUpdateTimespan = LasUpdateTimespan;
            this.CustomerId = CustomerId;
            this.Id = Id;
            this.Status = Status;
            this.TotalInPayment = TotalInPayment;
            this.PlanId = PlanId;
        }
        
        /// <summary>
        /// Gets or Sets CustomerPlanId
        /// </summary>
        [DataMember(Name="customerPlanId", EmitDefaultValue=false)]
        public string CustomerPlanId { get; set; }
        /// <summary>
        /// Gets or Sets CreationTimespan
        /// </summary>
        [DataMember(Name="creationTimespan", EmitDefaultValue=false)]
        public long? CreationTimespan { get; set; }
        /// <summary>
        /// Gets or Sets LasUpdateTimespan
        /// </summary>
        [DataMember(Name="lasUpdateTimespan", EmitDefaultValue=false)]
        public long? LasUpdateTimespan { get; set; }
        /// <summary>
        /// Gets or Sets CustomerId
        /// </summary>
        [DataMember(Name="customerId", EmitDefaultValue=false)]
        public string CustomerId { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets TotalInPayment
        /// </summary>
        [DataMember(Name="totalInPayment", EmitDefaultValue=false)]
        public Dictionary<string, long?> TotalInPayment { get; set; }
        /// <summary>
        /// Gets or Sets PlanId
        /// </summary>
        [DataMember(Name="planId", EmitDefaultValue=false)]
        public string PlanId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerBill {\n");
            sb.Append("  CustomerPlanId: ").Append(CustomerPlanId).Append("\n");
            sb.Append("  CreationTimespan: ").Append(CreationTimespan).Append("\n");
            sb.Append("  LasUpdateTimespan: ").Append(LasUpdateTimespan).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TotalInPayment: ").Append(TotalInPayment).Append("\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CustomerBill);
        }

        /// <summary>
        /// Returns true if CustomerBill instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomerBill to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerBill other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CustomerPlanId == other.CustomerPlanId ||
                    this.CustomerPlanId != null &&
                    this.CustomerPlanId.Equals(other.CustomerPlanId)
                ) && 
                (
                    this.CreationTimespan == other.CreationTimespan ||
                    this.CreationTimespan != null &&
                    this.CreationTimespan.Equals(other.CreationTimespan)
                ) && 
                (
                    this.LasUpdateTimespan == other.LasUpdateTimespan ||
                    this.LasUpdateTimespan != null &&
                    this.LasUpdateTimespan.Equals(other.LasUpdateTimespan)
                ) && 
                (
                    this.CustomerId == other.CustomerId ||
                    this.CustomerId != null &&
                    this.CustomerId.Equals(other.CustomerId)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.TotalInPayment == other.TotalInPayment ||
                    this.TotalInPayment != null &&
                    this.TotalInPayment.SequenceEqual(other.TotalInPayment)
                ) && 
                (
                    this.PlanId == other.PlanId ||
                    this.PlanId != null &&
                    this.PlanId.Equals(other.PlanId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.CustomerPlanId != null)
                    hash = hash * 59 + this.CustomerPlanId.GetHashCode();
                if (this.CreationTimespan != null)
                    hash = hash * 59 + this.CreationTimespan.GetHashCode();
                if (this.LasUpdateTimespan != null)
                    hash = hash * 59 + this.LasUpdateTimespan.GetHashCode();
                if (this.CustomerId != null)
                    hash = hash * 59 + this.CustomerId.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.TotalInPayment != null)
                    hash = hash * 59 + this.TotalInPayment.GetHashCode();
                if (this.PlanId != null)
                    hash = hash * 59 + this.PlanId.GetHashCode();
                return hash;
            }
        }
    }

}