#nullable enable

namespace LangSmith
{
    public partial interface ISkillsClient
    {
        /// <summary>
        /// Create a skill<br/>
        /// Creates a workspace skill with the supplied file tree.<br/>
        /// Skills support file entries only — linked agent/skill entries<br/>
        /// are rejected.<br/>
        /// Cleanup is best-effort: if the initial commit fails the empty<br/>
        /// repo is deleted, but a transport failure during rollback can<br/>
        /// leave an orphan repo with no commits. Subsequent creates with<br/>
        /// the same name will then 409; delete the orphan and retry.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SkillsSkill> CreateASkillAsync(

            global::LangSmith.SkillsCreateSkillRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a skill<br/>
        /// Creates a workspace skill with the supplied file tree.<br/>
        /// Skills support file entries only — linked agent/skill entries<br/>
        /// are rejected.<br/>
        /// Cleanup is best-effort: if the initial commit fails the empty<br/>
        /// repo is deleted, but a transport failure during rollback can<br/>
        /// leave an orphan repo with no commits. Subsequent creates with<br/>
        /// the same name will then 409; delete the orphan and retry.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SkillsSkill>> CreateASkillAsResponseAsync(

            global::LangSmith.SkillsCreateSkillRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a skill<br/>
        /// Creates a workspace skill with the supplied file tree.<br/>
        /// Skills support file entries only — linked agent/skill entries<br/>
        /// are rejected.<br/>
        /// Cleanup is best-effort: if the initial commit fails the empty<br/>
        /// repo is deleted, but a transport failure during rollback can<br/>
        /// leave an orphan repo with no commits. Subsequent creates with<br/>
        /// the same name will then 409; delete the orphan and retry.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SkillsSkill> CreateASkillAsync(
            global::System.Collections.Generic.Dictionary<string, global::LangSmith.SkillsFileEntry> files,
            string name,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}