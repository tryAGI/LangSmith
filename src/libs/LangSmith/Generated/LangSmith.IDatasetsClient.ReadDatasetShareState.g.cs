#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Read Dataset Share State<br/>
        /// Get the state of sharing a dataset
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DatasetShareSchema> ReadDatasetShareStateAsync(
            global::System.Guid datasetId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}