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
    ///  Class for testing UpgradeShop
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UpgradeShopTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UpgradeShop
        //private UpgradeShop instance;

        public UpgradeShopTests()
        {
            // TODO uncomment below to create an instance of UpgradeShop
            //instance = new UpgradeShop();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UpgradeShop
        /// </summary>
        [Fact]
        public void UpgradeShopInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" UpgradeShop
            //Assert.IsInstanceOfType<UpgradeShop> (instance, "variable 'instance' is a UpgradeShop");
        }


        /// <summary>
        /// Test the property 'Upgrades'
        /// </summary>
        [Fact]
        public void UpgradesTest()
        {
            // TODO unit test for the property 'Upgrades'
        }
        /// <summary>
        /// Test the property 'Information'
        /// </summary>
        [Fact]
        public void InformationTest()
        {
            // TODO unit test for the property 'Information'
        }

    }

}