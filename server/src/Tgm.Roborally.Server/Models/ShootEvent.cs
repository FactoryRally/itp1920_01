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
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Tgm.Roborally.Server.Engine;

namespace Tgm.Roborally.Server.Models {
	/// <summary>
	///     Event if a player shoots a lazer
	/// </summary>
	[DataContract]
	public class ShootEvent : IEquatable<ShootEvent>, Event {
		/// <summary>
		///     The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value
		///     will be autogenerated by the api and is read only
		/// </summary>
		/// <value>
		///     The unique identification of this entity. &lt;br&gt; *!!!* This is not the id of the player&lt;br&gt; This value
		///     will be autogenerated by the api and is read only
		/// </value>
		[DataMember(Name = "shooter", EmitDefaultValue = false)]
		public int Shooter { get; set; }

		/// <summary>
		///     Gets or Sets Direction
		/// </summary>
		[DataMember(Name = "direction", EmitDefaultValue = false)]
		public Direction Direction { get; set; }

		/// <summary>
		///     Gets or Sets To
		/// </summary>
		[DataMember(Name = "to", EmitDefaultValue = false)]
		public Position To { get; set; }

		/// <summary>
		///     The entitys hit by the ray
		/// </summary>
		/// <value>The entitys hit by the ray</value>
		[DataMember(Name = "hit-entitys", EmitDefaultValue = false)]
		public List<int> HitEntitys { get; set; }

		public EventType GetEventType() => EventType.LazerShot;

		/// <summary>
		///     Returns true if ShootEvent instances are equal
		/// </summary>
		/// <param name="other">Instance of ShootEvent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ShootEvent other) {
			if (other is null) return false;
			if (ReferenceEquals(this, other)) return true;

			return
				(
					Shooter == other.Shooter ||
					Shooter.Equals(other.Shooter)
				) &&
				(
					Direction == other.Direction ||
					Direction.Equals(other.Direction)
				) &&
				(
					To == other.To ||
					To != null &&
					To.Equals(other.To)
				) &&
				(
					HitEntitys == other.HitEntitys ||
					HitEntitys       != null &&
					other.HitEntitys != null &&
					HitEntitys.SequenceEqual(other.HitEntitys)
				);
		}

		/// <summary>
		///     Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString() {
			StringBuilder sb = new StringBuilder();
			sb.Append("class ShootEvent {\n");
			sb.Append("  Shooter: ").Append(Shooter).Append("\n");
			sb.Append("  Direction: ").Append(Direction).Append("\n");
			sb.Append("  To: ").Append(To).Append("\n");
			sb.Append("  HitEntitys: ").Append(HitEntitys).Append("\n");
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
			return obj.GetType() == GetType() && Equals((ShootEvent) obj);
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

				hashCode = hashCode * 59 + Shooter.GetHashCode();

				hashCode = hashCode * 59 + Direction.GetHashCode();
				if (To != null)
					hashCode = hashCode * 59 + To.GetHashCode();
				if (HitEntitys != null)
					hashCode = hashCode * 59 + HitEntitys.GetHashCode();
				return hashCode;
			}
		}

		#region Operators

		#pragma warning disable 1591

		public static bool operator ==(ShootEvent left, ShootEvent right) => Equals(left, right);

		public static bool operator !=(ShootEvent left, ShootEvent right) => !Equals(left, right);

		#pragma warning restore 1591

		#endregion Operators
	}
}