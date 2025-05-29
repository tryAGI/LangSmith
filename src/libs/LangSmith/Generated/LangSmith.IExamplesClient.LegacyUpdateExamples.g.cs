#nullable enable

namespace LangSmith
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Legacy Update Examples<br/>
        /// Legacy update examples in bulk. For update involving attachments, use PATCH /v1/platform/datasets/{dataset_id}/examples instead.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> LegacyUpdateExamplesAsync(
            global::System.Collections.Generic.IList<global::LangSmith.ExampleUpdateWithID> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}