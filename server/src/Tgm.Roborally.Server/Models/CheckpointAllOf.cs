/*
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: v0.4.1b0
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

namespace Tgm.Roborally.Server.Models {
	/// <summary>
	/// 
	/// </summary>
	[DataContract]
	public partial class CheckpointAllOf : IEquatable<CheckpointAllOf> {
		/// <summary>
		/// The number of the checkpoint defining the order they need to be called in
		/// </summary>
		/// <value>The number of the checkpoint defining the order they need to be called in</value>
		[DataMember(Name = "number", EmitDefaultValue = false)]
		public int Number { get; set; }

		/// <summary>
		/// The entities (robots) which allready were at this point
		/// </summary>
		/// <value>The entities (robots) which allready were at this point</value>
		[DataMember(Name = "checked-by", EmitDefaultValue = false)]
		public List<int> CheckedBy { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString() {
			var sb = new StringBuilder();
			sb.Append("class CheckpointAllOf {\n");
			sb.Append("  Number: ").Append(Number).Append("\n");
			sb.Append("  CheckedBy: ").Append(CheckedBy).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}

		/// <summary>
		/// Returns the JSON string presentation of the object
		/// </summary>
		/// <returns>JSON string presentation of the object</returns>
		public string ToJson() {
			return JsonConvert.SerializeObject(this, Formatting.Indented);
		}

		/// <summary>
		/// Returns true if objects are equal
		/// </summary>
		/// <param name="obj">Object to be compared</param>
		/// <returns>Boolean</returns>
		public override bool Equals(object obj) {
			if (obj is null) return false;
			if (ReferenceEquals(this, obj)) return true;
			return obj.GetType() == GetType() && Equals((CheckpointAllOf) obj);
		}

		/// <summary>
		/// Returns true if CheckpointAllOf instances are equal
		/// </summary>
		/// <param name="other">Instance of CheckpointAllOf to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CheckpointAllOf other) {
			if (other is null) return false;
			if (ReferenceEquals(this, other)) return true;

			return
				(
					Number == other.Number ||
					Number.Equals(other.Number)
				) &&
				(
					CheckedBy == other.CheckedBy ||
					CheckedBy       != null &&
					other.CheckedBy != null &&
					CheckedBy.SequenceEqual(other.CheckedBy)
				);
		}

		/// <summary>
		/// Gets the hash code
		/// </summary>
		/// <returns>Hash code</returns>
		public override int GetHashCode() {
			unchecked // Overflow is fine, just wrap
			{
				var hashCode = 41;
				// Suitable nullity checks etc, of course :)

				hashCode = hashCode * 59 + Number.GetHashCode();
				if (CheckedBy != null)
					hashCode = hashCode * 59 + CheckedBy.GetHashCode();
				return hashCode;
			}
		}

		#region Operators

		#pragma warning disable 1591

		public static bool operator ==(CheckpointAllOf left, CheckpointAllOf right) {
			return Equals(left, right);
		}

		public static bool operator !=(CheckpointAllOf left, CheckpointAllOf right) {
			return !Equals(left, right);
		}

		#pragma warning restore 1591

		#endregion Operators
	}
}