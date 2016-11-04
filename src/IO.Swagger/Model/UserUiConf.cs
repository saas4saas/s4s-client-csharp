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
    public partial class UserUiConf :  IEquatable<UserUiConf>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserUiConf" /> class.
        /// </summary>
        /// <param name="GoogleClientId">GoogleClientId.</param>
        /// <param name="GoogleClientKey">GoogleClientKey.</param>
        /// <param name="LoginUrl">LoginUrl.</param>
        /// <param name="BasePath">BasePath.</param>
        /// <param name="ChangePasswordUrl">ChangePasswordUrl.</param>
        /// <param name="RegisterUrl">RegisterUrl.</param>
        /// <param name="RecoverPasswordUrl">RecoverPasswordUrl.</param>
        /// <param name="LoginHandler">LoginHandler.</param>
        /// <param name="SubscribeUrl">SubscribeUrl.</param>
        public UserUiConf(string GoogleClientId = null, string GoogleClientKey = null, string LoginUrl = null, string BasePath = null, string ChangePasswordUrl = null, string RegisterUrl = null, string RecoverPasswordUrl = null, string LoginHandler = null, string SubscribeUrl = null)
        {
            this.GoogleClientId = GoogleClientId;
            this.GoogleClientKey = GoogleClientKey;
            this.LoginUrl = LoginUrl;
            this.BasePath = BasePath;
            this.ChangePasswordUrl = ChangePasswordUrl;
            this.RegisterUrl = RegisterUrl;
            this.RecoverPasswordUrl = RecoverPasswordUrl;
            this.LoginHandler = LoginHandler;
            this.SubscribeUrl = SubscribeUrl;
        }
        
        /// <summary>
        /// Gets or Sets GoogleClientId
        /// </summary>
        [DataMember(Name="googleClientId", EmitDefaultValue=false)]
        public string GoogleClientId { get; set; }
        /// <summary>
        /// Gets or Sets GoogleClientKey
        /// </summary>
        [DataMember(Name="googleClientKey", EmitDefaultValue=false)]
        public string GoogleClientKey { get; set; }
        /// <summary>
        /// Gets or Sets LoginUrl
        /// </summary>
        [DataMember(Name="loginUrl", EmitDefaultValue=false)]
        public string LoginUrl { get; set; }
        /// <summary>
        /// Gets or Sets BasePath
        /// </summary>
        [DataMember(Name="basePath", EmitDefaultValue=false)]
        public string BasePath { get; set; }
        /// <summary>
        /// Gets or Sets ChangePasswordUrl
        /// </summary>
        [DataMember(Name="changePasswordUrl", EmitDefaultValue=false)]
        public string ChangePasswordUrl { get; set; }
        /// <summary>
        /// Gets or Sets RegisterUrl
        /// </summary>
        [DataMember(Name="registerUrl", EmitDefaultValue=false)]
        public string RegisterUrl { get; set; }
        /// <summary>
        /// Gets or Sets RecoverPasswordUrl
        /// </summary>
        [DataMember(Name="recoverPasswordUrl", EmitDefaultValue=false)]
        public string RecoverPasswordUrl { get; set; }
        /// <summary>
        /// Gets or Sets LoginHandler
        /// </summary>
        [DataMember(Name="loginHandler", EmitDefaultValue=false)]
        public string LoginHandler { get; set; }
        /// <summary>
        /// Gets or Sets SubscribeUrl
        /// </summary>
        [DataMember(Name="subscribeUrl", EmitDefaultValue=false)]
        public string SubscribeUrl { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserUiConf {\n");
            sb.Append("  GoogleClientId: ").Append(GoogleClientId).Append("\n");
            sb.Append("  GoogleClientKey: ").Append(GoogleClientKey).Append("\n");
            sb.Append("  LoginUrl: ").Append(LoginUrl).Append("\n");
            sb.Append("  BasePath: ").Append(BasePath).Append("\n");
            sb.Append("  ChangePasswordUrl: ").Append(ChangePasswordUrl).Append("\n");
            sb.Append("  RegisterUrl: ").Append(RegisterUrl).Append("\n");
            sb.Append("  RecoverPasswordUrl: ").Append(RecoverPasswordUrl).Append("\n");
            sb.Append("  LoginHandler: ").Append(LoginHandler).Append("\n");
            sb.Append("  SubscribeUrl: ").Append(SubscribeUrl).Append("\n");
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
            return this.Equals(obj as UserUiConf);
        }

        /// <summary>
        /// Returns true if UserUiConf instances are equal
        /// </summary>
        /// <param name="other">Instance of UserUiConf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserUiConf other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.GoogleClientId == other.GoogleClientId ||
                    this.GoogleClientId != null &&
                    this.GoogleClientId.Equals(other.GoogleClientId)
                ) && 
                (
                    this.GoogleClientKey == other.GoogleClientKey ||
                    this.GoogleClientKey != null &&
                    this.GoogleClientKey.Equals(other.GoogleClientKey)
                ) && 
                (
                    this.LoginUrl == other.LoginUrl ||
                    this.LoginUrl != null &&
                    this.LoginUrl.Equals(other.LoginUrl)
                ) && 
                (
                    this.BasePath == other.BasePath ||
                    this.BasePath != null &&
                    this.BasePath.Equals(other.BasePath)
                ) && 
                (
                    this.ChangePasswordUrl == other.ChangePasswordUrl ||
                    this.ChangePasswordUrl != null &&
                    this.ChangePasswordUrl.Equals(other.ChangePasswordUrl)
                ) && 
                (
                    this.RegisterUrl == other.RegisterUrl ||
                    this.RegisterUrl != null &&
                    this.RegisterUrl.Equals(other.RegisterUrl)
                ) && 
                (
                    this.RecoverPasswordUrl == other.RecoverPasswordUrl ||
                    this.RecoverPasswordUrl != null &&
                    this.RecoverPasswordUrl.Equals(other.RecoverPasswordUrl)
                ) && 
                (
                    this.LoginHandler == other.LoginHandler ||
                    this.LoginHandler != null &&
                    this.LoginHandler.Equals(other.LoginHandler)
                ) && 
                (
                    this.SubscribeUrl == other.SubscribeUrl ||
                    this.SubscribeUrl != null &&
                    this.SubscribeUrl.Equals(other.SubscribeUrl)
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
                if (this.GoogleClientId != null)
                    hash = hash * 59 + this.GoogleClientId.GetHashCode();
                if (this.GoogleClientKey != null)
                    hash = hash * 59 + this.GoogleClientKey.GetHashCode();
                if (this.LoginUrl != null)
                    hash = hash * 59 + this.LoginUrl.GetHashCode();
                if (this.BasePath != null)
                    hash = hash * 59 + this.BasePath.GetHashCode();
                if (this.ChangePasswordUrl != null)
                    hash = hash * 59 + this.ChangePasswordUrl.GetHashCode();
                if (this.RegisterUrl != null)
                    hash = hash * 59 + this.RegisterUrl.GetHashCode();
                if (this.RecoverPasswordUrl != null)
                    hash = hash * 59 + this.RecoverPasswordUrl.GetHashCode();
                if (this.LoginHandler != null)
                    hash = hash * 59 + this.LoginHandler.GetHashCode();
                if (this.SubscribeUrl != null)
                    hash = hash * 59 + this.SubscribeUrl.GetHashCode();
                return hash;
            }
        }
    }

}