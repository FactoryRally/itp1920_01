/*
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: 0.1.0
 * Contact: nbrugger@student.tgm.ac.at
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using Tgm.Roborally.Server.Attributes;
using Tgm.Roborally.Server.Authentication;
using Tgm.Roborally.Server.Engine;
using Tgm.Roborally.Server.Engine.Exceptions;
using Tgm.Roborally.Server.Models;
using Action = Tgm.Roborally.Server.Models.Action;

namespace Tgm.Roborally.Server.Controllers
{
	/// <summary>
	/// 
	/// </summary>
	[ApiController]
	public class GameApiController : ControllerBase
	{
		/// <summary>
		/// Commit Action
		/// </summary>
		/// <remarks>Queues an action to be executed</remarks>
		/// <param name="gameId"></param>
		/// <param name="action"></param>
		/// <response code="200">OK</response>
		/// <response code="404">Not Found</response>
		/// <response code="409">Conflict</response>
		[HttpPut]
		[Route("/v1/games/{game_id}/actions")]
		[ValidateModelState]
		[SwaggerOperation("CommitAction")]
		[SwaggerResponse(statusCode: 404, type: typeof(ErrorMessage), description: "Not Found")]
		[SwaggerResponse(statusCode: 409, type: typeof(ErrorMessage), description: "Conflict")]
		public virtual IActionResult CommitAction([FromRoute] [Required] [Range(0, 2048)]
			int gameId, [FromQuery] [Required()] ActionType action)
		{
			return 
				new GameRequestPipeline()
				.game(gameId)
				.compute(c =>
				{
					c.Game.ActionHandler.Add(action);
					c.Game.ActionHandler.ExecuteNext();
				})
				.execute();
		}

		/// <summary>
		/// Create Game
		/// </summary>
		/// <remarks>Creates a random game by your defined rules</remarks>
		/// <param name="gameRules">*Optional* This rules define how your game will behave</param>
		/// <response code="200">OK</response>
		[HttpPost]
		[Route("/v1/games/")]
		[ValidateModelState]
		[SwaggerOperation("CreateGame")]
		public virtual IActionResult CreateGame([FromBody] GameRules gameRules)
		{
			GameManager.instance.startGame(gameRules);
			return StatusCode(200);
		}

		/// <summary>
		/// Get games actions
		/// </summary>
		/// <remarks>Get all (**not robot related**) actions comitted to this game.</remarks>
		/// <param name="gameId"></param>
		/// <param name="mode">Defines wich entries to return</param>
		/// <response code="200">OK</response>
		/// <response code="201">Created</response>
		/// <response code="404">Not Found</response>
		[HttpGet]
		[Route("/v1/games/{game_id}/actions")]
		[ValidateModelState]
		[SwaggerOperation("GetActions")]
		[SwaggerResponse(statusCode: 200, type: typeof(List<Action>), description: "OK")]
		[SwaggerResponse(statusCode: 404, type: typeof(ErrorMessage), description: "Not Found")]
		public virtual IActionResult GetActions([FromRoute] [Required] [Range(0, 2048)]
			int gameId, [FromQuery] string mode)
		{
			return 
				new GameRequestPipeline()
					.game(gameId)
					.compute(c => c.Response = new OkObjectResult(c.Game.ActionHandler.Queue))
					.execute();
		}

		/// <summary>
		/// Get game status
		/// </summary>
		/// <remarks>Returns the status of a game</remarks>
		/// <param name="gameId"></param>
		/// <response code="200">OK</response>
		/// <response code="404">Not Found</response>
		[HttpGet]
		[Route("/v1/games/{game_id}/status")]
		[ValidateModelState]
		[SwaggerOperation("GetGameState")]
		[SwaggerResponse(statusCode: 200, type: typeof(GameInfo), description: "OK")]
		[SwaggerResponse(statusCode: 404, type: typeof(ErrorMessage), description: "Not Found")]
		public virtual IActionResult GetGameState([FromRoute] [Required] [Range(0, 2048)]
			int gameId)
		{
			return new GameRequestPipeline()
				.game(gameId)
				.compute(e => e.Response = new OkObjectResult(e.Game.Info))
				.execute();
		}

		/// <summary>
		/// Get all games
		/// </summary>
		/// <remarks>Returns a list of all hosted games</remarks>
		/// <param name="joinable">true: only return joinable games</param>
		/// <param name="unprotected">true: only display games with no password set</param>
		/// <response code="200">OK</response>
		[HttpGet]
		[Route("/v1/games/")]
		[ValidateModelState]
		[SwaggerOperation("GetGames")]
		[SwaggerResponse(statusCode: 200, type: typeof(List<int>), description: "OK")]
		public virtual IActionResult GetGames([FromQuery] bool joinable, [FromQuery] bool unprotected)
		{
			return new ObjectResult(GameManager.instance.games.Where(pair =>
					(!joinable || pair.Value.Joinable) && (!unprotected || pair.Value.Password == null))
				.Select(e => e.Key));
		}
	}
}