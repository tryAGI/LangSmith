#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Get a warm pool<br/>
        /// Get a warm pool by name
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesPoolResponse> GetAWarmPoolAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}