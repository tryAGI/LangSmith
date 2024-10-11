#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Search<br/>
        /// Search a dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SearchDatasetResponse> SearchAsync(
            global::System.Guid datasetId,
            global::LangSmith.SearchDatasetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Search<br/>
        /// Search a dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="inputs"></param>
        /// <param name="limit">
        /// Default Value: 5
        /// </param>
        /// <param name="debug">
        /// Default Value: false
        /// </param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SearchDatasetResponse> SearchAsync(
            global::System.Guid datasetId,
            object inputs,
            int? limit = 5,
            bool? debug = false,
            global::LangSmith.AnyOf<string, object>? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}