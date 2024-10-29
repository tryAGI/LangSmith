#nullable enable

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public sealed class PlaygroundPromptCanvasPayloadReadingLevelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.PlaygroundPromptCanvasPayloadReadingLevel?>
    {
        /// <inheritdoc />
        public override global::LangSmith.PlaygroundPromptCanvasPayloadReadingLevel? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::LangSmith.PlaygroundPromptCanvasPayloadReadingLevelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LangSmith.PlaygroundPromptCanvasPayloadReadingLevel)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.PlaygroundPromptCanvasPayloadReadingLevel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LangSmith.PlaygroundPromptCanvasPayloadReadingLevelExtensions.ToValueString(value.Value));
            }
        }
    }
}
