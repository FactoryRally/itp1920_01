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
    /// Describes the map *without* the tiles
    /// </summary>
    [DataContract]
    public partial class MapInfo : IEquatable<MapInfo>
    {
        private Tgm.Roborally.Server.Engine.Map _map;

        public MapInfo(Tgm.Roborally.Server.Engine.Map map)
        {
            _map = map;
        }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [Range(4, 500)]
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public int Width => _map.Width;

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [Range(4, 500)]
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public int Height => _map.Height;

        /// <summary>
        /// Gets or Sets PrioBeacon
        /// </summary>
        [DataMember(Name = "prioBeacon", EmitDefaultValue = false)]
        public Position PrioBeacon => _map.PrioCorePos;
        /// <summary>
        /// The default rule for names in the game
        /// </summary>
        /// <value>The default rule for names in the game</value>
        [RegularExpression("[A-Za-z]+[A-Za-z0-9 _- ]+")]
        [StringLength(13, MinimumLength=3)]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MapInfo {\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  PrioBeacon: ").Append(PrioBeacon).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MapInfo)obj);
        }

        /// <summary>
        /// Returns true if MapInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of MapInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MapInfo other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Width == other.Width ||
                    
                    Width.Equals(other.Width)
                ) && 
                (
                    Height == other.Height ||
                    
                    Height.Equals(other.Height)
                ) && 
                (
                    PrioBeacon == other.PrioBeacon ||
                    PrioBeacon != null &&
                    PrioBeacon.Equals(other.PrioBeacon)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
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
                    
                    hashCode = hashCode * 59 + Width.GetHashCode();
                    
                    hashCode = hashCode * 59 + Height.GetHashCode();
                    if (PrioBeacon != null)
                    hashCode = hashCode * 59 + PrioBeacon.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MapInfo left, MapInfo right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MapInfo left, MapInfo right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
