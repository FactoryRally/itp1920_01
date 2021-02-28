/*
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: v0.8.2
 * Contact: nbrugger@student.tgm.ac.at
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Tgm.Roborally.Server.Models {
	/// <summary>
	///     The game is over
	/// </summary>
	[DataContract]
	public class GameEndEvent : IEquatable<GameEndEvent> {
		/// <summary>
		///     Gets or Sets Winner
		/// </summary>
		[Required]
		[DataMember(Name = "winner", EmitDefaultValue = false)]
		public Player Winner { get; set; }

		/// <summary>
		///     Returns true if GameEndEvent instances are equal
		/// </summary>
		/// <param name="other">Instance of GameEndEvent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(GameEndEvent other) {
			if (other is null) return false;
			if (ReferenceEquals(this, other)) return true;

			return
				Winner == other.Winner ||
				Winner != null &&
				Winner.Equals(other.Winner);
		}

		/// <summary>
		///     Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString() {
			StringBuilder sb = new StringBuilder();
			sb.Append("class GameEndEvent {\n");
			sb.Append("  Winner: ").Append(Winner).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}

		/// <summary>
		///     Returns the JSON string presentation of the object
		/// </summary>
		/// <returns>JSON string presentation of the object</returns>
		public string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);

		/// <summary>
		///     Returns true if objects are equal
		/// </summary>
		/// <param name="obj">Object to be compared</param>
		/// <returns>Boolean</returns>
		public override bool Equals(object obj) {
			if (obj is null) return false;
			if (ReferenceEquals(this, obj)) return true;
			return obj.GetType() == GetType() && Equals((GameEndEvent) obj);
		}

		/// <summary>
		///     Gets the hash code
		/// </summary>
		/// <returns>Hash code</returns>
		public override int GetHashCode() {
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				// Suitable nullity checks etc, of course :)
				if (Winner != null)
					hashCode = hashCode * 59 + Winner.GetHashCode();
				return hashCode;
			}
		}

		#region Operators

		#pragma warning disable 1591

		public static bool operator ==(GameEndEvent left, GameEndEvent right) => Equals(left, right);

		public static bool operator !=(GameEndEvent left, GameEndEvent right) => !Equals(left, right);

		#pragma warning restore 1591

		#endregion Operators
	}
}