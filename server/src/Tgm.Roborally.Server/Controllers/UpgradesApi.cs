/*
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: v0.9.0
 * Contact: nbrugger@student.tgm.ac.at
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Tgm.Roborally.Server.Attributes;
using Tgm.Roborally.Server.Authentication;
using Tgm.Roborally.Server.Engine;
using Tgm.Roborally.Server.Engine.Managers;
using Tgm.Roborally.Server.Models;

namespace Tgm.Roborally.Server.Controllers {
	/// <summary>
	/// 
	/// </summary>
	[ApiController]
	public class UpgradesApiController : ControllerBase {
		/// <summary>
		/// Buy Upgrade
		/// </summary>
		/// <remarks>Buy this Upgrade from the shop. ### Note If your robot allready owns 3 Upgrades you have to use the &#x60;exchange&#x60; parameter. This is the ID of the Upgrade to replace with the bought one</remarks>
		/// <param name="gameId">The id of the game to interact with</param>
		/// <param name="upgradeId">The id of the upgrade to interact with</param>
		/// <param name="exchange">The id of the upgrade to exchange with. Set to null or leave empty for a regular purchase</param>
		/// <response code="200">OK</response>
		/// <response code="404">The error message including a human readable description</response>
		/// <response code="409">The error message including a human readable description</response>
		[HttpPatch]
		[Route("/v1/games/{game_id}/upgrades/shop/{upgrade_id}")]
		[ValidateModelState]
		[GameAuth(Role.PLAYER)]
		[SwaggerOperation("BuyUpgrade")]
		[SwaggerResponse(statusCode: 404, type: typeof(ErrorMessage), description: "Not Found")]
		public virtual IActionResult BuyUpgrade([FromRoute(Name = "game_id")] [Required] [Range(0, 2048)]
												int gameId,  [FromQuery] [Required()] [Range(0, 10000)]
												int upgrade, [FromQuery] [Range(0, 10000)] int exchange) {
			return new GameRequestPipeline()
				   .Game(gameId)
				   .Compute(c => c.Game.BuyUpgrade(((Player) HttpContext.Items[GameAuth.PLAYER]).Id, upgrade))
				   .ExecuteAction();
		}

		/// <summary>
		/// get all Upgrades
		/// </summary>
		/// <remarks>Returns a list of all Upgrade IDs</remarks>
		/// <param name="gameId"></param>
		/// <response code="200">OK</response>
		/// <response code="404">Not Found</response>
		[HttpGet]
		[Route("/v1/games/{game_id}/upgrades/")]
		[GameAuth(Role.PLAYER)]
		[ValidateModelState]
		[SwaggerOperation("GetAllUpgradeIDs")]
		[SwaggerResponse(statusCode: 200, type: typeof(List<int>), description: "OK")]
		[SwaggerResponse(statusCode: 404, type: typeof(ErrorMessage), description: "Not Found")]
		public virtual IActionResult GetAllUpgradeIDs([FromRoute(Name = "game_id")] [Required] [Range(0, 2048)]
													  int gameId) {
			return new GameRequestPipeline()
				   .Game(gameId)
				   .Compute(c => { c.Response = new ObjectResult(c.Game.Upgrades.Ids); }).ExecuteSecure();
		}

		/// <summary>
		/// Get upgrade information
		/// </summary>
		/// <remarks>Get detailed information about the Upgrade</remarks>
		/// <param name="gameId"></param>
		/// <param name="upgradeId"></param>
		/// <response code="200">OK</response>
		/// <response code="404">Not Found</response>
		[HttpGet]
		[Route("/v1/games/{game_id}/upgrades/{upgrade_id}")]
		[GameAuth(Role.PLAYER)]
		[ValidateModelState]
		[SwaggerOperation("GetUpgradeInformation")]
		[SwaggerResponse(statusCode: 200, type: typeof(Upgrade), description: "OK")]
		[SwaggerResponse(statusCode: 404, type: typeof(ErrorMessage), description: "Not Found")]
		public virtual IActionResult GetUpgradeInformation([FromRoute(Name = "game_id")] [Required] [Range(0, 2048)]
														   int gameId, [FromRoute(Name = "upgrade_id")]
														   [Required]
														   [Range(0, 10000)]
														   int upgradeId) {
			return new GameRequestPipeline()
				   .Game(gameId)
				   .Compute(c => {
					   Upgrade u = c.Game.Upgrades[upgradeId];
					   if (u == null) {
						   c.Response = StatusCode(404);
					   }
					   else {
						   c.Response = new ObjectResult(u);
					   }
				   })
				   .ExecuteSecure();
		}

		/// <summary>
		/// Get upgrade shop
		/// </summary>
		/// <remarks>Retuns a list of all cards in the upgrade shop</remarks>
		/// <param name="gameId"></param>
		/// <response code="200">OK</response>
		/// <response code="404">Not Found</response>
		[HttpGet]
		[Route("/v1/games/{game_id}/upgrades/shop")]
		[GameAuth(Role.PLAYER)]
		[ValidateModelState]
		[SwaggerOperation("GetUpgradeShop")]
		[SwaggerResponse(statusCode: 200, type: typeof(UpgradeShop), description: "OK")]
		[SwaggerResponse(statusCode: 404, type: typeof(ErrorMessage), description: "Not Found")]
		public virtual IActionResult GetUpgradeShop([FromRoute(Name = "game_id")] [Required] [Range(0, 2048)]
													int gameId) {
			return new GameRequestPipeline()
				   .Game(gameId)
				   .Compute(c => { c.Response = new ObjectResult(c.Game.Upgrades.Shop); })
				   .ExecuteSecure();
		}
	}
}