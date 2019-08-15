/* 
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// TypeHolderExample
    /// </summary>
    [DataContract]
    public partial class TypeHolderExample :  IEquatable<TypeHolderExample>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TypeHolderExample" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TypeHolderExample() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TypeHolderExample" /> class.
        /// </summary>
        /// <param name="stringItem">stringItem (required).</param>
        /// <param name="numberItem">numberItem (required).</param>
        /// <param name="integerItem">integerItem (required).</param>
        /// <param name="boolItem">boolItem (required).</param>
        /// <param name="arrayItem">arrayItem (required).</param>
        public TypeHolderExample(string stringItem = default(string), decimal numberItem = default(decimal), int integerItem = default(int), bool boolItem = default(bool), List<int> arrayItem = default(List<int>))
        {
            // to ensure "stringItem" is required (not null)
            if (stringItem == null)
            {
                throw new InvalidDataException("stringItem is a required property for TypeHolderExample and cannot be null");
            }
            else
            {
                this.StringItem = stringItem;
            }
            
            // to ensure "numberItem" is required (not null)
            if (numberItem == null)
            {
                throw new InvalidDataException("numberItem is a required property for TypeHolderExample and cannot be null");
            }
            else
            {
                this.NumberItem = numberItem;
            }
            
            // to ensure "integerItem" is required (not null)
            if (integerItem == null)
            {
                throw new InvalidDataException("integerItem is a required property for TypeHolderExample and cannot be null");
            }
            else
            {
                this.IntegerItem = integerItem;
            }
            
            // to ensure "boolItem" is required (not null)
            if (boolItem == null)
            {
                throw new InvalidDataException("boolItem is a required property for TypeHolderExample and cannot be null");
            }
            else
            {
                this.BoolItem = boolItem;
            }
            
            // to ensure "arrayItem" is required (not null)
            if (arrayItem == null)
            {
                throw new InvalidDataException("arrayItem is a required property for TypeHolderExample and cannot be null");
            }
            else
            {
                this.ArrayItem = arrayItem;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets StringItem
        /// </summary>
        [DataMember(Name="string_item", EmitDefaultValue=false)]
        public string StringItem { get; set; }

        /// <summary>
        /// Gets or Sets NumberItem
        /// </summary>
        [DataMember(Name="number_item", EmitDefaultValue=false)]
        public decimal NumberItem { get; set; }

        /// <summary>
        /// Gets or Sets IntegerItem
        /// </summary>
        [DataMember(Name="integer_item", EmitDefaultValue=false)]
        public int IntegerItem { get; set; }

        /// <summary>
        /// Gets or Sets BoolItem
        /// </summary>
        [DataMember(Name="bool_item", EmitDefaultValue=false)]
        public bool BoolItem { get; set; }

        /// <summary>
        /// Gets or Sets ArrayItem
        /// </summary>
        [DataMember(Name="array_item", EmitDefaultValue=false)]
        public List<int> ArrayItem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TypeHolderExample {\n");
            sb.Append("  StringItem: ").Append(StringItem).Append("\n");
            sb.Append("  NumberItem: ").Append(NumberItem).Append("\n");
            sb.Append("  IntegerItem: ").Append(IntegerItem).Append("\n");
            sb.Append("  BoolItem: ").Append(BoolItem).Append("\n");
            sb.Append("  ArrayItem: ").Append(ArrayItem).Append("\n");
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
            return this.Equals(input as TypeHolderExample);
        }

        /// <summary>
        /// Returns true if TypeHolderExample instances are equal
        /// </summary>
        /// <param name="input">Instance of TypeHolderExample to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TypeHolderExample input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StringItem == input.StringItem ||
                    (this.StringItem != null &&
                    this.StringItem.Equals(input.StringItem))
                ) && 
                (
                    this.NumberItem == input.NumberItem ||
                    (this.NumberItem != null &&
                    this.NumberItem.Equals(input.NumberItem))
                ) && 
                (
                    this.IntegerItem == input.IntegerItem ||
                    (this.IntegerItem != null &&
                    this.IntegerItem.Equals(input.IntegerItem))
                ) && 
                (
                    this.BoolItem == input.BoolItem ||
                    (this.BoolItem != null &&
                    this.BoolItem.Equals(input.BoolItem))
                ) && 
                (
                    this.ArrayItem == input.ArrayItem ||
                    this.ArrayItem != null &&
                    input.ArrayItem != null &&
                    this.ArrayItem.SequenceEqual(input.ArrayItem)
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
                if (this.StringItem != null)
                    hashCode = hashCode * 59 + this.StringItem.GetHashCode();
                if (this.NumberItem != null)
                    hashCode = hashCode * 59 + this.NumberItem.GetHashCode();
                if (this.IntegerItem != null)
                    hashCode = hashCode * 59 + this.IntegerItem.GetHashCode();
                if (this.BoolItem != null)
                    hashCode = hashCode * 59 + this.BoolItem.GetHashCode();
                if (this.ArrayItem != null)
                    hashCode = hashCode * 59 + this.ArrayItem.GetHashCode();
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
            yield break;
        }
    }

}
