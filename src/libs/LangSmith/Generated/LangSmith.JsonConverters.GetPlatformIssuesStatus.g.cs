#nullable enable

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetPlatformIssuesStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.GetPlatformIssuesStatus>
    {
        /// <inheritdoc />
        public override global::LangSmith.GetPlatformIssuesStatus Read(
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
                        return global::LangSmith.GetPlatformIssuesStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LangSmith.GetPlatformIssuesStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LangSmith.GetPlatformIssuesStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.GetPlatformIssuesStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LangSmith.GetPlatformIssuesStatusExtensions.ToValueString(value));
        }
    }
}
