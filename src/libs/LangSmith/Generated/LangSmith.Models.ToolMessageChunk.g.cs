
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Tool Message chunk.
    /// </summary>
    public sealed partial class ToolMessageChunk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AnyOf<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_kwargs")]
        public object? AdditionalKwargs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_metadata")]
        public object? ResponseMetadata { get; set; }

        /// <summary>
        /// Default Value: ToolMessageChunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.ToolMessageChunkTypeJsonConverter))]
        public global::LangSmith.ToolMessageChunkType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact")]
        public object? Artifact { get; set; }

        /// <summary>
        /// Default Value: success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.ToolMessageChunkStatusJsonConverter))]
        public global::LangSmith.ToolMessageChunkStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMessageChunk" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="additionalKwargs"></param>
        /// <param name="responseMetadata"></param>
        /// <param name="type">
        /// Default Value: ToolMessageChunk
        /// </param>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="toolCallId"></param>
        /// <param name="artifact"></param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolMessageChunk(
            global::LangSmith.AnyOf<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>> content,
            string toolCallId,
            object? additionalKwargs,
            object? responseMetadata,
            global::LangSmith.ToolMessageChunkType? type,
            string? name,
            string? id,
            object? artifact,
            global::LangSmith.ToolMessageChunkStatus? status)
        {
            this.Content = content;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.AdditionalKwargs = additionalKwargs;
            this.ResponseMetadata = responseMetadata;
            this.Type = type;
            this.Name = name;
            this.Id = id;
            this.Artifact = artifact;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMessageChunk" /> class.
        /// </summary>
        public ToolMessageChunk()
        {
        }
    }
}