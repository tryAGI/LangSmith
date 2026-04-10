#nullable enable

namespace LangSmith
{
    public partial interface IPlaygroundSettingsClient
    {
        /// <summary>
        /// Update Playground Settings<br/>
        /// Update playground settings.
        /// </summary>
        /// <param name="playgroundSettingsId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PlaygroundSettingsResponse> UpdatePlaygroundSettingsAsync(
            string playgroundSettingsId,

            global::LangSmith.PlaygroundSettingsUpdateRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Playground Settings<br/>
        /// Update playground settings.
        /// </summary>
        /// <param name="playgroundSettingsId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="settings"></param>
        /// <param name="options"></param>
        /// <param name="availableInPlayground"></param>
        /// <param name="availableInEvaluators"></param>
        /// <param name="availableInAgentBuilder"></param>
        /// <param name="availableInPolly"></param>
        /// <param name="availableInInsightsHeavy"></param>
        /// <param name="availableInInsightsLight"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PlaygroundSettingsResponse> UpdatePlaygroundSettingsAsync(
            string playgroundSettingsId,
            string? name = default,
            string? description = default,
            object? settings = default,
            global::LangSmith.PlaygroundSavedOptions? options = default,
            bool? availableInPlayground = default,
            bool? availableInEvaluators = default,
            bool? availableInAgentBuilder = default,
            bool? availableInPolly = default,
            bool? availableInInsightsHeavy = default,
            bool? availableInInsightsLight = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}