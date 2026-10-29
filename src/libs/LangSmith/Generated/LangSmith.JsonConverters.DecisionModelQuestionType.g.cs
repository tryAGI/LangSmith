#nullable enable

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public sealed class DecisionModelQuestionTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.DecisionModelQuestionType>
    {
        /// <inheritdoc />
        public override global::LangSmith.DecisionModelQuestionType Read(
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
                        return global::LangSmith.DecisionModelQuestionTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LangSmith.DecisionModelQuestionType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LangSmith.DecisionModelQuestionType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.DecisionModelQuestionType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LangSmith.DecisionModelQuestionTypeExtensions.ToValueString(value));
        }
    }
}
