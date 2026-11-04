#nullable enable

namespace LangSmith
{
    public partial interface IModelPriceMapClient
    {
        /// <summary>
        /// List organization model prices<br/>
        /// List the model prices set for this organization.<br/>
        /// Returns only the organization's own entries, not the workspace or<br/>
        /// LangSmith default entries a workspace also prices against; list those<br/>
        /// from a workspace with `GET /model-price-map`.
        /// </summary>
        /// <param name="pageSize">
        /// Maximum number of entries to return.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="cursor">
        /// `next_cursor` from the previous page. Treat as opaque.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ModelPriceMapListResponse> ListOrganizationModelPricesAsync(
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List organization model prices<br/>
        /// List the model prices set for this organization.<br/>
        /// Returns only the organization's own entries, not the workspace or<br/>
        /// LangSmith default entries a workspace also prices against; list those<br/>
        /// from a workspace with `GET /model-price-map`.
        /// </summary>
        /// <param name="pageSize">
        /// Maximum number of entries to return.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="cursor">
        /// `next_cursor` from the previous page. Treat as opaque.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.ModelPriceMapListResponse>> ListOrganizationModelPricesAsResponseAsync(
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}