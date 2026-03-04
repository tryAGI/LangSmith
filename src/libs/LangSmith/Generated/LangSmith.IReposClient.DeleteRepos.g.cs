#nullable enable

namespace LangSmith
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Delete Repos<br/>
        /// Delete multiple repos with partial success support.<br/>
        /// Returns:<br/>
        ///     - 200: All repos deleted successfully<br/>
        ///     - 207: Some repos deleted successfully, some failed
        /// </summary>
        /// <param name="repoIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteReposAsync(
            global::System.Collections.Generic.IList<global::System.Guid> repoIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}