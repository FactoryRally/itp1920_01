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
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Tgm.Roborally.Server.Attributes;
using Microsoft.AspNetCore.Authorization;
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
        [HttpPut]
        [Route("/v1/games/{game_id}/actions")]
        [Authorize(Policy = "Host-token-access")]
        [ValidateModelState]
        [SwaggerOperation("CommitAction")]
        public virtual IActionResult CommitAction([FromRoute][Required]string gameId, [FromQuery][Required()]ActionType action)
        { 

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Create Game
        /// </summary>
        /// <remarks>Creates a random game by your defined rules</remarks>
        /// <param name="gameRules">*Optional* This rules define how your game will behave</param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/v1/games/")]
        [Authorize(Policy = "Host-token-access")]
        [ValidateModelState]
        [SwaggerOperation("CreateGame")]
        public virtual IActionResult CreateGame([FromBody]GameRules gameRules)
        { 

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Get games actions
        /// </summary>
        /// <remarks>Get all (**not robot related**) actions comitted to this game.</remarks>
        /// <param name="gameId"></param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/v1/games/{game_id}/actions")]
        [Authorize(Policy = "Host-token-access")]
        [ValidateModelState]
        [SwaggerOperation("GetActions")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Action>), description: "OK")]
        public virtual IActionResult GetActions([FromRoute][Required]string gameId)
        { 

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Action>));
            string exampleJson = null;
            exampleJson = "{\r\n  \"canceled\" : true,\r\n  \"index\" : 0,\r\n  \"executed\" : true,\r\n  \"requestor\" : 6\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Action>>(exampleJson)
            : default(List<Action>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get game status
        /// </summary>
        /// <remarks>Returns the status of a game</remarks>
        /// <param name="gameId"></param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/v1/games/{game_id}/status")]
        [Authorize(Policy = "Player-Token-Access")]
        [ValidateModelState]
        [SwaggerOperation("GetGameState")]
        [SwaggerResponse(statusCode: 200, type: typeof(GameInfo), description: "OK")]
        public virtual IActionResult GetGameState([FromRoute][Required][Range(0, 2048)]int gameId)
        { 

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(GameInfo));
            string exampleJson = null;
            exampleJson = "{\r\n  \"hardware-attached\" : false,\r\n  \"hardware-compatible\" : false,\r\n  \"player-on-turn\" : 3,\r\n  \"passed-time\" : 240\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<GameInfo>(exampleJson)
            : default(GameInfo);
            //TODO: Change the data returned
            return new ObjectResult(example);
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
        public virtual IActionResult GetGames([FromQuery]bool joinable, [FromQuery]bool unprotected)
        { 

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<int>));
            string exampleJson = null;
            exampleJson = "537";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<int>>(exampleJson)
            : default(List<int>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
