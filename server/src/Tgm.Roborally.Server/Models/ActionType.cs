/*
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: v0.4.1b0
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
	///     Defines what an action will do
	/// </summary>
	/// <value>Defines what an action will do</value>
	[TypeConverter(typeof(CustomEnumConverter<ActionType>))]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ActionType {
		/// <summary>
		///     Enum PAUSE for PAUSE
		/// </summary>
		[EnumMember(Value = "PAUSE")] PAUSE = 1,

		/// <summary>
		///     Enum UNPAUSE for UNPAUSE
		/// </summary>
		[EnumMember(Value = "UNPAUSE")] UNPAUSE = 2,

		/// <summary>
		///     Enum STARTGAME for START_GAME
		/// </summary>
		[EnumMember(Value = "START_GAME")] STARTGAME = 3
	}
}