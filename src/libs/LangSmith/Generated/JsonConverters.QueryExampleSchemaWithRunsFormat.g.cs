#nullable enable

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public sealed class QueryExampleSchemaWithRunsFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.QueryExampleSchemaWithRunsFormat>
    {
        /// <inheritdoc />
        public override global::LangSmith.QueryExampleSchemaWithRunsFormat Read(
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
                        return global::LangSmith.QueryExampleSchemaWithRunsFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LangSmith.QueryExampleSchemaWithRunsFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LangSmith.QueryExampleSchemaWithRunsFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.QueryExampleSchemaWithRunsFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LangSmith.QueryExampleSchemaWithRunsFormatExtensions.ToValueString(value));
        }
    }
}
