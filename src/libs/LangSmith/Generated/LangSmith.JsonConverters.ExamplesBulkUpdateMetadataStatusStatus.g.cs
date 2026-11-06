#nullable enable

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public sealed class ExamplesBulkUpdateMetadataStatusStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.ExamplesBulkUpdateMetadataStatusStatus>
    {
        /// <inheritdoc />
        public override global::LangSmith.ExamplesBulkUpdateMetadataStatusStatus Read(
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
                        return global::LangSmith.ExamplesBulkUpdateMetadataStatusStatusExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LangSmith.ExamplesBulkUpdateMetadataStatusStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LangSmith.ExamplesBulkUpdateMetadataStatusStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.ExamplesBulkUpdateMetadataStatusStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LangSmith.ExamplesBulkUpdateMetadataStatusStatusExtensions.ToValueString(value));
        }
    }
}
