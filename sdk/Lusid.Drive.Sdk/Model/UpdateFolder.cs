/* 
 * FINBOURNE Drive API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.230
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Lusid.Drive.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Drive.Sdk.Model
{
    /// <summary>
    /// DTO representing the update of the name or path of a file
    /// </summary>
    [DataContract]
    public partial class UpdateFolder :  IEquatable<UpdateFolder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFolder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateFolder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFolder" /> class.
        /// </summary>
        /// <param name="path">Path of the updated folder (required).</param>
        /// <param name="name">Name of the updated folder (required).</param>
        public UpdateFolder(string path = default(string), string name = default(string))
        {
            // to ensure "path" is required (not null)
            if (path == null)
            {
                throw new InvalidDataException("path is a required property for UpdateFolder and cannot be null");
            }
            else
            {
                this.Path = path;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for UpdateFolder and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
        }
        
        /// <summary>
        /// Path of the updated folder
        /// </summary>
        /// <value>Path of the updated folder</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Name of the updated folder
        /// </summary>
        /// <value>Name of the updated folder</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateFolder {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as UpdateFolder);
        }

        /// <summary>
        /// Returns true if UpdateFolder instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateFolder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateFolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }

}
