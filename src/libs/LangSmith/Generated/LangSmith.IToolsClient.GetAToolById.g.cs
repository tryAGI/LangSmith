#nullable enable

namespace LangSmith
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Get a tool by ID<br/>
        /// Returns a tool identified by its UUID.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ToolsTool> GetAToolByIdAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}