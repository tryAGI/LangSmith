#nullable enable

namespace LangSmith
{
    public partial interface IToolsClient
    {

        /// <summary>
        /// Delete a tool by ID<br/>
        /// Deletes a tool identified by its UUID.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAToolByIdAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}