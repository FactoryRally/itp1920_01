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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Tgm.Roborally.Api.Client;
using Tgm.Roborally.Api.Model;

namespace Tgm.Roborally.Api.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMapApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Map info
        /// </summary>
        /// <remarks>
        /// Get meta information abouzt the map of the game
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <returns>MapInfo</returns>
        MapInfo GetMapInfo (int gameId);

        /// <summary>
        /// Get Map info
        /// </summary>
        /// <remarks>
        /// Get meta information abouzt the map of the game
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <returns>ApiResponse of MapInfo</returns>
        ApiResponse<MapInfo> GetMapInfoWithHttpInfo (int gameId);
        /// <summary>
        /// Get tile
        /// </summary>
        /// <remarks>
        /// Inspect a tile of the map
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Tile</returns>
        Tile GetTile (int gameId, string x, string y);

        /// <summary>
        /// Get tile
        /// </summary>
        /// <remarks>
        /// Inspect a tile of the map
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>ApiResponse of Tile</returns>
        ApiResponse<Tile> GetTileWithHttpInfo (int gameId, string x, string y);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMapApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get Map info
        /// </summary>
        /// <remarks>
        /// Get meta information abouzt the map of the game
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <returns>Task of MapInfo</returns>
        System.Threading.Tasks.Task<MapInfo> GetMapInfoAsync (int gameId);

        /// <summary>
        /// Get Map info
        /// </summary>
        /// <remarks>
        /// Get meta information abouzt the map of the game
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <returns>Task of ApiResponse (MapInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<MapInfo>> GetMapInfoAsyncWithHttpInfo (int gameId);
        /// <summary>
        /// Get tile
        /// </summary>
        /// <remarks>
        /// Inspect a tile of the map
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Task of Tile</returns>
        System.Threading.Tasks.Task<Tile> GetTileAsync (int gameId, string x, string y);

        /// <summary>
        /// Get tile
        /// </summary>
        /// <remarks>
        /// Inspect a tile of the map
        /// </remarks>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Task of ApiResponse (Tile)</returns>
        System.Threading.Tasks.Task<ApiResponse<Tile>> GetTileAsyncWithHttpInfo (int gameId, string x, string y);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMapApi : IMapApiSync, IMapApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MapApi : IMapApi
    {
        private Tgm.Roborally.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MapApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MapApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MapApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MapApi(String basePath)
        {
            this.Configuration = Tgm.Roborally.Api.Client.Configuration.MergeConfigurations(
                Tgm.Roborally.Api.Client.GlobalConfiguration.Instance,
                new Tgm.Roborally.Api.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Tgm.Roborally.Api.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Tgm.Roborally.Api.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Tgm.Roborally.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MapApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MapApi(Tgm.Roborally.Api.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Tgm.Roborally.Api.Client.Configuration.MergeConfigurations(
                Tgm.Roborally.Api.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Tgm.Roborally.Api.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Tgm.Roborally.Api.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Tgm.Roborally.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MapApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public MapApi(Tgm.Roborally.Api.Client.ISynchronousClient client,Tgm.Roborally.Api.Client.IAsynchronousClient asyncClient, Tgm.Roborally.Api.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Tgm.Roborally.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Tgm.Roborally.Api.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Tgm.Roborally.Api.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Tgm.Roborally.Api.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Tgm.Roborally.Api.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get Map info Get meta information abouzt the map of the game
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <returns>MapInfo</returns>
        public MapInfo GetMapInfo (int gameId)
        {
             Tgm.Roborally.Api.Client.ApiResponse<MapInfo> localVarResponse = GetMapInfoWithHttpInfo(gameId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Map info Get meta information abouzt the map of the game
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <returns>ApiResponse of MapInfo</returns>
        public Tgm.Roborally.Api.Client.ApiResponse< MapInfo > GetMapInfoWithHttpInfo (int gameId)
        {
            Tgm.Roborally.Api.Client.RequestOptions localVarRequestOptions = new Tgm.Roborally.Api.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Tgm.Roborally.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Tgm.Roborally.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("game_id", Tgm.Roborally.Api.Client.ClientUtils.ParameterToString(gameId)); // path parameter

            // authentication (Player-Access-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("pat")))
            {
                foreach (var _kvp in Tgm.Roborally.Api.Client.ClientUtils.ParameterToMultiMap("", "pat", this.Configuration.GetApiKeyWithPrefix("pat")))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< MapInfo >("/games/{game_id}/map/info", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMapInfo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Map info Get meta information abouzt the map of the game
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <returns>Task of MapInfo</returns>
        public async System.Threading.Tasks.Task<MapInfo> GetMapInfoAsync (int gameId)
        {
             Tgm.Roborally.Api.Client.ApiResponse<MapInfo> localVarResponse = await GetMapInfoAsyncWithHttpInfo(gameId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Map info Get meta information abouzt the map of the game
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <returns>Task of ApiResponse (MapInfo)</returns>
        public async System.Threading.Tasks.Task<Tgm.Roborally.Api.Client.ApiResponse<MapInfo>> GetMapInfoAsyncWithHttpInfo (int gameId)
        {

            Tgm.Roborally.Api.Client.RequestOptions localVarRequestOptions = new Tgm.Roborally.Api.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.PathParameters.Add("game_id", Tgm.Roborally.Api.Client.ClientUtils.ParameterToString(gameId)); // path parameter

            // authentication (Player-Access-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("pat")))
            {
                foreach (var _kvp in Tgm.Roborally.Api.Client.ClientUtils.ParameterToMultiMap("", "pat", this.Configuration.GetApiKeyWithPrefix("pat")))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<MapInfo>("/games/{game_id}/map/info", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMapInfo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get tile Inspect a tile of the map
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Tile</returns>
        public Tile GetTile (int gameId, string x, string y)
        {
             Tgm.Roborally.Api.Client.ApiResponse<Tile> localVarResponse = GetTileWithHttpInfo(gameId, x, y);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get tile Inspect a tile of the map
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>ApiResponse of Tile</returns>
        public Tgm.Roborally.Api.Client.ApiResponse< Tile > GetTileWithHttpInfo (int gameId, string x, string y)
        {
            // verify the required parameter 'x' is set
            if (x == null)
                throw new Tgm.Roborally.Api.Client.ApiException(400, "Missing required parameter 'x' when calling MapApi->GetTile");

            // verify the required parameter 'y' is set
            if (y == null)
                throw new Tgm.Roborally.Api.Client.ApiException(400, "Missing required parameter 'y' when calling MapApi->GetTile");

            Tgm.Roborally.Api.Client.RequestOptions localVarRequestOptions = new Tgm.Roborally.Api.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Tgm.Roborally.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Tgm.Roborally.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("game_id", Tgm.Roborally.Api.Client.ClientUtils.ParameterToString(gameId)); // path parameter
            if (x != null)
                localVarRequestOptions.PathParameters.Add("x", Tgm.Roborally.Api.Client.ClientUtils.ParameterToString(x)); // path parameter
            if (y != null)
                localVarRequestOptions.PathParameters.Add("y", Tgm.Roborally.Api.Client.ClientUtils.ParameterToString(y)); // path parameter

            // authentication (Player-Access-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("pat")))
            {
                foreach (var _kvp in Tgm.Roborally.Api.Client.ClientUtils.ParameterToMultiMap("", "pat", this.Configuration.GetApiKeyWithPrefix("pat")))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< Tile >("/games/{game_id}/map/tiles/{x}/{y}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTile", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get tile Inspect a tile of the map
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Task of Tile</returns>
        public async System.Threading.Tasks.Task<Tile> GetTileAsync (int gameId, string x, string y)
        {
             Tgm.Roborally.Api.Client.ApiResponse<Tile> localVarResponse = await GetTileAsyncWithHttpInfo(gameId, x, y);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get tile Inspect a tile of the map
        /// </summary>
        /// <exception cref="Tgm.Roborally.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Task of ApiResponse (Tile)</returns>
        public async System.Threading.Tasks.Task<Tgm.Roborally.Api.Client.ApiResponse<Tile>> GetTileAsyncWithHttpInfo (int gameId, string x, string y)
        {
            // verify the required parameter 'x' is set
            if (x == null)
                throw new Tgm.Roborally.Api.Client.ApiException(400, "Missing required parameter 'x' when calling MapApi->GetTile");

            // verify the required parameter 'y' is set
            if (y == null)
                throw new Tgm.Roborally.Api.Client.ApiException(400, "Missing required parameter 'y' when calling MapApi->GetTile");


            Tgm.Roborally.Api.Client.RequestOptions localVarRequestOptions = new Tgm.Roborally.Api.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.PathParameters.Add("game_id", Tgm.Roborally.Api.Client.ClientUtils.ParameterToString(gameId)); // path parameter
            if (x != null)
                localVarRequestOptions.PathParameters.Add("x", Tgm.Roborally.Api.Client.ClientUtils.ParameterToString(x)); // path parameter
            if (y != null)
                localVarRequestOptions.PathParameters.Add("y", Tgm.Roborally.Api.Client.ClientUtils.ParameterToString(y)); // path parameter

            // authentication (Player-Access-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("pat")))
            {
                foreach (var _kvp in Tgm.Roborally.Api.Client.ClientUtils.ParameterToMultiMap("", "pat", this.Configuration.GetApiKeyWithPrefix("pat")))
                {
                    foreach (var _kvpValue in _kvp.Value)
                    {
                        localVarRequestOptions.QueryParameters.Add(_kvp.Key, _kvpValue);
                    }
                }
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Tile>("/games/{game_id}/map/tiles/{x}/{y}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTile", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
