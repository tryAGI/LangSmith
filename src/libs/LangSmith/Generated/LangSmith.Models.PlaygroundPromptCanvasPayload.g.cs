
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlaygroundPromptCanvasPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>> Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlighted")]
        public global::LangSmith.Highlight? Highlighted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact")]
        public global::LangSmith.Artifact? Artifact { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact_length")]
        public global::LangSmith.PlaygroundPromptCanvasPayloadArtifactLength2? ArtifactLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reading_level")]
        public global::LangSmith.PlaygroundPromptCanvasPayloadReadingLevel2? ReadingLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_action")]
        public string? CustomAction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadTemplateFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.PlaygroundPromptCanvasPayloadTemplateFormat TemplateFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Secrets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundPromptCanvasPayload" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="templateFormat"></param>
        /// <param name="secrets"></param>
        /// <param name="highlighted"></param>
        /// <param name="artifact"></param>
        /// <param name="artifactLength"></param>
        /// <param name="readingLevel"></param>
        /// <param name="customAction"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaygroundPromptCanvasPayload(
            global::System.Collections.Generic.IList<global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>> messages,
            global::LangSmith.PlaygroundPromptCanvasPayloadTemplateFormat templateFormat,
            global::System.Collections.Generic.Dictionary<string, string> secrets,
            global::LangSmith.Highlight? highlighted,
            global::LangSmith.Artifact? artifact,
            global::LangSmith.PlaygroundPromptCanvasPayloadArtifactLength2? artifactLength,
            global::LangSmith.PlaygroundPromptCanvasPayloadReadingLevel2? readingLevel,
            string? customAction)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Highlighted = highlighted;
            this.Artifact = artifact;
            this.ArtifactLength = artifactLength;
            this.ReadingLevel = readingLevel;
            this.CustomAction = customAction;
            this.TemplateFormat = templateFormat;
            this.Secrets = secrets ?? throw new global::System.ArgumentNullException(nameof(secrets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundPromptCanvasPayload" /> class.
        /// </summary>
        public PlaygroundPromptCanvasPayload()
        {
        }
    }
}