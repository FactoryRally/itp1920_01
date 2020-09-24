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
    /// A player attending in a game. #### Warning This is **not** permanent. It is created and removed with the game (or with you joining and leaving the game)
    /// </summary>
    [DataContract]
    public partial class Player :  IEquatable<Player>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Player" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Player() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Player" /> class.
        /// </summary>
        /// <param name="id">This id uniquely identifys the player (in a game).   **Not** to be confused with the &#x60;uid&#x60; which is used for authentication (required).</param>
        /// <param name="controlledEntities">The list of entities controlled by this player (required).</param>
        /// <param name="onTurn">Îf this is true rhe player is able to interact at the moment (default to false).</param>
        /// <param name="active">Defines if the player is actively playing. If this is false the player does random moves. This is only false if the player disconnects (default to true).</param>
        public Player(int id = default(int), List<int> controlledEntities = default(List<int>), bool onTurn = false, bool active = true)
        {
            this.Id = id;
            // to ensure "controlledEntities" is required (not null)
            this.ControlledEntities = controlledEntities ?? throw new ArgumentNullException("controlledEntities is a required property for Player and cannot be null");
            this.OnTurn = onTurn;
            this.Active = active;
        }
        
        /// <summary>
        /// This id uniquely identifys the player (in a game).   **Not** to be confused with the &#x60;uid&#x60; which is used for authentication
        /// </summary>
        /// <value>This id uniquely identifys the player (in a game).   **Not** to be confused with the &#x60;uid&#x60; which is used for authentication</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// The list of entities controlled by this player
        /// </summary>
        /// <value>The list of entities controlled by this player</value>
        [DataMember(Name="controlled_entities", EmitDefaultValue=false)]
        public List<int> ControlledEntities { get; set; }

        /// <summary>
        /// Îf this is true rhe player is able to interact at the moment
        /// </summary>
        /// <value>Îf this is true rhe player is able to interact at the moment</value>
        [DataMember(Name="on-turn", EmitDefaultValue=false)]
        public bool OnTurn { get; set; }

        /// <summary>
        /// Defines if the player is actively playing. If this is false the player does random moves. This is only false if the player disconnects
        /// </summary>
        /// <value>Defines if the player is actively playing. If this is false the player does random moves. This is only false if the player disconnects</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool Active { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Player {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ControlledEntities: ").Append(ControlledEntities).Append("\n");
            sb.Append("  OnTurn: ").Append(OnTurn).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
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
            return this.Equals(input as Player);
        }

        /// <summary>
        /// Returns true if Player instances are equal
        /// </summary>
        /// <param name="input">Instance of Player to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Player input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.ControlledEntities == input.ControlledEntities ||
                    this.ControlledEntities != null &&
                    input.ControlledEntities != null &&
                    this.ControlledEntities.SequenceEqual(input.ControlledEntities)
                ) && 
                (
                    this.OnTurn == input.OnTurn ||
                    this.OnTurn.Equals(input.OnTurn)
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ControlledEntities != null)
                    hashCode = hashCode * 59 + this.ControlledEntities.GetHashCode();
                hashCode = hashCode * 59 + this.OnTurn.GetHashCode();
                hashCode = hashCode * 59 + this.Active.GetHashCode();
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
            // Id (int) maximum
            if(this.Id > (int)8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must be a value less than or equal to 8.", new [] { "Id" });
            }

            // Id (int) minimum
            if(this.Id < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must be a value greater than or equal to 0.", new [] { "Id" });
            }

            yield break;
        }
    }

}
