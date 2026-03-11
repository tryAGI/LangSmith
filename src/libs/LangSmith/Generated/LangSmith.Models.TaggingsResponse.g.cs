
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaggingsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string TagKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid TagKeyId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string TagValue { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_value_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid TagValueId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::LangSmith.TaggingsByResourceType Resources { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaggingsResponse" /> class.
        /// </summary>
        /// <param name="tagKey"></param>
        /// <param name="tagKeyId"></param>
        /// <param name="tagValue"></param>
        /// <param name="tagValueId"></param>
        /// <param name="resources"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaggingsResponse(
            string tagKey,
            global::System.Guid tagKeyId,
            string tagValue,
            global::System.Guid tagValueId,
            global::LangSmith.TaggingsByResourceType resources)
        {
            this.TagKey = tagKey ?? throw new global::System.ArgumentNullException(nameof(tagKey));
            this.TagKeyId = tagKeyId;
            this.TagValue = tagValue ?? throw new global::System.ArgumentNullException(nameof(tagValue));
            this.TagValueId = tagValueId;
            this.Resources = resources ?? throw new global::System.ArgumentNullException(nameof(resources));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaggingsResponse" /> class.
        /// </summary>
        public TaggingsResponse()
        {
        }
    }
}