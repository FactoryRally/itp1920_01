/* 
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: 0.1.0
 * Contact: nbrugger@student.tgm.ac.at
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Model;

namespace Tgm.Roborally.Api.Test
{
    /// <summary>
    ///  Class for testing PlayersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PlayersApiTests : IDisposable
    {
        private PlayersApi instance;

        public PlayersApiTests()
        {
            instance = new PlayersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PlayersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PlayersApi
            //Assert.IsType(typeof(PlayersApi), instance, "instance is a PlayersApi");
        }

        
        /// <summary>
        /// Test GetAllPlayers
        /// </summary>
        [Fact]
        public void GetAllPlayersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int gameId = null;
            //var response = instance.GetAllPlayers(gameId);
            //Assert.IsType<List<int>> (response, "response is List<int>");
        }
        
        /// <summary>
        /// Test GetPlayer
        /// </summary>
        [Fact]
        public void GetPlayerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int gameId = null;
            //int playerId = null;
            //var response = instance.GetPlayer(gameId, playerId);
            //Assert.IsType<Player> (response, "response is Player");
        }
        
        /// <summary>
        /// Test Join
        /// </summary>
        [Fact]
        public void JoinTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int gameId = null;
            //string password = null;
            //var response = instance.Join(gameId, password);
            //Assert.IsType<JoinResponse> (response, "response is JoinResponse");
        }
        
        /// <summary>
        /// Test KickPlayer
        /// </summary>
        [Fact]
        public void KickPlayerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int gameId = null;
            //int playerId = null;
            //instance.KickPlayer(gameId, playerId);
            
        }
        
    }

}