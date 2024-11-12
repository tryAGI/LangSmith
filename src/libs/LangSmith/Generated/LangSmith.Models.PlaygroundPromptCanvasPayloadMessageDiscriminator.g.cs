
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlaygroundPromptCanvasPayloadMessageDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadMessageDiscriminatorTypeJsonConverter))]
        public global::LangSmith.PlaygroundPromptCanvasPayloadMessageDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundPromptCanvasPayloadMessageDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PlaygroundPromptCanvasPayloadMessageDiscriminator(
            global::LangSmith.PlaygroundPromptCanvasPayloadMessageDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundPromptCanvasPayloadMessageDiscriminator" /> class.
        /// </summary>
        public PlaygroundPromptCanvasPayloadMessageDiscriminator()
        {
        }
    }
}