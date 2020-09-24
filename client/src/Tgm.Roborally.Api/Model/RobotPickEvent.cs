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
    /// Triggered when a robot is assigned to a player
    /// </summary>
    [DataContract]
    public partial class RobotPickEvent :  IEquatable<RobotPickEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RobotPickEvent" /> class.
        /// </summary>
        /// <param name="player">This id uniquely identifys the player (in a game).   **Not** to be confused with the &#x60;uid&#x60; which is used for authentication.</param>
        /// <param name="robot">The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value will be autogenerated by the api and is read only.</param>
        public RobotPickEvent(int player = default(int), int robot = default(int))
        {
            this.Player = player;
            this.Robot = robot;
        }
        
        /// <summary>
        /// This id uniquely identifys the player (in a game).   **Not** to be confused with the &#x60;uid&#x60; which is used for authentication
        /// </summary>
        /// <value>This id uniquely identifys the player (in a game).   **Not** to be confused with the &#x60;uid&#x60; which is used for authentication</value>
        [DataMember(Name="player", EmitDefaultValue=false)]
        public int Player { get; set; }

        /// <summary>
        /// The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value will be autogenerated by the api and is read only
        /// </summary>
        /// <value>The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value will be autogenerated by the api and is read only</value>
        [DataMember(Name="robot", EmitDefaultValue=false)]
        public int Robot { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RobotPickEvent {\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  Robot: ").Append(Robot).Append("\n");
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
            return this.Equals(input as RobotPickEvent);
        }

        /// <summary>
        /// Returns true if RobotPickEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of RobotPickEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RobotPickEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Player == input.Player ||
                    this.Player.Equals(input.Player)
                ) && 
                (
                    this.Robot == input.Robot ||
                    this.Robot.Equals(input.Robot)
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
                hashCode = hashCode * 59 + this.Player.GetHashCode();
                hashCode = hashCode * 59 + this.Robot.GetHashCode();
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
            // Player (int) maximum
            if(this.Player > (int)8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Player, must be a value less than or equal to 8.", new [] { "Player" });
            }

            // Player (int) minimum
            if(this.Player < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Player, must be a value greater than or equal to 0.", new [] { "Player" });
            }

            // Robot (int) minimum
            if(this.Robot < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Robot, must be a value greater than or equal to 0.", new [] { "Robot" });
            }

            yield break;
        }
    }

}
