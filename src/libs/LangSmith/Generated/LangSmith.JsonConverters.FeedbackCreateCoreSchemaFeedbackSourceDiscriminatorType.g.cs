#nullable enable

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public sealed class FeedbackCreateCoreSchemaFeedbackSourceDiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceDiscriminatorType Read(
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
                        return global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceDiscriminatorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceDiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
