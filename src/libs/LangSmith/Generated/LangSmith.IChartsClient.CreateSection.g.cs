#nullable enable

namespace LangSmith
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Create Section<br/>
        /// Create a new section.
        /// </summary>
        /// <param name="accessScope">
        /// Default Value: workspace
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartsSectionResponse> CreateSectionAsync(

            global::LangSmith.CustomChartsSectionCreate request,
            global::LangSmith.AccessScope? accessScope = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Section<br/>
        /// Create a new section.
        /// </summary>
        /// <param name="accessScope">
        /// Default Value: workspace
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.CustomChartsSectionResponse>> CreateSectionAsResponseAsync(

            global::LangSmith.CustomChartsSectionCreate request,
            global::LangSmith.AccessScope? accessScope = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Section<br/>
        /// Create a new section.
        /// </summary>
        /// <param name="accessScope">
        /// Default Value: workspace
        /// </param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="index"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartsSectionResponse> CreateSectionAsync(
            string title,
            global::LangSmith.AccessScope? accessScope = default,
            string? description = default,
            int? index = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}