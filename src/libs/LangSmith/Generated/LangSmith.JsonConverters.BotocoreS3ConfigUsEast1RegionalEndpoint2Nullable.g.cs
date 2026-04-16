#nullable enable

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public sealed class BotocoreS3ConfigUsEast1RegionalEndpoint2NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.BotocoreS3ConfigUsEast1RegionalEndpoint2?>
    {
        /// <inheritdoc />
        public override global::LangSmith.BotocoreS3ConfigUsEast1RegionalEndpoint2? Read(
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
                        return global::LangSmith.BotocoreS3ConfigUsEast1RegionalEndpoint2Extensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LangSmith.BotocoreS3ConfigUsEast1RegionalEndpoint2)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LangSmith.BotocoreS3ConfigUsEast1RegionalEndpoint2?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.BotocoreS3ConfigUsEast1RegionalEndpoint2? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LangSmith.BotocoreS3ConfigUsEast1RegionalEndpoint2Extensions.ToValueString(value.Value));
            }
        }
    }
}
