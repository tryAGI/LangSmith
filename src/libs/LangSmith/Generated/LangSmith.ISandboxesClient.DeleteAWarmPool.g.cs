#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Delete a warm pool<br/>
        /// Delete a warm pool by name
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAWarmPoolAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}