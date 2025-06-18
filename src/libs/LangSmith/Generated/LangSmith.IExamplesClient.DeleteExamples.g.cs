#nullable enable

namespace LangSmith
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Delete Examples<br/>
        /// Soft delete examples. Only deletes the examples in the 'latest' version of the dataset.
        /// </summary>
        /// <param name="exampleIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteExamplesAsync(
            global::System.Collections.Generic.IList<global::System.Guid> exampleIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}