#nullable enable

namespace LangSmith
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Delete an example<br/>
        /// Soft-delete an example, preserving prior versions and their attachments. If the latest version is already deleted, the request succeeds without creating another version. Deletion is recorded at the current time or just after the latest version, whichever is later. For future-dated versions, latest reads reflect deletion immediately; timestamp reads reflect deletion only at or after the recorded deletion timestamp.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="exampleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAnExampleAsync(
            global::System.Guid datasetId,
            global::System.Guid exampleId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an example<br/>
        /// Soft-delete an example, preserving prior versions and their attachments. If the latest version is already deleted, the request succeeds without creating another version. Deletion is recorded at the current time or just after the latest version, whichever is later. For future-dated versions, latest reads reflect deletion immediately; timestamp reads reflect deletion only at or after the recorded deletion timestamp.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="exampleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> DeleteAnExampleAsResponseAsync(
            global::System.Guid datasetId,
            global::System.Guid exampleId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}