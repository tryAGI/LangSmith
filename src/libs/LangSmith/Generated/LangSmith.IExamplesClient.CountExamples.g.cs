#nullable enable

namespace LangSmith
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Count Examples<br/>
        /// Count the examples that match the filters.
        /// </summary>
        /// <param name="id">
        /// Only count examples with these IDs.
        /// </param>
        /// <param name="asOf">
        /// Only modifications made on or before this time are included. If None, the latest version of the dataset is used.<br/>
        /// Default Value: latest
        /// </param>
        /// <param name="metadata">
        /// JSON object. Only count examples whose metadata contains it.
        /// </param>
        /// <param name="fullTextContains">
        /// Only count examples whose inputs or outputs contain every one of these terms, ignoring case.
        /// </param>
        /// <param name="splits">
        /// Only count examples in any of these splits.
        /// </param>
        /// <param name="dataset">
        /// Only count examples in this dataset.
        /// </param>
        /// <param name="filter">
        /// Filter expression the examples must match.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<int> CountExamplesAsync(
            global::System.Collections.Generic.IList<global::System.Guid>? id = default,
            global::LangSmith.AnyOf<global::System.DateTime?, string>? asOf = default,
            string? metadata = default,
            global::System.Collections.Generic.IList<string>? fullTextContains = default,
            global::System.Collections.Generic.IList<string>? splits = default,
            global::System.Guid? dataset = default,
            string? filter = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Count Examples<br/>
        /// Count the examples that match the filters.
        /// </summary>
        /// <param name="id">
        /// Only count examples with these IDs.
        /// </param>
        /// <param name="asOf">
        /// Only modifications made on or before this time are included. If None, the latest version of the dataset is used.<br/>
        /// Default Value: latest
        /// </param>
        /// <param name="metadata">
        /// JSON object. Only count examples whose metadata contains it.
        /// </param>
        /// <param name="fullTextContains">
        /// Only count examples whose inputs or outputs contain every one of these terms, ignoring case.
        /// </param>
        /// <param name="splits">
        /// Only count examples in any of these splits.
        /// </param>
        /// <param name="dataset">
        /// Only count examples in this dataset.
        /// </param>
        /// <param name="filter">
        /// Filter expression the examples must match.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<int>> CountExamplesAsResponseAsync(
            global::System.Collections.Generic.IList<global::System.Guid>? id = default,
            global::LangSmith.AnyOf<global::System.DateTime?, string>? asOf = default,
            string? metadata = default,
            global::System.Collections.Generic.IList<string>? fullTextContains = default,
            global::System.Collections.Generic.IList<string>? splits = default,
            global::System.Guid? dataset = default,
            string? filter = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}