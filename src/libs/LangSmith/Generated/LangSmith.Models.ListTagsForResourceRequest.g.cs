
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListTagsForResourceRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.ResourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.ResourceType ResourceType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTagsForResourceRequest" /> class.
        /// </summary>
        /// <param name="resourceId"></param>
        /// <param name="resourceType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListTagsForResourceRequest(
            global::System.Guid resourceId,
            global::LangSmith.ResourceType resourceType)
        {
            this.ResourceId = resourceId;
            this.ResourceType = resourceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTagsForResourceRequest" /> class.
        /// </summary>
        public ListTagsForResourceRequest()
        {
        }
    }
}