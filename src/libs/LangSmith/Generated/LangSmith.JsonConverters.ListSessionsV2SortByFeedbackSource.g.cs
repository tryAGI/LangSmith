#nullable enable

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListSessionsV2SortByFeedbackSourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.ListSessionsV2SortByFeedbackSource>
    {
        /// <inheritdoc />
        public override global::LangSmith.ListSessionsV2SortByFeedbackSource Read(
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
                        return global::LangSmith.ListSessionsV2SortByFeedbackSourceExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LangSmith.ListSessionsV2SortByFeedbackSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LangSmith.ListSessionsV2SortByFeedbackSource);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.ListSessionsV2SortByFeedbackSource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LangSmith.ListSessionsV2SortByFeedbackSourceExtensions.ToValueString(value));
        }
    }
}
