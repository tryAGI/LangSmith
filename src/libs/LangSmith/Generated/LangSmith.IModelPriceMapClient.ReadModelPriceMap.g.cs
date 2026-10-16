#nullable enable

namespace LangSmith
{
    public partial interface IModelPriceMapClient
    {
        /// <summary>
        /// Read Model Price Map
        /// </summary>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="q"></param>
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
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.ModelPriceMapSchema>> ReadModelPriceMapAsync(
            int? offset = default,
            int? limit = default,
            string? q = default,
            global::System.Collections.Generic.IList<string>? provider = default,
            string? sortBy = default,
            global::LangSmith.ReadModelPriceMapApiV1ModelPriceMapGetSortOrder? sortOrder = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Read Model Price Map
        /// </summary>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="q"></param>
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
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LangSmith.ModelPriceMapSchema>>> ReadModelPriceMapAsResponseAsync(
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