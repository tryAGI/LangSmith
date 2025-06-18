#nullable enable

namespace LangSmith
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Hard Delete Examples<br/>
        /// This endpoint hard deletes *all* versions of a dataset example(s).<br/>
        /// Deletion is performed by setting inputs, outputs, and metadata to null and deleting attachment files while keeping the example ID, dataset ID, and creation timestamp.<br/>
        /// IMPORTANT: attachment files can take up to 7 days to be deleted. inputs, outputs and metadata are nullified immediately.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ExamplesExamplesDeletedResponse> HardDeleteExamplesAsync(
            global::LangSmith.ExamplesDeleteExamplesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Hard Delete Examples<br/>
        /// This endpoint hard deletes *all* versions of a dataset example(s).<br/>
        /// Deletion is performed by setting inputs, outputs, and metadata to null and deleting attachment files while keeping the example ID, dataset ID, and creation timestamp.<br/>
        /// IMPORTANT: attachment files can take up to 7 days to be deleted. inputs, outputs and metadata are nullified immediately.
        /// </summary>
        /// <param name="exampleIds">
        /// ExampleIDs is a list of UUIDs identifying the examples to delete.
        /// </param>
        /// <param name="hardDelete">
        /// HardDelete indicates whether to perform a hard delete.<br/>
        /// Currently only True is supported.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ExamplesExamplesDeletedResponse> HardDeleteExamplesAsync(
            global::System.Collections.Generic.IList<string> exampleIds,
            bool hardDelete,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}