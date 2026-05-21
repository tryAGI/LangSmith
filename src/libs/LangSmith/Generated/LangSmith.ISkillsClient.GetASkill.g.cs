#nullable enable

namespace LangSmith
{
    public partial interface ISkillsClient
    {
        /// <summary>
        /// Get a skill<br/>
        /// Returns the specified skill, including its full file tree.
        /// </summary>
        /// <param name="skillID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SkillsSkill> GetASkillAsync(
            string skillID,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a skill<br/>
        /// Returns the specified skill, including its full file tree.
        /// </summary>
        /// <param name="skillID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SkillsSkill>> GetASkillAsResponseAsync(
            string skillID,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}