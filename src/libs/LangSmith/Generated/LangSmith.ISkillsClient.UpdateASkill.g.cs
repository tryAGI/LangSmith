#nullable enable

namespace LangSmith
{
    public partial interface ISkillsClient
    {
        /// <summary>
        /// Update a skill<br/>
        /// Applies a sparse patch to the skill's file tree. Each entry in<br/>
        /// `files` is keyed by relative path: a non-null value upserts<br/>
        /// that file, an explicit null deletes it, and absent paths are<br/>
        /// left unchanged. SKILL.md cannot be deleted via this endpoint —<br/>
        /// use DELETE on the skill instead. Skills support file entries<br/>
        /// only — linked agent/skill entries are rejected. The commit is<br/>
        /// atomic: on validation failure no changes are applied.
        /// </summary>
        /// <param name="skillID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SkillsSkill> UpdateASkillAsync(
            string skillID,

            global::LangSmith.SkillsUpdateSkillRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a skill<br/>
        /// Applies a sparse patch to the skill's file tree. Each entry in<br/>
        /// `files` is keyed by relative path: a non-null value upserts<br/>
        /// that file, an explicit null deletes it, and absent paths are<br/>
        /// left unchanged. SKILL.md cannot be deleted via this endpoint —<br/>
        /// use DELETE on the skill instead. Skills support file entries<br/>
        /// only — linked agent/skill entries are rejected. The commit is<br/>
        /// atomic: on validation failure no changes are applied.
        /// </summary>
        /// <param name="skillID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SkillsSkill>> UpdateASkillAsResponseAsync(
            string skillID,

            global::LangSmith.SkillsUpdateSkillRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a skill<br/>
        /// Applies a sparse patch to the skill's file tree. Each entry in<br/>
        /// `files` is keyed by relative path: a non-null value upserts<br/>
        /// that file, an explicit null deletes it, and absent paths are<br/>
        /// left unchanged. SKILL.md cannot be deleted via this endpoint —<br/>
        /// use DELETE on the skill instead. Skills support file entries<br/>
        /// only — linked agent/skill entries are rejected. The commit is<br/>
        /// atomic: on validation failure no changes are applied.
        /// </summary>
        /// <param name="skillID"></param>
        /// <param name="files"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SkillsSkill> UpdateASkillAsync(
            string skillID,
            global::System.Collections.Generic.Dictionary<string, global::LangSmith.SkillsFileEntry> files,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}