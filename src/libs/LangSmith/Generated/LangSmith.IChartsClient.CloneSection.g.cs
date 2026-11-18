#nullable enable

namespace LangSmith
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Clone Section<br/>
        /// Clone a dashboard.
        /// </summary>
        /// <param name="accessScope">
        /// Default Value: workspace
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartsSectionResponse> CloneSectionAsync(

            global::LangSmith.CustomChartsSectionsCloneRequest request,
            global::LangSmith.AccessScope? accessScope = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clone Section<br/>
        /// Clone a dashboard.
        /// </summary>
        /// <param name="accessScope">
        /// Default Value: workspace
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.CustomChartsSectionResponse>> CloneSectionAsResponseAsync(

            global::LangSmith.CustomChartsSectionsCloneRequest request,
            global::LangSmith.AccessScope? accessScope = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clone Section<br/>
        /// Clone a dashboard.
        /// </summary>
        /// <param name="accessScope">
        /// Default Value: workspace
        /// </param>
        /// <param name="sectionId"></param>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartsSectionResponse> CloneSectionAsync(
            global::LangSmith.AccessScope? accessScope = default,
            global::System.Guid? sectionId = default,
            global::System.Guid? sessionId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}