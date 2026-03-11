#nullable enable

namespace LangSmith
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Delete a tool by handle<br/>
        /// Deletes a tool identified by its handle.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAToolByHandleAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}