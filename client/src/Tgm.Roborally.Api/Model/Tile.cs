/* 
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: 0.1.0
 * Contact: nbrugger@student.tgm.ac.at
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
using OpenAPIDateConverter = Tgm.Roborally.Api.Client.OpenAPIDateConverter;

namespace Tgm.Roborally.Api.Model
{
    /// <summary>
    /// A tile is a square at the Game field&lt;br&gt; **Note:**  * &#x60;direction&#x60; is only aviable for belts * properties with a &#x60;rotator-&#x60; prefix are only aviable for rotator (parts)
    /// </summary>
    [DataContract]
    public partial class Tile :  IEquatable<Tile>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TileType Type { get; set; }
        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public Direction? Direction { get; set; }
        /// <summary>
        /// Gets or Sets RotatorDirection
        /// </summary>
        [DataMember(Name="rotator-direction", EmitDefaultValue=false)]
        public Rotation? RotatorDirection { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Tile" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Tile() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Tile" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="empty">If there is no player at the tile this is true.</param>
        /// <param name="direction">direction.</param>
        /// <param name="rotatorDirection">rotatorDirection.</param>
        public Tile(TileType type = default(TileType), bool empty = default(bool), Direction direction = default(Direction), Rotation rotatorDirection = default(Rotation))
        {
            // to ensure "type" is required (not null)
            this.Type = type;
            this.Empty = empty;
            this.Direction = direction;
            this.RotatorDirection = rotatorDirection;
        }
        
        /// <summary>
        /// If there is no player at the tile this is true
        /// </summary>
        /// <value>If there is no player at the tile this is true</value>
        [DataMember(Name="empty", EmitDefaultValue=false)]
        public bool Empty { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tile {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Empty: ").Append(Empty).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  RotatorDirection: ").Append(RotatorDirection).Append("\n");
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
            return this.Equals(input as Tile);
        }

        /// <summary>
        /// Returns true if Tile instances are equal
        /// </summary>
        /// <param name="input">Instance of Tile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Empty == input.Empty ||
                    this.Empty.Equals(input.Empty)
                ) && 
                (
                    this.Direction == input.Direction ||
                    this.Direction.Equals(input.Direction)
                ) && 
                (
                    this.RotatorDirection == input.RotatorDirection ||
                    this.RotatorDirection.Equals(input.RotatorDirection)
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.Empty.GetHashCode();
                hashCode = hashCode * 59 + this.Direction.GetHashCode();
                hashCode = hashCode * 59 + this.RotatorDirection.GetHashCode();
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