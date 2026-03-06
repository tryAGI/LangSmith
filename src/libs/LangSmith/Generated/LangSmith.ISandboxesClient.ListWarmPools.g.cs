#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// List warm pools<br/>
        /// List all warm pools for the current workspace
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="nameContains"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesPoolListResponse> ListWarmPoolsAsync(
            int? limit = default,
            int? offset = default,
            string? nameContains = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}