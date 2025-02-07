
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
        public required global::System.Collections.Generic.IList<global::LangSmith.MessagesItem> Messages { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadArtifactLengthJsonConverter))]
        public global::LangSmith.PlaygroundPromptCanvasPayloadArtifactLength? ArtifactLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reading_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadReadingLevelJsonConverter))]
        public global::LangSmith.PlaygroundPromptCanvasPayloadReadingLevel? ReadingLevel { get; set; }

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
        /// <param name="highlighted"></param>
        /// <param name="artifact"></param>
        /// <param name="artifactLength"></param>
        /// <param name="readingLevel"></param>
        /// <param name="customAction"></param>
        /// <param name="templateFormat"></param>
        /// <param name="secrets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaygroundPromptCanvasPayload(
            global::System.Collections.Generic.IList<global::LangSmith.MessagesItem> messages,
            global::LangSmith.PlaygroundPromptCanvasPayloadTemplateFormat templateFormat,
            global::System.Collections.Generic.Dictionary<string, string> secrets,
            global::LangSmith.Highlight? highlighted,
            global::LangSmith.Artifact? artifact,
            global::LangSmith.PlaygroundPromptCanvasPayloadArtifactLength? artifactLength,
            global::LangSmith.PlaygroundPromptCanvasPayloadReadingLevel? readingLevel,
            string? customAction)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.TemplateFormat = templateFormat;
            this.Secrets = secrets ?? throw new global::System.ArgumentNullException(nameof(secrets));
            this.Highlighted = highlighted;
            this.Artifact = artifact;
            this.ArtifactLength = artifactLength;
            this.ReadingLevel = readingLevel;
            this.CustomAction = customAction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundPromptCanvasPayload" /> class.
        /// </summary>
        public PlaygroundPromptCanvasPayload()
        {
        }
    }
}