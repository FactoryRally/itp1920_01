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
    ///  Class for testing EventHandlingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EventHandlingApiTests : IDisposable
    {
        private EventHandlingApi instance;

        public EventHandlingApiTests()
        {
            instance = new EventHandlingApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EventHandlingApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EventHandlingApi
            //Assert.IsType(typeof(EventHandlingApi), instance, "instance is a EventHandlingApi");
        }

        
        /// <summary>
        /// Test FetchNextDamageEvent
        /// </summary>
        [Fact]
        public void FetchNextDamageEventTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string gameId = null;
            //var response = instance.FetchNextDamageEvent(gameId);
            //Assert.IsType<DamageEvent> (response, "response is DamageEvent");
        }
        
        /// <summary>
        /// Test FetchNextLazerHitEvent
        /// </summary>
        [Fact]
        public void FetchNextLazerHitEventTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string gameId = null;
            //var response = instance.FetchNextLazerHitEvent(gameId);
            //Assert.IsType<LazerHitEvent> (response, "response is LazerHitEvent");
        }
        
        /// <summary>
        /// Test FetchNextMapEvent
        /// </summary>
        [Fact]
        public void FetchNextMapEventTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string gameId = null;
            //var response = instance.FetchNextMapEvent(gameId);
            //Assert.IsType<MapEvent> (response, "response is MapEvent");
        }
        
        /// <summary>
        /// Test FetchNextMovementEvent
        /// </summary>
        [Fact]
        public void FetchNextMovementEventTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string gameId = null;
            //var response = instance.FetchNextMovementEvent(gameId);
            //Assert.IsType<MovementEvent> (response, "response is MovementEvent");
        }
        
        /// <summary>
        /// Test FetchNextPushEvent
        /// </summary>
        [Fact]
        public void FetchNextPushEventTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string gameId = null;
            //var response = instance.FetchNextPushEvent(gameId);
            //Assert.IsType<PushEvent> (response, "response is PushEvent");
        }
        
        /// <summary>
        /// Test FetchNextShootEvent
        /// </summary>
        [Fact]
        public void FetchNextShootEventTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string gameId = null;
            //var response = instance.FetchNextShootEvent(gameId);
            //Assert.IsType<ShootEvent> (response, "response is ShootEvent");
        }
        
        /// <summary>
        /// Test FetchNextShutdownEvent
        /// </summary>
        [Fact]
        public void FetchNextShutdownEventTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string gameId = null;
            //var response = instance.FetchNextShutdownEvent(gameId);
            //Assert.IsType<ShutdownEvent> (response, "response is ShutdownEvent");
        }
        
        /// <summary>
        /// Test TraceEvent
        /// </summary>
        [Fact]
        public void TraceEventTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string gameId = null;
            //bool? batch = null;
            //bool? wait = null;
            //var response = instance.TraceEvent(gameId, batch, wait);
            //Assert.IsType<InlineResponse200> (response, "response is InlineResponse200");
        }
        
    }

}