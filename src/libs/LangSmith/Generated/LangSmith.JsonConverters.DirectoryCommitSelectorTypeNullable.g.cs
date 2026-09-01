#nullable enable

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public sealed class DirectoryCommitSelectorTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.DirectoryCommitSelectorType?>
    {
        /// <inheritdoc />
        public override global::LangSmith.DirectoryCommitSelectorType? Read(
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
                        return global::LangSmith.DirectoryCommitSelectorTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LangSmith.DirectoryCommitSelectorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LangSmith.DirectoryCommitSelectorType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.DirectoryCommitSelectorType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LangSmith.DirectoryCommitSelectorTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
