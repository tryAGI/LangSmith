#nullable enable

namespace LangSmith
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Update a Run<br/>
        /// Updates a run identified by its ID. The body should contain only the fields to be changed; unknown fields are ignored.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateARunAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}