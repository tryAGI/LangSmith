#nullable enable

namespace LangSmith
{
    public partial interface IPlaygroundSettingsClient
    {
        /// <summary>
        /// Create Playground Settings<br/>
        /// Create playground settings.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PlaygroundSettingsResponse> CreatePlaygroundSettingsAsync(

            global::LangSmith.PlaygroundSettingsCreateRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Playground Settings<br/>
        /// Create playground settings.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.PlaygroundSettingsResponse>> CreatePlaygroundSettingsAsResponseAsync(

            global::LangSmith.PlaygroundSettingsCreateRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Playground Settings<br/>
        /// Create playground settings.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="settings"></param>
        /// <param name="options"></param>
        /// <param name="settingsType">
        /// Default Value: complex
        /// </param>
        /// <param name="oauthEnabled"></param>
        /// <param name="oauthTokenUrl"></param>
        /// <param name="oauthClientId"></param>
        /// <param name="oauthClientSecret"></param>
        /// <param name="oauthTokenEndpointAuthMethod"></param>
        /// <param name="oauthParams"></param>
        /// <param name="oauthHeaders"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PlaygroundSettingsResponse> CreatePlaygroundSettingsAsync(
            object settings,
            string? name = default,
            string? description = default,
            global::LangSmith.PlaygroundSavedOptions? options = default,
            global::LangSmith.PlaygroundSettingsCreateRequestSettingsType? settingsType = default,
            bool? oauthEnabled = default,
            string? oauthTokenUrl = default,
            string? oauthClientId = default,
            string? oauthClientSecret = default,
            global::LangSmith.PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod2? oauthTokenEndpointAuthMethod = default,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? oauthParams = default,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? oauthHeaders = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}