
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Fields to create a prompt tag
    /// </summary>
    public sealed partial class RepoTagRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TagName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CommitId { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_webhooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<global::System.Guid>>))]
        public global::LangSmith.AnyOf<bool?, global::System.Collections.Generic.IList<global::System.Guid>>? SkipWebhooks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepoTagRequest" /> class.
        /// </summary>
        /// <param name="tagName"></param>
        /// <param name="commitId"></param>
        /// <param name="skipWebhooks">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepoTagRequest(
            string tagName,
            global::System.Guid commitId,
            global::LangSmith.AnyOf<bool?, global::System.Collections.Generic.IList<global::System.Guid>>? skipWebhooks)
        {
            this.TagName = tagName ?? throw new global::System.ArgumentNullException(nameof(tagName));
            this.CommitId = commitId;
            this.SkipWebhooks = skipWebhooks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepoTagRequest" /> class.
        /// </summary>
        public RepoTagRequest()
        {
        }
    }
}