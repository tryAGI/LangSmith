#nullable enable

namespace LangSmith
{
    public partial interface IModelPriceMapClient
    {
        /// <summary>
        /// Get a model price<br/>
        /// Get one model price this workspace uses to compute run costs.<br/>
        /// Any entry the list returns can be read here: the workspace's custom<br/>
        /// entries, its organization's entries, and the LangSmith default entries.<br/>
        /// Returns 404 for an ID the workspace does not price against, including<br/>
        /// other workspaces' entries.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ModelPriceMapSchema> GetAModelPriceAsync(
            global::System.Guid id,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a model price<br/>
        /// Get one model price this workspace uses to compute run costs.<br/>
        /// Any entry the list returns can be read here: the workspace's custom<br/>
        /// entries, its organization's entries, and the LangSmith default entries.<br/>
        /// Returns 404 for an ID the workspace does not price against, including<br/>
        /// other workspaces' entries.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.ModelPriceMapSchema>> GetAModelPriceAsResponseAsync(
            global::System.Guid id,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}