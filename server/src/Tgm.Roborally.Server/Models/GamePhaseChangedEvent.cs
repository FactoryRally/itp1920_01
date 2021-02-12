/*
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: v1.3.0
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
	/// When the next game phase started
	/// </summary>
	[DataContract]
	public partial class GamePhaseChangedEvent : IEquatable<GamePhaseChangedEvent>,Event
	{
		/// <summary>
		/// Gets or Sets Phase
		/// </summary>
		[Required]
		[DataMember(Name="phase", EmitDefaultValue=false)]
		public RoundPhase? Phase { get; set; }

		/// <summary>
		/// WIP! Currently class names. Enum later on  Describes the game phase more deeply
		/// </summary>
		/// <value>WIP! Currently class names. Enum later on  Describes the game phase more deeply</value>
		[Required]
		[DataMember(Name="step", EmitDefaultValue=false)]
		public string Step { get; set; }

		/// <summary>
		/// Unspecified information about the game phase (you can also obtain this information in a typesave way using the GameAPI)
		/// </summary>
		/// <value>Unspecified information about the game phase (you can also obtain this information in a typesave way using the GameAPI)</value>
		[DataMember(Name="information", EmitDefaultValue=false)]
		public Object Information { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GamePhaseChangedEvent {\n");
			sb.Append("  Phase: ").Append(Phase).Append("\n");
			sb.Append("  Step: ").Append(Step).Append("\n");
			sb.Append("  Information: ").Append(Information).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}

		public EventType GetEventType() => EventType.GameRoundPhaseChanged;

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
			return obj.GetType() == GetType() && Equals((GamePhaseChangedEvent)obj);
		}

		/// <summary>
		/// Returns true if GamePhaseChangedEvent instances are equal
		/// </summary>
		/// <param name="other">Instance of GamePhaseChangedEvent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(GamePhaseChangedEvent other)
		{
			if (other is null) return false;
			if (ReferenceEquals(this, other)) return true;

			return 
				(
					Phase == other.Phase ||
					
					Phase.Equals(other.Phase)
				) && 
				(
					Step == other.Step ||
					Step != null &&
					Step.Equals(other.Step)
				) && 
				(
					Information == other.Information ||
					Information != null &&
					Information.Equals(other.Information)
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
					
					hashCode = hashCode * 59 + Phase.GetHashCode();
					if (Step != null)
					hashCode = hashCode * 59 + Step.GetHashCode();
					if (Information != null)
					hashCode = hashCode * 59 + Information.GetHashCode();
				return hashCode;
			}
		}

		#region Operators
		#pragma warning disable 1591

		public static bool operator ==(GamePhaseChangedEvent left, GamePhaseChangedEvent right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(GamePhaseChangedEvent left, GamePhaseChangedEvent right)
		{
			return !Equals(left, right);
		}

		#pragma warning restore 1591
		#endregion Operators
	}
}
