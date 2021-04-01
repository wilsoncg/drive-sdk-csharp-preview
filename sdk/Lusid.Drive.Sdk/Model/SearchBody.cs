/* 
 * FINBOURNE Drive API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.200
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
    /// DTO representing the search query
    /// </summary>
    [DataContract]
    public partial class SearchBody :  IEquatable<SearchBody>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchBody" /> class.
        /// </summary>
        /// <param name="withPath">Optional path field to limit the search to result with a matching (case insensitive) path.</param>
        /// <param name="name">Name of the file or folder to be searched (required).</param>
        public SearchBody(string withPath = default(string), string name = default(string))
        {
            this.WithPath = withPath;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for SearchBody and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            this.WithPath = withPath;
        }
        
        /// <summary>
        /// Optional path field to limit the search to result with a matching (case insensitive) path
        /// </summary>
        /// <value>Optional path field to limit the search to result with a matching (case insensitive) path</value>
        [DataMember(Name="withPath", EmitDefaultValue=true)]
        public string WithPath { get; set; }

        /// <summary>
        /// Name of the file or folder to be searched
        /// </summary>
        /// <value>Name of the file or folder to be searched</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchBody {\n");
            sb.Append("  WithPath: ").Append(WithPath).Append("\n");
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
            return this.Equals(input as SearchBody);
        }

        /// <summary>
        /// Returns true if SearchBody instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WithPath == input.WithPath ||
                    (this.WithPath != null &&
                    this.WithPath.Equals(input.WithPath))
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
                if (this.WithPath != null)
                    hashCode = hashCode * 59 + this.WithPath.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }

}
