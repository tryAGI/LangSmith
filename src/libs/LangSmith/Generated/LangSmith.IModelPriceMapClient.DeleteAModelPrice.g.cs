#nullable enable

namespace LangSmith
{
    public partial interface IModelPriceMapClient
    {
        /// <summary>
        /// Delete a model price<br/>
        /// Delete a custom model price from this workspace.<br/>
        /// Only the workspace's own entries can be deleted; LangSmith default entries<br/>
        /// cannot. Deleting an ID that does not belong to the workspace succeeds<br/>
        /// without changing anything. Existing run costs are not recomputed.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteAModelPriceAsync(
            global::System.Guid id,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a model price<br/>
        /// Delete a custom model price from this workspace.<br/>
        /// Only the workspace's own entries can be deleted; LangSmith default entries<br/>
        /// cannot. Deleting an ID that does not belong to the workspace succeeds<br/>
        /// without changing anything. Existing run costs are not recomputed.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<string>> DeleteAModelPriceAsResponseAsync(
            global::System.Guid id,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}