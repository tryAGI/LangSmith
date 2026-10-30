#nullable enable

namespace LangSmith
{
    public partial interface IModelPriceMapClient
    {
        /// <summary>
        /// List model prices<br/>
        /// List the model prices LangSmith uses to compute run costs in this workspace.<br/>
        /// Returns both the workspace's custom entries (`tenant_id` set) and the<br/>
        /// LangSmith default entries (`tenant_id` null). Default entries can be read<br/>
        /// but not updated or deleted; to price a model differently, for example<br/>
        /// because of a negotiated rate with an inference provider, create a custom<br/>
        /// entry with the same match pattern.<br/>
        /// The total number of matching entries is returned in the<br/>
        /// `X-Pagination-Total` response header.
        /// </summary>
        /// <param name="offset">
        /// Number of entries to skip before this page.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Maximum number of entries to return.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="q">
        /// Case-insensitive substring matched against the entry name, match pattern, and provider. Hyphens and spaces are treated as equivalent.
        /// </param>
        /// <param name="provider">
        /// Only return price maps for these providers (case-insensitive).
        /// </param>
        /// <param name="sortBy">
        /// Field to sort on. Defaults to match priority order.
        /// </param>
        /// <param name="sortOrder">
        /// Sort direction for sort_by. Unset start dates sort last.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.ModelPriceMapSchema>> ListModelPricesAsync(
            int? offset = default,
            int? limit = default,
            string? q = default,
            global::System.Collections.Generic.IList<string>? provider = default,
            string? sortBy = default,
            global::LangSmith.ReadModelPriceMapApiV1ModelPriceMapGetSortOrder? sortOrder = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List model prices<br/>
        /// List the model prices LangSmith uses to compute run costs in this workspace.<br/>
        /// Returns both the workspace's custom entries (`tenant_id` set) and the<br/>
        /// LangSmith default entries (`tenant_id` null). Default entries can be read<br/>
        /// but not updated or deleted; to price a model differently, for example<br/>
        /// because of a negotiated rate with an inference provider, create a custom<br/>
        /// entry with the same match pattern.<br/>
        /// The total number of matching entries is returned in the<br/>
        /// `X-Pagination-Total` response header.
        /// </summary>
        /// <param name="offset">
        /// Number of entries to skip before this page.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Maximum number of entries to return.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="q">
        /// Case-insensitive substring matched against the entry name, match pattern, and provider. Hyphens and spaces are treated as equivalent.
        /// </param>
        /// <param name="provider">
        /// Only return price maps for these providers (case-insensitive).
        /// </param>
        /// <param name="sortBy">
        /// Field to sort on. Defaults to match priority order.
        /// </param>
        /// <param name="sortOrder">
        /// Sort direction for sort_by. Unset start dates sort last.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LangSmith.ModelPriceMapSchema>>> ListModelPricesAsResponseAsync(
            int? offset = default,
            int? limit = default,
            string? q = default,
            global::System.Collections.Generic.IList<string>? provider = default,
            string? sortBy = default,
            global::LangSmith.ReadModelPriceMapApiV1ModelPriceMapGetSortOrder? sortOrder = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}