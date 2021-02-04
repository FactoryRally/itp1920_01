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
	public partial class ProgrammingTimerStartEvent : IEquatable<ProgrammingTimerStartEvent> {
		/// <summary>
		/// Time the timer will run for
		/// </summary>
		/// <value>Time the timer will run for</value>
		[Required]
		[Range(3, 300)]
		[DataMember(Name = "seconds", EmitDefaultValue = false)]
		public int Seconds { get; set; }

		/// <summary>
		/// The time at which the timer ends. Given as &#x60;ms since epoche&#x60; [link](currentmillis.com) 
		/// </summary>
		/// <value>The time at which the timer ends. Given as &#x60;ms since epoche&#x60; [link](currentmillis.com) </value>
		[Required]
		[DataMember(Name = "end", EmitDefaultValue = false)]
		public long End { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString() {
			var sb = new StringBuilder();
			sb.Append("class ProgrammingTimerStartEvent {\n");
			sb.Append("  Seconds: ").Append(Seconds).Append("\n");
			sb.Append("  End: ").Append(End).Append("\n");
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
			return obj.GetType() == GetType() && Equals((ProgrammingTimerStartEvent) obj);
		}

		/// <summary>
		/// Returns true if ProgrammingTimerStartEvent instances are equal
		/// </summary>
		/// <param name="other">Instance of ProgrammingTimerStartEvent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ProgrammingTimerStartEvent other) {
			if (other is null) return false;
			if (ReferenceEquals(this, other)) return true;

			return
				(
					Seconds == other.Seconds ||
					Seconds.Equals(other.Seconds)
				) &&
				(
					End == other.End ||
					End.Equals(other.End)
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

				hashCode = hashCode * 59 + Seconds.GetHashCode();

				hashCode = hashCode * 59 + End.GetHashCode();
				return hashCode;
			}
		}

		#region Operators

		#pragma warning disable 1591

		public static bool operator ==(ProgrammingTimerStartEvent left, ProgrammingTimerStartEvent right) {
			return Equals(left, right);
		}

		public static bool operator !=(ProgrammingTimerStartEvent left, ProgrammingTimerStartEvent right) {
			return !Equals(left, right);
		}

		#pragma warning restore 1591

		#endregion Operators
	}
}