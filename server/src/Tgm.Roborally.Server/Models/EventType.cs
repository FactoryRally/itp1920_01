/*
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: v0.9.0
 * Contact: nbrugger@student.tgm.ac.at
 * Generated by: https://openapi-generator.tech
 */

using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Tgm.Roborally.Server.Converters;

namespace Tgm.Roborally.Server.Models {
	/// <summary>
	///     Describes what the event is about
	/// </summary>
	/// <value>Describes what the event is about</value>
	[TypeConverter(typeof(CustomEnumConverter<EventType>))]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EventType {
		/// <summary>
		///     Enum Movement for movement
		/// </summary>
		[EnumMember(Value = "movement")] Movement = 1,

		/// <summary>
		///     Enum UpgradePurchase for upgrade purchase
		/// </summary>
		[EnumMember(Value = "upgrade purchase")]
		UpgradePurchase = 2,

		/// <summary>
		///     Enum ActivateUpgrade for activate upgrade
		/// </summary>
		[EnumMember(Value = "activate upgrade")]
		ActivateUpgrade = 3,

		/// <summary>
		///     Enum LazerShot for lazer shot
		/// </summary>
		[EnumMember(Value = "lazer shot")] LazerShot = 4,

		/// <summary>
		///     Enum GameStart for game start
		/// </summary>
		[EnumMember(Value = "game start")] GameStart = 5,

		/// <summary>
		///     Enum ClearShop for clear shop
		/// </summary>
		[EnumMember(Value = "clear shop")] ClearShop = 6,

		/// <summary>
		///     Enum FillShop for fill shop
		/// </summary>
		[EnumMember(Value = "fill shop")] FillShop = 7,

		/// <summary>
		///     Enum ProgrammingTimerStart for programming timer start
		/// </summary>
		[EnumMember(Value = "programming timer start")]
		ProgrammingTimerStart = 8,

		/// <summary>
		///     Enum ProgrammingTimerStop for programming timer stop
		/// </summary>
		[EnumMember(Value = "programming timer stop")]
		ProgrammingTimerStop = 9,

		/// <summary>
		///     Enum RandomCardDistribution for random card distribution
		/// </summary>
		[EnumMember(Value = "random card distribution")]
		RandomCardDistribution = 10,

		/// <summary>
		///     Enum TakeCardEvent for take card event
		/// </summary>
		[EnumMember(Value = "take card event")]
		TakeCardEvent = 11,

		/// <summary>
		///     Enum ActivateCheckpoint for activate checkpoint
		/// </summary>
		[EnumMember(Value = "activate checkpoint")]
		ActivateCheckpoint = 12,

		/// <summary>
		///     Enum GamePhaseChanged for game_phase_changed
		/// </summary>
		[EnumMember(Value = "game_phase_changed")]
		GamePhaseChanged = 13,

		/// <summary>
		///     Enum GameRoundPhaseChanged for game_round_phase_changed
		/// </summary>
		[EnumMember(Value = "game_round_phase_changed")]
		GameRoundPhaseChanged = 14,

		/// <summary>
		///     Enum Pause for pause
		/// </summary>
		[EnumMember(Value = "pause")] Pause = 15,

		/// <summary>
		///     Enum Unpause for unpause
		/// </summary>
		[EnumMember(Value = "unpause")] Unpause = 16,

		/// <summary>
		///     Enum Damage for damage
		/// </summary>
		[EnumMember(Value = "damage")] Damage = 17,

		/// <summary>
		///     Enum LazerHit for lazer hit
		/// </summary>
		[EnumMember(Value = "lazer hit")] LazerHit = 18,

		/// <summary>
		///     Enum Push for push
		/// </summary>
		[EnumMember(Value = "push")] Push = 19,

		/// <summary>
		///     Enum Join for join
		/// </summary>
		[EnumMember(Value = "join")] Join = 20,

		/// <summary>
		///     Enum LockIn for lock in
		/// </summary>
		[EnumMember(Value = "lock in")] LockIn = 21,

		/// <summary>
		///     Enum RobotStartExecuting for robot_start_executing
		/// </summary>
		[EnumMember(Value = "robot_start_executing")]
		RobotStartExecuting = 22,

		/// <summary>
		///     Enum Heal for heal
		/// </summary>
		[EnumMember(Value = "heal")] Heal = 23,

		/// <summary>
		///     Enum EnergyGain for energy gain
		/// </summary>
		[EnumMember(Value = "energy gain")] EnergyGain = 24,

		/// <summary>
		///     Enum Map for map
		/// </summary>
		[EnumMember(Value = "map")] Map = 25,

		/// <summary>
		///     Enum Shutdown for shutdown
		/// </summary>
		[EnumMember(Value = "shutdown")] Shutdown = 26,

		/// <summary>
		///     Enum ChangeRegister for change register
		/// </summary>
		[EnumMember(Value = "change register")]
		ChangeRegister = 27,

		/// <summary>
		///     Enum GameEndEvent for game end event
		/// </summary>
		[EnumMember(Value = "game end event")] GameEndEvent = 28,

		/// <summary>
		///     Enum ClearRegister for clear register
		/// </summary>
		[EnumMember(Value = "clear register")] ClearRegister = 29,

		/// <summary>
		///     Enum TimeElapsed for time elapsed
		/// </summary>
		[EnumMember(Value = "time elapsed")] TimeElapsed = 30,

		/// <summary>
		///     Enum MapCreated for map created
		/// </summary>
		[EnumMember(Value = "map created")] MapCreated = 31,

		/// <summary>
		///     Enum UpgradesDiscarded for upgrades discarded
		/// </summary>
		[EnumMember(Value = "upgrades discarded")]
		UpgradesDiscarded = 32
	}
}