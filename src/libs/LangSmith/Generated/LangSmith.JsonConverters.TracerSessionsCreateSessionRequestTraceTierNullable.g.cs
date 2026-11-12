#nullable enable

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public sealed class TracerSessionsCreateSessionRequestTraceTierNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.TracerSessionsCreateSessionRequestTraceTier?>
    {
        /// <inheritdoc />
        public override global::LangSmith.TracerSessionsCreateSessionRequestTraceTier? Read(
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
                        return global::LangSmith.TracerSessionsCreateSessionRequestTraceTierExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LangSmith.TracerSessionsCreateSessionRequestTraceTier)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LangSmith.TracerSessionsCreateSessionRequestTraceTier?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.TracerSessionsCreateSessionRequestTraceTier? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LangSmith.TracerSessionsCreateSessionRequestTraceTierExtensions.ToValueString(value.Value));
            }
        }
    }
}
