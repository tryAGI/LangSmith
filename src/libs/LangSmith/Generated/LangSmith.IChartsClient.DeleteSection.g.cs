#nullable enable

namespace LangSmith
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Delete Section<br/>
        /// Delete a section.
        /// </summary>
        /// <param name="sectionId"></param>
        /// <param name="accessScope">
        /// Default Value: workspace
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteSectionAsync(
            global::System.Guid sectionId,
            global::LangSmith.AccessScope? accessScope = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Section<br/>
        /// Delete a section.
        /// </summary>
        /// <param name="sectionId"></param>
        /// <param name="accessScope">
        /// Default Value: workspace
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<string>> DeleteSectionAsResponseAsync(
            global::System.Guid sectionId,
            global::LangSmith.AccessScope? accessScope = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}