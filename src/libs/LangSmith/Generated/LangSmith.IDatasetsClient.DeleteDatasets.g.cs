#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {

        /// <summary>
        /// Delete Datasets<br/>
        /// Delete multiple datasets.
        /// </summary>
        /// <param name="datasetIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteDatasetsAsync(
            global::System.Collections.Generic.IList<global::System.Guid> datasetIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}