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
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using Tgm.Roborally.Server.Attributes;
using Tgm.Roborally.Server.Engine;
using Tgm.Roborally.Server.Models;

namespace Tgm.Roborally.Server.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class PlayersApiController : ControllerBase
    { 
        /// <summary>
        /// Get all players
        /// </summary>
        /// <remarks>Returns the index of all players</remarks>
        /// <param name="gameId"></param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/v1/games/{game_id}/players/")]
        [ValidateModelState]
        [SwaggerOperation("GetAllPlayers")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<int>), description: "OK")]
        public virtual IActionResult GetAllPlayers([FromRoute(Name = "game_id")][Required][Range(0, 2048)]int gameId)
        {
            IActionResult response = null;
            
            GameLogic game = GameManager.instance.GetGame(gameId, ref response);
            if (response != null)
                return response;
            
            return new ObjectResult(game.PlayerIds);
        }

        /// <summary>
        /// Get player
        /// </summary>
        /// <remarks>Get closer information about the player</remarks>
        /// <param name="gameId"></param>
        /// <param name="playerId"></param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/v1/games/{game_id}/players/{player_id}")]
        [ValidateModelState]
        [SwaggerOperation("GetPlayer")]
        [SwaggerResponse(statusCode: 200, type: typeof(Player), description: "OK")]
        public virtual IActionResult GetPlayer([FromRoute(Name = "game_id")][Required][Range(0, 2048)]int gameId, [FromRoute(Name = "player_id")][Required][Range(0, 8)]int playerId)
        { 

            IActionResult response = null;
            
            GameLogic game = GameManager.instance.GetGame(gameId, ref response);
            Player p = game.GetPlayer(playerId, ref response);
            if (response != null)
                return response;
            return new ObjectResult(p);
        }

        /// <summary>
        /// Join game
        /// </summary>
        /// <remarks>Join the given game. You will get your ID by doing this, if you already in the game you can get your ID again if you lost it.&lt;br&gt; The id is neccessary for any further API calls</remarks>
        /// <param name="gameId"></param>
        /// <param name="password">The password of the game if the lobby is password protected</param>
        /// <response code="200">Joined</response>
        /// <response code="401">Wrong/No password</response>
        [HttpPost]
        [Route("/v1/games/{game_id}/players/")]
        [ValidateModelState]
        [SwaggerOperation("Join")]
        [SwaggerResponse(statusCode: 200, type: typeof(JoinResponse), description: "Joined")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorMessage), description: "Wrong/No password")]
        public virtual IActionResult Join([FromRoute(Name = "game_id")][Required][Range(0, 2048)]int gameId, [FromQuery]string password)
        {
            IActionResult response = null;
            
            GameLogic game = GameManager.instance.GetGame(gameId, ref response);
            if (response != null)
                return response;
            game.Join(password,ref response);
            return response;
        }

        /// <summary>
        /// Remove Player
        /// </summary>
        /// <remarks>Removes a player from the game. This can be done by the player itsself or by the host.</remarks>
        /// <param name="gameId"></param>
        /// <param name="playerId"></param>
        /// <response code="200">OK</response>
        [HttpDelete]
        [Route("/v1/games/{game_id}/players/{player_id}")]
        [Authorize(Policy = "Host-token-access")]
        [Authorize(Policy = "Player-Token-Access")]
        [ValidateModelState]
        [SwaggerOperation("KickPlayer")]
        public virtual IActionResult KickPlayer([FromRoute(Name = "game_id")][Required][Range(0, 2048)]int gameId, [FromRoute(Name = "player_id")][Required][Range(0, 8)]int playerId)
        { 

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }
    }
}
