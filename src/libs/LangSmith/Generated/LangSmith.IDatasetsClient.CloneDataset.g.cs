#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Clone Dataset<br/>
        /// Clone a dataset.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.Example>> CloneDatasetAsync(
            global::LangSmith.BodyCloneDatasetApiV1DatasetsClonePost request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Clone Dataset<br/>
        /// Clone a dataset.
        /// </summary>
        /// <param name="targetDatasetId"></param>
        /// <param name="sourceDatasetId"></param>
        /// <param name="asOf">
        /// Only modifications made on or before this time are included. If None, the latest version of the dataset is used.
        /// </param>
        /// <param name="examples"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.Example>> CloneDatasetAsync(
            global::System.Guid targetDatasetId,
            global::System.Guid sourceDatasetId,
            object? asOf = default,
            global::System.Collections.Generic.IList<global::System.Guid>? examples = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}