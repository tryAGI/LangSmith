#nullable enable

namespace LangSmith
{
    public partial interface IToolsClient
    {

        /// <summary>
        /// Update a tool by ID<br/>
        /// Updates an existing tool identified by its UUID.
        /// </summary>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ToolsTool> UpdateAToolByIdAsync(

            global::LangSmith.ToolsUpdateToolPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a tool by ID<br/>
        /// Updates an existing tool identified by its UUID.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="enabled"></param>
        /// <param name="metadata"></param>
        /// <param name="name"></param>
        /// <param name="parameters"></param>
        /// <param name="returns"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ToolsTool> UpdateAToolByIdAsync(
            string? description = default,
            bool? enabled = default,
            object? metadata = default,
            string? name = default,
            object? parameters = default,
            object? returns = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}