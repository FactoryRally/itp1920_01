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
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Tgm.Roborally.Server.Models {
	/// <summary>
	///     Game Rules define the rules for a Game
	/// </summary>
	[DataContract]
	public class GameRules : IEquatable<GameRules> {
		/// <summary>
		///     If true players can see the name of the player controlling a robot
		/// </summary>
		/// <value>If true players can see the name of the player controlling a robot</value>
		[DataMember(Name = "player-names-visible", EmitDefaultValue = false)]
		public bool PlayerNamesVisible { get; set; } = true;

		/// <summary>
		///     The maximum ammount of players able to join the game
		/// </summary>
		/// <value>The maximum ammount of players able to join the game</value>
		[Range(1, 6)]
		[DataMember(Name = "max-players", EmitDefaultValue = false)]
		public int MaxPlayers { get; set; } = 6;

		/// <summary>
		///     The visible name of the game
		/// </summary>
		/// <value>The visible name of the game</value>
		[Required]
		[StringLength(50, MinimumLength = 3)]
		[DataMember(Name                = "name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		///     Defines the number of robots per player
		/// </summary>
		/// <value>Defines the number of robots per player</value>
		[Range(1, 3)]
		[DataMember(Name = "robots-per-player", EmitDefaultValue = false)]
		public int RobotsPerPlayer { get; set; } = 1;

		/// <summary>
		///     The password of a game
		/// </summary>
		/// <value>The password of a game</value>
		[StringLength(18, MinimumLength = 4)]
		[DataMember(Name                = "password", EmitDefaultValue = false)]
		public string Password { get; set; }

		/// <summary>
		///     If true emply player slots are going to be filled up with AI enemys
		/// </summary>
		/// <value>If true emply player slots are going to be filled up with AI enemys</value>
		[DataMember(Name = "fill-with-bots", EmitDefaultValue = false)]
		public bool FillWithBots { get; set; }

		/// <summary>
		///     Returns true if GameRules instances are equal
		/// </summary>
		/// <param name="other">Instance of GameRules to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(GameRules other) {
			if (other is null) return false;
			if (ReferenceEquals(this, other)) return true;

			return
				(
					PlayerNamesVisible == other.PlayerNamesVisible ||
					PlayerNamesVisible.Equals(other.PlayerNamesVisible)
				) &&
				(
					MaxPlayers == other.MaxPlayers ||
					MaxPlayers.Equals(other.MaxPlayers)
				) &&
				(
					Name == other.Name ||
					Name != null &&
					Name.Equals(other.Name)
				) &&
				(
					RobotsPerPlayer == other.RobotsPerPlayer ||
					RobotsPerPlayer.Equals(other.RobotsPerPlayer)
				) &&
				(
					Password == other.Password ||
					Password != null &&
					Password.Equals(other.Password)
				) &&
				(
					FillWithBots == other.FillWithBots ||
					FillWithBots.Equals(other.FillWithBots)
				);
		}

		/// <summary>
		///     Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString() {
			StringBuilder sb = new StringBuilder();
			sb.Append("class GameRules {\n");
			sb.Append("  PlayerNamesVisible: ").Append(PlayerNamesVisible).Append("\n");
			sb.Append("  MaxPlayers: ").Append(MaxPlayers).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  RobotsPerPlayer: ").Append(RobotsPerPlayer).Append("\n");
			sb.Append("  Password: ").Append(Password).Append("\n");
			sb.Append("  FillWithBots: ").Append(FillWithBots).Append("\n");
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
			return obj.GetType() == GetType() && Equals((GameRules) obj);
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

				hashCode = hashCode * 59 + PlayerNamesVisible.GetHashCode();

				hashCode = hashCode * 59 + MaxPlayers.GetHashCode();
				if (Name != null)
					hashCode = hashCode * 59 + Name.GetHashCode();

				hashCode = hashCode * 59 + RobotsPerPlayer.GetHashCode();
				if (Password != null)
					hashCode = hashCode * 59 + Password.GetHashCode();

				hashCode = hashCode * 59 + FillWithBots.GetHashCode();
				return hashCode;
			}
		}

		#region Operators

		#pragma warning disable 1591

		public static bool operator ==(GameRules left, GameRules right) => Equals(left, right);

		public static bool operator !=(GameRules left, GameRules right) => !Equals(left, right);

		#pragma warning restore 1591

		#endregion Operators
	}
}