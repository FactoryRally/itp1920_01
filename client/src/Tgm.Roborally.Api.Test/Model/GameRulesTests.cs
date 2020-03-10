/* 
 * Robot Rally Game logic engine
 *
 * This api controlls the flow of a game and provides it's data. It is desiged to be RESTfull so the structure works simmilar as file system. The service will run and only work in a local network, `game.host` is the IP of the Computer hosting the game and will be found via a IP scan
 *
 * The version of the OpenAPI document: 0.1.0
 * Contact: nbrugger@student.tgm.ac.at
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Tgm.Roborally.Api.Api;
using Tgm.Roborally.Api.Model;
using Tgm.Roborally.Api.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Tgm.Roborally.Api.Test
{
    /// <summary>
    ///  Class for testing GameRules
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GameRulesTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GameRules
        //private GameRules instance;

        public GameRulesTests()
        {
            // TODO uncomment below to create an instance of GameRules
            //instance = new GameRules();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GameRules
        /// </summary>
        [Fact]
        public void GameRulesInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" GameRules
            //Assert.IsInstanceOfType<GameRules> (instance, "variable 'instance' is a GameRules");
        }


        /// <summary>
        /// Test the property 'PlayerNamesVisible'
        /// </summary>
        [Fact]
        public void PlayerNamesVisibleTest()
        {
            // TODO unit test for the property 'PlayerNamesVisible'
        }
        /// <summary>
        /// Test the property 'Wholes'
        /// </summary>
        [Fact]
        public void WholesTest()
        {
            // TODO unit test for the property 'Wholes'
        }
        /// <summary>
        /// Test the property 'MaxPlayers'
        /// </summary>
        [Fact]
        public void MaxPlayersTest()
        {
            // TODO unit test for the property 'MaxPlayers'
        }

    }

}