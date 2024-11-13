
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Function Message chunk.
    /// </summary>
    public sealed partial class FunctionMessageChunk
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
        /// Default Value: FunctionMessageChunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.FunctionMessageChunkTypeJsonConverter))]
        public global::LangSmith.FunctionMessageChunkType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionMessageChunk" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="additionalKwargs"></param>
        /// <param name="responseMetadata"></param>
        /// <param name="type">
        /// Default Value: FunctionMessageChunk
        /// </param>
        /// <param name="name"></param>
        /// <param name="id"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FunctionMessageChunk(
            global::LangSmith.AnyOf<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>> content,
            string name,
            object? additionalKwargs,
            object? responseMetadata,
            global::LangSmith.FunctionMessageChunkType? type,
            string? id)
        {
            this.Content = content;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AdditionalKwargs = additionalKwargs;
            this.ResponseMetadata = responseMetadata;
            this.Type = type;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionMessageChunk" /> class.
        /// </summary>
        public FunctionMessageChunk()
        {
        }
    }
}