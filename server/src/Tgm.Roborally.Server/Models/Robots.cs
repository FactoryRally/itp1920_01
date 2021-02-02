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
	/// Gets or Sets Robots
	/// </summary>
	[TypeConverter(typeof(CustomEnumConverter<Robots>))]
	[JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
	public enum Robots {
		/// <summary>
		/// Enum Dicer for dicer
		/// </summary>
		[EnumMember(Value = "dicer")] Dicer = 1,

		/// <summary>
		/// Enum Tank for tank
		/// </summary>
		[EnumMember(Value = "tank")] Tank = 2
	}
}