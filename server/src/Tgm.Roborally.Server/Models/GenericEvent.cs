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
    /// Used to store any event and generalize them into a single type
    /// </summary>
    [DataContract]
    public partial class GenericEvent : IEquatable<GenericEvent> , Event
    {
        public GenericEvent(EventType type)
        {
            Type = type;
        }
        public GenericEvent(Event e)
        {
            Type = e.GetEventType();
            Data = e;
        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public EventType Type { get; set; }

        /// <summary>
        /// This is the data for the Event. In the case of type beeing &#x60;lazer hit&#x60;, data will be of the type &#x60;LazerHitEvent&#x60;. So the object-type allways matches to the &#x60;type&#x60; field 
        /// </summary>
        /// <value>This is the data for the Event. In the case of type beeing &#x60;lazer hit&#x60;, data will be of the type &#x60;LazerHitEvent&#x60;. So the object-type allways matches to the &#x60;type&#x60; field </value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public Object Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenericEvent {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public EventType GetEventType()
        {
            return Type;
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
            return obj.GetType() == GetType() && Equals((GenericEvent)obj);
        }

        /// <summary>
        /// Returns true if GenericEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of GenericEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenericEvent other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Type == other.Type ||
                    
                    Type.Equals(other.Type)
                ) && 
                (
                    Data == other.Data ||
                    Data != null &&
                    Data.Equals(other.Data)
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
                    
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Data != null)
                    hashCode = hashCode * 59 + Data.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(GenericEvent left, GenericEvent right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GenericEvent left, GenericEvent right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
