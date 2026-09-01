#nullable enable

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public sealed class DirectorySkillEntryInputTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.DirectorySkillEntryInputType?>
    {
        /// <inheritdoc />
        public override global::LangSmith.DirectorySkillEntryInputType? Read(
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
                        return global::LangSmith.DirectorySkillEntryInputTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LangSmith.DirectorySkillEntryInputType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LangSmith.DirectorySkillEntryInputType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.DirectorySkillEntryInputType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LangSmith.DirectorySkillEntryInputTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
