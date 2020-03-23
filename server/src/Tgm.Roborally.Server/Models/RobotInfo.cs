/*
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: 0.1.0
 * Contact: nbrugger@student.tgm.ac.at
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Tgm.Roborally.Server.Converters;

namespace Tgm.Roborally.Server.Models
{ 
    /// <summary>
    /// Describes the state/stats of a robot
    /// </summary>
    [DataContract]
    public partial class RobotInfo : IEquatable<RobotInfo>
    {
        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [Required]
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public Direction Direction { get; set; }

        /// <summary>
        /// The default rule for names in the game
        /// </summary>
        /// <value>The default rule for names in the game</value>
        [Required]
        [RegularExpression("[A-Za-z]+[A-Za-z0-9 _-]+")]
        [StringLength(13, MinimumLength=3)]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value will be autogenerated by the api and is read only
        /// </summary>
        /// <value>The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value will be autogenerated by the api and is read only</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [Required]
        [DataMember(Name="location", EmitDefaultValue=false)]
        public Position Location { get; set; }

        /// <summary>
        /// The number of avainable energy cubes
        /// </summary>
        /// <value>The number of avainable energy cubes</value>
        [Range(0, 20)]
        [DataMember(Name="energy-cubes", EmitDefaultValue=false)]
        public int EnergyCubes { get; set; } = 3;

        /// <summary>
        /// The remaining health points
        /// </summary>
        /// <value>The remaining health points</value>
        [Range(1, 10)]
        [DataMember(Name="health", EmitDefaultValue=false)]
        public int Health { get; set; } = 10;

        /// <summary>
        /// True if the robot is not in rebooting mode
        /// </summary>
        /// <value>True if the robot is not in rebooting mode</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool Active { get; set; } = true;

        /// <summary>
        /// If the robot is in virtual mode
        /// </summary>
        /// <value>If the robot is in virtual mode</value>
        [DataMember(Name="virtual", EmitDefaultValue=false)]
        public bool Virtual { get; set; } = false;

        /// <summary>
        /// The priority of this player. Higher is more priority. 1 &#x3D; lowest. max &#x3D; number of players
        /// </summary>
        /// <value>The priority of this player. Higher is more priority. 1 &#x3D; lowest. max &#x3D; number of players</value>
        [Range(1, 8)]
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int Priority { get; set; }

        /// <summary>
        /// True if the robot is currently active (executing a register)
        /// </summary>
        /// <value>True if the robot is currently active (executing a register)</value>
        [DataMember(Name="on-turn", EmitDefaultValue=false)]
        public bool OnTurn { get; set; }

        /// <summary>
        /// True if you are the one controlling the robot
        /// </summary>
        /// <value>True if you are the one controlling the robot</value>
        [DataMember(Name="is-mine", EmitDefaultValue=false)]
        public bool IsMine { get; set; }

        /// <summary>
        /// The cards in the hand of the robot
        /// </summary>
        /// <value>The cards in the hand of the robot</value>
        [Range(0, 9)]
        [DataMember(Name="hand-cards", EmitDefaultValue=false)]
        public int HandCards { get; set; }

        /// <summary>
        /// The height level of the robot
        /// </summary>
        /// <value>The height level of the robot</value>
        [Range(0, 4)]
        [DataMember(Name="attitude", EmitDefaultValue=false)]
        public int Attitude { get; set; } = 0;

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public Robots Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RobotInfo {\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  EnergyCubes: ").Append(EnergyCubes).Append("\n");
            sb.Append("  Health: ").Append(Health).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Virtual: ").Append(Virtual).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  OnTurn: ").Append(OnTurn).Append("\n");
            sb.Append("  IsMine: ").Append(IsMine).Append("\n");
            sb.Append("  HandCards: ").Append(HandCards).Append("\n");
            sb.Append("  Attitude: ").Append(Attitude).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((RobotInfo)obj);
        }

        /// <summary>
        /// Returns true if RobotInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of RobotInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RobotInfo other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Direction == other.Direction ||
                    
                    Direction.Equals(other.Direction)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    Location == other.Location ||
                    Location != null &&
                    Location.Equals(other.Location)
                ) && 
                (
                    EnergyCubes == other.EnergyCubes ||
                    
                    EnergyCubes.Equals(other.EnergyCubes)
                ) && 
                (
                    Health == other.Health ||
                    
                    Health.Equals(other.Health)
                ) && 
                (
                    Active == other.Active ||
                    
                    Active.Equals(other.Active)
                ) && 
                (
                    Virtual == other.Virtual ||
                    
                    Virtual.Equals(other.Virtual)
                ) && 
                (
                    Priority == other.Priority ||
                    
                    Priority.Equals(other.Priority)
                ) && 
                (
                    OnTurn == other.OnTurn ||
                    
                    OnTurn.Equals(other.OnTurn)
                ) && 
                (
                    IsMine == other.IsMine ||
                    
                    IsMine.Equals(other.IsMine)
                ) && 
                (
                    HandCards == other.HandCards ||
                    
                    HandCards.Equals(other.HandCards)
                ) && 
                (
                    Attitude == other.Attitude ||
                    
                    Attitude.Equals(other.Attitude)
                ) && 
                (
                    Type == other.Type ||
                    
                    Type.Equals(other.Type)
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
                    
                    hashCode = hashCode * 59 + Direction.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Location != null)
                    hashCode = hashCode * 59 + Location.GetHashCode();
                    
                    hashCode = hashCode * 59 + EnergyCubes.GetHashCode();
                    
                    hashCode = hashCode * 59 + Health.GetHashCode();
                    
                    hashCode = hashCode * 59 + Active.GetHashCode();
                    
                    hashCode = hashCode * 59 + Virtual.GetHashCode();
                    
                    hashCode = hashCode * 59 + Priority.GetHashCode();
                    
                    hashCode = hashCode * 59 + OnTurn.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsMine.GetHashCode();
                    
                    hashCode = hashCode * 59 + HandCards.GetHashCode();
                    
                    hashCode = hashCode * 59 + Attitude.GetHashCode();
                    
                    hashCode = hashCode * 59 + Type.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RobotInfo left, RobotInfo right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RobotInfo left, RobotInfo right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
