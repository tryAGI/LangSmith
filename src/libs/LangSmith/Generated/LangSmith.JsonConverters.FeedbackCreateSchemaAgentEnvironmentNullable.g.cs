#nullable enable

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public sealed class FeedbackCreateSchemaAgentEnvironmentNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.FeedbackCreateSchemaAgentEnvironment?>
    {
        /// <inheritdoc />
        public override global::LangSmith.FeedbackCreateSchemaAgentEnvironment? Read(
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
                        return global::LangSmith.FeedbackCreateSchemaAgentEnvironmentExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LangSmith.FeedbackCreateSchemaAgentEnvironment)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LangSmith.FeedbackCreateSchemaAgentEnvironment?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.FeedbackCreateSchemaAgentEnvironment? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LangSmith.FeedbackCreateSchemaAgentEnvironmentExtensions.ToValueString(value.Value));
            }
        }
    }
}
