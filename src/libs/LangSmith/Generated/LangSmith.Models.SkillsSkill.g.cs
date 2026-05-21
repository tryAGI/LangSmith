
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SkillsSkill
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_hash")]
        public string? CommitHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_id")]
        public string? CommitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.SkillsFileEntry>? Files { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owners")]
        public global::System.Collections.Generic.IList<global::LangSmith.SkillsSkillOwner>? Owners { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        public string? Visibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillsSkill" /> class.
        /// </summary>
        /// <param name="commitHash"></param>
        /// <param name="commitId"></param>
        /// <param name="createdAt"></param>
        /// <param name="files"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="owners"></param>
        /// <param name="updatedAt"></param>
        /// <param name="visibility"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SkillsSkill(
            string? commitHash,
            string? commitId,
            string? createdAt,
            global::System.Collections.Generic.Dictionary<string, global::LangSmith.SkillsFileEntry>? files,
            string? id,
            string? name,
            global::System.Collections.Generic.IList<global::LangSmith.SkillsSkillOwner>? owners,
            string? updatedAt,
            string? visibility)
        {
            this.CommitHash = commitHash;
            this.CommitId = commitId;
            this.CreatedAt = createdAt;
            this.Files = files;
            this.Id = id;
            this.Name = name;
            this.Owners = owners;
            this.UpdatedAt = updatedAt;
            this.Visibility = visibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillsSkill" /> class.
        /// </summary>
        public SkillsSkill()
        {
        }

    }
}