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
using Tgm.Roborally.Server.Engine;

namespace Tgm.Roborally.Server.Models
{ 
    /// <summary>
    /// When a robot gains energy
    /// </summary>
    [DataContract]
    public partial class EnergyGainEvent : IEquatable<EnergyGainEvent>, Event
    {
        /// <summary>
        /// The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value will be autogenerated by the api and is read only
        /// </summary>
        /// <value>The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value will be autogenerated by the api and is read only</value>
        [Required]
        [DataMember(Name="robot", EmitDefaultValue=false)]
        public int Robot { get; set; }

        /// <summary>
        /// The ammount of energy gained
        /// </summary>
        /// <value>The ammount of energy gained</value>
        [Required]
        [Range(0, 10)]
        [DataMember(Name="ammount", EmitDefaultValue=false)]
        public int Ammount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyGainEvent {\n");
            sb.Append("  Robot: ").Append(Robot).Append("\n");
            sb.Append("  Ammount: ").Append(Ammount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public EventType GetEventType() => EventType.EnergyGain;

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
            return obj.GetType() == GetType() && Equals((EnergyGainEvent)obj);
        }

        /// <summary>
        /// Returns true if EnergyGainEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of EnergyGainEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyGainEvent other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Robot == other.Robot ||
                    
                    Robot.Equals(other.Robot)
                ) && 
                (
                    Ammount == other.Ammount ||
                    
                    Ammount.Equals(other.Ammount)
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
                    
                    hashCode = hashCode * 59 + Robot.GetHashCode();
                    
                    hashCode = hashCode * 59 + Ammount.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EnergyGainEvent left, EnergyGainEvent right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EnergyGainEvent left, EnergyGainEvent right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
