#nullable enable

namespace LangSmith
{
    public partial interface ISkillsClient
    {
        /// <summary>
        /// Delete a skill<br/>
        /// Deletes the skill and all of its files. Idempotent: deleting an<br/>
        /// already-deleted skill returns 204.
        /// </summary>
        /// <param name="skillID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteASkillAsync(
            string skillID,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a skill<br/>
        /// Deletes the skill and all of its files. Idempotent: deleting an<br/>
        /// already-deleted skill returns 204.
        /// </summary>
        /// <param name="skillID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> DeleteASkillAsResponseAsync(
            string skillID,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}