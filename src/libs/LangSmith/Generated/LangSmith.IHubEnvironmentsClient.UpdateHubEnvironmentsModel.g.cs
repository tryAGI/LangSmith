#nullable enable

namespace LangSmith
{
    public partial interface IHubEnvironmentsClient
    {
        /// <summary>
        /// Update hub environments model<br/>
        /// Replaces the environments array on an existing model.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.HubEnvironmentsHubEnvironmentsModel> UpdateHubEnvironmentsModelAsync(
            string id,

            global::LangSmith.HubEnvironmentsUpdateEnvironmentsRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update hub environments model<br/>
        /// Replaces the environments array on an existing model.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="environments"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.HubEnvironmentsHubEnvironmentsModel> UpdateHubEnvironmentsModelAsync(
            string id,
            global::System.Collections.Generic.IList<global::LangSmith.HubEnvironmentsEnvironmentEntry> environments,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}