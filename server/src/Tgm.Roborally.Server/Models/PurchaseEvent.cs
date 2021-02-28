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
using Tgm.Roborally.Server.Engine;

namespace Tgm.Roborally.Server.Models {
	/// <summary>
	///     The event that occurs if a player buys an upgrade
	/// </summary>
	[DataContract]
	public class PurchaseEvent : IEquatable<PurchaseEvent>, Event {
		/// <summary>
		///     This id uniquely identifys the player (in a game).   **Not** to be confused with the &#x60;uid&#x60; which is used
		///     for authentication
		/// </summary>
		/// <value>
		///     This id uniquely identifys the player (in a game).   **Not** to be confused with the &#x60;uid&#x60; which is
		///     used for authentication
		/// </value>
		[Range(0, 8)]
		[DataMember(Name = "player", EmitDefaultValue = false)]
		public int Player { get; set; }

		/// <summary>
		///     The id of an upgrade. **Unique**
		/// </summary>
		/// <value>The id of an upgrade. **Unique**</value>
		[Range(0, 10000)]
		[DataMember(Name = "upgrade", EmitDefaultValue = false)]
		public int Upgrade { get; set; }

		public EventType GetEventType() => EventType.UpgradePurchase;

		/// <summary>
		///     Returns true if PurchaseEvent instances are equal
		/// </summary>
		/// <param name="other">Instance of PurchaseEvent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PurchaseEvent other) {
			if (other is null) return false;
			if (ReferenceEquals(this, other)) return true;

			return
				(
					Player == other.Player ||
					Player.Equals(other.Player)
				) &&
				(
					Upgrade == other.Upgrade ||
					Upgrade.Equals(other.Upgrade)
				);
		}

		/// <summary>
		///     Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString() {
			StringBuilder sb = new StringBuilder();
			sb.Append("class PurchaseEvent {\n");
			sb.Append("  Player: ").Append(Player).Append("\n");
			sb.Append("  Upgrade: ").Append(Upgrade).Append("\n");
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
			return obj.GetType() == GetType() && Equals((PurchaseEvent) obj);
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

				hashCode = hashCode * 59 + Player.GetHashCode();

				hashCode = hashCode * 59 + Upgrade.GetHashCode();
				return hashCode;
			}
		}

		#region Operators

		#pragma warning disable 1591

		public static bool operator ==(PurchaseEvent left, PurchaseEvent right) => Equals(left, right);

		public static bool operator !=(PurchaseEvent left, PurchaseEvent right) => !Equals(left, right);

		#pragma warning restore 1591

		#endregion Operators
	}
}