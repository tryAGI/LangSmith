
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Message chunk from an AI (yielded when streaming).
    /// </summary>
    public sealed partial class AIMessageChunk
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
        /// Default Value: AIMessageChunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::LangSmith.ToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invalid_tool_calls")]
        public global::System.Collections.Generic.IList<global::LangSmith.InvalidToolCall>? InvalidToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_metadata")]
        public global::LangSmith.UsageMetadata? UsageMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_chunks")]
        public global::System.Collections.Generic.IList<global::LangSmith.ToolCallChunk>? ToolCallChunks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_position")]
        public string? ChunkPosition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AIMessageChunk" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="additionalKwargs"></param>
        /// <param name="responseMetadata"></param>
        /// <param name="type">
        /// Default Value: AIMessageChunk
        /// </param>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="toolCalls"></param>
        /// <param name="invalidToolCalls"></param>
        /// <param name="usageMetadata"></param>
        /// <param name="toolCallChunks"></param>
        /// <param name="chunkPosition"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AIMessageChunk(
            global::LangSmith.AnyOf<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>> content,
            object? additionalKwargs,
            object? responseMetadata,
            string? type,
            string? name,
            string? id,
            global::System.Collections.Generic.IList<global::LangSmith.ToolCall>? toolCalls,
            global::System.Collections.Generic.IList<global::LangSmith.InvalidToolCall>? invalidToolCalls,
            global::LangSmith.UsageMetadata? usageMetadata,
            global::System.Collections.Generic.IList<global::LangSmith.ToolCallChunk>? toolCallChunks,
            string? chunkPosition)
        {
            this.Content = content;
            this.AdditionalKwargs = additionalKwargs;
            this.ResponseMetadata = responseMetadata;
            this.Type = type;
            this.Name = name;
            this.Id = id;
            this.ToolCalls = toolCalls;
            this.InvalidToolCalls = invalidToolCalls;
            this.UsageMetadata = usageMetadata;
            this.ToolCallChunks = toolCallChunks;
            this.ChunkPosition = chunkPosition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AIMessageChunk" /> class.
        /// </summary>
        public AIMessageChunk()
        {
        }
    }
}