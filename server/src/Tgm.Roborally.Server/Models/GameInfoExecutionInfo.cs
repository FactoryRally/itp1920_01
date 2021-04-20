/*
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: v2.2.0b0
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
	///     Information abou the executon cycle
	/// </summary>
	[DataContract]
	public class GameInfoExecutionInfo : IEquatable<GameInfoExecutionInfo> {
		/// <summary>
		///     The index of the register currently executed
		/// </summary>
		/// <value>The index of the register currently executed</value>
		[Required]
		[DataMember(Name = "currentRegister", EmitDefaultValue = false)]
		public int CurrentRegister { get; set; }

		/// <summary>
		///     The id of the robot currently executing
		/// </summary>
		/// <value>The id of the robot currently executing</value>
		[Required]
		[DataMember(Name = "currentRobot", EmitDefaultValue = false)]
		public int CurrentRobot => _ref.Entitys.Robots[_currentRobotIndex];

		/// <summary>
		/// Switches to the next robot and prepares him for command execution
		/// </summary>
		/// <returns></returns>
		public bool NextRobot() => _currentRobotIndex++ < _ref.Entitys.Robots.Count-1; //TODO implement robo priority (distance from beacon)


		private readonly GameLogic _ref;
		private int       _currentRobotIndex = 0;

		public GameInfoExecutionInfo(GameLogic @ref) {
			_ref = @ref;
		}

		/// <summary>
		///     Returns true if GameInfoExecutionInfo instances are equal
		/// </summary>
		/// <param name="other">Instance of GameInfoExecutionInfo to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(GameInfoExecutionInfo other) {
			if (other is null) return false;
			if (ReferenceEquals(this, other)) return true;

			return
				(
					CurrentRegister == other.CurrentRegister ||
					CurrentRegister.Equals(other.CurrentRegister)
				) &&
				(
					CurrentRobot == other.CurrentRobot ||
					CurrentRobot.Equals(other.CurrentRobot)
				);
		}

		/// <summary>
		///     Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString() {
			StringBuilder sb = new StringBuilder();
			sb.Append("class GameInfoExecutionInfo {\n");
			sb.Append("  CurrentRegister: ").Append(CurrentRegister).Append("\n");
			sb.Append("  CurrentRobot: ").Append(CurrentRobot).Append("\n");
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
			return obj.GetType() == GetType() && Equals((GameInfoExecutionInfo) obj);
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

				hashCode = hashCode * 59 + CurrentRegister.GetHashCode();

				hashCode = hashCode * 59 + CurrentRobot.GetHashCode();
				return hashCode;
			}
		}

		#region Operators

		#pragma warning disable 1591

		public static bool operator ==(GameInfoExecutionInfo left, GameInfoExecutionInfo right) => Equals(left, right);

		public static bool operator !=(GameInfoExecutionInfo left, GameInfoExecutionInfo right) => !Equals(left, right);

		#pragma warning restore 1591

		#endregion Operators
	}
}