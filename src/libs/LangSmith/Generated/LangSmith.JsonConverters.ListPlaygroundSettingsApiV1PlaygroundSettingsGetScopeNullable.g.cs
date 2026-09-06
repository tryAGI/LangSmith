#nullable enable

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListPlaygroundSettingsApiV1PlaygroundSettingsGetScopeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope?>
    {
        /// <inheritdoc />
        public override global::LangSmith.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope? Read(
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
                        return global::LangSmith.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScopeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LangSmith.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LangSmith.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LangSmith.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScopeExtensions.ToValueString(value.Value));
            }
        }
    }
}
