#nullable enable

namespace LangSmith
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// List tools<br/>
        /// Returns a paginated list of tools in the workspace.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="query"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ToolsListToolsResponse> ListToolsAsync(
            int? limit = default,
            int? offset = default,
            string? query = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}